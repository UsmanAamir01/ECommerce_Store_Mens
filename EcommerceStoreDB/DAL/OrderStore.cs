using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB.DAL
{
    public class OrderStore
    {
        private Database db;

        public OrderStore()
        {
            db = new Database();
        }

        public DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();
            string query = "SELECT ORDERID, USERID, TOTALAMOUNT, STATUS, ORDERDATE FROM ORDERS";

            try
            {
                using (OracleConnection conn = db.GetConnection())
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error fetching orders: " + ex.Message);
            }

            return dt;
        }
    }
}
