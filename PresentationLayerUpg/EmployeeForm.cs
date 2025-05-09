using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EmployeeForm : Form
    {
        Employee selectedEmployee;
        bool updatedEmployee = false;
        bool deleteEmployee = false;
        int currentRowIndex = -1;
        private Manager<Employee, int> employeeManager;
        private EmployeesContext employeeContext;
        private TravelAgencyDbContext context;
        public EmployeeForm()
        {
            InitializeComponent();

            context = new TravelAgencyDbContext();
            employeeContext = new EmployeesContext(context);
            employeeManager = new Manager<Employee, int>(employeeContext);
            employeeContextBindingSource.DataSource = employeeManager.ReadAll();
            dataGridView1.DataSource = employeeContextBindingSource;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            try
            {
                List<Employee> employees = employeeManager.ReadAll();
                //employeeGridView.DataSource = employees;
                //employeeGridView.Columns["EmployeeId"].Visible = false;
                //employeeGridView.Columns["Excursions"].Visible = false;
                //employeeGridView.Columns["ClientId"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                string name = nameTxtBox.Text;
                string secondName = name2TxtBox.Text;
                string familyName = name3TxtBox.Text;
                string position = positionTxtBox.Text;
                decimal salary = decimal.Parse(salaryTxtBox.Text);
                int age = DateTime.Now.Year - agePicker.Value.Year;
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(secondName) || string.IsNullOrWhiteSpace(familyName) ||
                    string.IsNullOrWhiteSpace(position) || string.IsNullOrWhiteSpace(salaryTxtBox.Text))
                {
                    MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (age < 18)
                {
                    MessageBox.Show("Employee must be 18 or older!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (agePicker.Value.Date.Year == DateTime.Now.Year)
                {
                    MessageBox.Show("Employee must be 18 or older!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Employee employee = new Employee(name, secondName, familyName, age, position, salary)
                {
                    Name = name,
                    SecondName = secondName,
                    FamilyName = familyName,
                    Age = age,
                    Position = position,
                    Salary = salary
                };
                employeeManager.Create(employee);
                MessageBox.Show("Employee created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadEmployees();
                nameTxtBox.Text = string.Empty;
                nameTxtBox.Focus();
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
                employeeManager.Update(selectedEmployee);
                MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                employeeManager.Delete(selectedEmployee.EmployeeId);
                MessageBox.Show("Employee deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addExcursion_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("You need to select an employee first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (int.TryParse(excursionIdTxtBox.Text, out int excursionId))
            {
                Excursion excursionToAdd = context.Excursions.Include(e => e.Employees).FirstOrDefault(e => e.ExcursionId == excursionId);

                if (excursionToAdd == null)
                {
                    MessageBox.Show("There is no excursion with this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.Entry(selectedEmployee).Collection(e => e.Excursions).Load();

                if (selectedEmployee.Excursions.Contains(excursionToAdd))
                {
                    MessageBox.Show("This excursion is already added to the current employee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                selectedEmployee.Excursions.Add(excursionToAdd);

                excursionToAdd.Employees.Add(selectedEmployee);

                context.SaveChanges();
                MessageBox.Show("The excursion was added to the employee successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Invalid ID. Please enter a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void showAllExcursions_Click(object sender, EventArgs e)
        {
            if (selectedEmployee == null)
            {
                MessageBox.Show("You need to select an employee first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            context.Entry(selectedEmployee).Collection(e => e.Excursions).Load();

            if (!selectedEmployee.Excursions.Any())
            {
                MessageBox.Show("The selected employee hasn't been to any excursions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var cities = context.Cities.ToDictionary(c => c.CityId);
            List<string> excursionInfo = selectedEmployee.Excursions.Select(e => cities.TryGetValue(e.CityId, out City city) 
            ? $"{city.Name}, {city.Country}" : "Unknown City").ToList();
            excursionsListBox.DataSource = excursionInfo;
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridView1.Rows[e.RowIndex];
                selectedEmployee = (Employee)selectedRow.DataBoundItem;
            }
        }
    }
}
