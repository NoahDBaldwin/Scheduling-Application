namespace SchedulingApplication
{
    partial class CustomerAddForm
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
            addCustNameTextBox = new TextBox();
            addCustNameLabel = new Label();
            addCustPhoneTextBox = new TextBox();
            addCustPhoneLabel = new Label();
            addCustAddressTextBox = new TextBox();
            addCustAddressLabel = new Label();
            addCustCityTextBox = new TextBox();
            addCustCityLabel = new Label();
            addCustCountryTextBox = new TextBox();
            addCustCountryLabel = new Label();
            addCustSaveButton = new Button();
            addCustLabel = new Label();
            addCustCancelButton = new Button();
            SuspendLayout();
            // 
            // addCustNameTextBox
            // 
            addCustNameTextBox.Location = new Point(150, 62);
            addCustNameTextBox.Name = "addCustNameTextBox";
            addCustNameTextBox.Size = new Size(227, 32);
            addCustNameTextBox.TabIndex = 3;
            // 
            // addCustNameLabel
            // 
            addCustNameLabel.AutoSize = true;
            addCustNameLabel.Location = new Point(51, 65);
            addCustNameLabel.Name = "addCustNameLabel";
            addCustNameLabel.Size = new Size(66, 25);
            addCustNameLabel.TabIndex = 2;
            addCustNameLabel.Text = "Name:";
            // 
            // addCustPhoneTextBox
            // 
            addCustPhoneTextBox.Location = new Point(150, 124);
            addCustPhoneTextBox.Name = "addCustPhoneTextBox";
            addCustPhoneTextBox.Size = new Size(227, 32);
            addCustPhoneTextBox.TabIndex = 5;
            // 
            // addCustPhoneLabel
            // 
            addCustPhoneLabel.AutoSize = true;
            addCustPhoneLabel.Location = new Point(51, 127);
            addCustPhoneLabel.Name = "addCustPhoneLabel";
            addCustPhoneLabel.Size = new Size(70, 25);
            addCustPhoneLabel.TabIndex = 4;
            addCustPhoneLabel.Text = "Phone:";
            // 
            // addCustAddressTextBox
            // 
            addCustAddressTextBox.Location = new Point(150, 187);
            addCustAddressTextBox.Name = "addCustAddressTextBox";
            addCustAddressTextBox.Size = new Size(227, 32);
            addCustAddressTextBox.TabIndex = 7;
            // 
            // addCustAddressLabel
            // 
            addCustAddressLabel.AutoSize = true;
            addCustAddressLabel.Location = new Point(51, 190);
            addCustAddressLabel.Name = "addCustAddressLabel";
            addCustAddressLabel.Size = new Size(83, 25);
            addCustAddressLabel.TabIndex = 6;
            addCustAddressLabel.Text = "Address:";
            // 
            // addCustCityTextBox
            // 
            addCustCityTextBox.Location = new Point(150, 248);
            addCustCityTextBox.Name = "addCustCityTextBox";
            addCustCityTextBox.Size = new Size(227, 32);
            addCustCityTextBox.TabIndex = 9;
            // 
            // addCustCityLabel
            // 
            addCustCityLabel.AutoSize = true;
            addCustCityLabel.Location = new Point(51, 251);
            addCustCityLabel.Name = "addCustCityLabel";
            addCustCityLabel.Size = new Size(48, 25);
            addCustCityLabel.TabIndex = 8;
            addCustCityLabel.Text = "City:";
            // 
            // addCustCountryTextBox
            // 
            addCustCountryTextBox.Location = new Point(150, 312);
            addCustCountryTextBox.Name = "addCustCountryTextBox";
            addCustCountryTextBox.Size = new Size(227, 32);
            addCustCountryTextBox.TabIndex = 11;
            // 
            // addCustCountryLabel
            // 
            addCustCountryLabel.AutoSize = true;
            addCustCountryLabel.Location = new Point(51, 315);
            addCustCountryLabel.Name = "addCustCountryLabel";
            addCustCountryLabel.Size = new Size(83, 25);
            addCustCountryLabel.TabIndex = 10;
            addCustCountryLabel.Text = "Country:";
            // 
            // addCustSaveButton
            // 
            addCustSaveButton.Location = new Point(150, 392);
            addCustSaveButton.Name = "addCustSaveButton";
            addCustSaveButton.Size = new Size(97, 45);
            addCustSaveButton.TabIndex = 12;
            addCustSaveButton.Text = "Save";
            addCustSaveButton.UseVisualStyleBackColor = true;
            addCustSaveButton.Click += addCustSaveButton_Click;
            // 
            // addCustLabel
            // 
            addCustLabel.AutoSize = true;
            addCustLabel.Font = new Font("Segoe UI", 14F);
            addCustLabel.Location = new Point(12, 9);
            addCustLabel.Name = "addCustLabel";
            addCustLabel.Size = new Size(57, 32);
            addCustLabel.TabIndex = 14;
            addCustLabel.Text = "Add";
            // 
            // addCustCancelButton
            // 
            addCustCancelButton.Location = new Point(280, 392);
            addCustCancelButton.Name = "addCustCancelButton";
            addCustCancelButton.Size = new Size(97, 45);
            addCustCancelButton.TabIndex = 15;
            addCustCancelButton.Text = "Cancel";
            addCustCancelButton.UseVisualStyleBackColor = true;
            addCustCancelButton.Click += addCustCancelButton_Click;
            // 
            // CustomerAddForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 469);
            Controls.Add(addCustCancelButton);
            Controls.Add(addCustLabel);
            Controls.Add(addCustSaveButton);
            Controls.Add(addCustCountryTextBox);
            Controls.Add(addCustCountryLabel);
            Controls.Add(addCustCityTextBox);
            Controls.Add(addCustCityLabel);
            Controls.Add(addCustAddressTextBox);
            Controls.Add(addCustAddressLabel);
            Controls.Add(addCustPhoneTextBox);
            Controls.Add(addCustPhoneLabel);
            Controls.Add(addCustNameTextBox);
            Controls.Add(addCustNameLabel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "CustomerAddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Customer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox addCustNameTextBox;
        private Label addCustNameLabel;
        private TextBox addCustPhoneTextBox;
        private Label addCustPhoneLabel;
        private TextBox addCustAddressTextBox;
        private Label addCustAddressLabel;
        private TextBox addCustCityTextBox;
        private Label addCustCityLabel;
        private TextBox addCustCountryTextBox;
        private Label addCustCountryLabel;
        private Button addCustSaveButton;
        private Label addCustLabel;
        private Button addCustCancelButton;
    }
}