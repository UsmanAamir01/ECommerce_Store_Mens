using EcommerceStoreDB.DAL;
using System;
using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class FeedbackBLL
    {
        private FeedbackDAL feedbackDAL;

        public FeedbackBLL()
        {
            feedbackDAL = new FeedbackDAL();
        }

        public DataTable LoadFeedbackData()
        {
            try
            {
                return feedbackDAL.GetFeedbackData();
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while loading feedback data.", ex);
            }
        }
    }
}
