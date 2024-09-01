using MySql.Data.MySqlClient;
using SchedulingApplication.Database;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingApplication.Database;
using System.ComponentModel;
using System.Security.Cryptography;

namespace SchedulingApplication
{
    internal class CustomerDAO
    {

        // Method to connect customers from SQL to DGV.
        public BindingList<Customer> getAllCustomers()
        {
            // start with an empty list
            BindingList<Customer> returnCustomers = new BindingList<Customer>();

            // Select customer fields for DGV
            MySqlCommand command = new MySqlCommand
                (
                    "SELECT customer.customerId, customer.customerName, address.phone, address.address, city.city, country.country FROM customer JOIN address ON address.addressId = customer.addressId JOIN city ON city.cityId = address.cityId JOIN country ON country.countryId = city.countryId;",
                    DBConnection.connection
                );

            // Read the data and add to a list
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer customer = new Customer
                    {
                        ID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Phone = reader.GetString(2),
                        Address = reader.GetString(3),
                        City = reader.GetString(4),
                        Country = reader.GetString(5)
                    };
                    // Add customer to list
                    returnCustomers.Add(customer);
                }
            }
            // Return list of customers
            return returnCustomers;
        }



        //Method to read the auto increment Ids created from an insert into the database.
        public static int ReadNewId(string enteredText, string field)
        {
            // Make a list to store the ID, make an sql query to select the ID, then read it and add to the list.
            // Return the ID from the list (it'll be the only element in the list).
            List<int> list = new List<int>();

            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT {field}Id FROM {field} WHERE {field} = \"{enteredText}\";",
                    DBConnection.connection
                );
            using (MySqlDataReader reader1 = command.ExecuteReader())
            {
                while (reader1.Read())
                {
                    list.Add(reader1.GetInt32(0));
                }
                return list[0];
            }
        }



        // Method to ensure that Id's dont duplicate
        public static List<string> SelectAllItems(string field)
        {
            //Make a list of the current items of entered type in the Data base
            List<string> itemsInDB = new List<string>();

            MySqlCommand command5 = new MySqlCommand
                (
                    $"SELECT {field} FROM {field};",
                    DBConnection.connection
                );
            using (MySqlDataReader reader2 = command5.ExecuteReader())
            {
                while (reader2.Read())
                {
                    itemsInDB.Add(reader2.GetString(0).ToLower());
                }
                return itemsInDB;
            }
        }


        // Method to get the current ID of a country if the country is already in the database
        public static int GetCurrentId(string field, string enteredText)
        {
            List<int> currentId = new List<int>();
            MySqlCommand command7 = new MySqlCommand
                (
                    $"SELECT {field}Id FROM {field} WHERE {field} = '{enteredText}';",
                    DBConnection.connection
                );
            using (MySqlDataReader reader3 = command7.ExecuteReader())
            {
                while (reader3.Read())
                {
                    currentId.Add(reader3.GetInt32(0));

                }
                return currentId[0];
            }
        }


        // Method to add all of the current customer Ids to the customerIds list
        public static void GetCustIds()
        {
            MySqlCommand command = new MySqlCommand
                (
                    $"SELECT customerId FROM customer;",
                    DBConnection.connection
                );

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Customer.customerIds.Add(reader.GetInt32(0));
                }
            }
        }





    }
}

    

