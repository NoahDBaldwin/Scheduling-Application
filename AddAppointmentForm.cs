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
    public partial class AddAppointmentForm : Form
    {
        public AddAppointmentForm()
        {
            InitializeComponent();
        }


        // Close window and don't save when cancel is clicked.
        private void addApptCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Get the current user on and a list of customer Ids on load
        private void AddAppointmentForm_Load(object sender, EventArgs e)
        {
            // input the userId box with the Id of the current user
            string userId = User.userList[0].ToString();
            addApptUserIDTextBox.Text = userId;

            // update customer list and make data source for combobox.
            Customer.customerIds.Clear();
            CustomerDAO.GetCustIds();

            addApptCustIDComBox.DataSource = Customer.customerIds;
        }


        // Save Button
        private void addApptSaveButton_Click(object sender, EventArgs e)
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
                // If no errors, add the Appointment
                int userId = Convert.ToInt32(addApptUserIDTextBox.Text.Trim());
                int custId = Convert.ToInt32(addApptCustIDComBox.Text.Trim());
                string apptType = addApptTypeComBox.Text.Trim();
                string apptLength = addApptLengthComBox.Text.Trim();
                string apptStart = addApptStart.Text.Trim();

                // convert to date time, change the time zone to UTC, then turn into SQL format.
                DateTime ApptStart = DateTime.Parse(apptStart);
                DateTime StartUTC = ApptStart.ToUniversalTime();

                int length = TimeConversion.GetLength(apptLength);

                // Add minutes to end the appointment length minutes later.
                string start = TimeConversion.ToSqlDateTime(StartUTC, 0);
                string end = TimeConversion.ToSqlDateTime(StartUTC, length);

                // Get the end in c# DateTime, and the hour for next tests.
                DateTime EndUTC = DateTime.Parse(end);
                int endHour = Convert.ToInt32(end.Substring(11, 2));
                
               
                // If not in business hours, alert and return.
                if (StartUTC.Hour < 14)
                {
                    MessageBox.Show("The appointment must be between the business hours of 9am and 5pm EST");
                    return;
                } 
                else if (endHour > 22)
                {
                    MessageBox.Show("The appointment must be between the business hours of 9am and 5pm EST");
                    return;
                }
               

                // Get every appointment from the database
                BindingList<Appointment> appointmentList = new BindingList<Appointment>();
                AppointmentDAO appointmentDAO = new AppointmentDAO();
                appointmentList = appointmentDAO.getAllAppointments();

                // Make sure there aren't any overlapping appointments
                foreach (Appointment appointment in appointmentList)
                {
                    if (StartUTC >= appointment.Start && StartUTC < appointment.End)
                    {
                        MessageBox.Show("New appointments cannot overlap with an existing appointment.");
                        return;
                    }
                    else if (EndUTC < appointment.Start && EndUTC >= appointment.End)
                    {
                        MessageBox.Show("New appointments cannot overlap with an existing appointment.");
                        return;
                    }
                }          
                
                // Add the new appointment, close the form, and open a new appointment form if no issues.
                Appointment.AddAppointment(userId, custId, apptType, apptLength, start, end);
                this.Close();
                AppointmentsForm appointmentsForm = new AppointmentsForm();
                appointmentsForm.Show();
            }
        }


       
    }
}
