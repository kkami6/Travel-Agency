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
    public partial class Client : Form
    {
        public Client()
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
                Client client = new Client();

                //Validate
                client.Name = nameTxtBox.Text;
                client.SecondName = name2TxtBox.Text;
                client.FamilyName = name3TxtBox.Text;
                client.Status = statusCheck; 

            }
        }
    }
}
