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
            components = new System.ComponentModel.Container();
            nameLabel = new Label();
            nameTxtBox = new TextBox();
            Label1 = new Label();
            Name3Label = new Label();
            name2TxtBox = new TextBox();
            name3TxtBox = new TextBox();
            ageLabel = new Label();
            statusLabel = new Label();
            createBtn = new Button();
            deleteBtn = new Button();
            agePicker = new DateTimePicker();
            statusCheck = new CheckBox();
            clientDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secondNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            familyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            clientsContextTestsBindingSource = new BindingSource(components);
            updateBtn = new Button();
            excursionsBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsContextTestsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)excursionsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(72, 49);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(64, 25);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name ";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(140, 45);
            nameTxtBox.Margin = new Padding(2, 4, 2, 4);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(112, 31);
            nameTxtBox.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(12, 104);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(123, 25);
            Label1.TabIndex = 2;
            Label1.Text = "Second Name";
            // 
            // Name3Label
            // 
            Name3Label.AutoSize = true;
            Name3Label.Location = new Point(24, 170);
            Name3Label.Margin = new Padding(2, 0, 2, 0);
            Name3Label.Name = "Name3Label";
            Name3Label.Size = new Size(114, 25);
            Name3Label.TabIndex = 3;
            Name3Label.Text = "Family Name";
            // 
            // name2TxtBox
            // 
            name2TxtBox.Location = new Point(140, 104);
            name2TxtBox.Margin = new Padding(2, 4, 2, 4);
            name2TxtBox.Name = "name2TxtBox";
            name2TxtBox.Size = new Size(112, 31);
            name2TxtBox.TabIndex = 4;
            // 
            // name3TxtBox
            // 
            name3TxtBox.Location = new Point(140, 166);
            name3TxtBox.Margin = new Padding(2, 4, 2, 4);
            name3TxtBox.Name = "name3TxtBox";
            name3TxtBox.Size = new Size(112, 31);
            name3TxtBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(308, 49);
            ageLabel.Margin = new Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(112, 25);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Date of Birth";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(351, 104);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(64, 25);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(140, 271);
            createBtn.Margin = new Padding(2, 4, 2, 4);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(82, 40);
            createBtn.TabIndex = 9;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(484, 271);
            deleteBtn.Margin = new Padding(2, 4, 2, 4);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(90, 40);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // agePicker
            // 
            agePicker.Location = new Point(426, 44);
            agePicker.Margin = new Padding(2, 4, 2, 4);
            agePicker.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            agePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            agePicker.Name = "agePicker";
            agePicker.Size = new Size(222, 31);
            agePicker.TabIndex = 12;
            agePicker.Value = new DateTime(2025, 5, 3, 0, 0, 0, 0);
            // 
            // statusCheck
            // 
            statusCheck.AutoSize = true;
            statusCheck.Location = new Point(424, 102);
            statusCheck.Margin = new Padding(2, 4, 2, 4);
            statusCheck.Name = "statusCheck";
            statusCheck.Size = new Size(79, 29);
            statusCheck.TabIndex = 13;
            statusCheck.Text = "Loyal";
            statusCheck.UseVisualStyleBackColor = true;
            // 
            // clientDataGridView
            // 
            clientDataGridView.AutoGenerateColumns = false;
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, secondNameDataGridViewTextBoxColumn, familyNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            clientDataGridView.DataSource = clientBindingSource;
            clientDataGridView.Location = new Point(72, 347);
            clientDataGridView.Margin = new Padding(2);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.RowHeadersWidth = 62;
            clientDataGridView.Size = new Size(823, 185);
            clientDataGridView.TabIndex = 14;
            clientDataGridView.CellContentClick += clientDataGridView_CellContentClick;
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
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // clientBindingSource
            // 
            clientBindingSource.AllowNew = true;
            clientBindingSource.DataSource = typeof(BusinessLayer.Client);
            // 
            // clientsContextTestsBindingSource
            // 
            clientsContextTestsBindingSource.DataSource = typeof(TestingLayer.ClientsContextTests);
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(308, 271);
            updateBtn.Margin = new Padding(2, 4, 2, 4);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(90, 40);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // excursionsBindingSource
            // 
            excursionsBindingSource.DataMember = "Excursions";
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 596);
            Controls.Add(updateBtn);
            Controls.Add(clientDataGridView);
            Controls.Add(statusCheck);
            Controls.Add(agePicker);
            Controls.Add(deleteBtn);
            Controls.Add(createBtn);
            Controls.Add(statusLabel);
            Controls.Add(ageLabel);
            Controls.Add(name3TxtBox);
            Controls.Add(name2TxtBox);
            Controls.Add(Name3Label);
            Controls.Add(Label1);
            Controls.Add(nameTxtBox);
            Controls.Add(nameLabel);
            Margin = new Padding(2, 4, 2, 4);
            Name = "ClientForm";
            Text = "Client Form";
            Load += ClientForm_Load;
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)clientsContextTestsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)excursionsBindingSource).EndInit();
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
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DateTimePicker agePicker;
        private System.Windows.Forms.CheckBox statusCheck;
        private DataGridView clientDataGridView;
        private BindingSource clientsContextTestsBindingSource;
        private Button updateBtn;
        private BindingSource excursionsBindingSource;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn familyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource clientBindingSource;
    }
}