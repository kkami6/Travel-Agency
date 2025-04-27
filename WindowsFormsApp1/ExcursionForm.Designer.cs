namespace WindowsFormsApp1
{
    partial class ExcursionForm
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
            this.hotelLbl = new System.Windows.Forms.Label();
            this.priceLbl = new System.Windows.Forms.Label();
            this.departureLbl = new System.Windows.Forms.Label();
            this.returnDateLbl = new System.Windows.Forms.Label();
            this.createBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(78, 61);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(35, 20);
            this.cityLbl.TabIndex = 0;
            this.cityLbl.Text = "City";
            // 
            // hotelLbl
            // 
            this.hotelLbl.AutoSize = true;
            this.hotelLbl.Location = new System.Drawing.Point(66, 120);
            this.hotelLbl.Name = "hotelLbl";
            this.hotelLbl.Size = new System.Drawing.Size(47, 20);
            this.hotelLbl.TabIndex = 1;
            this.hotelLbl.Text = "Hotel";
            // 
            // priceLbl
            // 
            this.priceLbl.AutoSize = true;
            this.priceLbl.Location = new System.Drawing.Point(69, 177);
            this.priceLbl.Name = "priceLbl";
            this.priceLbl.Size = new System.Drawing.Size(44, 20);
            this.priceLbl.TabIndex = 2;
            this.priceLbl.Text = "Price";
            // 
            // departureLbl
            // 
            this.departureLbl.AutoSize = true;
            this.departureLbl.Location = new System.Drawing.Point(339, 61);
            this.departureLbl.Name = "departureLbl";
            this.departureLbl.Size = new System.Drawing.Size(117, 20);
            this.departureLbl.TabIndex = 3;
            this.departureLbl.Text = "Departure date";
            // 
            // returnDateLbl
            // 
            this.returnDateLbl.AutoSize = true;
            this.returnDateLbl.Location = new System.Drawing.Point(362, 120);
            this.returnDateLbl.Name = "returnDateLbl";
            this.returnDateLbl.Size = new System.Drawing.Size(94, 20);
            this.returnDateLbl.TabIndex = 4;
            this.returnDateLbl.Text = "Return date";
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(198, 289);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(107, 45);
            this.createBtn.TabIndex = 5;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(349, 289);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(107, 45);
            this.deleteBtn.TabIndex = 6;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // ExcursionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.returnDateLbl);
            this.Controls.Add(this.departureLbl);
            this.Controls.Add(this.priceLbl);
            this.Controls.Add(this.hotelLbl);
            this.Controls.Add(this.cityLbl);
            this.Name = "ExcursionForm";
            this.Text = "ExcursionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.Label hotelLbl;
        private System.Windows.Forms.Label priceLbl;
        private System.Windows.Forms.Label departureLbl;
        private System.Windows.Forms.Label returnDateLbl;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button deleteBtn;
    }
}