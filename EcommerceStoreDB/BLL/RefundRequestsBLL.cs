using System;
using System.Data;

namespace EcommerceStoreDB
{
    public class RefundRequestBLL
    {
        private readonly RefundRequestDAL refundRequestDAL;

        public RefundRequestBLL()
        {
            refundRequestDAL = new RefundRequestDAL();
        }

        public DataTable GetRefundRequests()
        {
            return refundRequestDAL.GetRefundRequests();
        }

        public string ProcessRefundRequest(int orderId, string reason, decimal refundAmount)
        {
            if (string.IsNullOrWhiteSpace(reason) || refundAmount <= 0)
            {
                return "Please provide a valid reason and amount.";
            }

            bool isRefundProcessed = refundRequestDAL.RequestRefund(orderId, reason, refundAmount);
            if (isRefundProcessed)
            {
                return "Refund request processed successfully.";
            }
            else
            {
                return "Failed to process refund request.";
            }
        }
    }
}
