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
            cityLbl = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            addressTxtBox = new TextBox();
            nameTxtBox = new TextBox();
            SPA = new CheckedListBox();
            Parking = new CheckedListBox();
            ratingUpDown = new NumericUpDown();
            createBtn = new Button();
            deleteBtn = new Button();
            cityTxtBox = new TextBox();
            updateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)ratingUpDown).BeginInit();
            SuspendLayout();
            // 
            // cityLbl
            // 
            cityLbl.AutoSize = true;
            cityLbl.Location = new Point(84, 62);
            cityLbl.Name = "cityLbl";
            cityLbl.Size = new Size(42, 25);
            cityLbl.TabIndex = 0;
            cityLbl.Text = "City";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 141);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 1;
            label1.Text = "Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 234);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(354, 62);
            label3.Name = "label3";
            label3.Size = new Size(63, 25);
            label3.TabIndex = 3;
            label3.Text = "Rating";
            // 
            // addressTxtBox
            // 
            addressTxtBox.Location = new Point(131, 139);
            addressTxtBox.Margin = new Padding(3, 4, 3, 4);
            addressTxtBox.Name = "addressTxtBox";
            addressTxtBox.Size = new Size(111, 31);
            addressTxtBox.TabIndex = 6;
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(130, 231);
            nameTxtBox.Margin = new Padding(3, 4, 3, 4);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(111, 31);
            nameTxtBox.TabIndex = 7;
            // 
            // SPA
            // 
            SPA.FormattingEnabled = true;
            SPA.Items.AddRange(new object[] { "SPA" });
            SPA.Location = new Point(359, 138);
            SPA.Margin = new Padding(3, 4, 3, 4);
            SPA.Name = "SPA";
            SPA.Size = new Size(133, 32);
            SPA.TabIndex = 8;
            SPA.Tag = "";
            // 
            // Parking
            // 
            Parking.FormattingEnabled = true;
            Parking.Items.AddRange(new object[] { "Parking" });
            Parking.Location = new Point(359, 230);
            Parking.Margin = new Padding(3, 4, 3, 4);
            Parking.Name = "Parking";
            Parking.Size = new Size(133, 32);
            Parking.TabIndex = 9;
            // 
            // ratingUpDown
            // 
            ratingUpDown.Location = new Point(423, 62);
            ratingUpDown.Margin = new Padding(3, 4, 3, 4);
            ratingUpDown.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            ratingUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            ratingUpDown.Name = "ratingUpDown";
            ratingUpDown.Size = new Size(69, 31);
            ratingUpDown.TabIndex = 10;
            ratingUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // createBtn
            // 
            createBtn.Location = new Point(158, 366);
            createBtn.Margin = new Padding(3, 4, 3, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(118, 65);
            createBtn.TabIndex = 11;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(472, 366);
            deleteBtn.Margin = new Padding(3, 4, 3, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(118, 65);
            deleteBtn.TabIndex = 12;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // cityTxtBox
            // 
            cityTxtBox.Location = new Point(132, 62);
            cityTxtBox.Margin = new Padding(3, 4, 3, 4);
            cityTxtBox.Name = "cityTxtBox";
            cityTxtBox.Size = new Size(111, 31);
            cityTxtBox.TabIndex = 13;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(317, 366);
            updateBtn.Margin = new Padding(3, 4, 3, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(118, 65);
            updateBtn.TabIndex = 14;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // HotelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 562);
            Controls.Add(updateBtn);
            Controls.Add(cityTxtBox);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(ratingUpDown);
            Controls.Add(Parking);
            Controls.Add(SPA);
            Controls.Add(nameTxtBox);
            Controls.Add(addressTxtBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cityLbl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HotelForm";
            Text = "HotelForm";
            Load += HotelForm_Load;
            ((System.ComponentModel.ISupportInitialize)ratingUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();

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
        private System.Windows.Forms.NumericUpDown ratingUpDown;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
        private TextBox cityTxtBox;
        private Button updateBtn;
    }
}