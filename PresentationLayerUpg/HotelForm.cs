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
    public partial class HotelForm : Form
    {
        Hotel selectedHotel;
        bool updatedHotel = false;
        bool deleteHotel = false;
        int currentRowIndex = -1;
        private Manager<Hotel, int> hotelManager;
        private HotelsContext hotelContext;
        private TravelAgencyDbContext context;
        public HotelForm()
        {
            InitializeComponent();
            context = new TravelAgencyDbContext();
            hotelContext = new HotelsContext(context);
            hotelManager = new Manager<Hotel, int>(hotelContext);
        }

        private void HotelForm_Load(object sender, EventArgs e)
        {
            LoadHotels();
            cityTxtBox.Focus();
            deleteBtn.Enabled = false;
        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                string name = nameTxtBox.Text;
                City city = context.Cities.FirstOrDefault(c => c.Name == cityTxtBox.Text);
                string address = addressTxtBox.Text;
                int rating = Convert.ToInt32(ratingUpDown.Value);
                bool spa, parking;
                if (SPA.Checked == true) { spa = true; }
                else spa = false;
                if (Parking.Checked == true) { parking = true; }
                else parking = false;
                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(city.Name) || string.IsNullOrWhiteSpace(address) || string.IsNullOrWhiteSpace(rating.ToString()))
                {
                    MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                Hotel hotel = new Hotel(city.CityId, address, name, rating, spa, parking)
                {
                    Name = name,
                    CityId = city.CityId,
                    Address = address,
                    SPA = spa,
                    Parking = parking,
                    Rating = rating
                };
                hotelContext.Create(hotel);
                MessageBox.Show("Hotel created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadHotels();
                nameTxtBox.Text = string.Empty;
                nameTxtBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHotels()
        {
            // Load clients logic
            try
            {
                List<Hotel> hotels = hotelManager.ReadAll(true, false);
                //hotelDataGridView.DataSource = hotels;
                //hotelDataGridView.AutoResizeColumns();
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
                hotelManager.Update(selectedHotel);
                MessageBox.Show("Hotel updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                hotelManager.Delete(selectedHotel.HotelId);
                MessageBox.Show("Hotel deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadHotels();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
