using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class OrderService
    {
        private OrderRepository orderRepository;

        public OrderService()
        {
            orderRepository = new OrderRepository();
        }

        public DataTable GetAllOrders()
        {
            return orderRepository.FetchAllOrders();
        }
    }
}
