using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;

namespace EcommerceStoreDB.DAL
{
    public class ManagerDAL
    {
        private readonly Database db = new Database();

        public Dictionary<string, string> GetManagerDetails(string username)
        {
            string query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, ADDRESS FROM Users WHERE USERNAME = :USERNAME AND ROLE = 'Manager'";
            Dictionary<string, string> managerDetails = new Dictionary<string, string>();

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
                                managerDetails["FirstName"] = reader["FIRSTNAME"]?.ToString();
                                managerDetails["LastName"] = reader["LASTNAME"]?.ToString();
                                managerDetails["Email"] = reader["EMAIL"]?.ToString();
                                managerDetails["PhoneNumber"] = reader["PHONENUMBER"]?.ToString();
                                managerDetails["Address"] = reader["ADDRESS"]?.ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching manager details", ex);
            }

            return managerDetails;
        }

        public int UpdateManagerDetails(string username, Dictionary<string, object> updateFields)
        {
            string setClause = string.Join(", ", updateFields.Keys);
            string query = $"UPDATE Users SET {setClause} WHERE USERNAME = :USERNAME AND ROLE = 'Manager'";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        foreach (var field in updateFields)
                        {
                            command.Parameters.Add(field.Key, OracleDbType.Varchar2).Value = field.Value ?? DBNull.Value;
                        }
                        command.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = username;

                        return command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating manager details", ex);
            }
        }
    }
}