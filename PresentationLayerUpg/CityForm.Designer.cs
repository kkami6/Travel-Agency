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
            cityContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)cityDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(37, 40);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(49, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(87, 37);
            nameTxtBox.Margin = new Padding(2, 3, 2, 3);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(113, 27);
            nameTxtBox.TabIndex = 1;
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(25, 96);
            countryLabel.Margin = new Padding(2, 0, 2, 0);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(60, 20);
            countryLabel.TabIndex = 2;
            countryLabel.Text = "Country";
            // 
            // countryTxtBox
            // 
            countryTxtBox.Location = new Point(87, 96);
            countryTxtBox.Margin = new Padding(2, 3, 2, 3);
            countryTxtBox.Name = "countryTxtBox";
            countryTxtBox.Size = new Size(113, 27);
            countryTxtBox.TabIndex = 3;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(122, 194);
            createBtn.Margin = new Padding(2);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(96, 43);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(258, 194);
            updateBtn.Margin = new Padding(2);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(96, 43);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(395, 194);
            deleteBtn.Margin = new Padding(2);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(96, 43);
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
            cityDataGridView.Location = new Point(122, 266);
            cityDataGridView.Margin = new Padding(2);
            cityDataGridView.Name = "cityDataGridView";
            cityDataGridView.RowHeadersWidth = 62;
            cityDataGridView.Size = new Size(454, 165);
            cityDataGridView.TabIndex = 7;
            cityDataGridView.CellContentClick += dataGridView1_CellContentClick;
            cityDataGridView.RowHeaderMouseClick += cityDataGridView_RowHeaderMouseClick;
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
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(cityDataGridView);
            Controls.Add(deleteBtn);
            Controls.Add(updateBtn);
            Controls.Add(createBtn);
            Controls.Add(countryTxtBox);
            Controls.Add(countryLabel);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLabel);
            Margin = new Padding(2, 3, 2, 3);
            Name = "CityForm";
            Text = "City";
            Load += CityForm_Load;
            ((System.ComponentModel.ISupportInitialize)cityDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)testManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityContextBindingSource).EndInit();
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
        private BindingSource cityContextBindingSource;
    }
}