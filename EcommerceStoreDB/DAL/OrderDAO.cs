using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB.DAL
{
    public class OrderDAO
    {
        private readonly Database _database;

        public OrderDAO()
        {
            _database = new Database();
        }

        public DataTable GetOrdersByUserId(int userId)
        {
            string query = "SELECT ORDERID, TOTALAMOUNT, STATUS, ORDERDATE FROM Orders WHERE USERID = :USERID";

            using (var connection = _database.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":USERID", OracleDbType.Int32).Value = userId;
                    using (var adapter = new OracleDataAdapter(command))
                    {
                        DataTable orders = new DataTable();
                        adapter.Fill(orders);
                        return orders;
                    }
                }
            }
        }

        public int GetUserIdByUsername(string username)
        {
            string query = "SELECT USERID FROM Users WHERE USERNAME = :USERNAME AND ROLE = 'Customer'";

            using (var connection = _database.GetConnection())
            {
                connection.Open();
                using (var command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(":USERNAME", OracleDbType.Varchar2).Value = username;
                    var result = command.ExecuteScalar();
                    return result != null ? Convert.ToInt32(result) : -1;
                }
            }
        }
    }
}