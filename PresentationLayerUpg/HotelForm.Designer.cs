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
            this.cityLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTxtBox = new System.Windows.Forms.TextBox();
            this.nameTxtBox = new System.Windows.Forms.TextBox();
            this.SPA = new System.Windows.Forms.CheckedListBox();
            this.Parking = new System.Windows.Forms.CheckedListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(76, 50);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(35, 20);
            this.cityLbl.TabIndex = 0;
            this.cityLbl.Text = "City";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rating";
            // 
            // addressTxtBox
            // 
            this.addressTxtBox.Location = new System.Drawing.Point(118, 111);
            this.addressTxtBox.Name = "addressTxtBox";
            this.addressTxtBox.Size = new System.Drawing.Size(100, 26);
            this.addressTxtBox.TabIndex = 6;
            // 
            // nameTxtBox
            // 
            this.nameTxtBox.Location = new System.Drawing.Point(117, 185);
            this.nameTxtBox.Name = "nameTxtBox";
            this.nameTxtBox.Size = new System.Drawing.Size(100, 26);
            this.nameTxtBox.TabIndex = 7;
            // 
            // SPA
            // 
            this.SPA.FormattingEnabled = true;
            this.SPA.Items.AddRange(new object[] {
            "SPA"});
            this.SPA.Location = new System.Drawing.Point(323, 110);
            this.SPA.Name = "SPA";
            this.SPA.Size = new System.Drawing.Size(120, 27);
            this.SPA.TabIndex = 8;
            this.SPA.Tag = "";
            // 
            // Parking
            // 
            this.Parking.FormattingEnabled = true;
            this.Parking.Items.AddRange(new object[] {
            "Parking"});
            this.Parking.Location = new System.Drawing.Point(323, 184);
            this.Parking.Name = "Parking";
            this.Parking.Size = new System.Drawing.Size(120, 27);
            this.Parking.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(381, 50);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(62, 26);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(142, 293);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(106, 52);
            this.createBtn.TabIndex = 11;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(302, 293);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(106, 52);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // HotelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Parking);
            this.Controls.Add(this.SPA);
            this.Controls.Add(this.nameTxtBox);
            this.Controls.Add(this.addressTxtBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cityLbl);
            this.Name = "HotelForm";
            this.Text = "HotelForm";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTxtBox;
        private System.Windows.Forms.TextBox nameTxtBox;
        private System.Windows.Forms.CheckedListBox SPA;
        private System.Windows.Forms.CheckedListBox Parking;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}