using System;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB.DAL
{
    public class SettingsDAL
    {
        public bool VerifyPassword(string username, string hashedPassword, OracleConnection conn)
        {
            string query = "SELECT COUNT(*) FROM Users WHERE USERNAME = :username AND PASSWORD = :password";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                cmd.Parameters.Add(new OracleParameter("username", username));
                cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count > 0;
            }
        }

        public bool UpdatePassword(string username, string hashedPassword, OracleConnection conn)
        {
            string query = "UPDATE Users SET PASSWORD = :password WHERE USERNAME = :username";
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                cmd.Parameters.Add(new OracleParameter("password", hashedPassword));
                cmd.Parameters.Add(new OracleParameter("username", username));
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}