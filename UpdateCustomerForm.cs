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

namespace SchedulingApplication
{
    public partial class UpdateCustomerForm : Form
    {
        CustomerDatabaseForm CustomerDatabaseForm;
        public UpdateCustomerForm(CustomerDatabaseForm CustomerDatabaseForm)
        {
            InitializeComponent();
            this.CustomerDatabaseForm = CustomerDatabaseForm;
            
        }


        // Populate text boxes on load
        private void UpdateCustomerForm_Load(object sender, EventArgs e)
        {
            // Make sure that a row was selected from partsDataGridView on load
            if (CustomerDatabaseForm.customersDGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select a customer to update.");
                this.Close();
            }
            else
            {
                foreach (DataGridViewRow row in CustomerDatabaseForm.customersDGV.SelectedRows)
                {
                    updateCustIdTextBox.Text = row.Cells[0].Value.ToString();
                    updateCustNameTextBox.Text = row.Cells[1].Value.ToString();
                    updateCustPhoneTextBox.Text = row.Cells[2].Value.ToString();
                    updateCustAddressTextBox.Text = row.Cells[3].Value.ToString();
                    updateCustCityTextBox.Text = row.Cells[4].Value.ToString();
                    updateCustCountryTextBox.Text = row.Cells[5].Value.ToString();
                }
                // if a customer is selected, close the customerDatabase form
                CustomerDatabaseForm.Close();

            }
        }



        // Close window and don't save when cancel is clicked.
        private void updateCustCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Save the Update
        private void updateCustSaveButton_Click(object sender, EventArgs e)
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
                Match match = Regex.Match(updateCustPhoneTextBox.Text, @"^[\d-]+$");

                if (match.Success)
                // If no errors, add the customer
                {
                    int custId = Convert.ToInt32(updateCustIdTextBox.Text.Trim());
                    string custName = updateCustNameTextBox.Text.Trim();
                    string custPhone = updateCustPhoneTextBox.Text.Trim();
                    string custAddress = updateCustAddressTextBox.Text.Trim();
                    string custCity = updateCustCityTextBox.Text.Trim();
                    string custCountry = updateCustCountryTextBox.Text.Trim();
                    Customer.UpdateCustomer(custId, custName, custPhone, custAddress, custCity, custCountry);
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
