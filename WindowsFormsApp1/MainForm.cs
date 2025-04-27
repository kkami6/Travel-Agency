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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void cityBtn_Click(object sender, EventArgs e)
        {
            CityForm cityForm = new CityForm();
            cityForm.ShowDialog();
        }


        private void clientBtn_Click(object sender, EventArgs e)
        {
            Client clientForm = new Client();
            clientForm.ShowDialog();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.ShowDialog();
        }

        private void hotelBtn_Click(object sender, EventArgs e)
        {
            HotelForm hotelForm = new HotelForm();
            hotelForm.ShowDialog();
        }

        private void excursionBtn_Click(object sender, EventArgs e)
        {
            ExcursionForm excursionForm = new ExcursionForm();
            excursionForm.ShowDialog();
        }
    }
}
