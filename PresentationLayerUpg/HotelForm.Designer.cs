namespace WindowsFormsApp1
{
    partial class HotelForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addressTxtBox = new TextBox();
            nameTxtBox = new TextBox();
            ratingUpDown = new NumericUpDown();
            createBtn = new Button();
            deleteBtn = new Button();
            cityTxtBox = new TextBox();
            updateBtn = new Button();
            SPA = new CheckBox();
            Parking = new CheckBox();
            dataGridView1 = new DataGridView();
            cityIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            addressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            sPADataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            parkingDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            hotelBindingSource = new BindingSource(components);
            hotelContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)ratingUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)hotelContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // cityLbl
            // 
            cityLbl.AutoSize = true;
            cityLbl.Location = new Point(67, 50);
            cityLbl.Margin = new Padding(2, 0, 2, 0);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new Size(34, 20);
            cityLbl.TabIndex = 0;
            cityLbl.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 1;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(54, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 50);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 3;
            label3.Text = "Rating";
            // 
            // addressTxtBox
            // 
            addressTxtBox.Location = new Point(104, 98);
            addressTxtBox.Margin = new Padding(2, 3, 2, 3);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(90, 27);
            addressTxtBox.TabIndex = 6;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(104, 139);
            nameTxtBox.Margin = new Padding(2, 3, 2, 3);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(90, 27);
            nameTxtBox.TabIndex = 7;
            // 
            // ratingUpDown
            // 
            ratingUpDown.Location = new Point(338, 50);
            ratingUpDown.Margin = new Padding(2, 3, 2, 3);
            ratingUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ratingUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ratingUpDown.Name = "ratingUpDown";
            ratingUpDown.Size = new Size(55, 27);
            ratingUpDown.TabIndex = 10;
            ratingUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // createBtn
            // 
            createBtn.Location = new Point(106, 207);
            createBtn.Margin = new Padding(2, 3, 2, 3);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(94, 52);
            createBtn.TabIndex = 11;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(372, 207);
            deleteBtn.Margin = new Padding(2, 3, 2, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(94, 52);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cityTxtBox
            // 
            cityTxtBox.Location = new Point(106, 50);
            cityTxtBox.Margin = new Padding(2, 3, 2, 3);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(90, 27);
            cityTxtBox.TabIndex = 13;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(239, 207);
            updateBtn.Margin = new Padding(2, 3, 2, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(94, 52);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // SPA
            // 
            SPA.AutoSize = true;
            SPA.Location = new Point(283, 95);
            SPA.Name = "SPA";
            SPA.Size = new Size(56, 24);
            SPA.TabIndex = 15;
            SPA.Text = "SPA";
            SPA.UseVisualStyleBackColor = true;
            // 
            // Parking
            // 
            Parking.AutoSize = true;
            Parking.Location = new Point(283, 136);
            Parking.Name = "Parking";
            Parking.Size = new Size(79, 24);
            Parking.TabIndex = 16;
            Parking.Text = "Parking";
            Parking.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { cityIdDataGridViewTextBoxColumn, addressDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, ratingDataGridViewTextBoxColumn, sPADataGridViewCheckBoxColumn, parkingDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = hotelBindingSource;
            dataGridView1.Location = new Point(10, 276);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(781, 142);
            dataGridView1.TabIndex = 17;
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
            // addressDataGridViewTextBoxColumn
            // 
            addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            addressDataGridViewTextBoxColumn.HeaderText = "Address";
            addressDataGridViewTextBoxColumn.MinimumWidth = 8;
            addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            addressDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 8;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Width = 150;
            // 
            // sPADataGridViewCheckBoxColumn
            // 
            sPADataGridViewCheckBoxColumn.DataPropertyName = "SPA";
            sPADataGridViewCheckBoxColumn.HeaderText = "SPA";
            sPADataGridViewCheckBoxColumn.MinimumWidth = 8;
            sPADataGridViewCheckBoxColumn.Name = "sPADataGridViewCheckBoxColumn";
            sPADataGridViewCheckBoxColumn.Width = 150;
            // 
            // parkingDataGridViewCheckBoxColumn
            // 
            parkingDataGridViewCheckBoxColumn.DataPropertyName = "Parking";
            parkingDataGridViewCheckBoxColumn.HeaderText = "Parking";
            parkingDataGridViewCheckBoxColumn.MinimumWidth = 8;
            parkingDataGridViewCheckBoxColumn.Name = "parkingDataGridViewCheckBoxColumn";
            parkingDataGridViewCheckBoxColumn.Width = 150;
            // 
            // hotelBindingSource
            // 
            hotelBindingSource.AllowNew = true;
            hotelBindingSource.DataSource = typeof(BusinessLayer.Hotel);
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Parking);
            Controls.Add(SPA);
            Controls.Add(updateBtn);
            Controls.Add(cityTxtBox);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(ratingUpDown);
            Controls.Add(nameTxtBox);
            Controls.Add(addressTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cityLbl);
            Margin = new Padding(2, 3, 2, 3);
            Name = "HotelForm";
            Text = "HotelForm";
            Load += HotelForm_Load;
            ((System.ComponentModel.ISupportInitialize)ratingUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)hotelContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.NumericUpDown ratingUpDown;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private TextBox cityTxtBox;
        private Button updateBtn;
        private CheckBox SPA;
        private CheckBox Parking;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn cityIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn sPADataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn parkingDataGridViewCheckBoxColumn;
        private BindingSource hotelBindingSource;
        private BindingSource hotelContextBindingSource;
    }
}