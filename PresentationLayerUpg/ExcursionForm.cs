using BusinessLayer;
using DataLayer;
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
        }

        private void ExcursionForm_Load(object sender, EventArgs e)
        {
            LoadExcursions();
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
                //excursionDataGridView.DataSource = excursions;
                //excursionDataGridView.AutoResizeColumns();
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
    }
}
