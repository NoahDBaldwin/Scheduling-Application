namespace SchedulingApplication
{
    partial class UpdateAppoinmentForm
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
            updateApptCancelButton = new Button();
            updateApptLabel = new Label();
            updateApptSaveButton = new Button();
            updateApptStartLabel = new Label();
            updateApptLengthLabel = new Label();
            updateApptTypeLabel = new Label();
            updateApptUserIDTextBox = new TextBox();
            updateApptUserIdLabel = new Label();
            updateApptCustIdLabel = new Label();
            updateApptCustIDComBox = new ComboBox();
            updateApptTypeComBox = new ComboBox();
            updateApptLengthComBox = new ComboBox();
            updateApptStart = new DateTimePicker();
            updateApptIDTextBox = new TextBox();
            updateApptIDLabel = new Label();
            SuspendLayout();
            // 
            // updateApptCancelButton
            // 
            updateApptCancelButton.Location = new Point(316, 445);
            updateApptCancelButton.Name = "updateApptCancelButton";
            updateApptCancelButton.Size = new Size(97, 45);
            updateApptCancelButton.TabIndex = 57;
            updateApptCancelButton.Text = "Cancel";
            updateApptCancelButton.UseVisualStyleBackColor = true;
            updateApptCancelButton.Click += updateApptCancelButton_Click;
            // 
            // updateApptLabel
            // 
            updateApptLabel.AutoSize = true;
            updateApptLabel.Font = new Font("Segoe UI", 14F);
            updateApptLabel.Location = new Point(12, 9);
            updateApptLabel.Name = "updateApptLabel";
            updateApptLabel.Size = new Size(91, 32);
            updateApptLabel.TabIndex = 42;
            updateApptLabel.Text = "Update";
            // 
            // updateApptSaveButton
            // 
            updateApptSaveButton.Location = new Point(187, 445);
            updateApptSaveButton.Name = "updateApptSaveButton";
            updateApptSaveButton.Size = new Size(97, 45);
            updateApptSaveButton.TabIndex = 55;
            updateApptSaveButton.Text = "Save";
            updateApptSaveButton.UseVisualStyleBackColor = true;
            updateApptSaveButton.Click += updateApptSaveButton_Click;
            // 
            // updateApptStartLabel
            // 
            updateApptStartLabel.AutoSize = true;
            updateApptStartLabel.Location = new Point(47, 351);
            updateApptStartLabel.Name = "updateApptStartLabel";
            updateApptStartLabel.Size = new Size(54, 25);
            updateApptStartLabel.TabIndex = 39;
            updateApptStartLabel.Text = "Start:";
            // 
            // updateApptLengthLabel
            // 
            updateApptLengthLabel.AutoSize = true;
            updateApptLengthLabel.Location = new Point(47, 287);
            updateApptLengthLabel.Name = "updateApptLengthLabel";
            updateApptLengthLabel.Size = new Size(119, 25);
            updateApptLengthLabel.TabIndex = 37;
            updateApptLengthLabel.Text = "Appt Length:";
            // 
            // updateApptTypeLabel
            // 
            updateApptTypeLabel.AutoSize = true;
            updateApptTypeLabel.Location = new Point(47, 226);
            updateApptTypeLabel.Name = "updateApptTypeLabel";
            updateApptTypeLabel.Size = new Size(100, 25);
            updateApptTypeLabel.TabIndex = 35;
            updateApptTypeLabel.Text = "Appt Type:";
            // 
            // updateApptUserIDTextBox
            // 
            updateApptUserIDTextBox.Location = new Point(213, 112);
            updateApptUserIDTextBox.Name = "updateApptUserIDTextBox";
            updateApptUserIDTextBox.ReadOnly = true;
            updateApptUserIDTextBox.Size = new Size(200, 32);
            updateApptUserIDTextBox.TabIndex = 34;
            updateApptUserIDTextBox.TabStop = false;
            // 
            // updateApptUserIdLabel
            // 
            updateApptUserIdLabel.AutoSize = true;
            updateApptUserIdLabel.Location = new Point(47, 115);
            updateApptUserIdLabel.Name = "updateApptUserIdLabel";
            updateApptUserIdLabel.Size = new Size(77, 25);
            updateApptUserIdLabel.TabIndex = 33;
            updateApptUserIdLabel.Text = "User ID:";
            // 
            // updateApptCustIdLabel
            // 
            updateApptCustIdLabel.AutoSize = true;
            updateApptCustIdLabel.Location = new Point(47, 168);
            updateApptCustIdLabel.Name = "updateApptCustIdLabel";
            updateApptCustIdLabel.Size = new Size(120, 25);
            updateApptCustIdLabel.TabIndex = 31;
            updateApptCustIdLabel.Text = "Customer ID:";
            // 
            // updateApptCustIDComBox
            // 
            updateApptCustIDComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            updateApptCustIDComBox.FormattingEnabled = true;
            updateApptCustIDComBox.Location = new Point(213, 165);
            updateApptCustIDComBox.Name = "updateApptCustIDComBox";
            updateApptCustIDComBox.Size = new Size(200, 33);
            updateApptCustIDComBox.TabIndex = 47;
            // 
            // updateApptTypeComBox
            // 
            updateApptTypeComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            updateApptTypeComBox.FormattingEnabled = true;
            updateApptTypeComBox.Items.AddRange(new object[] { "Consultation", "Meeting", "Review" });
            updateApptTypeComBox.Location = new Point(213, 223);
            updateApptTypeComBox.Name = "updateApptTypeComBox";
            updateApptTypeComBox.Size = new Size(200, 33);
            updateApptTypeComBox.TabIndex = 49;
            // 
            // updateApptLengthComBox
            // 
            updateApptLengthComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            updateApptLengthComBox.FormattingEnabled = true;
            updateApptLengthComBox.Items.AddRange(new object[] { "30 Minutes", "1 Hour", "1.5 Hours" });
            updateApptLengthComBox.Location = new Point(213, 284);
            updateApptLengthComBox.Name = "updateApptLengthComBox";
            updateApptLengthComBox.Size = new Size(200, 33);
            updateApptLengthComBox.TabIndex = 51;
            // 
            // updateApptStart
            // 
            updateApptStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            updateApptStart.Format = DateTimePickerFormat.Custom;
            updateApptStart.Location = new Point(171, 345);
            updateApptStart.Name = "updateApptStart";
            updateApptStart.Size = new Size(242, 32);
            updateApptStart.TabIndex = 53;
            updateApptStart.Value = new DateTime(2024, 8, 30, 0, 0, 0, 0);
            // 
            // updateApptIDTextBox
            // 
            updateApptIDTextBox.Location = new Point(213, 58);
            updateApptIDTextBox.Name = "updateApptIDTextBox";
            updateApptIDTextBox.ReadOnly = true;
            updateApptIDTextBox.Size = new Size(200, 32);
            updateApptIDTextBox.TabIndex = 50;
            updateApptIDTextBox.TabStop = false;
            // 
            // updateApptIDLabel
            // 
            updateApptIDLabel.AutoSize = true;
            updateApptIDLabel.Location = new Point(47, 61);
            updateApptIDLabel.Name = "updateApptIDLabel";
            updateApptIDLabel.Size = new Size(79, 25);
            updateApptIDLabel.TabIndex = 49;
            updateApptIDLabel.Text = "Appt ID:";
            // 
            // UpdateAppoinmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 525);
            Controls.Add(updateApptIDTextBox);
            Controls.Add(updateApptIDLabel);
            Controls.Add(updateApptStart);
            Controls.Add(updateApptCustIDComBox);
            Controls.Add(updateApptTypeComBox);
            Controls.Add(updateApptLengthComBox);
            Controls.Add(updateApptCancelButton);
            Controls.Add(updateApptLabel);
            Controls.Add(updateApptSaveButton);
            Controls.Add(updateApptStartLabel);
            Controls.Add(updateApptLengthLabel);
            Controls.Add(updateApptTypeLabel);
            Controls.Add(updateApptUserIDTextBox);
            Controls.Add(updateApptUserIdLabel);
            Controls.Add(updateApptCustIdLabel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "UpdateAppoinmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update Appoinment";
            Load += UpdateAppoinmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button updateApptCancelButton;
        private Label updateApptLabel;
        private Button updateApptSaveButton;
        private Label updateApptStartLabel;
        private Label updateApptLengthLabel;
        private Label updateApptTypeLabel;
        private TextBox updateApptUserIDTextBox;
        private Label updateApptUserIdLabel;
        private Label updateApptCustIdLabel;
        private ComboBox updateApptCustIDComBox;
        private ComboBox updateApptTypeComBox;
        private ComboBox updateApptLengthComBox;
        private DateTimePicker updateApptStart;
        private TextBox updateApptIDTextBox;
        private Label updateApptIDLabel;
    }
}