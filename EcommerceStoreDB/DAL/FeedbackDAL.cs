using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class FeedbackDAL
    {
        private Database database;

        public FeedbackDAL()
        {
            database = new Database();
        }

        public DataTable GetFeedbackData()
        {
            DataTable feedbackData = new DataTable();
            try
            {
                using (OracleConnection connection = database.GetConnection())
                {
                    string query = "SELECT FEEDBACKID, USERID, PRODUCTID, RATING, COMMENTS, FEEDBACKDATE, PRODUCTNAME FROM FEEDBACK";
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(query, connection);
                    dataAdapter.Fill(feedbackData);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving feedback data.", ex);
            }

            return feedbackData;
        }
    }
}
