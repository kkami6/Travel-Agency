using BusinessLayer;
using DataLayer;
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
    }
}
