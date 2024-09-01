namespace SchedulingApplication
{
    partial class AddAppointmentForm
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
            addApptCancelButton = new Button();
            addApptLabel = new Label();
            addApptSaveButton = new Button();
            addApptTypeLabel = new Label();
            addApptIdLabel = new Label();
            addApptLengthComBox = new ComboBox();
            addApptLengthLabel = new Label();
            addApptTypeComBox = new ComboBox();
            addApptStart = new DateTimePicker();
            addApptStartLabel = new Label();
            addApptUserIDTextBox = new TextBox();
            addApptUserIDLabel = new Label();
            addApptCustIDComBox = new ComboBox();
            SuspendLayout();
            // 
            // addApptCancelButton
            // 
            addApptCancelButton.Location = new Point(312, 398);
            addApptCancelButton.Name = "addApptCancelButton";
            addApptCancelButton.Size = new Size(97, 45);
            addApptCancelButton.TabIndex = 49;
            addApptCancelButton.Text = "Cancel";
            addApptCancelButton.UseVisualStyleBackColor = true;
            addApptCancelButton.Click += addApptCancelButton_Click;
            // 
            // addApptLabel
            // 
            addApptLabel.AutoSize = true;
            addApptLabel.Font = new Font("Segoe UI", 14F);
            addApptLabel.Location = new Point(12, 9);
            addApptLabel.Name = "addApptLabel";
            addApptLabel.Size = new Size(57, 32);
            addApptLabel.TabIndex = 29;
            addApptLabel.Text = "Add";
            // 
            // addApptSaveButton
            // 
            addApptSaveButton.Location = new Point(182, 398);
            addApptSaveButton.Name = "addApptSaveButton";
            addApptSaveButton.Size = new Size(97, 45);
            addApptSaveButton.TabIndex = 48;
            addApptSaveButton.Text = "Save";
            addApptSaveButton.UseVisualStyleBackColor = true;
            addApptSaveButton.Click += addApptSaveButton_Click;
            // 
            // addApptTypeLabel
            // 
            addApptTypeLabel.AutoSize = true;
            addApptTypeLabel.Location = new Point(53, 179);
            addApptTypeLabel.Name = "addApptTypeLabel";
            addApptTypeLabel.Size = new Size(100, 25);
            addApptTypeLabel.TabIndex = 20;
            addApptTypeLabel.Text = "Appt Type:";
            // 
            // addApptIdLabel
            // 
            addApptIdLabel.AutoSize = true;
            addApptIdLabel.Location = new Point(52, 118);
            addApptIdLabel.Name = "addApptIdLabel";
            addApptIdLabel.Size = new Size(120, 25);
            addApptIdLabel.TabIndex = 16;
            addApptIdLabel.Text = "Customer ID:";
            // 
            // addApptLengthComBox
            // 
            addApptLengthComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addApptLengthComBox.FormattingEnabled = true;
            addApptLengthComBox.Items.AddRange(new object[] { "30 Minutes", "1 Hour", "1.5 Hours" });
            addApptLengthComBox.Location = new Point(209, 236);
            addApptLengthComBox.Name = "addApptLengthComBox";
            addApptLengthComBox.Size = new Size(200, 33);
            addApptLengthComBox.TabIndex = 46;
            // 
            // addApptLengthLabel
            // 
            addApptLengthLabel.AutoSize = true;
            addApptLengthLabel.Location = new Point(53, 242);
            addApptLengthLabel.Name = "addApptLengthLabel";
            addApptLengthLabel.Size = new Size(119, 25);
            addApptLengthLabel.TabIndex = 37;
            addApptLengthLabel.Text = "Appt Length:";
            // 
            // addApptTypeComBox
            // 
            addApptTypeComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addApptTypeComBox.FormattingEnabled = true;
            addApptTypeComBox.Items.AddRange(new object[] { "Consultation", "Meeting", "Review" });
            addApptTypeComBox.Location = new Point(209, 176);
            addApptTypeComBox.Name = "addApptTypeComBox";
            addApptTypeComBox.Size = new Size(200, 33);
            addApptTypeComBox.TabIndex = 45;
            // 
            // addApptStart
            // 
            addApptStart.CustomFormat = "MM/dd/yyyy hh:mm tt";
            addApptStart.Format = DateTimePickerFormat.Custom;
            addApptStart.Location = new Point(167, 302);
            addApptStart.Name = "addApptStart";
            addApptStart.Size = new Size(242, 32);
            addApptStart.TabIndex = 47;
            addApptStart.Value = new DateTime(2024, 8, 30, 0, 0, 0, 0);
            // 
            // addApptStartLabel
            // 
            addApptStartLabel.AutoSize = true;
            addApptStartLabel.Location = new Point(53, 308);
            addApptStartLabel.Name = "addApptStartLabel";
            addApptStartLabel.Size = new Size(54, 25);
            addApptStartLabel.TabIndex = 41;
            addApptStartLabel.Text = "Start:";
            // 
            // addApptUserIDTextBox
            // 
            addApptUserIDTextBox.Location = new Point(209, 57);
            addApptUserIDTextBox.Name = "addApptUserIDTextBox";
            addApptUserIDTextBox.ReadOnly = true;
            addApptUserIDTextBox.Size = new Size(200, 32);
            addApptUserIDTextBox.TabIndex = 43;
            addApptUserIDTextBox.TabStop = false;
            // 
            // addApptUserIDLabel
            // 
            addApptUserIDLabel.AutoSize = true;
            addApptUserIDLabel.Location = new Point(51, 60);
            addApptUserIDLabel.Name = "addApptUserIDLabel";
            addApptUserIDLabel.Size = new Size(77, 25);
            addApptUserIDLabel.TabIndex = 42;
            addApptUserIDLabel.Text = "User ID:";
            // 
            // addApptCustIDComBox
            // 
            addApptCustIDComBox.DropDownStyle = ComboBoxStyle.DropDownList;
            addApptCustIDComBox.FormattingEnabled = true;
            addApptCustIDComBox.Location = new Point(209, 115);
            addApptCustIDComBox.Name = "addApptCustIDComBox";
            addApptCustIDComBox.Size = new Size(200, 33);
            addApptCustIDComBox.TabIndex = 44;
            // 
            // AddAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 470);
            Controls.Add(addApptCustIDComBox);
            Controls.Add(addApptUserIDTextBox);
            Controls.Add(addApptUserIDLabel);
            Controls.Add(addApptStartLabel);
            Controls.Add(addApptStart);
            Controls.Add(addApptTypeComBox);
            Controls.Add(addApptLengthComBox);
            Controls.Add(addApptLengthLabel);
            Controls.Add(addApptCancelButton);
            Controls.Add(addApptLabel);
            Controls.Add(addApptSaveButton);
            Controls.Add(addApptTypeLabel);
            Controls.Add(addApptIdLabel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "AddAppointmentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Appointment";
            Load += AddAppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addApptCancelButton;
        private Label addApptLabel;
        private Button addApptSaveButton;
        private Label addApptTypeLabel;
        private Label addApptIdLabel;
        private ComboBox addApptLengthComBox;
        private Label addApptLengthLabel;
        private ComboBox addApptTypeComBox;
        private DateTimePicker addApptStart;
        private Label addApptStartLabel;
        private TextBox addApptUserIDTextBox;
        private Label addApptUserIDLabel;
        private ComboBox addApptCustIDComBox;
    }
}