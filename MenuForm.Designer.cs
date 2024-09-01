namespace SchedulingApplication
{
    partial class MenuForm
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
            mainCustomersButton = new Button();
            mainAppointmentsButton = new Button();
            mainReportsButton = new Button();
            mainLogoutButton = new Button();
            SuspendLayout();
            // 
            // mainCustomersButton
            // 
            mainCustomersButton.Location = new Point(127, 34);
            mainCustomersButton.Name = "mainCustomersButton";
            mainCustomersButton.Size = new Size(355, 70);
            mainCustomersButton.TabIndex = 0;
            mainCustomersButton.Text = "Customers";
            mainCustomersButton.UseVisualStyleBackColor = true;
            mainCustomersButton.Click += mainCustomersButton_Click;
            // 
            // mainAppointmentsButton
            // 
            mainAppointmentsButton.Location = new Point(127, 137);
            mainAppointmentsButton.Name = "mainAppointmentsButton";
            mainAppointmentsButton.Size = new Size(355, 70);
            mainAppointmentsButton.TabIndex = 1;
            mainAppointmentsButton.Text = "Appointments";
            mainAppointmentsButton.UseVisualStyleBackColor = true;
            mainAppointmentsButton.Click += mainAppointmentsButton_Click;
            // 
            // mainReportsButton
            // 
            mainReportsButton.Location = new Point(127, 241);
            mainReportsButton.Name = "mainReportsButton";
            mainReportsButton.Size = new Size(355, 70);
            mainReportsButton.TabIndex = 2;
            mainReportsButton.Text = "Reports";
            mainReportsButton.UseVisualStyleBackColor = true;
            mainReportsButton.Click += mainReportsButton_Click;
            // 
            // mainLogoutButton
            // 
            mainLogoutButton.BackColor = SystemColors.ControlLight;
            mainLogoutButton.Location = new Point(218, 344);
            mainLogoutButton.Name = "mainLogoutButton";
            mainLogoutButton.Size = new Size(170, 34);
            mainLogoutButton.TabIndex = 3;
            mainLogoutButton.Text = "Logout";
            mainLogoutButton.UseVisualStyleBackColor = false;
            mainLogoutButton.Click += mainLogoutButton_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(609, 416);
            Controls.Add(mainLogoutButton);
            Controls.Add(mainReportsButton);
            Controls.Add(mainAppointmentsButton);
            Controls.Add(mainCustomersButton);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main";
            Load += MenuForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button mainCustomersButton;
        private Button mainAppointmentsButton;
        private Button mainReportsButton;
        private Button mainLogoutButton;
    }
}