using EcommerceStoreDB.Models;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Security.Cryptography;
using System.Text;

namespace EcommerceStoreDB.DAL
{
    public class AuthDataAccess
    {
        private readonly Database database;
        public AuthDataAccess()
        {
            database = new Database();
        }

        public bool InsertUser(User user)
        {
            try
            {
                using (OracleConnection connection = database.GetConnection())
                {
                    string query = "INSERT INTO USERS (EMAIL, FIRSTNAME, LASTNAME, USERNAME, PASSWORD, PHONENUMBER, ADDRESS, ROLE, CREATIONTIME) " +
                                   "VALUES (:Email, :FirstName, :LastName, :Username, :Password, :PhoneNumber, :Address, :Role, SYSTIMESTAMP)";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":Email", user.Email);
                        command.Parameters.Add(":FirstName", user.FirstName);
                        command.Parameters.Add(":LastName", user.LastName);
                        command.Parameters.Add(":Username", user.Username);
                        string hashedPassword = HashPassword(user.Password);
                        command.Parameters.Add(":Password", hashedPassword);
                        command.Parameters.Add(":PhoneNumber", user.PhoneNumber);
                        command.Parameters.Add(":Address", user.Address);
                        command.Parameters.Add(":Role", user.Role);
                        connection.Open();
                        int rowsInserted = command.ExecuteNonQuery();
                        return rowsInserted > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inserting user: {ex.Message}");
                return false;
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public User ValidateLogin(string username, string password, string role)
        {
            try
            {
                using (OracleConnection connection = database.GetConnection())
                {
                    string query = "SELECT USERID, EMAIL, FIRSTNAME, LASTNAME, USERNAME, ROLE " +
                                   "FROM USERS WHERE USERNAME = :Username AND PASSWORD = :Password AND ROLE = :Role";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":Username", username);
                        string hashedPassword = HashPassword(password);
                        command.Parameters.Add(":Password", hashedPassword);
                        command.Parameters.Add(":Role", role);

                        connection.Open();
                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    Email = reader.GetString(0),
                                    FirstName = reader.GetString(1),
                                    LastName = reader.GetString(2),
                                    Username = reader.GetString(3),
                                    Role = reader.GetString(4)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error validating login: {ex.Message}");
            }
            return null;
        }
    }
}