using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class OrderDataAccess
    {
        private Database database;

        public OrderDataAccess()
        {
            database = new Database();
        }

        public DataTable FetchOrders()
        {
            string query = @"
                SELECT O.ORDERID, O.USERID, O.TOTALAMOUNT, O.STATUS, O.ORDERDATE,
                       OI.ORDERINFOID, OI.PRODUCTID, OI.QUANTITY, OI.SUBTOTAL
                FROM ORDERS O
                INNER JOIN ORDERINFORMATION OI ON O.ORDERID = OI.ORDERID";

            using (OracleConnection connection = database.GetConnection())
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    using (OracleDataAdapter adapter = new OracleDataAdapter(command))
                    {
                        DataTable ordersTable = new DataTable();
                        adapter.Fill(ordersTable);
                        return ordersTable;
                    }
                }
            }
        }
    }
}