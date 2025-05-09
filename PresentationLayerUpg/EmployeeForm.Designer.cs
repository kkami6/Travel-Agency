namespace WindowsFormsApp1
{
    partial class EmployeeForm
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
            nameLbl = new Label();
            nameTxtBox = new TextBox();
            name2Lbl = new Label();
            name3Lbl = new Label();
            ageLbl = new Label();
            positionLbl = new Label();
            salaryLbl = new Label();
            name2TxtBox = new TextBox();
            name3TxtBox = new TextBox();
            agePicker = new DateTimePicker();
            positionTxtBox = new TextBox();
            salaryTxtBox = new TextBox();
            createBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            dataGridView1 = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secondNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            familyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            salaryDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeBindingSource = new BindingSource(components);
            label1 = new Label();
            excursionIdTxtBox = new TextBox();
            addExcursion = new Button();
            showAllExcursions = new Button();
            excursionsListBox = new ListBox();
            employeeContextBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeContextBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(77, 40);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(49, 20);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(128, 37);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(89, 27);
            nameTxtBox.TabIndex = 1;
            // 
            // name2Lbl
            // 
            name2Lbl.AutoSize = true;
            name2Lbl.Location = new Point(27, 96);
            name2Lbl.Name = "name2Lbl";
            name2Lbl.Size = new Size(99, 20);
            name2Lbl.TabIndex = 2;
            name2Lbl.Text = "Second name";
            // 
            // name3Lbl
            // 
            name3Lbl.AutoSize = true;
            name3Lbl.Location = new Point(36, 146);
            name3Lbl.Name = "name3Lbl";
            name3Lbl.Size = new Size(92, 20);
            name3Lbl.TabIndex = 3;
            name3Lbl.Text = "Family name";
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Location = new Point(258, 40);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(94, 20);
            ageLbl.TabIndex = 4;
            ageLbl.Text = "Date of birth";
            // 
            // positionLbl
            // 
            positionLbl.AutoSize = true;
            positionLbl.Location = new Point(286, 93);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(61, 20);
            positionLbl.TabIndex = 5;
            positionLbl.Text = "Position";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(297, 146);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(49, 20);
            salaryLbl.TabIndex = 6;
            salaryLbl.Text = "Salary";
            // 
            // name2TxtBox
            // 
            name2TxtBox.Location = new Point(128, 90);
            name2TxtBox.Name = "name2TxtBox";
            name2TxtBox.Size = new Size(89, 27);
            name2TxtBox.TabIndex = 7;
            // 
            // name3TxtBox
            // 
            name3TxtBox.Location = new Point(128, 143);
            name3TxtBox.Name = "name3TxtBox";
            name3TxtBox.Size = new Size(89, 27);
            name3TxtBox.TabIndex = 8;
            // 
            // agePicker
            // 
            agePicker.Location = new Point(349, 37);
            agePicker.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            agePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            agePicker.Name = "agePicker";
            agePicker.Size = new Size(178, 27);
            agePicker.TabIndex = 12;
            agePicker.Value = new DateTime(2025, 5, 4, 0, 0, 0, 0);
            // 
            // positionTxtBox
            // 
            positionTxtBox.Location = new Point(349, 90);
            positionTxtBox.Name = "positionTxtBox";
            positionTxtBox.Size = new Size(89, 27);
            positionTxtBox.TabIndex = 13;
            // 
            // salaryTxtBox
            // 
            salaryTxtBox.Location = new Point(349, 143);
            salaryTxtBox.Name = "salaryTxtBox";
            salaryTxtBox.Size = new Size(89, 27);
            salaryTxtBox.TabIndex = 14;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(158, 204);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(80, 46);
            createBtn.TabIndex = 15;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(419, 204);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(80, 46);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(286, 204);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(80, 46);
            updateBtn.TabIndex = 17;
            updateBtn.Text = "Upate";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, secondNameDataGridViewTextBoxColumn, familyNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, salaryDataGridViewTextBoxColumn });
            dataGridView1.DataSource = employeeBindingSource;
            dataGridView1.Location = new Point(10, 256);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(775, 129);
            dataGridView1.TabIndex = 18;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            secondNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            secondNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // familyNameDataGridViewTextBoxColumn
            // 
            familyNameDataGridViewTextBoxColumn.DataPropertyName = "FamilyName";
            familyNameDataGridViewTextBoxColumn.HeaderText = "FamilyName";
            familyNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            familyNameDataGridViewTextBoxColumn.Name = "familyNameDataGridViewTextBoxColumn";
            familyNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.Width = 150;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.MinimumWidth = 8;
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            positionDataGridViewTextBoxColumn.Width = 150;
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            salaryDataGridViewTextBoxColumn.MinimumWidth = 8;
            salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            salaryDataGridViewTextBoxColumn.Width = 150;
            // 
            // employeeBindingSource
            // 
            employeeBindingSource.AllowNew = true;
            employeeBindingSource.DataSource = typeof(BusinessLayer.Employee);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(850, 37);
            label1.Name = "label1";
            label1.Size = new Size(222, 20);
            label1.TabIndex = 19;
            label1.Text = "To add an excursion write the ID";
            // 
            // excursionIdTxtBox
            // 
            excursionIdTxtBox.Location = new Point(878, 60);
            excursionIdTxtBox.Name = "excursionIdTxtBox";
            excursionIdTxtBox.Size = new Size(125, 27);
            excursionIdTxtBox.TabIndex = 20;
            // 
            // addExcursion
            // 
            addExcursion.Location = new Point(892, 96);
            addExcursion.Name = "addExcursion";
            addExcursion.Size = new Size(97, 53);
            addExcursion.TabIndex = 21;
            addExcursion.Text = "Add excursion";
            addExcursion.UseVisualStyleBackColor = true;
            addExcursion.Click += addExcursion_Click;
            // 
            // showAllExcursions
            // 
            showAllExcursions.Location = new Point(892, 155);
            showAllExcursions.Name = "showAllExcursions";
            showAllExcursions.Size = new Size(97, 57);
            showAllExcursions.TabIndex = 22;
            showAllExcursions.Text = "Show all excursions";
            showAllExcursions.UseVisualStyleBackColor = true;
            showAllExcursions.Click += showAllExcursions_Click;
            // 
            // excursionsListBox
            // 
            excursionsListBox.FormattingEnabled = true;
            excursionsListBox.Location = new Point(850, 229);
            excursionsListBox.Name = "excursionsListBox";
            excursionsListBox.Size = new Size(222, 124);
            excursionsListBox.TabIndex = 23;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 450);
            Controls.Add(excursionsListBox);
            Controls.Add(showAllExcursions);
            Controls.Add(addExcursion);
            Controls.Add(excursionIdTxtBox);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(salaryTxtBox);
            Controls.Add(positionTxtBox);
            Controls.Add(agePicker);
            Controls.Add(name3TxtBox);
            Controls.Add(name2TxtBox);
            Controls.Add(salaryLbl);
            Controls.Add(positionLbl);
            Controls.Add(ageLbl);
            Controls.Add(name3Lbl);
            Controls.Add(name2Lbl);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLbl);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeContextBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label name2Lbl;
        private System.Windows.Forms.Label name3Lbl;
        private System.Windows.Forms.Label ageLbl;
        private System.Windows.Forms.Label positionLbl;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.TextBox name2TxtBox;
        private System.Windows.Forms.TextBox name3TxtBox;
        private System.Windows.Forms.DateTimePicker agePicker;
        private System.Windows.Forms.TextBox positionTxtBox;
        private System.Windows.Forms.TextBox salaryTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private Button updateBtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn familyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private BindingSource employeeBindingSource;
        private Label label1;
        private TextBox excursionIdTxtBox;
        private Button addExcursion;
        private Button showAllExcursions;
        private ListBox excursionsListBox;
        private BindingSource employeeContextBindingSource;
    }
}