using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    public class RefundRequestDAL
    {
        private readonly Database db;

        public RefundRequestDAL()
        {
            db = new Database();
        }

        public DataTable GetRefundRequests()
        {
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT ORDERID, USERID, TOTALAMOUNT, STATUS, ORDERDATE FROM ORDERS";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public bool RequestRefund(int orderId, string reason, decimal refundAmount)
        {
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO REFUNDS (REFUNDID, ORDERID, REASON, REFUNDAMOUNT, REFUNDDATE) " +
                               "VALUES (SEQ_REFUNDS.NEXTVAL, :orderID, :reason, :refundAmount, DEFAULT)";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(":orderID", OracleDbType.Int32).Value = orderId;
                    cmd.Parameters.Add(":reason", OracleDbType.Varchar2).Value = reason;
                    cmd.Parameters.Add(":refundAmount", OracleDbType.Decimal).Value = refundAmount;

                    int rowsAffected = cmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
    }
}
