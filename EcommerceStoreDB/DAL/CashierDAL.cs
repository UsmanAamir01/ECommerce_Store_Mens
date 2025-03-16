using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class CashierDAL
    {
        private Database db = new Database();

        public DataRow GetCashierDetails(string username)
        {
            string query = "SELECT FIRSTNAME, LASTNAME, EMAIL, PHONENUMBER, ADDRESS FROM Users WHERE USERNAME = :USERNAME AND ROLE = 'Cashier'";

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
                            DataTable dt = new DataTable();
                            dt.Load(reader);

                            if (dt.Rows.Count > 0)
                            {
                                return dt.Rows[0]; 
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error loading cashier details: " + ex.Message);
            }

            return null;
        }
        public bool UpdateCashierDetails(string username, string firstName, string lastName, string email, string phoneNumber, string address)
        {
            string query = "UPDATE Users SET FIRSTNAME = :FIRSTNAME, LASTNAME = :LASTNAME, EMAIL = :EMAIL, PHONENUMBER = :PHONENUMBER, ADDRESS = :ADDRESS WHERE USERNAME = :USERNAME AND ROLE = 'Cashier'";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":FIRSTNAME", OracleDbType.Varchar2).Value = firstName;
                        command.Parameters.Add(":LASTNAME", OracleDbType.Varchar2).Value = lastName;
                        command.Parameters.Add(":EMAIL", OracleDbType.Varchar2).Value = email;
                        command.Parameters.Add(":PHONENUMBER", OracleDbType.Varchar2).Value = phoneNumber;
                        command.Parameters.Add(":ADDRESS", OracleDbType.Varchar2).Value = address;
                        command.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = username;

                        int rowsUpdated = command.ExecuteNonQuery();
                        return rowsUpdated > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error updating cashier details: " + ex.Message);
            }
        }

    }
}