using MySql.Data.MySqlClient;
using SchedulingApplication.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingApplication
{
    internal class Country
    {
        // Binding source for the country combo box
        public static BindingList<string> countriesList = new BindingList<string>();


        // Method to get all countries in the database
        public static void GetAllCountries()
        {
            countriesList.Clear();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT country FROM country;",
                    DBConnection.connection

                );
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    countriesList.Add(reader.GetString(0));
                }
            }
        }

        
        // Get the Id of the selected country
        public static int GetCountryId(string country)
        {
            List<int> countryId = new List<int>();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT countryId FROM country WHERE country = '{country}';",
                    DBConnection.connection
                );

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    countryId.Add(reader.GetInt32(0));
                }
            }
            return countryId[0];
        }


        // Get all of the customers from a particular country added to a list.
        public static List<int> GetAllCustFromCountry(int countryId)
        {
            // Initialize lists
            List<int> cityIds = new List<int>();
            List<int> addressIds = new List<int>();  
            List<int> customerIds = new List<int>();

            // Get all of the cityIds in the country
            MySqlCommand command1 = new MySqlCommand
            (
                    $"SELECT cityId FROM city WHERE countryId = {countryId};",
                    DBConnection.connection
            );
            using (MySqlDataReader reader1 = command1.ExecuteReader())
            {
                while(reader1.Read())
                {
                    cityIds.Add(reader1.GetInt32(0));
                }
            }

            // Get every address Id from every selected cityId
            foreach (int cityId in cityIds)
            {
                MySqlCommand command2 = new MySqlCommand
                (
                    $"SELECT addressId FROM address WHERE cityId = {cityId};",
                    DBConnection.connection
                );
                using (MySqlDataReader reader2 = command2.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        addressIds.Add(reader2.GetInt32(0));
                    }
                }
            }

            // Get every customer Id from every selected addressId
            foreach (int addressId in addressIds)
            {
                MySqlCommand command3 = new MySqlCommand
                (
                    $"SELECT customerId FROM customer WHERE addressId = {addressId};",
                    DBConnection.connection
                );
                using (MySqlDataReader reader3 = command3.ExecuteReader())
                {
                    while (reader3.Read())
                    {
                        customerIds.Add(reader3.GetInt32(0));
                    }
                }
            }
            return customerIds;
        }


    }
}
