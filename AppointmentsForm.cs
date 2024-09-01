using Org.BouncyCastle.Bcpg;
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
    public partial class AppointmentsForm : Form
    {
        public AppointmentsForm()
        {
            InitializeComponent();
        }

        BindingList<Appointment> appointmentList = new BindingList<Appointment>();

        // When the form is loaded, populate the DGV with SQL query and clear selection
        private void AppointmentsForm_Load(object sender, EventArgs e)
        { 

            AppointmentDAO appointmentsDAO = new AppointmentDAO();
            appointmentList = appointmentsDAO.getAllAppointments();

            // Change the start and end date times to display local time
            foreach (Appointment appointment in appointmentList)
            {
                appointment.Start = appointment.Start.ToLocalTime();
                appointment.End = appointment.End.ToLocalTime();
            }
            // Tie DGV to appoinment list
            appointmentsDGV.DataSource = appointmentList;

            appointmentsDGV.ClearSelection();
        }


        // Close window when clicked
        private void appointmentsCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Open Add and Update forms when buttons are clicked.
        private void appointmentsAddButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AddAppointmentForm addAppointmentForm = new AddAppointmentForm();
            addAppointmentForm.ShowDialog();         
        }
        private void appointmentsUpdateButton_Click(object sender, EventArgs e)
        {
            // Add "this" to transfer the DGV data
            UpdateAppoinmentForm updateAppointmentForm = new UpdateAppoinmentForm(this);
            updateAppointmentForm.ShowDialog();
        }



        // Search Button
        private void appointmentsSearchButton_Click(object sender, EventArgs e)
        {
            // Clear current DGV selection
            appointmentsDGV.ClearSelection();

            // Take in input of the ID number
            int appointmentSearchId;
            if (appointmentsSearchTextBox.Text != "")
            {
                // Make sure that the search is an int
                try
                {
                    Convert.ToInt32(appointmentsSearchTextBox.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                appointmentSearchId = Convert.ToInt32(appointmentsSearchTextBox.Text);

                bool found = false;
                // Find if the searchId matches an appointment, make row selected if found.
                foreach (Appointment appointment in appointmentList)
                {

                    if (appointment.apptId == appointmentSearchId)
                    {
                        Appointment searched = appointment;

                        foreach (DataGridViewRow row in appointmentsDGV.Rows)
                        {
                            Appointment rowAppointment = row.DataBoundItem as Appointment;
                            if (rowAppointment != null && rowAppointment == searched)
                            {
                                row.Selected = true;
                                found = true;
                            }
                        }
                    }
                }
                // If no appointment is found...
                if (found == false)
                {
                    MessageBox.Show("No Appointment has that ID");
                }
            }
            // If nothing is entered in the search text box...
            else
            {
                MessageBox.Show("Enter an Appointment ID");
            }
        }


        // Delete Button
        private void appointmentsDeleteButton_Click(object sender, EventArgs e)
        {
            if (appointmentsDGV.SelectedRows.Count > 0)
            {
                DialogResult isSure = MessageBox.Show("Are you sure you want to delete this?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (isSure == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in appointmentsDGV.SelectedRows)
                    {
                        // Get the ID of the selected appointment
                        string selectedId = appointmentsDGV.SelectedRows[0].Cells[0].Value.ToString();
                        Appointment.DeleteAppointment(Convert.ToInt32(selectedId));
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
                MessageBox.Show("Select a appointment to delete");
            }

            // refresh the DGV and clear selection
            AppointmentDAO appointmentsDAO = new AppointmentDAO();
            appointmentList = appointmentsDAO.getAllAppointments();
            appointmentsDGV.DataSource = appointmentList;
            appointmentsDGV.ClearSelection();
        }



        // All, This Week, and This Month buttons.
        
        // Find current week, and month (local time)
        DateTime oneWeek = DateTime.Now.AddDays(7);
        int thisMonth = DateTime.Now.Month;

        // Show all appointments when pressed
        private void apptAllButton_Click(object sender, EventArgs e)
        {
            foreach (Appointment appointment in appointmentList)
            {
                foreach (DataGridViewRow row in appointmentsDGV.Rows)
                {
                    row.Visible = true;
                }
            }
        }


        // Show appointments in a 7 day period
        private void apptThisWeekButton_Click(object sender, EventArgs e)
        {
            List<int> apptsThisWeek = new List<int>();

            // Check if each appointment is within next 7 days, if yes, add to list.
            foreach(Appointment appointment in appointmentList)
            {
                if (appointment.Start <= oneWeek)
                {
                    apptsThisWeek.Add(appointment.apptId);
                }   
            }
            foreach (DataGridViewRow row in appointmentsDGV.Rows)
            {
                // Make each appointment row accessible as an Appointment to compare apptId
                // Then use as a DGV row to change visibility
                Appointment rowAppointment = row.DataBoundItem as Appointment;
                if (apptsThisWeek.Contains(rowAppointment.apptId))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }


        // Show appointments in current month
        private void apptThisMonthButton_Click(object sender, EventArgs e)
        {
            List<int>apptsThisMonth = new List<int>();

            // Check if each appointment is in the current month, add to list if yes.
            foreach (Appointment appointment in appointmentList)
            {
                if (appointment.Start.Month == thisMonth)
                {
                    apptsThisMonth.Add(appointment.apptId);
                }
            }
            foreach (DataGridViewRow row in appointmentsDGV.Rows)
            {
                // Make each appointment row accessible as an Appointment to compare apptId
                // Then use as a DGV row to change visibility
                Appointment rowAppointment = row.DataBoundItem as Appointment;
                if (apptsThisMonth.Contains(rowAppointment.apptId))
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }



    }
}
