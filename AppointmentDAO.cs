using MySql.Data.MySqlClient;
using SchedulingApplication.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApplication
{
    internal class AppointmentDAO
    {
        // Method to connect appointments from SQL to DGV.
        public BindingList<Appointment> getAllAppointments()
        {
            // start with an empty list
            BindingList<Appointment> returnAppointments = new BindingList<Appointment>();

            // Select appointment fields for DGV
            MySqlCommand command = new MySqlCommand
                (
                    "SELECT appointment.appointmentId, appointment.userId, appointment.customerId, customer.customerName, type, start, end FROM appointment JOIN customer ON appointment.customerId = customer.customerId;",
                    DBConnection.connection
                );

            // Read the data and add to a list
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Appointment appointment = new Appointment
                    {
                        apptId = reader.GetInt32(0),
                        userId = reader.GetInt32(1),
                        custId = reader.GetInt32(2),
                        custName = reader.GetString(3),
                        apptType = reader.GetString(4),
                        Start = reader.GetDateTime(5),
                        End = reader.GetDateTime(6)
                    };
                    // Add Appointment to list
                    returnAppointments.Add(appointment);
                }
            }
            // Return list of appointments
            return returnAppointments;
        }


        public static BindingList<Appointment> GetAppointmentsOfUser(int userId)
        {
            BindingList<Appointment> returnAppointments = new BindingList<Appointment>();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT appointmentid, customerId, start, end, type FROM appointment WHERE userId = {userId};",
                    DBConnection.connection
                );

            using (MySqlDataReader reader = command.ExecuteReader())
            {

                while (reader.Read()) 
                {
                    Appointment appointment = new Appointment
                    {
                        apptId = reader.GetInt32(0),
                        custId = reader.GetInt32(1),
                        Start = reader.GetDateTime(2),
                        End = reader.GetDateTime(3),
                        apptType = reader.GetString(4)
                    };
                    // Add Appointment to list
                    returnAppointments.Add(appointment);
                }
            }
            return returnAppointments;
        }



        // Get all of the appointment starts of the selected type. Only add the month.
        public static List<int> GetDatesOfType(string type)
        {
            List<int> apptStarts = new List<int>();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT start FROM appointment WHERE type = '{type}';",
                    DBConnection.connection
                );
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    apptStarts.Add(reader.GetDateTime(0).Month);
                }
            }
            return apptStarts;
        }
        


    }
}
