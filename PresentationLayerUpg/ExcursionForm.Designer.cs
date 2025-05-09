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
            excursionBindingSource2 = new BindingSource(components);
            cityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            hotelIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            returnDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)excursionBindingSource2).BeginInit();
            SuspendLayout();
            // 
            // cityLbl
            // 
            cityLbl.AutoSize = true;
            cityLbl.Location = new Point(87, 76);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new Size(42, 25);
            cityLbl.TabIndex = 0;
            cityLbl.Text = "City";
            // 
            // hotelLbl
            // 
            hotelLbl.AutoSize = true;
            hotelLbl.Location = new Point(73, 150);
            hotelLbl.Name = "hotelLbl";
            hotelLbl.Size = new Size(55, 25);
            hotelLbl.TabIndex = 1;
            hotelLbl.Text = "Hotel";
            // 
            // priceLbl
            // 
            priceLbl.AutoSize = true;
            priceLbl.Location = new Point(77, 221);
            priceLbl.Name = "priceLbl";
            priceLbl.Size = new Size(49, 25);
            priceLbl.TabIndex = 2;
            priceLbl.Text = "Price";
            // 
            // departureLbl
            // 
            departureLbl.AutoSize = true;
            departureLbl.Location = new Point(377, 76);
            departureLbl.Name = "departureLbl";
            departureLbl.Size = new Size(131, 25);
            departureLbl.TabIndex = 3;
            departureLbl.Text = "Departure date";
            // 
            // returnDateLbl
            // 
            returnDateLbl.AutoSize = true;
            returnDateLbl.Location = new Point(402, 150);
            returnDateLbl.Name = "returnDateLbl";
            returnDateLbl.Size = new Size(103, 25);
            returnDateLbl.TabIndex = 4;
            returnDateLbl.Text = "Return date";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(226, 302);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(119, 56);
            createBtn.TabIndex = 5;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(553, 302);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(119, 56);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(386, 302);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(119, 56);
            updateBtn.TabIndex = 7;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // cityTxtBox
            // 
            cityTxtBox.Location = new Point(135, 76);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(150, 31);
            cityTxtBox.TabIndex = 8;
            // 
            // hotelTxtBox
            // 
            hotelTxtBox.Location = new Point(134, 150);
            hotelTxtBox.Name = "hotelTxtBox";
            hotelTxtBox.Size = new Size(150, 31);
            hotelTxtBox.TabIndex = 9;
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(132, 221);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(150, 31);
            priceTxtBox.TabIndex = 10;
            // 
            // departureDateTimePicker
            // 
            departureDateTimePicker.Location = new Point(514, 71);
            departureDateTimePicker.Name = "departureDateTimePicker";
            departureDateTimePicker.Size = new Size(300, 31);
            departureDateTimePicker.TabIndex = 13;
            // 
            // returnDateTimePicker
            // 
            returnDateTimePicker.Location = new Point(511, 148);
            returnDateTimePicker.Name = "returnDateTimePicker";
            returnDateTimePicker.Size = new Size(300, 31);
            returnDateTimePicker.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cityIdDataGridViewTextBoxColumn, hotelIdDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, departureDateDataGridViewTextBoxColumn, returnDateDataGridViewTextBoxColumn });
            dataGridView1.DataSource = excursionBindingSource2;
            dataGridView1.Location = new Point(87, 365);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(824, 171);
            dataGridView1.TabIndex = 15;
            // 
            // excursionBindingSource2
            // 
            excursionBindingSource2.AllowNew = true;
            excursionBindingSource2.DataSource = typeof(BusinessLayer.Excursion);
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
            // ExcursionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 562);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "ExcursionForm";
            Text = "ExcursionForm";
            Load += ExcursionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)excursionBindingSource2).EndInit();
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
    }
}