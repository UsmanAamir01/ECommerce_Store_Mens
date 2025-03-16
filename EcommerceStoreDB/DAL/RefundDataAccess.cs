using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB.DAL
{
    public class RefundDataAccess
    {
        private Database db;

        public RefundDataAccess()
        {
            db = new Database();
        }

        public DataTable GetRefunds()
        {
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "SELECT REFUNDID, ORDERID, REASON, REFUNDAMOUNT, REFUNDDATE FROM REFUNDS";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void DeleteRefund(int refundID)
        {
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM REFUNDS WHERE REFUNDID = :refundID";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":refundID", OracleDbType.Int32)).Value = refundID;
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InsertNotification(string username, string message, string role)
        {
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO NOTIFICATIONS (NOTIFICATIONID, USERNAME, MESSAGE, ROLE) " +
                               "VALUES (notification_id_seq.NEXTVAL, :username, :message, :role)";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":username", OracleDbType.Varchar2)).Value = username;
                    cmd.Parameters.Add(new OracleParameter(":message", OracleDbType.Varchar2)).Value = message;
                    cmd.Parameters.Add(new OracleParameter(":role", OracleDbType.Varchar2)).Value = role;
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}