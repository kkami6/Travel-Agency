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
using ServiceLayer;
using DataLayer;
using Mysqlx;
using Microsoft.EntityFrameworkCore;


namespace WindowsFormsApp1
{
    public partial class ClientForm : Form
    {
        Client selectedClient;
        bool updatedClient = false;
        bool deleteClient = false;
        int currentRowIndex = -1;
        private Manager<Client, int> clientManager;
        private ClientsContext clientContext;
        private TravelAgencyDbContext context;

        public ClientForm()
        {
            InitializeComponent();
            context = new TravelAgencyDbContext();
            clientContext = new ClientsContext(context);
            clientManager = new Manager<Client, int>(clientContext);
        }


        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                string name = nameTxtBox.Text;
                string secondName = name2TxtBox.Text;
                string familyName = name3TxtBox.Text;
                string status = statusCheck.Checked ? "Loyal" : "Normal";
                int age = DateTime.Now.Year - agePicker.Value.Year;

                if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(secondName) || string.IsNullOrWhiteSpace(familyName))
                {
                    MessageBox.Show("Please fill in all fields!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (age < 18)
                {
                    MessageBox.Show("Client must be 18 or older!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (agePicker.Value.Date.Year == DateTime.Now.Year)
                {
                    MessageBox.Show("You must enter your birth date!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                Client client = new Client(name, secondName, familyName, age, status);

                //serv layer
                clientContext.Create(client);
                MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                currentRowIndex = -1;

                LoadClients();

                nameTxtBox.Focus();

                deleteBtn.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            //Load clients into the DataGridView
            LoadClients();
        }

        private void LoadClients()
        {
            // Load clients logic
            try
            {
                List<Client> clients = clientManager.ReadAll(true, false);
                clientDataGridView.DataSource = clients;
                clientDataGridView.AutoResizeColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void clientDataGridView_RowEnter(object sender, DataGridViewRowEventArgs e)
        //{
        //    //MessageBox.Show("Text to show", "Caption", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (currentRowIndex == -1 || deleteClient)
        //    {
        //        currentRowIndex = 0;
        //        return;
        //    }

        //    if (updatedClient)
        //    {
        //        clientManager.Update(selectedClient);
        //    }

        //    //currentRowIndex = e.RowIndex;

        //    //selectedClient = new Client();

        //    //selectedClient.ClientId = ....Client[currentRowIndex].ClientId;
        //    //selectedClient.Name = .Client[currentRowIndex].Name;
        //    //selectedClient.SecondName = .Client[currentRowIndex].SecondName;
        //    //selectedClient.FamilyName = .Client[currentRowIndex].FamilyName;
        //    //selectedClient.Age = .Client[currentRowIndex].Age;
        //    //selectedClient.Status = .Client[currentRowIndex].Status;
        //    ////selectedClient.Excursions = .Client[currentRowIndex].Excursions;

        //    ////Update graphical components
        //    //nameTxtBox.Text = selectedClient.Name;
        //    //name2TxtBox.Text = selectedClient.SecondName;
        //    //name3TxtBox.Text = selectedClient.FamilyName;
        //    //statusCheck.Checked = selectedClient.Status;
        //    //agePicker.Value = selectedClient.Age;

        //    //updatedClient = false;
        //    //deleteBtn.Enabled = true;
        //}

        //private void clientDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex != -1 && e.ColumnIndex != -1)
        //    {
        //        clientDataGridView.UpdateCellValue(e.ColumnIndex, e.RowIndex);

        //        //switch (e.ColumnIndex)
        //        //{
        //        //    case 0:
        //        //        selectedClient.Name = .Client[e.RowIndex].Name;
        //        //        nameTxtBox.Text = selectedClient.Name;
        //        //        break;
        //        //    case 1:
        //        //        selectedClient.SecondName = .Client[e.RowIndex].SecondName;
        //        //        name2TxtBox.Text = selectedClient.SecondName;
        //        //        break;
        //        //    case 2:
        //        //        selectedClient.FamilyName = .Client[e.RowIndex].FamilyName;
        //        //        name3TxtBox.Text = selectedClient.FamilyName;
        //        //        break;
        //        //    case 3:
        //        //        selectedClient.Age = .Client[e.RowIndex].Age;
        //        //        agePicker.Value = selectedClient.Age;
        //        //        break;
        //        //    case 4:
        //        //        selectedClient.Status = .Client[e.RowIndex].Status;
        //        //        statusCheck.Checked = selectedClient.Status;
        //        //        break;

        //        //    default:
        //        //        break;
        //        //}

        //        //updatedClient = true;
        //    }
        //}


        private void updateBtn_Click(object sender, EventArgs e)
        {
            selectedClient.Name = nameTxtBox.Text;
            selectedClient.SecondName = name2TxtBox.Text;
            selectedClient.FamilyName = name3TxtBox.Text;
            selectedClient.Age = DateTime.Now.Year - agePicker.Value.Year;
            if (statusCheck.Checked) selectedClient.Status = "loyal";
            else selectedClient.Status = "normal";

            clientManager.Update(selectedClient);

            //Update
            clientDataGridView[0, currentRowIndex].Value = selectedClient.Name;
            clientDataGridView[1, currentRowIndex].Value = selectedClient.SecondName;
            clientDataGridView[2, currentRowIndex].Value = selectedClient.FamilyName;
            clientDataGridView[3, currentRowIndex].Value = selectedClient.Age;
            clientDataGridView[4, currentRowIndex].Value = selectedClient.Status;

            MessageBox.Show("Client updated successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            deleteClient = true;

            clientDataGridView.Rows.RemoveAt(clientDataGridView.CurrentRow.Index);

            clientManager.Delete(selectedClient.ClientId);

            deleteBtn.Enabled = false;
            deleteClient = false;

            MessageBox.Show("Client deleted successfuly!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearUserInterface();
            //.Clear();

            currentRowIndex = -1;

            LoadClients();
        }

        private void ClearUserInterface()
        {
            nameTxtBox.Text = string.Empty;
            name2TxtBox.Text = string.Empty;
            name3TxtBox.Text = string.Empty;
            agePicker.Value = DateTime.Now;
            statusCheck.Checked = false;
        }
        private void clientDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
