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
    public partial class UpdateAppoinmentForm : Form
    {
        AppointmentsForm appointmentsForm;
        public UpdateAppoinmentForm(AppointmentsForm appointmentsForm)
        {
            InitializeComponent();
            this.appointmentsForm = appointmentsForm;
        }


        // Close window and don't save when cancel is clicked.
        private void updateApptCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // Populate form on load with selected appointment info, current user, and customer Ids
        private void UpdateAppoinmentForm_Load(object sender, EventArgs e)
        {
            // input the userId box with the Id of the current user
            string userId = User.userList[0].ToString();
            updateApptUserIDTextBox.Text = userId;

            // update customer list and make data source for custId comboBox.
            Customer.customerIds.Clear();
            CustomerDAO.GetCustIds();
            updateApptCustIDComBox.DataSource = Customer.customerIds;


            // Make sure that a row was selected from partsDataGridView on load
            if (appointmentsForm.appointmentsDGV.SelectedRows.Count < 1)
            {
                MessageBox.Show("Select an appointment to update.");
                this.Close();
            }
            
            else
            {
                // Populate form fields with data from the DGV
                foreach (DataGridViewRow row in appointmentsForm.appointmentsDGV.SelectedRows)
                {
                    updateApptIDTextBox.Text = row.Cells[0].Value.ToString();
                    updateApptUserIDTextBox.Text = row.Cells[1].Value.ToString();
                    updateApptCustIDComBox.Text = row.Cells[2].Value.ToString();
                    updateApptTypeComBox.Text = row.Cells[4].Value.ToString();
                    updateApptStart.Text = row.Cells[5].Value.ToString();

                    // Calculate the appointment length
                    DateTime start = DateTime.Parse(row.Cells[5].Value.ToString());
                    DateTime end = DateTime.Parse(row.Cells[6].Value.ToString());

                    string length = (end - start).ToString();
                    if (length == "01:30:00")
                    {
                        updateApptLengthComBox.Text = "1.5 Hours";
                    } 
                    else if (length == "01:00:00")
                    {
                        updateApptLengthComBox.Text = "1 Hour";
                    }
                    else
                    {
                        updateApptLengthComBox.Text = "30 Minutes";
                    }
                }
                // if an appointment is selected, close the appointments form
                //appointmentsForm.Close();
            }
        }





        // Save the Update
        private void updateApptSaveButton_Click(object sender, EventArgs e)
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
                int apptId = Convert.ToInt32(updateApptIDTextBox.Text.Trim());
                int userId = Convert.ToInt32(updateApptUserIDTextBox.Text.Trim());
                int custId = Convert.ToInt32(updateApptCustIDComBox.Text.Trim());
                string apptType = updateApptTypeComBox.Text.Trim();
                string apptLength = updateApptLengthComBox.Text.Trim();
                string apptStart = updateApptStart.Text.Trim();

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


                // Make a new list of appointments that is every appointment except for the one being updated
                // This ensures that the current appointment isn't tested against the overlapping appointment time.
                List<Appointment> apptsList = new List<Appointment>();
                foreach (Appointment appointment in appointmentList)
                {
                    if (appointment.apptId == apptId)
                    {
                        apptsList.Remove(appointment);
                    }
                }


                // Make sure there aren't any overlapping appointments
                foreach (Appointment appointment in apptsList)
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

                // Update the  appointment, close the form, and open a new appointment form if no issues.
                Appointment.UpdateAppointment(apptId, custId, apptType, start, end);
                this.Close();
                appointmentsForm.Close();
                AppointmentsForm newAppointmentsForm = new AppointmentsForm();
                newAppointmentsForm.Show();

            }
        }


    }
}
