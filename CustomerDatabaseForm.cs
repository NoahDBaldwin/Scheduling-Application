using SchedulingApplication.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class CustomerDatabaseForm : Form
    {
        BindingList<Customer> customerList = new BindingList<Customer>();


        public CustomerDatabaseForm()
        {
            InitializeComponent();
        }

        // When the form is loaded, populate the DGV with SQL query and clear selection
        public void CustomerDatabaseForm_Load(object sender, EventArgs e)
        {
            CustomerDAO customersDAO = new CustomerDAO();
            customerList = customersDAO.getAllCustomers();
            customersDGV.DataSource = customerList;

            customersDGV.ClearSelection();
        }


        // Close window when close button is clicked
        private void customersCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Open Add and Update forms when the buttons are pressed.
        private void customersAddButton_Click(object sender, EventArgs e)
        {
            CustomerAddForm customerAddForm = new CustomerAddForm();
            customerAddForm.Show();

            this.Close();
        }
        private void customersUpdateButton_Click(object sender, EventArgs e)
        {
            // add "this" to transfer the DGV data
            UpdateCustomerForm updateCustomerForm = new UpdateCustomerForm(this);
            updateCustomerForm.Show();
        }





        // Search for a customer by ID.
        private void customersSearchButton_Click(object sender, EventArgs e)
        {
            // Clear current DGV selection
            customersDGV.ClearSelection();

            // Take in input of the ID number
            int customerSearchId;
            if (customersSearchTextBox.Text != "")
            {
                // Make sure that the search is an int
                try
                {
                    Convert.ToInt32(customersSearchTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                customerSearchId = Convert.ToInt32(customersSearchTextBox.Text);

                bool found = false;
                // Find if the searchId matches a customer, make row selected if found.
                foreach (Customer customer in customerList)
                {

                    if (customer.ID == customerSearchId)
                    {
                        Customer searched = customer;

                        foreach (DataGridViewRow row in customersDGV.Rows)
                        {
                            Customer rowCustomer = row.DataBoundItem as Customer;
                            if (rowCustomer != null && rowCustomer == searched)
                            {
                                row.Selected = true;
                                found = true;
                            }
                        }
                    }
                }
                // If no customer is found...
                if (found == false)
                {
                    MessageBox.Show("No customer has that ID");
                }
            }
            // If nothing is entered in the search text box...
            else
            {
                MessageBox.Show("Enter a Customer ID");
            }
        }


        // Delete Button
        private void customersDeleteButton_Click(object sender, EventArgs e)
        {
            if (customersDGV.SelectedRows.Count > 0)
            {
                DialogResult isSure = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (isSure == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in customersDGV.SelectedRows)
                    {
                        // Get the ID of the selected customer
                        string selectedId = customersDGV.SelectedRows[0].Cells[0].Value.ToString();
                        Customer.DeleteCustomer(Convert.ToInt32(selectedId));
                    }
                }
                else
                {
                    return;
                }
            }
            // If a customer is not selected...
            else
            {
                MessageBox.Show("Select a customer to delete");
            }
            

            // refresh the DGV and clear selection
            CustomerDAO customersDAO = new CustomerDAO();
            customerList = customersDAO.getAllCustomers();
            customersDGV.DataSource = customerList;
            customersDGV.ClearSelection();
        }


    }
}
