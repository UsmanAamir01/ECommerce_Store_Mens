using EcommerceStoreDB.DAL;
using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class OrderManager
    {
        private OrderDataAccess orderDataAccess;

        public OrderManager()
        {
            orderDataAccess = new OrderDataAccess();
        }

        public DataTable GetOrders()
        {
            return orderDataAccess.FetchOrders();
        }
    }
}
