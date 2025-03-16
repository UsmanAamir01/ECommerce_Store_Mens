// DAL/DeliveryPersonDAO.cs
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace EcommerceStoreDB.DAL
{
    public class DeliveryPersonDAO
    {
        private Database db = new Database();

        public Dictionary<string, string> GetDeliveryPersonDetails(string username)
        {
            string query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, ADDRESS FROM Users WHERE USERNAME = :USERNAME AND ROLE = 'DeliveryPerson'";
            Dictionary<string, string> details = new Dictionary<string, string>();

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
                                details["FIRSTNAME"] = reader["FIRSTNAME"]?.ToString();
                                details["LASTNAME"] = reader["LASTNAME"]?.ToString();
                                details["EMAIL"] = reader["EMAIL"]?.ToString();
                                details["PHONENUMBER"] = reader["PHONENUMBER"]?.ToString();
                                details["ADDRESS"] = reader["ADDRESS"]?.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading delivery person details: " + ex.Message);
            }
            return details;
        }

        public bool UpdateDeliveryPersonDetails(string username, Dictionary<string, object> updateParameters)
        {
            List<string> updateClauses = new List<string>();
            foreach (var param in updateParameters)
            {
                updateClauses.Add($"{param.Key} = :{param.Key}");
            }

            string query = $"UPDATE Users SET {string.Join(", ", updateClauses)} WHERE USERNAME = :USERNAME AND ROLE = 'DeliveryPerson'";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        foreach (var param in updateParameters)
                        {
                            command.Parameters.Add(":" + param.Key, OracleDbType.Varchar2).Value = param.Value ?? DBNull.Value;
                        }

                        command.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = username;

                        int rowsUpdated = command.ExecuteNonQuery();
                        return rowsUpdated > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error saving changes: " + ex.Message);
            }
        }
    }
}
