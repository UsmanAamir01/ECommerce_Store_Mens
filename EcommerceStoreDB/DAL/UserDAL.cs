using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
namespace EcommerceStoreDB.DAL
{
    public class UserDAL
    {
        private Database db = new Database();
        public Dictionary<string, string> GetAdminDetails(string username)
        {
            string query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, ADDRESS FROM Users WHERE USERNAME = :USERNAME AND ROLE = 'Admin'";
            Dictionary<string, string> adminDetails = new Dictionary<string, string>();
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
                                adminDetails["FIRSTNAME"] = reader["FIRSTNAME"]?.ToString() ?? "N/A";
                                adminDetails["LASTNAME"] = reader["LASTNAME"]?.ToString() ?? "N/A";
                                adminDetails["EMAIL"] = reader["EMAIL"]?.ToString() ?? "N/A";
                                adminDetails["PHONENUMBER"] = reader["PHONENUMBER"]?.ToString() ?? "N/A";
                                adminDetails["ADDRESS"] = reader["ADDRESS"]?.ToString() ?? "N/A";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching admin details: " + ex.Message);
            }

            return adminDetails;
        }

        public int UpdateAdminDetails(string username, Dictionary<string, object> updates)
        {
            List<string> updateClauses = new List<string>();
            foreach (var field in updates.Keys)
            {
                updateClauses.Add($"{field} = :{field}");
            }

            string query = $"UPDATE Users SET {string.Join(", ", updateClauses)} WHERE USERNAME = :USERNAME AND ROLE = 'Admin'";
            updates.Add(":USERNAME", username);

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        foreach (var param in updates)
                        {
                            command.Parameters.Add(param.Key, OracleDbType.Varchar2).Value = param.Value ?? DBNull.Value;
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating admin details: " + ex.Message);
            }
        }
    }
}