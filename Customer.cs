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
    internal class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }



        public static BindingList<int> customerIds = new BindingList<int>(); 


        /*                  
           /\      | |   | |  / ____|        | |                           
          /  \   __| | __| | | |    _   _ ___| |_ ___  _ __ ___   ___ _ __ 
         / /\ \ / _` |/ _` | | |   | | | / __| __/ _ \| '_ ` _ \ / _ \ '__|
        / ____ \ (_| | (_| | | |___| |_| \__ \ || (_) | | | | | |  __/ |   
       /_/    \_\__,_|\__,_|  \_____\__,_|___/\__\___/|_| |_| |_|\___|_| 
        */

        // Method to add a customer to database
        // Insert info each table and get the auto incremented Id's to add to the next table if needed.
        public static void AddCustomer(string name, string phone, string address, string city, string country)
        {

            // If the country is already in the database, use the current country, otherwise insert a new one.
            string countryField = "country";
            List<string> countriesInDB = CustomerDAO.SelectAllItems(countryField);
            int countryId;
            if (countriesInDB.Contains(country.ToLower()))
            {
                countryId = CustomerDAO.GetCurrentId(countryField, country);
            }
            else
            {
                MySqlCommand command1 = new MySqlCommand
                (
                     $"INSERT INTO country VALUES (NULL, '{country}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah');",
                     DBConnection.connection
                );
                command1.ExecuteNonQuery();

                // Get the ID that was autoincremented in the insert statement
                countryId = CustomerDAO.ReadNewId(country, "country");
            }


            // If the city is already in the database, use the current city, otherwise insert a new one.
            string cityField = "city";
            List<string> citiesInDB = CustomerDAO.SelectAllItems(cityField);
            int cityId;
            if (citiesInDB.Contains(city.ToLower()))
            {
                cityId = CustomerDAO.GetCurrentId(cityField, city);
            }
            else
            {
                MySqlCommand command2 = new MySqlCommand
                (
                     $"INSERT INTO city VALUES (NULL, '{city}', '{countryId}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah' );",
                     DBConnection.connection
                );
                command2.ExecuteNonQuery();

                // Get the ID that was autoincremented in the insert statement
                cityId = CustomerDAO.ReadNewId(city, "city");
            }


            // If the address is already in the database, use the current address, otherwise insert a new one.
            string addressField = "address";
            List<string> addressesInDB = CustomerDAO.SelectAllItems(addressField);
            int addressId;
            if (addressesInDB.Contains(address.ToLower()))
            {
                addressId = CustomerDAO.GetCurrentId(addressField, address);
            }
            else
            {
                MySqlCommand command3 = new MySqlCommand
                (
                     $"INSERT INTO address VALUES (NULL, '{address}', '0', {cityId}, 55555, '{phone}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah');",
                     DBConnection.connection
                );
                command3.ExecuteNonQuery();

                // Get the ID that was autoincremented in the insert statement
                addressId = CustomerDAO.ReadNewId(address, "address");
            }


            // Insert the new customer
            MySqlCommand command4 = new MySqlCommand
                (
                     $"INSERT INTO customer VALUES (NULL, '{name}', {addressId}, 1, '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah');",
                     DBConnection.connection
                );
            command4.ExecuteNonQuery();
        }


        /*
         _    _           _       _          _____          _                            
        | |  | |         | |     | |        / ____|        | |                           
        | |  | |_ __   __| | __ _| |_ ___  | |    _   _ ___| |_ ___  _ __ ___   ___ _ __ 
        | |  | | '_ \ / _` |/ _` | __/ _ \ | |   | | | / __| __/ _ \| '_ ` _ \ / _ \ '__|
        | |__| | |_) | (_| | (_| | ||  __/ | |___| |_| \__ \ || (_) | | | | | |  __/ |   
         \____/| .__/ \__,_|\__,_|\__\___|  \_____\__,_|___/\__\___/|_| |_| |_|\___|_|   
               | |                                                                       
               |_|                                                                        
        */

        // Method to Update a customer in the Database
        // Same exact code as the AddCustomer method, except for command4 and custId parameter added.
        public static void UpdateCustomer(int custId, string name, string phone, string address, string city, string country)
        {
            // If the country is already in the database, use the current country, otherwise insert a new one.
            string countryField = "country";
            List<string> countriesInDB = CustomerDAO.SelectAllItems(countryField);
            int countryId;
            if (countriesInDB.Contains(country.ToLower()))
            {
                countryId = CustomerDAO.GetCurrentId(countryField, country);
            }
            else
            {
                MySqlCommand command1 = new MySqlCommand
                (
                     $"INSERT INTO country VALUES (NULL, '{country}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah');",
                     DBConnection.connection
                );
                command1.ExecuteNonQuery();

                // Get the ID that was autoincremented in the insert statement
                countryId = CustomerDAO.ReadNewId(country, "country");
            }


            // If the city is already in the database, use the current city, otherwise insert a new one.
            string cityField = "city";
            List<string> citiesInDB = CustomerDAO.SelectAllItems(cityField);
            int cityId;
            if (citiesInDB.Contains(city.ToLower()))
            {
                cityId = CustomerDAO.GetCurrentId(cityField, city);
            }
            else
            {
                MySqlCommand command2 = new MySqlCommand
                (
                     $"INSERT INTO city VALUES (NULL, '{city}', '{countryId}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah' );",
                     DBConnection.connection
                );
                command2.ExecuteNonQuery();

                // Get the ID that was autoincremented in the insert statement
                cityId = CustomerDAO.ReadNewId(city, "city");
            }


            // If the address is already in the database, use the current address, otherwise insert a new one.
            string addressField = "address";
            List<string> addressesInDB = CustomerDAO.SelectAllItems(addressField);
            int addressId;
            if (addressesInDB.Contains(address.ToLower()))
            {
                addressId = CustomerDAO.GetCurrentId(addressField, address);
            }
            else
            {
                MySqlCommand command3 = new MySqlCommand
                (
                     $"INSERT INTO address VALUES (NULL, '{address}', '0', {cityId}, 55555, '{phone}', '2024-08-23 12:00:00', 'Noah', '2024-08-23 12:00:00', 'Noah');",
                     DBConnection.connection
                );
                command3.ExecuteNonQuery();

                // Get the ID that was autoincremented in the insert statement
                addressId = CustomerDAO.ReadNewId(address, "address");
            }



            // Update the new customer
            MySqlCommand command4 = new MySqlCommand
                (
                     $"UPDATE customer SET customerName = '{name}', addressId = {addressId} WHERE customerId = {custId};",
                     DBConnection.connection
                );
            command4.ExecuteNonQuery();
        }



        /*
         _____       _      _          _____          _                            
        |  __ \     | |    | |        / ____|        | |                           
        | |  | | ___| | ___| |_ ___  | |    _   _ ___| |_ ___  _ __ ___   ___ _ __ 
        | |  | |/ _ \ |/ _ \ __/ _ \ | |   | | | / __| __/ _ \| '_ ` _ \ / _ \ '__|
        | |__| |  __/ |  __/ ||  __/ | |___| |_| \__ \ || (_) | | | | | |  __/ |   
        |_____/ \___|_|\___|\__\___|  \_____\__,_|___/\__\___/|_| |_| |_|\___|_|   
        */

        // Method to delete a customer in database
        public static void DeleteCustomer(int selectedId)
        {
            MySqlCommand command = new MySqlCommand
            (
                $"DELETE FROM customer WHERE customerId = {selectedId};",
                DBConnection.connection
            );
            command.ExecuteNonQuery();
        }

        

    }
}
