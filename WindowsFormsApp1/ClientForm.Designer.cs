namespace WindowsFormsApp1
{
    partial class Client
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.Name3Label = new System.Windows.Forms.Label();
            this.name2TxtBox = new System.Windows.Forms.TextBox();
            this.name3TxtBox = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.agePicker = new System.Windows.Forms.DateTimePicker();
            this.statusCheck = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(65, 39);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(55, 20);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name ";
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(126, 36);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 26);
            this.nameTxtBox.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(12, 83);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(110, 20);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Second Name";
            // 
            // Name3Label
            // 
            this.Name3Label.AutoSize = true;
            this.Name3Label.Location = new System.Drawing.Point(22, 136);
            this.Name3Label.Name = "Name3Label";
            this.Name3Label.Size = new System.Drawing.Size(100, 20);
            this.Name3Label.TabIndex = 3;
            this.Name3Label.Text = "Family Name";
            // 
            // name2TxtBox
            // 
            this.name2TxtBox.Location = new System.Drawing.Point(126, 83);
            this.name2TxtBox.Name = "name2TxtBox";
            this.name2TxtBox.Size = new System.Drawing.Size(100, 26);
            this.name2TxtBox.TabIndex = 4;
            // 
            // name3TxtBox
            // 
            this.name3TxtBox.Location = new System.Drawing.Point(126, 133);
            this.name3TxtBox.Name = "name3TxtBox";
            this.name3TxtBox.Size = new System.Drawing.Size(100, 26);
            this.name3TxtBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(277, 39);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(99, 20);
            this.ageLabel.TabIndex = 6;
            this.ageLabel.Text = "Date of Birth";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(316, 83);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 20);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status:";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(151, 249);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(75, 32);
            this.createBtn.TabIndex = 9;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(295, 249);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(81, 32);
            this.UpdateBtn.TabIndex = 10;
            this.UpdateBtn.Text = "Update";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(440, 249);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(81, 32);
            this.deleteBtn.TabIndex = 11;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // agePicker
            // 
            this.agePicker.Location = new System.Drawing.Point(383, 35);
            this.agePicker.MaxDate = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            this.agePicker.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.agePicker.Name = "agePicker";
            this.agePicker.Size = new System.Drawing.Size(200, 26);
            this.agePicker.TabIndex = 12;
            this.agePicker.Value = new System.DateTime(2007, 12, 31, 0, 0, 0, 0);
            // 
            // statusCheck
            // 
            this.statusCheck.AutoSize = true;
            this.statusCheck.Location = new System.Drawing.Point(382, 82);
            this.statusCheck.Name = "statusCheck";
            this.statusCheck.Size = new System.Drawing.Size(72, 24);
            this.statusCheck.TabIndex = 13;
            this.statusCheck.Text = "Loyal";
            this.statusCheck.UseVisualStyleBackColor = true;
            this.statusCheck.CheckedChanged += new System.EventHandler(this.statusCheck_CheckedChanged);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 399);
            this.Controls.Add(this.statusCheck);
            this.Controls.Add(this.agePicker);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.name3TxtBox);
            this.Controls.Add(this.name2TxtBox);
            this.Controls.Add(this.Name3Label);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "Client";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

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