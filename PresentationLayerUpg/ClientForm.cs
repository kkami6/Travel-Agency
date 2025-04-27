using BusinessLayer;
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
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {

        }

        private void statusCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {

                //Validate
                string name = nameTxtBox.Text;
                string secondName = name2TxtBox.Text;
                string familyName = name3TxtBox.Text;
                string status = statusCheck.Checked ? "Loyal" : "Normal";
                int age = 5;

                Client client = new Client(name, secondName, familyName, age, status);


            }
            catch (Exception ex)
            {

            }
        }
    }
}
