namespace SchedulingApplication
{
    partial class AppointmentsForm
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
            appointmentsCloseButton = new Button();
            appointmentsDeleteButton = new Button();
            appointmentsUpdateButton = new Button();
            appointmentsAddButton = new Button();
            appointmentsDGV = new DataGridView();
            appointmentsSearchTextBox = new TextBox();
            appointmentsSearchButton = new Button();
            appointmentsLabel = new Label();
            apptAllButton = new Button();
            apptThisWeekButton = new Button();
            apptThisMonthButton = new Button();
            ((System.ComponentModel.ISupportInitialize)appointmentsDGV).BeginInit();
            SuspendLayout();
            // 
            // appointmentsCloseButton
            // 
            appointmentsCloseButton.BackColor = SystemColors.ControlLight;
            appointmentsCloseButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            appointmentsCloseButton.Location = new Point(83, 479);
            appointmentsCloseButton.Name = "appointmentsCloseButton";
            appointmentsCloseButton.Size = new Size(119, 44);
            appointmentsCloseButton.TabIndex = 23;
            appointmentsCloseButton.Text = "Close";
            appointmentsCloseButton.UseVisualStyleBackColor = false;
            appointmentsCloseButton.Click += appointmentsCloseButton_Click;
            // 
            // appointmentsDeleteButton
            // 
            appointmentsDeleteButton.Location = new Point(901, 479);
            appointmentsDeleteButton.Name = "appointmentsDeleteButton";
            appointmentsDeleteButton.Size = new Size(119, 47);
            appointmentsDeleteButton.TabIndex = 22;
            appointmentsDeleteButton.Text = "Delete";
            appointmentsDeleteButton.UseVisualStyleBackColor = true;
            appointmentsDeleteButton.Click += appointmentsDeleteButton_Click;
            // 
            // appointmentsUpdateButton
            // 
            appointmentsUpdateButton.Location = new Point(727, 479);
            appointmentsUpdateButton.Name = "appointmentsUpdateButton";
            appointmentsUpdateButton.Size = new Size(119, 47);
            appointmentsUpdateButton.TabIndex = 21;
            appointmentsUpdateButton.Text = "Update";
            appointmentsUpdateButton.UseVisualStyleBackColor = true;
            appointmentsUpdateButton.Click += appointmentsUpdateButton_Click;
            // 
            // appointmentsAddButton
            // 
            appointmentsAddButton.Location = new Point(545, 479);
            appointmentsAddButton.Name = "appointmentsAddButton";
            appointmentsAddButton.Size = new Size(119, 47);
            appointmentsAddButton.TabIndex = 20;
            appointmentsAddButton.Text = "Add";
            appointmentsAddButton.UseVisualStyleBackColor = true;
            appointmentsAddButton.Click += appointmentsAddButton_Click;
            // 
            // appointmentsDGV
            // 
            appointmentsDGV.AllowUserToAddRows = false;
            appointmentsDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            appointmentsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            appointmentsDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            appointmentsDGV.Location = new Point(83, 123);
            appointmentsDGV.MultiSelect = false;
            appointmentsDGV.Name = "appointmentsDGV";
            appointmentsDGV.ReadOnly = true;
            appointmentsDGV.RowHeadersVisible = false;
            appointmentsDGV.RowHeadersWidth = 51;
            appointmentsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentsDGV.Size = new Size(937, 324);
            appointmentsDGV.TabIndex = 19;
            // 
            // appointmentsSearchTextBox
            // 
            appointmentsSearchTextBox.Location = new Point(773, 51);
            appointmentsSearchTextBox.Name = "appointmentsSearchTextBox";
            appointmentsSearchTextBox.Size = new Size(247, 32);
            appointmentsSearchTextBox.TabIndex = 10;
            // 
            // appointmentsSearchButton
            // 
            appointmentsSearchButton.Location = new Point(585, 47);
            appointmentsSearchButton.Name = "appointmentsSearchButton";
            appointmentsSearchButton.Size = new Size(149, 39);
            appointmentsSearchButton.TabIndex = 9;
            appointmentsSearchButton.Text = "Search";
            appointmentsSearchButton.UseVisualStyleBackColor = true;
            appointmentsSearchButton.Click += appointmentsSearchButton_Click;
            // 
            // appointmentsLabel
            // 
            appointmentsLabel.AutoSize = true;
            appointmentsLabel.Font = new Font("Segoe UI", 14F);
            appointmentsLabel.Location = new Point(12, 9);
            appointmentsLabel.Name = "appointmentsLabel";
            appointmentsLabel.Size = new Size(165, 32);
            appointmentsLabel.TabIndex = 8;
            appointmentsLabel.Text = "Appointments";
            // 
            // apptAllButton
            // 
            apptAllButton.Location = new Point(83, 74);
            apptAllButton.Name = "apptAllButton";
            apptAllButton.Size = new Size(116, 46);
            apptAllButton.TabIndex = 16;
            apptAllButton.Text = "All";
            apptAllButton.UseVisualStyleBackColor = true;
            apptAllButton.Click += apptAllButton_Click;
            // 
            // apptThisWeekButton
            // 
            apptThisWeekButton.Location = new Point(219, 74);
            apptThisWeekButton.Name = "apptThisWeekButton";
            apptThisWeekButton.Size = new Size(116, 46);
            apptThisWeekButton.TabIndex = 17;
            apptThisWeekButton.Text = "This Week";
            apptThisWeekButton.UseVisualStyleBackColor = true;
            apptThisWeekButton.Click += apptThisWeekButton_Click;
            // 
            // apptThisMonthButton
            // 
            apptThisMonthButton.Location = new Point(353, 74);
            apptThisMonthButton.Name = "apptThisMonthButton";
            apptThisMonthButton.Size = new Size(116, 46);
            apptThisMonthButton.TabIndex = 18;
            apptThisMonthButton.Text = "This Month";
            apptThisMonthButton.UseVisualStyleBackColor = true;
            apptThisMonthButton.Click += apptThisMonthButton_Click;
            // 
            // AppointmentsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1116, 562);
            Controls.Add(apptThisMonthButton);
            Controls.Add(apptThisWeekButton);
            Controls.Add(apptAllButton);
            Controls.Add(appointmentsCloseButton);
            Controls.Add(appointmentsDeleteButton);
            Controls.Add(appointmentsUpdateButton);
            Controls.Add(appointmentsAddButton);
            Controls.Add(appointmentsDGV);
            Controls.Add(appointmentsSearchTextBox);
            Controls.Add(appointmentsSearchButton);
            Controls.Add(appointmentsLabel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "AppointmentsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointments";
            Load += AppointmentsForm_Load;
            ((System.ComponentModel.ISupportInitialize)appointmentsDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button appointmentsCloseButton;
        private Button appointmentsDeleteButton;
        private Button appointmentsUpdateButton;
        private Button appointmentsAddButton;
        private TextBox appointmentsSearchTextBox;
        private Button appointmentsSearchButton;
        private Label appointmentsLabel;
        private Button apptAllButton;
        private Button apptThisWeekButton;
        private Button apptThisMonthButton;
        public DataGridView appointmentsDGV;
    }
}