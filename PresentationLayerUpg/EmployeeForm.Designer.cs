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
            agePicker = new DateTimePicker();
            positionTxtBox = new TextBox();
            salaryTxtBox = new TextBox();
            createBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            SuspendLayout();
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(96, 50);
            nameLbl.Margin = new Padding(4, 0, 4, 0);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(59, 25);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(160, 46);
            nameTxtBox.Margin = new Padding(4);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(110, 31);
            nameTxtBox.TabIndex = 1;
            // 
            // name2Lbl
            // 
            name2Lbl.AutoSize = true;
            name2Lbl.Location = new Point(34, 120);
            name2Lbl.Margin = new Padding(4, 0, 4, 0);
            name2Lbl.Name = "name2Lbl";
            name2Lbl.Size = new Size(120, 25);
            name2Lbl.TabIndex = 2;
            name2Lbl.Text = "Second name";
            // 
            // name3Lbl
            // 
            name3Lbl.AutoSize = true;
            name3Lbl.Location = new Point(45, 182);
            name3Lbl.Margin = new Padding(4, 0, 4, 0);
            name3Lbl.Name = "name3Lbl";
            name3Lbl.Size = new Size(111, 25);
            name3Lbl.TabIndex = 3;
            name3Lbl.Text = "Family name";
            // 
            // ageLbl
            // 
            ageLbl.AutoSize = true;
            ageLbl.Location = new Point(322, 50);
            ageLbl.Margin = new Padding(4, 0, 4, 0);
            ageLbl.Name = "ageLbl";
            ageLbl.Size = new Size(113, 25);
            ageLbl.TabIndex = 4;
            ageLbl.Text = "Date of birth";
            // 
            // positionLbl
            // 
            positionLbl.AutoSize = true;
            positionLbl.Location = new Point(358, 116);
            positionLbl.Margin = new Padding(4, 0, 4, 0);
            positionLbl.Name = "positionLbl";
            positionLbl.Size = new Size(75, 25);
            positionLbl.TabIndex = 5;
            positionLbl.Text = "Position";
            // 
            // salaryLbl
            // 
            salaryLbl.AutoSize = true;
            salaryLbl.Location = new Point(371, 182);
            salaryLbl.Margin = new Padding(4, 0, 4, 0);
            salaryLbl.Name = "salaryLbl";
            salaryLbl.Size = new Size(59, 25);
            salaryLbl.TabIndex = 6;
            salaryLbl.Text = "Salary";
            // 
            // name2TxtBox
            // 
            name2TxtBox.Location = new Point(160, 112);
            name2TxtBox.Margin = new Padding(4);
            name2TxtBox.Name = "name2TxtBox";
            name2TxtBox.Size = new Size(110, 31);
            name2TxtBox.TabIndex = 7;
            // 
            // name3TxtBox
            // 
            name3TxtBox.Location = new Point(160, 179);
            name3TxtBox.Margin = new Padding(4);
            name3TxtBox.Name = "name3TxtBox";
            name3TxtBox.Size = new Size(110, 31);
            name3TxtBox.TabIndex = 8;
            // 
            // agePicker
            // 
            agePicker.Location = new Point(436, 46);
            agePicker.Margin = new Padding(4);
            agePicker.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            agePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            agePicker.Name = "agePicker";
            agePicker.Size = new Size(222, 31);
            agePicker.TabIndex = 12;
            agePicker.Value = new DateTime(2025, 5, 4, 0, 0, 0, 0);
            // 
            // positionTxtBox
            // 
            positionTxtBox.Location = new Point(436, 112);
            positionTxtBox.Margin = new Padding(4);
            positionTxtBox.Name = "positionTxtBox";
            positionTxtBox.Size = new Size(110, 31);
            positionTxtBox.TabIndex = 13;
            // 
            // salaryTxtBox
            // 
            salaryTxtBox.Location = new Point(436, 179);
            salaryTxtBox.Margin = new Padding(4);
            salaryTxtBox.Name = "salaryTxtBox";
            salaryTxtBox.Size = new Size(110, 31);
            salaryTxtBox.TabIndex = 14;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(187, 344);
            createBtn.Margin = new Padding(4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(100, 58);
            createBtn.TabIndex = 15;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(535, 344);
            deleteBtn.Margin = new Padding(4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(100, 58);
            deleteBtn.TabIndex = 16;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(358, 344);
            updateBtn.Margin = new Padding(4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(100, 58);
            updateBtn.TabIndex = 17;
            updateBtn.Text = "Upate";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
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
            Margin = new Padding(4);
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
        private System.Windows.Forms.DateTimePicker agePicker;
        private System.Windows.Forms.TextBox positionTxtBox;
        private System.Windows.Forms.TextBox salaryTxtBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private Button updateBtn;
    }
}