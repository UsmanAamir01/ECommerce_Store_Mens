using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EcommerceStoreDB
{
    public class OrderRepository
    {
        public DataTable FetchAllOrders()
        {
            string query = "SELECT ORDERID, USERID, TOTALAMOUNT, STATUS, ORDERDATE FROM Orders";

            try
            {
                Database database = new Database();
                using (OracleConnection connection = database.GetConnection())
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            return dataTable;
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                throw new Exception("Database error: " + ex.Message);
            }
        }
    }
}
