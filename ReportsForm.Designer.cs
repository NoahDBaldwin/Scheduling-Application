namespace SchedulingApplication
{
    partial class ReportsForm
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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            reportsLabel = new Label();
            reportsCloseButton = new Button();
            numApptTypeLabel = new Label();
            eachUserLabel = new Label();
            userScheduleDGV = new DataGridView();
            monthComBox = new ComboBox();
            apptTypeComBox = new ComboBox();
            monthLabel = new Label();
            typeComBox = new Label();
            userComBox = new ComboBox();
            userLabel = new Label();
            numApptsLabel = new Label();
            numApptsTextBox = new TextBox();
            numApptsSubmit = new Button();
            countrySubmit = new Button();
            numCustTextBox = new TextBox();
            numCustLabel = new Label();
            countryLabel = new Label();
            countryComBox = new ComboBox();
            custCountryLabel = new Label();
            userSubmit = new Button();
            ((System.ComponentModel.ISupportInitialize)userScheduleDGV).BeginInit();
            SuspendLayout();
            // 
            // reportsLabel
            // 
            reportsLabel.AutoSize = true;
            reportsLabel.Font = new Font("Segoe UI", 14F);
            reportsLabel.Location = new Point(12, 9);
            reportsLabel.Name = "reportsLabel";
            reportsLabel.Size = new Size(94, 32);
            reportsLabel.TabIndex = 1;
            reportsLabel.Text = "Reports";
            // 
            // reportsCloseButton
            // 
            reportsCloseButton.Location = new Point(1027, 602);
            reportsCloseButton.Name = "reportsCloseButton";
            reportsCloseButton.Size = new Size(125, 42);
            reportsCloseButton.TabIndex = 35;
            reportsCloseButton.Text = "Close";
            reportsCloseButton.UseVisualStyleBackColor = true;
            reportsCloseButton.Click += reportsCloseButton_Click;
            // 
            // numApptTypeLabel
            // 
            numApptTypeLabel.AutoSize = true;
            numApptTypeLabel.Location = new Point(41, 72);
            numApptTypeLabel.Name = "numApptTypeLabel";
            numApptTypeLabel.Size = new Size(360, 25);
            numApptTypeLabel.TabIndex = 7;
            numApptTypeLabel.Text = "Number of Appointment Types By Month:";
            // 
            // eachUserLabel
            // 
            eachUserLabel.AutoSize = true;
            eachUserLabel.Location = new Point(461, 72);
            eachUserLabel.Name = "eachUserLabel";
            eachUserLabel.Size = new Size(136, 25);
            eachUserLabel.TabIndex = 9;
            eachUserLabel.Text = "User Schedule:";
            // 
            // userScheduleDGV
            // 
            userScheduleDGV.AllowUserToAddRows = false;
            userScheduleDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            userScheduleDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            userScheduleDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userScheduleDGV.Location = new Point(432, 120);
            userScheduleDGV.MultiSelect = false;
            userScheduleDGV.Name = "userScheduleDGV";
            userScheduleDGV.ReadOnly = true;
            userScheduleDGV.RowHeadersVisible = false;
            userScheduleDGV.RowHeadersWidth = 51;
            userScheduleDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            userScheduleDGV.Size = new Size(720, 425);
            userScheduleDGV.TabIndex = 10;
            // 
            // monthComBox
            // 
            monthComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            monthComBox.FormattingEnabled = true;
            monthComBox.Items.AddRange(new object[] { "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12" });
            monthComBox.Location = new Point(159, 110);
            monthComBox.Name = "monthComBox";
            monthComBox.Size = new Size(178, 33);
            monthComBox.TabIndex = 11;
            // 
            // apptTypeComBox
            // 
            apptTypeComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            apptTypeComBox.FormattingEnabled = true;
            apptTypeComBox.Items.AddRange(new object[] { "Consultation", "Meeting", "Review" });
            apptTypeComBox.Location = new Point(159, 163);
            apptTypeComBox.Name = "apptTypeComBox";
            apptTypeComBox.Size = new Size(178, 33);
            apptTypeComBox.TabIndex = 12;
            // 
            // monthLabel
            // 
            monthLabel.AutoSize = true;
            monthLabel.Location = new Point(44, 113);
            monthLabel.Name = "monthLabel";
            monthLabel.Size = new Size(72, 25);
            monthLabel.TabIndex = 13;
            monthLabel.Text = "Month:";
            // 
            // typeComBox
            // 
            typeComBox.AutoSize = true;
            typeComBox.Location = new Point(44, 166);
            typeComBox.Name = "typeComBox";
            typeComBox.Size = new Size(100, 25);
            typeComBox.TabIndex = 14;
            typeComBox.Text = "Appt Type:";
            // 
            // userComBox
            // 
            userComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userComBox.FormattingEnabled = true;
            userComBox.Location = new Point(827, 69);
            userComBox.Name = "userComBox";
            userComBox.Size = new Size(212, 33);
            userComBox.TabIndex = 30;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(719, 72);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(54, 25);
            userLabel.TabIndex = 16;
            userLabel.Text = "User:";
            // 
            // numApptsLabel
            // 
            numApptsLabel.AutoSize = true;
            numApptsLabel.Location = new Point(44, 291);
            numApptsLabel.Name = "numApptsLabel";
            numApptsLabel.Size = new Size(110, 25);
            numApptsLabel.TabIndex = 17;
            numApptsLabel.Text = "Num Appts:";
            // 
            // numApptsTextBox
            // 
            numApptsTextBox.Location = new Point(159, 288);
            numApptsTextBox.Name = "numApptsTextBox";
            numApptsTextBox.ReadOnly = true;
            numApptsTextBox.Size = new Size(178, 32);
            numApptsTextBox.TabIndex = 20;
            numApptsTextBox.TabStop = false;
            // 
            // numApptsSubmit
            // 
            numApptsSubmit.Location = new Point(177, 224);
            numApptsSubmit.Name = "numApptsSubmit";
            numApptsSubmit.Size = new Size(160, 41);
            numApptsSubmit.TabIndex = 19;
            numApptsSubmit.Text = "Submit";
            numApptsSubmit.UseVisualStyleBackColor = true;
            numApptsSubmit.Click += numApptsSubmit_Click;
            // 
            // countrySubmit
            // 
            countrySubmit.Location = new Point(174, 486);
            countrySubmit.Name = "countrySubmit";
            countrySubmit.Size = new Size(160, 41);
            countrySubmit.TabIndex = 27;
            countrySubmit.Text = "Submit";
            countrySubmit.UseVisualStyleBackColor = true;
            countrySubmit.Click += countrySubmit_Click;
            // 
            // numCustTextBox
            // 
            numCustTextBox.Location = new Point(157, 550);
            numCustTextBox.Name = "numCustTextBox";
            numCustTextBox.ReadOnly = true;
            numCustTextBox.Size = new Size(178, 32);
            numCustTextBox.TabIndex = 26;
            // 
            // numCustLabel
            // 
            numCustLabel.AutoSize = true;
            numCustLabel.Location = new Point(41, 553);
            numCustLabel.Name = "numCustLabel";
            numCustLabel.Size = new Size(105, 25);
            numCustLabel.TabIndex = 25;
            numCustLabel.Text = "Customers:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Location = new Point(41, 432);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(83, 25);
            countryLabel.TabIndex = 23;
            countryLabel.Text = "Country:";
            // 
            // countryComBox
            // 
            countryComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            countryComBox.FormattingEnabled = true;
            countryComBox.Location = new Point(156, 429);
            countryComBox.Name = "countryComBox";
            countryComBox.Size = new Size(178, 33);
            countryComBox.TabIndex = 21;
            // 
            // custCountryLabel
            // 
            custCountryLabel.AutoSize = true;
            custCountryLabel.Location = new Point(41, 384);
            custCountryLabel.Name = "custCountryLabel";
            custCountryLabel.Size = new Size(294, 25);
            custCountryLabel.TabIndex = 20;
            custCountryLabel.Text = "Number of Customers by Country";
            // 
            // userSubmit
            // 
            userSubmit.Location = new Point(1060, 69);
            userSubmit.Name = "userSubmit";
            userSubmit.Size = new Size(92, 33);
            userSubmit.TabIndex = 32;
            userSubmit.Text = "Submit";
            userSubmit.UseVisualStyleBackColor = true;
            userSubmit.Click += userSubmit_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1191, 656);
            Controls.Add(userSubmit);
            Controls.Add(countrySubmit);
            Controls.Add(numCustTextBox);
            Controls.Add(numCustLabel);
            Controls.Add(countryLabel);
            Controls.Add(countryComBox);
            Controls.Add(custCountryLabel);
            Controls.Add(numApptsSubmit);
            Controls.Add(numApptsTextBox);
            Controls.Add(numApptsLabel);
            Controls.Add(userLabel);
            Controls.Add(userComBox);
            Controls.Add(typeComBox);
            Controls.Add(monthLabel);
            Controls.Add(apptTypeComBox);
            Controls.Add(monthComBox);
            Controls.Add(userScheduleDGV);
            Controls.Add(eachUserLabel);
            Controls.Add(numApptTypeLabel);
            Controls.Add(reportsCloseButton);
            Controls.Add(reportsLabel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "ReportsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += ReportsForm_Load;
            ((System.ComponentModel.ISupportInitialize)userScheduleDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label reportsLabel;
        private Button reportsCloseButton;
        private Label numApptTypeLabel;
        private Label eachUserLabel;
        private ComboBox monthComBox;
        private ComboBox apptTypeComBox;
        private Label monthLabel;
        private Label typeComBox;
        private ComboBox userComBox;
        private Label userLabel;
        private Label numApptsLabel;
        private TextBox numApptsTextBox;
        private Button numApptsSubmit;
        private Button countrySubmit;
        private TextBox numCustTextBox;
        private Label numCustLabel;
        private Label countryLabel;
        private ComboBox countryComBox;
        private Label custCountryLabel;
        private Button userSubmit;
        public DataGridView userScheduleDGV;
    }
}