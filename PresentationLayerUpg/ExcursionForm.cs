using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class ExcursionForm : Form
    {
        Excursion selectedExcursion;
        bool updatedExcursion = false;
        bool deleteExcursion = false;
        int currentRowIndex = -1;
        private Manager<Excursion, int> excursionManager;
        private ExcursionsContext excursionContext;
        private TravelAgencyDbContext context;
        public ExcursionForm()
        {
            InitializeComponent();
            context = new TravelAgencyDbContext();
            excursionContext = new ExcursionsContext(context);
            excursionManager = new Manager<Excursion, int>(excursionContext);
            excursionContextBindingSource.DataSource = excursionManager.ReadAll();
            dataGridView1.DataSource = excursionContextBindingSource;
        }

        private void ExcursionForm_Load(object sender, EventArgs e)
        {
            LoadExcursions();
            selectedExcursion = context.Excursions.Include(e => e.Clients).FirstOrDefault();
            selectedExcursion = context.Excursions.Include(e => e.Employees).FirstOrDefault();
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                City city = context.Cities.FirstOrDefault(c => c.Name == cityTxtBox.Text);
                Hotel hotel = context.Hotels.FirstOrDefault(h => h.Name == hotelTxtBox.Text);
                decimal price = decimal.Parse(priceTxtBox.Text);
                DateTime departureDate = departureDateTimePicker.Value;
                DateTime returnDate = returnDateTimePicker.Value;

                if (string.IsNullOrWhiteSpace(city.Name) || string.IsNullOrWhiteSpace(hotel.Name) || string.IsNullOrWhiteSpace(priceTxtBox.Text))
                {
                    MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (departureDate > returnDate)
                {
                    MessageBox.Show("The return date must be after the departure date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Excursion excursion = new Excursion(city.CityId, hotel.HotelId, price, departureDate, returnDate)
                {
                    Price = price,
                    HotelId = hotel.HotelId,
                    CityId = city.CityId,
                    ReturnDate = returnDate,
                    DepartureDate = departureDateTimePicker.Value.Date
                };

                excursionContext.Create(excursion);
                MessageBox.Show("Excursion created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadExcursions();
                cityTxtBox.Text = string.Empty;
                cityTxtBox.Focus();

                deleteBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExcursions()
        {
            try
            {
                List<Excursion> excursions = excursionManager.ReadAll(true, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                excursionManager.Update(selectedExcursion);
                MessageBox.Show("Excursion updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                excursionManager.Delete(selectedExcursion.ExcursionId);
                MessageBox.Show("Excursion deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadExcursions();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void excursionBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedExcursion = (Excursion)selectedRow.DataBoundItem;
            }
        }

        private void addClient_Click(object sender, EventArgs e)
        {
            if (int.TryParse(clientIdTxtBox.Text, out int clientId))
            {
                Client clientToAdd = context.Clients.Include(c => c.Excursions).FirstOrDefault(c => c.ClientId == clientId);

                if (clientToAdd == null)
                {
                    MessageBox.Show("There is no client with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                context.Entry(selectedExcursion).Collection(e => e.Clients).Load();
                if (selectedExcursion.Clients.Contains(clientToAdd))
                {
                    MessageBox.Show("This client is already added to the current excursion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedExcursion.Clients.Add(clientToAdd);

                clientToAdd.Excursions.Add(selectedExcursion);

                context.SaveChanges();
                MessageBox.Show("The client was added to the excursion successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void showAllClients_Click(object sender, EventArgs e)
        {
            if (selectedExcursion == null)
            {
                MessageBox.Show("You need to select an excursion first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            context.Entry(selectedExcursion).Collection(e => e.Clients).Load();

            if (!selectedExcursion.Clients.Any())
            {
                MessageBox.Show("The selected excursion has no clients.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> clientsFullNames = selectedExcursion.Clients.Select(c => $"{c.Name} {c.SecondName} {c.FamilyName}").ToList();
            clientsListBox.DataSource = clientsFullNames;
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            if (selectedExcursion == null)
            {
                MessageBox.Show("You need to select an excursion first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(employeeIdTxtBox.Text, out int employeeId))
            {
                Employee employeeToAdd = context.Employees.Include(e => e.Excursions).FirstOrDefault(e => e.EmployeeId == employeeId);

                if (employeeToAdd == null)
                {
                    MessageBox.Show("There is no employee with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                context.Entry(selectedExcursion).Collection(e => e.Employees).Load();
                if (selectedExcursion.Employees.Contains(employeeToAdd))
                {
                    MessageBox.Show("This employee is already added to the current excursion.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedExcursion.Employees.Add(employeeToAdd);

                employeeToAdd.Excursions.Add(selectedExcursion);

                context.SaveChanges();
                MessageBox.Show("The employee was added to the excursion successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showAllEmployees_Click(object sender, EventArgs e)
        {
            if (selectedExcursion == null)
            {
                MessageBox.Show("You need to select an excursion first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            context.Entry(selectedExcursion).Collection(e => e.Employees).Load();

            if (!selectedExcursion.Employees.Any())
            {
                MessageBox.Show("The selected excursion has no employees.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<string> employeesFullNames = selectedExcursion.Employees.Select(e => $"{e.Name} {e.SecondName} {e.FamilyName}").ToList();
            employeesListBox.DataSource = employeesFullNames;
        }
    }
}
