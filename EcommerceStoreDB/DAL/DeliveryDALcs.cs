using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    public class DeliveryDAL
    {
        private Database db = new Database();

        public DataTable GetDeliveries()
        {
            string query = "SELECT DELIVERYID, SHIPMENTID, DELIVERYPERSONID, DELIVERYDATE, DELIVERYSTATUS, DELIVERYADDRESS FROM DELIVERY";
            using (OracleConnection conn = db.GetConnection())
            {
                try
                {
                    conn.Open();
                    using (OracleCommand cmd = new OracleCommand(query, conn))
                    {
                        using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error retrieving data: " + ex.Message);
                }
            }
        }
    }
}
