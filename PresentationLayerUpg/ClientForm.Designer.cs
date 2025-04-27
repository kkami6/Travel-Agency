namespace WindowsFormsApp1
{
    partial class ClientForm
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
            nameLabel = new Label();
            nameTxtBox = new TextBox();
            Label1 = new Label();
            Name3Label = new Label();
            name2TxtBox = new TextBox();
            name3TxtBox = new TextBox();
            ageLabel = new Label();
            statusLabel = new Label();
            createBtn = new Button();
            UpdateBtn = new Button();
            deleteBtn = new Button();
            agePicker = new DateTimePicker();
            statusCheck = new CheckBox();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(72, 49);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(64, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name ";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(140, 45);
            nameTxtBox.Margin = new Padding(3, 4, 3, 4);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(111, 31);
            nameTxtBox.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(13, 104);
            Label1.Name = "Label1";
            Label1.Size = new Size(123, 25);
            Label1.TabIndex = 2;
            Label1.Text = "Second Name";
            // 
            // Name3Label
            // 
            Name3Label.AutoSize = true;
            Name3Label.Location = new Point(24, 170);
            Name3Label.Name = "Name3Label";
            Name3Label.Size = new Size(114, 25);
            Name3Label.TabIndex = 3;
            Name3Label.Text = "Family Name";
            // 
            // name2TxtBox
            // 
            name2TxtBox.Location = new Point(140, 104);
            name2TxtBox.Margin = new Padding(3, 4, 3, 4);
            name2TxtBox.Name = "name2TxtBox";
            name2TxtBox.Size = new Size(111, 31);
            name2TxtBox.TabIndex = 4;
            // 
            // name3TxtBox
            // 
            name3TxtBox.Location = new Point(140, 166);
            name3TxtBox.Margin = new Padding(3, 4, 3, 4);
            name3TxtBox.Name = "name3TxtBox";
            name3TxtBox.Size = new Size(111, 31);
            name3TxtBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(308, 49);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(112, 25);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Date of Birth";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(351, 104);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(64, 25);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(168, 311);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(83, 40);
            createBtn.TabIndex = 9;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(328, 311);
            UpdateBtn.Margin = new Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(90, 40);
            UpdateBtn.TabIndex = 10;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(489, 311);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(90, 40);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // agePicker
            // 
            agePicker.Location = new Point(426, 44);
            agePicker.Margin = new Padding(3, 4, 3, 4);
            agePicker.MaxDate = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            agePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            agePicker.Name = "agePicker";
            agePicker.Size = new Size(222, 31);
            agePicker.TabIndex = 12;
            agePicker.Value = new DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // statusCheck
            // 
            statusCheck.AutoSize = true;
            statusCheck.Location = new Point(424, 102);
            statusCheck.Margin = new Padding(3, 4, 3, 4);
            statusCheck.Name = "statusCheck";
            statusCheck.Size = new Size(79, 29);
            statusCheck.TabIndex = 13;
            statusCheck.Text = "Loyal";
            statusCheck.UseVisualStyleBackColor = true;
            statusCheck.CheckedChanged += statusCheck_CheckedChanged;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 499);
            Controls.Add(statusCheck);
            Controls.Add(agePicker);
            Controls.Add(deleteBtn);
            Controls.Add(UpdateBtn);
            Controls.Add(createBtn);
            Controls.Add(statusLabel);
            Controls.Add(ageLabel);
            Controls.Add(name3TxtBox);
            Controls.Add(name2TxtBox);
            Controls.Add(Name3Label);
            Controls.Add(Label1);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLabel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ClientForm";
            Text = "Client Form";
            Load += ClientForm_Load;
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Name3Label;
        private System.Windows.Forms.TextBox name2TxtBox;
        private System.Windows.Forms.TextBox name3TxtBox;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DateTimePicker agePicker;
        private System.Windows.Forms.CheckBox statusCheck;
    }
}