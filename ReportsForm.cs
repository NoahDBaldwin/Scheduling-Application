using Org.BouncyCastle.Crypto.EC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
        }

        // When the form loads, populate the combo box selections
        private void ReportsForm_Load(object sender, EventArgs e)
        {
            // Country combobox
            Country.GetAllCountries();
            countryComBox.DataSource = Country.countriesList;

            // User combobox
            User.GetAllUsers();
            userComBox.DataSource = User.allUsersList;
        }


        // Close this window
        private void reportsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Lamda that gets a list of appointments of a selected type. only the months of the start are in the list.
        delegate List<int> GetApptMonthsOfType(string type);
        GetApptMonthsOfType getApptMonthsOfType = type => AppointmentDAO.GetDatesOfType(type);

        // When a month and type are entered, show how many appointments there are.
        private void numApptsSubmit_Click(object sender, EventArgs e)
        {

            //make sure fields aren't blank
            if(monthComBox.Text == "" || apptTypeComBox.Text == "")
            {
                MessageBox.Show("Select a Month and appointment Type.");
                return;
            }
                
            // Get month and type from the combo boxes
            int month = Convert.ToInt32(monthComBox.Text);
            string type = apptTypeComBox.Text;

            // get a list of appointments of the selected type. The list is their months. By calling lambda.
            List<int> appointmentStartMonths = getApptMonthsOfType(type);

            // Make a new list to add to.
            List<int> appointmentsOfMonthAndType = new List<int>();
            

            // if the month is the same as the selected month, add to a list. The count populates the textbox.
            foreach (int appointmentMonth in appointmentStartMonths)
            {
                if (appointmentMonth == month)
                {
                    appointmentsOfMonthAndType.Add(appointmentMonth);
                }
            }
            numApptsTextBox.Text = appointmentsOfMonthAndType.Count.ToString();
        }
    





        // Using a lambda function, use multiple methods from country to create a Collection (list) of the customers in a selected country
        // Find the count of all of the users, the lambda returns that count. 
        // Using a lambda here allows for a lot of steps to be consolidated into one function.
        delegate string CustomerIdCount(string country);
        CustomerIdCount customerIdCount = country => Country.GetAllCustFromCountry(Country.GetCountryId(country)).Count().ToString();

        // After a country is selected and submit, show number of customers in that country
        private void countrySubmit_Click(object sender, EventArgs e)
        {
            string country = countryComBox.Text;

            numCustTextBox.Text = customerIdCount(country);
        }




        // Delegate and lambda to get userID from text box and get all appointments from that user.
        delegate BindingList<Appointment> UserAppointments(string user);
        UserAppointments userAppointmentsFunc = user => AppointmentDAO.GetAppointmentsOfUser(User.GetUserId(user));

        // Make a binding list to hold all the appointments of a user to tie to DGV.
        BindingList<Appointment> userAppointments = new BindingList<Appointment>();

        // Select the schedule of a user
        private void userSubmit_Click(object sender, EventArgs e)
        {
            // Call lambda
            userAppointments = userAppointmentsFunc(userComBox.Text);

            // Change the start and end date times to display local time
            foreach (Appointment appointment in userAppointments)
            {
                appointment.Start = appointment.Start.ToLocalTime();
                appointment.End = appointment.End.ToLocalTime();
            }
            // Tie DGV to appoinment list
            userScheduleDGV.DataSource = userAppointments;

            userScheduleDGV.ClearSelection();
            userScheduleDGV.Columns["custName"].Visible = false;
            userScheduleDGV.Columns["userId"].Visible = false;
        }



    }
}
