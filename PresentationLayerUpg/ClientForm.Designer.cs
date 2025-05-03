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
            clientIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            secondNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            familyNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ageDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientBindingSource = new BindingSource(components);
            clientsContextTestsBindingSource = new BindingSource(components);
            updateBtn = new Button();
            excursionsBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)clientDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clientsContextTestsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)excursionsBindingSource).BeginInit();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(58, 39);
            nameLabel.Margin = new Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(53, 20);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Name ";
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(112, 36);
            nameTxtBox.Margin = new Padding(2, 3, 2, 3);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(90, 27);
            nameTxtBox.TabIndex = 1;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(10, 83);
            Label1.Margin = new Padding(2, 0, 2, 0);
            Label1.Name = "Label1";
            Label1.Size = new Size(102, 20);
            Label1.TabIndex = 2;
            Label1.Text = "Second Name";
            // 
            // Name3Label
            // 
            Name3Label.AutoSize = true;
            Name3Label.Location = new Point(19, 136);
            Name3Label.Margin = new Padding(2, 0, 2, 0);
            Name3Label.Name = "Name3Label";
            Name3Label.Size = new Size(95, 20);
            Name3Label.TabIndex = 3;
            Name3Label.Text = "Family Name";
            // 
            // name2TxtBox
            // 
            name2TxtBox.Location = new Point(112, 83);
            name2TxtBox.Margin = new Padding(2, 3, 2, 3);
            name2TxtBox.Name = "name2TxtBox";
            name2TxtBox.Size = new Size(90, 27);
            name2TxtBox.TabIndex = 4;
            // 
            // name3TxtBox
            // 
            name3TxtBox.Location = new Point(112, 133);
            name3TxtBox.Margin = new Padding(2, 3, 2, 3);
            name3TxtBox.Name = "name3TxtBox";
            name3TxtBox.Size = new Size(90, 27);
            name3TxtBox.TabIndex = 5;
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(246, 39);
            ageLabel.Margin = new Padding(2, 0, 2, 0);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(94, 20);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Date of Birth";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(281, 83);
            statusLabel.Margin = new Padding(2, 0, 2, 0);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(52, 20);
            statusLabel.TabIndex = 7;
            statusLabel.Text = "Status:";
            // 
            // createBtn
            // 
            createBtn.Location = new Point(112, 217);
            createBtn.Margin = new Padding(2, 3, 2, 3);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(66, 32);
            createBtn.TabIndex = 9;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(387, 217);
            deleteBtn.Margin = new Padding(2, 3, 2, 3);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(72, 32);
            deleteBtn.TabIndex = 11;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // agePicker
            // 
            agePicker.Location = new Point(341, 35);
            agePicker.Margin = new Padding(2, 3, 2, 3);
            agePicker.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            agePicker.MinDate = new DateTime(1950, 1, 1, 0, 0, 0, 0);
            agePicker.Name = "agePicker";
            agePicker.Size = new Size(178, 27);
            agePicker.TabIndex = 12;
            agePicker.Value = new DateTime(2025, 5, 3, 0, 0, 0, 0);
            // 
            // statusCheck
            // 
            statusCheck.AutoSize = true;
            statusCheck.Location = new Point(339, 82);
            statusCheck.Margin = new Padding(2, 3, 2, 3);
            statusCheck.Name = "statusCheck";
            statusCheck.Size = new Size(66, 24);
            statusCheck.TabIndex = 13;
            statusCheck.Text = "Loyal";
            statusCheck.UseVisualStyleBackColor = true;
            // 
            // clientDataGridView
            // 
            clientDataGridView.AutoGenerateColumns = false;
            clientDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            clientDataGridView.Columns.AddRange(new DataGridViewColumn[] { clientIdDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, secondNameDataGridViewTextBoxColumn, familyNameDataGridViewTextBoxColumn, ageDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn });
            clientDataGridView.DataSource = clientBindingSource;
            clientDataGridView.Location = new Point(14, 295);
            clientDataGridView.Margin = new Padding(2);
            clientDataGridView.Name = "clientDataGridView";
            clientDataGridView.RowHeadersWidth = 62;
            clientDataGridView.Size = new Size(650, 148);
            clientDataGridView.TabIndex = 14;
            clientDataGridView.CellContentClick += clientDataGridView_CellContentClick;
            // 
            // clientIdDataGridViewTextBoxColumn
            // 
            clientIdDataGridViewTextBoxColumn.DataPropertyName = "ClientId";
            clientIdDataGridViewTextBoxColumn.HeaderText = "ClientId";
            clientIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            clientIdDataGridViewTextBoxColumn.Name = "clientIdDataGridViewTextBoxColumn";
            clientIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            secondNameDataGridViewTextBoxColumn.HeaderText = "SecondName";
            secondNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            secondNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // familyNameDataGridViewTextBoxColumn
            // 
            familyNameDataGridViewTextBoxColumn.DataPropertyName = "FamilyName";
            familyNameDataGridViewTextBoxColumn.HeaderText = "FamilyName";
            familyNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            familyNameDataGridViewTextBoxColumn.Name = "familyNameDataGridViewTextBoxColumn";
            familyNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            ageDataGridViewTextBoxColumn.HeaderText = "Age";
            ageDataGridViewTextBoxColumn.MinimumWidth = 6;
            ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            ageDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 125;
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
            updateBtn.Location = new Point(246, 217);
            updateBtn.Margin = new Padding(2, 3, 2, 3);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(72, 32);
            updateBtn.TabIndex = 15;
            updateBtn.Text = "Update";
            updateBtn.UseVisualStyleBackColor = true;
            updateBtn.Click += updateBtn_Click;
            // 
            // excursionsBindingSource
            // 
            excursionsBindingSource.DataMember = "Excursions";
            excursionsBindingSource.DataSource = clientBindingSource;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(583, 140);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 16;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // ClientForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(740, 477);
            Controls.Add(dateTimePicker1);
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
            Margin = new Padding(2, 3, 2, 3);
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
        private BindingSource clientBindingSource;
        private BindingSource clientsContextTestsBindingSource;
        private Button updateBtn;
        private DataGridViewTextBoxColumn clientIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn familyNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private BindingSource excursionsBindingSource;
        private DateTimePicker dateTimePicker1;
    }
}