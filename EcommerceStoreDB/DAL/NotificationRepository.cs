using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB.DAL
{
    public class NotificationRepository
    {
        private readonly Database db;

        public NotificationRepository()
        {
            db = new Database();
        }

        public DataTable GetNotificationsByRole(string role)
        {
            DataTable dt = new DataTable();
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT NOTIFICATIONID, USERNAME, MESSAGE, ROLE, STATUS, 
                           TO_CHAR(NOTIFYDATE, 'YYYY-MM-DD HH24:MI:SS') AS NOTIFYDATE
                    FROM NOTIFICATIONS
                    WHERE ROLE = :Role
                    ORDER BY NOTIFYDATE DESC";

                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("Role", role));
                    using (OracleDataAdapter adapter = new OracleDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public bool UpdateNotificationStatus(string notificationId, string newStatus)
        {
            using (OracleConnection conn = db.GetConnection())
            {
                conn.Open();
                string query = "UPDATE NOTIFICATIONS SET STATUS = :Status WHERE NOTIFICATIONID = :NotificationId";
                using (OracleCommand cmd = new OracleCommand(query, conn))
                {
                    cmd.Parameters.Add(new OracleParameter("Status", newStatus));
                    cmd.Parameters.Add(new OracleParameter("NotificationId", notificationId));
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
