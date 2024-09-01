namespace SchedulingApplication
{
    partial class CustomerDatabaseForm
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
            customerDataLabel = new Label();
            customersSearchButton = new Button();
            customersSearchTextBox = new TextBox();
            customersDGV = new DataGridView();
            customersAddButton = new Button();
            customersUpdateButton = new Button();
            customersDeleteButton = new Button();
            customersCloseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customersDGV).BeginInit();
            SuspendLayout();
            // 
            // customerDataLabel
            // 
            customerDataLabel.AutoSize = true;
            customerDataLabel.Font = new Font("Segoe UI", 14F);
            customerDataLabel.Location = new Point(12, 9);
            customerDataLabel.Name = "customerDataLabel";
            customerDataLabel.Size = new Size(127, 32);
            customerDataLabel.TabIndex = 0;
            customerDataLabel.Text = "Customers";
            // 
            // customersSearchButton
            // 
            customersSearchButton.Location = new Point(558, 47);
            customersSearchButton.Name = "customersSearchButton";
            customersSearchButton.Size = new Size(149, 39);
            customersSearchButton.TabIndex = 1;
            customersSearchButton.Text = "Search";
            customersSearchButton.UseVisualStyleBackColor = true;
            customersSearchButton.Click += customersSearchButton_Click;
            // 
            // customersSearchTextBox
            // 
            customersSearchTextBox.Location = new Point(753, 51);
            customersSearchTextBox.Name = "customersSearchTextBox";
            customersSearchTextBox.Size = new Size(267, 32);
            customersSearchTextBox.TabIndex = 2;
            // 
            // customersDGV
            // 
            customersDGV.AllowUserToAddRows = false;
            customersDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            customersDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customersDGV.Location = new Point(83, 123);
            customersDGV.MultiSelect = false;
            customersDGV.Name = "customersDGV";
            customersDGV.ReadOnly = true;
            customersDGV.RowHeadersVisible = false;
            customersDGV.RowHeadersWidth = 51;
            customersDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customersDGV.Size = new Size(937, 324);
            customersDGV.TabIndex = 3;
            // 
            // customersAddButton
            // 
            customersAddButton.Location = new Point(545, 479);
            customersAddButton.Name = "customersAddButton";
            customersAddButton.Size = new Size(119, 47);
            customersAddButton.TabIndex = 4;
            customersAddButton.Text = "Add";
            customersAddButton.UseVisualStyleBackColor = true;
            customersAddButton.Click += customersAddButton_Click;
            // 
            // customersUpdateButton
            // 
            customersUpdateButton.Location = new Point(727, 479);
            customersUpdateButton.Name = "customersUpdateButton";
            customersUpdateButton.Size = new Size(119, 47);
            customersUpdateButton.TabIndex = 5;
            customersUpdateButton.Text = "Update";
            customersUpdateButton.UseVisualStyleBackColor = true;
            customersUpdateButton.Click += customersUpdateButton_Click;
            // 
            // customersDeleteButton
            // 
            customersDeleteButton.Location = new Point(901, 479);
            customersDeleteButton.Name = "customersDeleteButton";
            customersDeleteButton.Size = new Size(119, 47);
            customersDeleteButton.TabIndex = 6;
            customersDeleteButton.Text = "Delete";
            customersDeleteButton.UseVisualStyleBackColor = true;
            customersDeleteButton.Click += customersDeleteButton_Click;
            // 
            // customersCloseButton
            // 
            customersCloseButton.BackColor = SystemColors.ControlLight;
            customersCloseButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customersCloseButton.Location = new Point(83, 479);
            customersCloseButton.Name = "customersCloseButton";
            customersCloseButton.Size = new Size(119, 44);
            customersCloseButton.TabIndex = 7;
            customersCloseButton.Text = "Close";
            customersCloseButton.UseVisualStyleBackColor = false;
            customersCloseButton.Click += customersCloseButton_Click;
            // 
            // CustomerDatabaseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1112, 558);
            Controls.Add(customersCloseButton);
            Controls.Add(customersDeleteButton);
            Controls.Add(customersUpdateButton);
            Controls.Add(customersAddButton);
            Controls.Add(customersDGV);
            Controls.Add(customersSearchTextBox);
            Controls.Add(customersSearchButton);
            Controls.Add(customerDataLabel);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "CustomerDatabaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Customer Database";
            Load += CustomerDatabaseForm_Load;
            ((System.ComponentModel.ISupportInitialize)customersDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customerDataLabel;
        private Button customersSearchButton;
        private TextBox customersSearchTextBox;
        private Button customersAddButton;
        private Button customersUpdateButton;
        private Button customersDeleteButton;
        private Button customersCloseButton;
        public DataGridView customersDGV;
    }
}