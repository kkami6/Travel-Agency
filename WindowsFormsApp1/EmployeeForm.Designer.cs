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
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.name2Lbl = new System.Windows.Forms.Label();
            this.name3Lbl = new System.Windows.Forms.Label();
            this.ageLbl = new System.Windows.Forms.Label();
            this.positionLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.name2TxtBox = new System.Windows.Forms.TextBox();
            this.name3TxtBox = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.positionTxtBox = new System.Windows.Forms.TextBox();
            this.salaryTxtBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(87, 40);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(51, 20);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "Name";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(144, 37);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 26);
            this.nameTxtBox.TabIndex = 1;
            // 
            // name2Lbl
            // 
            this.name2Lbl.AutoSize = true;
            this.name2Lbl.Location = new System.Drawing.Point(30, 96);
            this.name2Lbl.Name = "name2Lbl";
            this.name2Lbl.Size = new System.Drawing.Size(108, 20);
            this.name2Lbl.TabIndex = 2;
            this.name2Lbl.Text = "Second name";
            // 
            // name3Lbl
            // 
            this.name3Lbl.AutoSize = true;
            this.name3Lbl.Location = new System.Drawing.Point(40, 146);
            this.name3Lbl.Name = "name3Lbl";
            this.name3Lbl.Size = new System.Drawing.Size(98, 20);
            this.name3Lbl.TabIndex = 3;
            this.name3Lbl.Text = "Family name";
            // 
            // ageLbl
            // 
            this.ageLbl.AutoSize = true;
            this.ageLbl.Location = new System.Drawing.Point(290, 40);
            this.ageLbl.Name = "ageLbl";
            this.ageLbl.Size = new System.Drawing.Size(97, 20);
            this.ageLbl.TabIndex = 4;
            this.ageLbl.Text = "Date of birth";
            // 
            // positionLbl
            // 
            this.positionLbl.AutoSize = true;
            this.positionLbl.Location = new System.Drawing.Point(322, 93);
            this.positionLbl.Name = "positionLbl";
            this.positionLbl.Size = new System.Drawing.Size(65, 20);
            this.positionLbl.TabIndex = 5;
            this.positionLbl.Text = "Position";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Location = new System.Drawing.Point(334, 146);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(53, 20);
            this.salaryLbl.TabIndex = 6;
            this.salaryLbl.Text = "Salary";
            // 
            // name2TxtBox
            // 
            this.name2TxtBox.Location = new System.Drawing.Point(144, 90);
            this.name2TxtBox.Name = "name2TxtBox";
            this.name2TxtBox.Size = new System.Drawing.Size(100, 26);
            this.name2TxtBox.TabIndex = 7;
            // 
            // name3TxtBox
            // 
            this.name3TxtBox.Location = new System.Drawing.Point(144, 143);
            this.name3TxtBox.Name = "name3TxtBox";
            this.name3TxtBox.Size = new System.Drawing.Size(100, 26);
            this.name3TxtBox.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(393, 37);
            this.dateTimePicker1.MaxDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.Value = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // positionTxtBox
            // 
            this.positionTxtBox.Location = new System.Drawing.Point(393, 90);
            this.positionTxtBox.Name = "positionTxtBox";
            this.positionTxtBox.Size = new System.Drawing.Size(100, 26);
            this.positionTxtBox.TabIndex = 13;
            // 
            // salaryTxtBox
            // 
            this.salaryTxtBox.Location = new System.Drawing.Point(393, 143);
            this.salaryTxtBox.Name = "salaryTxtBox";
            this.salaryTxtBox.Size = new System.Drawing.Size(100, 26);
            this.salaryTxtBox.TabIndex = 14;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(178, 275);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(90, 46);
            this.createBtn.TabIndex = 15;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(338, 275);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 46);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.salaryTxtBox);
            this.Controls.Add(this.positionTxtBox);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.name3TxtBox);
            this.Controls.Add(this.name2TxtBox);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.positionLbl);
            this.Controls.Add(this.ageLbl);
            this.Controls.Add(this.name3Lbl);
            this.Controls.Add(this.name2Lbl);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLbl);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

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