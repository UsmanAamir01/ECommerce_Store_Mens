using System;
using System.Data;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class RefundManager
    {
        private RefundDataAccess refundDataAccess;

        public RefundManager()
        {
            refundDataAccess = new RefundDataAccess();
        }

        public DataTable GetRefunds()
        {
            return refundDataAccess.GetRefunds();
        }

        public void IssueRefund(int refundID, string username, string role, string orderID, string reason, decimal refundAmount, DateTime refundDate)
        {
            // Create notification message
            string notificationMessage = $"Refund issued for Order ID: {orderID}, Reason: {reason}, Refund Amount: {refundAmount:C}, Refund Date: {refundDate.ToShortDateString()}";

            // Insert notification and delete refund
            refundDataAccess.InsertNotification(username, notificationMessage, role);
            refundDataAccess.DeleteRefund(refundID);
        }
    }
}
