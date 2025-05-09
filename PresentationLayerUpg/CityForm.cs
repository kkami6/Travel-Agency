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
using BusinessLayer;
using DataLayer;

namespace WindowsFormsApp1
{
    public partial class CityForm : Form
    {
        City selectedCity;
        bool updatedCity = false;
        bool deleteCity = false;
        int currentRowIndex = -1;
        private Manager<City, int> cityManager;
        private CitiesContext cityContext;
        private TravelAgencyDbContext context;
        public CityForm()
        {
            InitializeComponent();
            context = new TravelAgencyDbContext();
            cityContext = new CitiesContext(context);
            cityManager = new Manager<City, int>(cityContext);
            cityContextBindingSource.DataSource = cityManager.ReadAll();
            cityDataGridView.DataSource = cityContextBindingSource;
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                string name = nameTxtBox.Text;
                string country = countryTxtBox.Text;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(country))
                {
                    MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                City city = new City(name, country)
                {
                    Name = name,
                    Country = country
                };
                cityContext.Create(city);
                MessageBox.Show("City created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCities();
                nameTxtBox.Text = string.Empty;
                nameTxtBox.Focus();

                deleteBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CityForm_Load(object sender, EventArgs e)
        {
            LoadCities();
        }

        private void LoadCities()
        {

        }
        private void LoadCities(object sender, EventArgs e)
        {
            // Load clients logic
            try
            {
                List<City> cities = cityManager.ReadAll(true, false);
                cityDataGridView.DataSource = cities;
                cityDataGridView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            try
            {
                cityManager.Update(selectedCity);
                MessageBox.Show("City updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                cityManager.Delete(selectedCity.CityId);
                MessageBox.Show("City deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadCities();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cityDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = cityDataGridView.Rows[e.RowIndex];
                selectedCity = (City)selectedRow.DataBoundItem;
            }
        }
    }
}
