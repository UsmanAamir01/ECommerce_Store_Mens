// FeedbackRepository.cs
using Oracle.ManagedDataAccess.Client;
using System;

namespace EcommerceStoreDB.DAL
{
    public class FeedbackRepository
    {
        private readonly Database database;

        public FeedbackRepository()
        {
            database = new Database();
        }

        public bool SaveFeedback(int userId, int productId, int rating, string comments, string productName)
        {
            try
            {
                using (OracleConnection connection = database.GetConnection())
                {
                    string query = @"
                        INSERT INTO FEEDBACK (FEEDBACKID, USERID, PRODUCTID, RATING, COMMENTS, FEEDBACKDATE, PRODUCTNAME) 
                        VALUES (FEEDBACK_SEQ.NEXTVAL, :UserId, :ProductId, :Rating, :Comments, SYSTIMESTAMP, :ProductName)";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(":UserId", userId);
                        command.Parameters.Add(":ProductId", productId);
                        command.Parameters.Add(":Rating", rating);
                        command.Parameters.Add(":Comments", comments);
                        command.Parameters.Add(":ProductName", productName);

                        connection.Open();
                        int rowsInserted = command.ExecuteNonQuery();

                        return rowsInserted > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error submitting feedback: {ex.Message}");
            }
        }
    }
}
