using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingApplication
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }


        // Show the different windows when the buttons are pressed.
        private void mainCustomersButton_Click(object sender, EventArgs e)
        {
            CustomerDatabaseForm customerDatabaseForm = new CustomerDatabaseForm();
            customerDatabaseForm.Show();
        }
        private void mainAppointmentsButton_Click(object sender, EventArgs e)
        {
            AppointmentsForm appointmentsForm = new AppointmentsForm();
            appointmentsForm.Show();
        }
        private void mainReportsButton_Click(object sender, EventArgs e)
        {
            ReportsForm reportForm = new ReportsForm();
            reportForm.Show();
        }

        // Close the application when logout is pressed
        private void mainLogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // When the main form loads, issue a warning if there is an appointment within 15 minutes. Check DB in UTC. Display in local
        private void MenuForm_Load(object sender, EventArgs e)
        {
            DateTime currentDateTime = DateTime.Now;
            DateTime currentUTC = currentDateTime.ToUniversalTime();

            // Change current time to mySQL format. Second argument means 0 minutes changed
            string mySqlDateTime = TimeConversion.ToSqlDateTime(currentUTC, 0);

            // Make the time that is 15 minutes later, second argument is 15 minutes changed
            string inFifteen = TimeConversion.ToSqlDateTime(currentUTC, 15);            
            
            // get any appointments within 15 minutes and change to local time.
            string isAppointmentSoon = Appointment.IsAppointmentSoon(mySqlDateTime, inFifteen);
            

            // If there is a valid appointment, show messageBox.
            if (isAppointmentSoon == "no appointments soon")
            {
                return;
            }
            else
            {
                // convert time back to local and display appointment
                DateTime nextAppointment = DateTime.Parse(isAppointmentSoon);
                DateTime appointmentInLocal = nextAppointment.ToLocalTime();

                int month = appointmentInLocal.Month;
                int day = appointmentInLocal.Day;
                int hour = appointmentInLocal.Hour;
                int minute = appointmentInLocal.Minute;

                MessageBox.Show($"You have an appointment within 15 minutes at {month}/{day} {hour}:{minute}");
            }
            
        }




    }
}
