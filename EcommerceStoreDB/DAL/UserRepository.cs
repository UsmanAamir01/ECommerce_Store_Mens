// UserRepository.cs
using Oracle.ManagedDataAccess.Client;
using System;

namespace EcommerceStoreDB.DAL
{
    public class UserRepository
    {
        private readonly Database database;

        public UserRepository()
        {
            database = new Database();
        }

        public int GetUserId(string username)
        {
            try
            {
                using (OracleConnection connection = database.GetConnection())
                {
                    string query = "SELECT USERID FROM USERS WHERE USERNAME = :Username AND ROLE = 'Customer'";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":Username", username);
                        connection.Open();

                        object result = command.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int userId))
                        {
                            return userId;
                        }
                        else
                        {
                            throw new Exception("User not found.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving UserID: {ex.Message}");
            }
        }
    }
}
