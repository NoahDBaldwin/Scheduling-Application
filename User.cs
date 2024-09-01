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
    internal class User
    {

        public string CurrentUserName { get; set; }
        public int CurrentUserId { get; set; }

        // Get one user ID
        public static List<int> userList = new List<int>();

        // Get list of all user names
        public static BindingList<string> allUsersList = new BindingList<string>();


        // Get the ID of the current user.
        public static void InputUserId(string currentUser)
        {
            List<int> id = new List<int>();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT userId FROM user WHERE userName = '{ currentUser }';",
                    DBConnection.connection
                );
            
            using ( MySqlDataReader reader = command.ExecuteReader())
            {
                while ( reader.Read())
                {
                    id.Add(reader.GetInt32(0));
                }
                userList.Add(id[0]);
            }
        }


        // Get the Id of a user by their username
        public static int GetUserId(string username)
        {
            List<int> id = new List<int>();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT userId FROM user WHERE userName = '{username}';",
                    DBConnection.connection
                );

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    id.Add(reader.GetInt32(0));
                }
                return id[0];
            }
        }



        


        // Method to get all usernames in the database
        public static void GetAllUsers()
        {
            allUsersList.Clear();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT userName FROM user;",
                    DBConnection.connection

                );
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    allUsersList.Add(reader.GetString(0));
                }
            }
        }




    }
}
