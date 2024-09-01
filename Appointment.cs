using MySql.Data.MySqlClient;
using SchedulingApplication.Database;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SchedulingApplication
{
    internal class Appointment
    {
        public int apptId { get; set; }
        public int userId {  get; set; }
        public int custId { get; set; }
        public string custName { get; set; }
        public string apptType { get; set; }
        public DateTime Start {  get; set; }
        public DateTime End { get; set; }



        // Method to delete an appointment from database
        public static void DeleteAppointment(int selectedId)
        {
            MySqlCommand command = new MySqlCommand
            (
                $"DELETE FROM appointment WHERE appointmentId = {selectedId};",
                DBConnection.connection
            );
            command.ExecuteNonQuery();
        }


        // Method to select any appointments within 15 minutes of login time.
        public static string IsAppointmentSoon(string currentTime, string inFifteen)
        {
            DateTime queryDateTime = new DateTime();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT start FROM appointment WHERE start >= '{currentTime}' AND start <= '{inFifteen}' ;",
                    DBConnection.connection
                );

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while ( reader.Read())
                {
                    queryDateTime = reader.GetDateTime(0);
                }
            }

            // Change the format for display and return
            int year = queryDateTime.Year;
            int hour = queryDateTime.Hour;
            int minute = queryDateTime.Minute;
            int day = queryDateTime.Day;
            int month = queryDateTime.Month;

            string appointmentTime = $"{month}-{day}-{year} {hour}:{minute}";


            // if the appointmentTime is not default, return the appointmentTime.
            if (appointmentTime == "1-1-1 0:0")
            {
                return "no appointments soon";
            }
            else
            {
                return appointmentTime;
            }
        }



        // Method to add an appointment
        public static void AddAppointment(int userId, int custId, string apptType, string apptLength, string apptStart, string apptEnd)
        {
            // display userId, custId, custName, apptType, start, end
            MySqlCommand command1 = new MySqlCommand
            (
                 $"INSERT INTO appointment VALUES (NULL, {custId}, {userId}, 'title', 'description', 'Online', 'Contact', '{apptType}', 'google.com', '{apptStart}', '{apptEnd}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah');",
                 DBConnection.connection
            );
            command1.ExecuteNonQuery();
        }



        // Method to Update an Appointment
        public static void UpdateAppointment(int apptId, int custId, string apptType, string apptStart, string apptEnd)
        {
            MySqlCommand command4 = new MySqlCommand
            (
                     $"UPDATE appointment SET customerId = {custId}, type = '{apptType}', start = '{apptStart}', end = '{apptEnd}' WHERE appointmentId = {apptId};",
                     DBConnection.connection
                );
            command4.ExecuteNonQuery();
        }
    }
}
