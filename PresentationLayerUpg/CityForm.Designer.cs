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
            dataGridView1 = new DataGridView();
            testManagerBindingSource = new BindingSource(components);
            cityBindingSource = new BindingSource(components);
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)testManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).BeginInit();
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
            createBtn.Location = new Point(137, 259);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(120, 54);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(312, 259);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(120, 54);
            updateBtn.TabIndex = 5;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(481, 259);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(120, 54);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, countryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = cityBindingSource;
            dataGridView1.Location = new Point(98, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(364, 206);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // testManagerBindingSource
            // 
            testManagerBindingSource.DataSource = typeof(TestingLayer.TestManager);
            // 
            // cityBindingSource
            // 
            cityBindingSource.AllowNew = true;
            cityBindingSource.DataSource = typeof(BusinessLayer.City);
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
            // CityForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)testManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)cityBindingSource).EndInit();
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
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn countryDataGridViewTextBoxColumn;
        private BindingSource cityBindingSource;
        private BindingSource testManagerBindingSource;
    }
}