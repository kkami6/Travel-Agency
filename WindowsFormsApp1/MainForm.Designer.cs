namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.cityBtn = new System.Windows.Forms.Button();
            this.clientBtn = new System.Windows.Forms.Button();
            this.employeeBtn = new System.Windows.Forms.Button();
            this.excursionBtn = new System.Windows.Forms.Button();
            this.hotelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cityBtn
            // 
            this.cityBtn.Location = new System.Drawing.Point(61, 47);
            this.cityBtn.Name = "cityBtn";
            this.cityBtn.Size = new System.Drawing.Size(84, 32);
            this.cityBtn.TabIndex = 0;
            this.cityBtn.Text = "City";
            this.cityBtn.UseVisualStyleBackColor = true;
            this.cityBtn.Click += new System.EventHandler(this.cityBtn_Click);
            // 
            // clientBtn
            // 
            this.clientBtn.Location = new System.Drawing.Point(61, 102);
            this.clientBtn.Name = "clientBtn";
            this.clientBtn.Size = new System.Drawing.Size(84, 32);
            this.clientBtn.TabIndex = 6;
            this.clientBtn.Text = "Client";
            this.clientBtn.UseVisualStyleBackColor = true;
            this.clientBtn.Click += new System.EventHandler(this.clientBtn_Click);
            // 
            // employeeBtn
            // 
            this.employeeBtn.Location = new System.Drawing.Point(52, 159);
            this.employeeBtn.Name = "employeeBtn";
            this.employeeBtn.Size = new System.Drawing.Size(93, 32);
            this.employeeBtn.TabIndex = 7;
            this.employeeBtn.Text = "Employee";
            this.employeeBtn.UseVisualStyleBackColor = true;
            this.employeeBtn.Click += new System.EventHandler(this.employeeBtn_Click);
            // 
            // excursionBtn
            // 
            this.excursionBtn.Location = new System.Drawing.Point(52, 215);
            this.excursionBtn.Name = "excursionBtn";
            this.excursionBtn.Size = new System.Drawing.Size(93, 32);
            this.excursionBtn.TabIndex = 8;
            this.excursionBtn.Text = "Excursion";
            this.excursionBtn.UseVisualStyleBackColor = true;
            this.excursionBtn.Click += new System.EventHandler(this.excursionBtn_Click);
            // 
            // hotelBtn
            // 
            this.hotelBtn.Location = new System.Drawing.Point(61, 273);
            this.hotelBtn.Name = "hotelBtn";
            this.hotelBtn.Size = new System.Drawing.Size(84, 32);
            this.hotelBtn.TabIndex = 9;
            this.hotelBtn.Text = "Hotel";
            this.hotelBtn.UseVisualStyleBackColor = true;
            this.hotelBtn.Click += new System.EventHandler(this.hotelBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hotelBtn);
            this.Controls.Add(this.excursionBtn);
            this.Controls.Add(this.employeeBtn);
            this.Controls.Add(this.clientBtn);
            this.Controls.Add(this.cityBtn);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cityBtn;
        private System.Windows.Forms.Button clientBtn;
        private System.Windows.Forms.Button employeeBtn;
        private System.Windows.Forms.Button excursionBtn;
        private System.Windows.Forms.Button hotelBtn;
    }
}

