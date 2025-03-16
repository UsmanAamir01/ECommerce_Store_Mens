using System.Data;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class OrderProcessor
    {
        private OrderStore orderStore;

        public OrderProcessor()
        {
            orderStore = new OrderStore();
        }

        public DataTable GetOrderData()
        {
            return orderStore.GetAllOrders();
        }
    }
}
