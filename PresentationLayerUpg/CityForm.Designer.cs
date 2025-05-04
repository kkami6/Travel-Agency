namespace WindowsFormsApp1
{
    partial class CityForm
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
            nameLabel = new Label();
            nameTxtBox = new TextBox();
            countryLabel = new Label();
            countryTxtBox = new TextBox();
            createBtn = new Button();
            updateBtn = new Button();
            deleteBtn = new Button();
            cityDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cityBindingSource = new BindingSource(components);
            testManagerBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)cityDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testManagerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(46, 50);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(59, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(109, 46);
            nameTxtBox.Margin = new Padding(3, 4, 3, 4);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(140, 31);
            nameTxtBox.TabIndex = 1;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(31, 120);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(75, 25);
            countryLabel.TabIndex = 2;
            countryLabel.Text = "Country";
            // 
            // countryTxtBox
            // 
            countryTxtBox.Location = new Point(109, 120);
            countryTxtBox.Margin = new Padding(3, 4, 3, 4);
            countryTxtBox.Name = "countryTxtBox";
            countryTxtBox.Size = new Size(140, 31);
            countryTxtBox.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(152, 242);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(120, 54);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Enabled = false;
            updateBtn.Location = new Point(322, 242);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(120, 54);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Enabled = false;
            deleteBtn.Location = new Point(494, 242);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(120, 54);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cityDataGridView
            // 
            cityDataGridView.AutoGenerateColumns = false;
            cityDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            cityDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            cityDataGridView.DataSource = cityBindingSource;
            cityDataGridView.Location = new Point(98, 329);
            cityDataGridView.Name = "cityDataGridView";
            cityDataGridView.RowHeadersWidth = 62;
            cityDataGridView.Size = new Size(366, 206);
            cityDataGridView.TabIndex = 7;
            cityDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // countryDataGridViewTextBoxColumn
            // 
            countryDataGridViewTextBoxColumn.DataPropertyName = "Country";
            countryDataGridViewTextBoxColumn.HeaderText = "Country";
            countryDataGridViewTextBoxColumn.MinimumWidth = 8;
            countryDataGridViewTextBoxColumn.Name = "countryDataGridViewTextBoxColumn";
            countryDataGridViewTextBoxColumn.Width = 150;
            // 
            // cityBindingSource
            // 
            cityBindingSource.AllowNew = true;
            cityBindingSource.DataSource = typeof(BusinessLayer.City);
            // 
            // testManagerBindingSource
            // 
            testManagerBindingSource.DataSource = typeof(TestingLayer.TestManager);
            // 
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(cityDataGridView);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(createBtn);
            Controls.Add(countryTxtBox);
            Controls.Add(countryLabel);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CityForm";
            Text = "City";
            Load += CityForm_Load;
            ((System.ComponentModel.ISupportInitialize)cityDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)testManagerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label countryLabel;
        private System.Windows.Forms.TextBox countryTxtBox;
        private Button createBtn;
        private Button updateBtn;
        private Button deleteBtn;
        private DataGridView cityDataGridView;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private BindingSource cityBindingSource;
        private BindingSource testManagerBindingSource;
    }
}