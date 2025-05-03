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
            nameLbl = new Label();
            nameTxtBox = new TextBox();
            name2Lbl = new Label();
            name3Lbl = new Label();
            ageLbl = new Label();
            positionLbl = new Label();
            salaryLbl = new Label();
            name2TxtBox = new TextBox();
            name3TxtBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            positionTxtBox = new TextBox();
            salaryTxtBox = new TextBox();
            createBtn = new Button();
            deleteBtn = new Button();
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
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(349, 37);
            dateTimePicker1.MaxDate = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 27);
            dateTimePicker1.TabIndex = 12;
            dateTimePicker1.Value = new DateTime(2007, 12, 31, 0, 0, 0, 0);
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
            createBtn.Location = new Point(158, 275);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(80, 46);
            createBtn.TabIndex = 15;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(300, 275);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(80, 46);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(711, 450);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(salaryTxtBox);
            Controls.Add(positionTxtBox);
            Controls.Add(dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox positionTxtBox;
        private System.Windows.Forms.TextBox salaryTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}