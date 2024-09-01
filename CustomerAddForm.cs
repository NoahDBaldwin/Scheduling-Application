using SchedulingApplication.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SchedulingApplication
{
    public partial class CustomerAddForm : Form
    {
        public CustomerAddForm()
        {
            InitializeComponent();
        }

        // Close window and don't save when cancel is clicked.
        private void addCustCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();

            CustomerDatabaseForm customerDatabaseForm = new CustomerDatabaseForm();
            customerDatabaseForm.Show();
        }


        // Save button
        private void addCustSaveButton_Click(object sender, EventArgs e)
        {
            // Keep track if there are errors
            int errorCount1 = 0;


            foreach (Control txtBox in this.Controls)
            {
                //Reset back color
                txtBox.BackColor = default;
                if (txtBox.Text == "")
                {
                    // Change color if missing a field
                    txtBox.BackColor = Color.FromArgb(255, 100, 100);
                    errorCount1++;
                }
            }
            // Show an error if any fields are missing
            if (errorCount1 > 0)
            {
                MessageBox.Show("Fill all of fields.");
            }
            else
            {
                //Make sure that phone number field only takes digits and dashes
                Match match = Regex.Match(addCustPhoneTextBox.Text, @"^[\d-]+$");

                if (match.Success)
                // If no errors, add the customer
                {
                    string custName = addCustNameTextBox.Text.Trim();
                    string custPhone = addCustPhoneTextBox.Text.Trim();
                    string custAddress = addCustAddressTextBox.Text.Trim();
                    string custCity = addCustCityTextBox.Text.Trim();
                    string custCountry = addCustCountryTextBox.Text.Trim();
                    Customer.AddCustomer(custName, custPhone, custAddress, custCity, custCountry);
                    this.Close();

                    //// load a new customer database form to reload the DGV
                    CustomerDatabaseForm customerDatabaseForm = new CustomerDatabaseForm();
                    customerDatabaseForm.Show();
                }
                else
                {
                    MessageBox.Show("The phone number can only contain digits and dashes.");
                }
            }

            
        }
    }
}
