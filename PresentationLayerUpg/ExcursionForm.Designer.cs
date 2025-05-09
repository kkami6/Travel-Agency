namespace WindowsFormsApp1
{
    partial class ExcursionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cityLbl = new Label();
            hotelLbl = new Label();
            priceLbl = new Label();
            departureLbl = new Label();
            returnDateLbl = new Label();
            createBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            cityTxtBox = new TextBox();
            hotelTxtBox = new TextBox();
            priceTxtBox = new TextBox();
            departureDateTimePicker = new DateTimePicker();
            returnDateTimePicker = new DateTimePicker();
            dataGridView1 = new DataGridView();
            cityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hotelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            excursionBindingSource2 = new BindingSource(components);
            excursionContextBindingSource = new BindingSource(components);
            addClient = new Button();
            label1 = new Label();
            clientIdTxtBox = new TextBox();
            showAllClients = new Button();
            clientsListBox = new ListBox();
            label2 = new Label();
            employeeIdTxtBox = new TextBox();
            addEmployee = new Button();
            showAllEmployees = new Button();
            employeesListBox = new ListBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)excursionBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)excursionContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cityLbl
            // 
            cityLbl.AutoSize = true;
            cityLbl.Location = new Point(70, 61);
            cityLbl.Margin = new Padding(2, 0, 2, 0);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new Size(34, 20);
            cityLbl.TabIndex = 0;
            cityLbl.Text = "City";
            // 
            // hotelLbl
            // 
            hotelLbl.AutoSize = true;
            hotelLbl.Location = new Point(58, 120);
            hotelLbl.Margin = new Padding(2, 0, 2, 0);
            hotelLbl.Name = "hotelLbl";
            hotelLbl.Size = new Size(46, 20);
            hotelLbl.TabIndex = 1;
            hotelLbl.Text = "Hotel";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(62, 177);
            priceLbl.Margin = new Padding(2, 0, 2, 0);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(41, 20);
            priceLbl.TabIndex = 2;
            priceLbl.Text = "Price";
            // 
            // departureLbl
            // 
            departureLbl.AutoSize = true;
            departureLbl.Location = new Point(302, 61);
            departureLbl.Margin = new Padding(2, 0, 2, 0);
            departureLbl.Name = "departureLbl";
            departureLbl.Size = new Size(110, 20);
            departureLbl.TabIndex = 3;
            departureLbl.Text = "Departure date";
            // 
            // returnDateLbl
            // 
            returnDateLbl.AutoSize = true;
            returnDateLbl.Location = new Point(322, 120);
            returnDateLbl.Margin = new Padding(2, 0, 2, 0);
            returnDateLbl.Name = "returnDateLbl";
            returnDateLbl.Size = new Size(86, 20);
            returnDateLbl.TabIndex = 4;
            returnDateLbl.Text = "Return date";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(181, 242);
            createBtn.Margin = new Padding(2, 3, 2, 3);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(95, 45);
            createBtn.TabIndex = 5;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(442, 242);
            deleteBtn.Margin = new Padding(2, 3, 2, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(95, 45);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(309, 242);
            updateBtn.Margin = new Padding(2, 3, 2, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(95, 45);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // cityTxtBox
            // 
            cityTxtBox.Location = new Point(108, 61);
            cityTxtBox.Margin = new Padding(2);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(121, 27);
            cityTxtBox.TabIndex = 8;
            // 
            // hotelTxtBox
            // 
            hotelTxtBox.Location = new Point(107, 120);
            hotelTxtBox.Margin = new Padding(2);
            hotelTxtBox.Name = "hotelTxtBox";
            hotelTxtBox.Size = new Size(121, 27);
            hotelTxtBox.TabIndex = 9;
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(106, 177);
            priceTxtBox.Margin = new Padding(2);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(121, 27);
            priceTxtBox.TabIndex = 10;
            // 
            // departureDateTimePicker
            // 
            departureDateTimePicker.Location = new Point(411, 57);
            departureDateTimePicker.Margin = new Padding(2);
            departureDateTimePicker.Name = "departureDateTimePicker";
            departureDateTimePicker.Size = new Size(241, 27);
            departureDateTimePicker.TabIndex = 13;
            // 
            // returnDateTimePicker
            // 
            returnDateTimePicker.Location = new Point(409, 118);
            returnDateTimePicker.Margin = new Padding(2);
            returnDateTimePicker.Name = "returnDateTimePicker";
            returnDateTimePicker.Size = new Size(241, 27);
            returnDateTimePicker.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cityIdDataGridViewTextBoxColumn, hotelIdDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, departureDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = excursionBindingSource2;
            dataGridView1.Location = new Point(70, 292);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(659, 137);
            dataGridView1.TabIndex = 15;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // cityIdDataGridViewTextBoxColumn
            // 
            cityIdDataGridViewTextBoxColumn.DataPropertyName = "CityId";
            cityIdDataGridViewTextBoxColumn.HeaderText = "CityId";
            cityIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            cityIdDataGridViewTextBoxColumn.Name = "cityIdDataGridViewTextBoxColumn";
            cityIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // hotelIdDataGridViewTextBoxColumn
            // 
            hotelIdDataGridViewTextBoxColumn.DataPropertyName = "HotelId";
            hotelIdDataGridViewTextBoxColumn.HeaderText = "HotelId";
            hotelIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            hotelIdDataGridViewTextBoxColumn.Name = "hotelIdDataGridViewTextBoxColumn";
            hotelIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.MinimumWidth = 8;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 150;
            // 
            // departureDateDataGridViewTextBoxColumn
            // 
            departureDateDataGridViewTextBoxColumn.DataPropertyName = "DepartureDate";
            departureDateDataGridViewTextBoxColumn.HeaderText = "DepartureDate";
            departureDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            departureDateDataGridViewTextBoxColumn.Name = "departureDateDataGridViewTextBoxColumn";
            departureDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            returnDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            returnDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // excursionBindingSource2
            // 
            excursionBindingSource2.AllowNew = true;
            excursionBindingSource2.DataSource = typeof(BusinessLayer.Excursion);
            // 
            // addClient
            // 
            addClient.Location = new Point(781, 111);
            addClient.Name = "addClient";
            addClient.Size = new Size(105, 46);
            addClient.TabIndex = 16;
            addClient.Text = "Add client";
            addClient.UseVisualStyleBackColor = true;
            addClient.Click += addClient_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(764, 46);
            label1.Name = "label1";
            label1.Size = new Size(188, 20);
            label1.TabIndex = 17;
            label1.Text = "To add a client write the ID";
            label1.Click += label1_Click;
            // 
            // clientIdTxtBox
            // 
            clientIdTxtBox.Location = new Point(770, 78);
            clientIdTxtBox.Name = "clientIdTxtBox";
            clientIdTxtBox.Size = new Size(125, 27);
            clientIdTxtBox.TabIndex = 18;
            // 
            // showAllClients
            // 
            showAllClients.Location = new Point(781, 163);
            showAllClients.Name = "showAllClients";
            showAllClients.Size = new Size(104, 58);
            showAllClients.TabIndex = 19;
            showAllClients.Text = "Show all clients";
            showAllClients.UseVisualStyleBackColor = true;
            showAllClients.Click += showAllClients_Click;
            // 
            // clientsListBox
            // 
            clientsListBox.FormattingEnabled = true;
            clientsListBox.Location = new Point(764, 242);
            clientsListBox.Name = "clientsListBox";
            clientsListBox.Size = new Size(188, 124);
            clientsListBox.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(999, 46);
            label2.Name = "label2";
            label2.Size = new Size(226, 20);
            label2.TabIndex = 21;
            label2.Text = "To add an employee write the ID";
            // 
            // employeeIdTxtBox
            // 
            employeeIdTxtBox.Location = new Point(999, 78);
            employeeIdTxtBox.Name = "employeeIdTxtBox";
            employeeIdTxtBox.Size = new Size(125, 27);
            employeeIdTxtBox.TabIndex = 22;
            // 
            // addEmployee
            // 
            addEmployee.Location = new Point(1008, 111);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(105, 54);
            addEmployee.TabIndex = 23;
            addEmployee.Text = "Add employee";
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // showAllEmployees
            // 
            showAllEmployees.Location = new Point(1008, 171);
            showAllEmployees.Name = "showAllEmployees";
            showAllEmployees.Size = new Size(105, 49);
            showAllEmployees.TabIndex = 24;
            showAllEmployees.Text = "Show all employees";
            showAllEmployees.UseVisualStyleBackColor = true;
            showAllEmployees.Click += showAllEmployees_Click;
            // 
            // employeesListBox
            // 
            employeesListBox.FormattingEnabled = true;
            employeesListBox.Location = new Point(999, 242);
            employeesListBox.Name = "employeesListBox";
            employeesListBox.Size = new Size(226, 124);
            employeesListBox.TabIndex = 25;
            // 
            // ExcursionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 450);
            Controls.Add(employeesListBox);
            Controls.Add(showAllEmployees);
            Controls.Add(addEmployee);
            Controls.Add(employeeIdTxtBox);
            Controls.Add(label2);
            Controls.Add(clientsListBox);
            Controls.Add(showAllClients);
            Controls.Add(clientIdTxtBox);
            Controls.Add(label1);
            Controls.Add(addClient);
            Controls.Add(dataGridView1);
            Controls.Add(returnDateTimePicker);
            Controls.Add(departureDateTimePicker);
            Controls.Add(priceTxtBox);
            Controls.Add(hotelTxtBox);
            Controls.Add(cityTxtBox);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(returnDateLbl);
            Controls.Add(departureLbl);
            Controls.Add(priceLbl);
            Controls.Add(hotelLbl);
            Controls.Add(cityLbl);
            Margin = new Padding(2, 3, 2, 3);
            Name = "ExcursionForm";
            Text = "ExcursionForm";
            Load += ExcursionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)excursionBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)excursionContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label hotelLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label departureLbl;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private Button updateBtn;
        private TextBox cityTxtBox;
        private TextBox hotelTxtBox;
        private TextBox priceTxtBox;
        private DateTimePicker departureDateTimePicker;
        private DateTimePicker returnDateTimePicker;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn hotelIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private BindingSource excursionBindingSource2;
        private BindingSource excursionContextBindingSource;
        private Button addClient;
        private Label label1;
        private TextBox clientIdTxtBox;
        private Button showAllClients;
        private ListBox clientsListBox;
        private Label label2;
        private TextBox employeeIdTxtBox;
        private Button addEmployee;
        private Button showAllEmployees;
        private ListBox employeesListBox;
    }
}