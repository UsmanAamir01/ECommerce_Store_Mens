// DAL/CustomerDAO.cs
using EcommerceStoreDB.Models;
using Oracle.ManagedDataAccess.Client;
using System;

namespace EcommerceStoreDB.DAL
{
    public class CustomerDAO
    {
        private Database db = new Database();

        // Method to fetch customer details from the database
        public Customer GetCustomerDetails(string username)
        {
            string query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, ADDRESS FROM Users WHERE USERNAME = :USERNAME AND ROLE = 'Customer'";
            Customer customer = null;

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = username;

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                customer = new Customer
                                {
                                    FirstName = reader["FIRSTNAME"]?.ToString(),
                                    LastName = reader["LASTNAME"]?.ToString(),
                                    Email = reader["EMAIL"]?.ToString(),
                                    PhoneNumber = reader["PHONENUMBER"]?.ToString(),
                                    Address = reader["ADDRESS"]?.ToString()
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching customer details: " + ex.Message);
            }

            return customer;
        }

        // Method to update customer details in the database
        public bool UpdateCustomerProfile(Customer customer, string username)
        {
            string query = @"UPDATE Users SET FIRSTNAME = :FIRSTNAME, LASTNAME = :LASTNAME, EMAIL = :EMAIL, PHONENUMBER = :PHONENUMBER, ADDRESS = :ADDRESS
                             WHERE USERNAME = :USERNAME AND ROLE = 'Customer'";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":FIRSTNAME", OracleDbType.Varchar2).Value = customer.FirstName;
                        command.Parameters.Add(":LASTNAME", OracleDbType.Varchar2).Value = customer.LastName;
                        command.Parameters.Add(":EMAIL", OracleDbType.Varchar2).Value = customer.Email;
                        command.Parameters.Add(":PHONENUMBER", OracleDbType.Varchar2).Value = customer.PhoneNumber;
                        command.Parameters.Add(":ADDRESS", OracleDbType.Varchar2).Value = customer.Address;
                        command.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = username;

                        int rowsUpdated = command.ExecuteNonQuery();
                        return rowsUpdated > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating customer details: " + ex.Message);
            }
        }
    }
}
