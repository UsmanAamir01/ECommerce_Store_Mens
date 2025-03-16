using System;
using System.Data;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB.BLL
{
    public class OrderHandler
    {
        private readonly OrderDAO _orderDAO;

        public OrderHandler()
        {
            _orderDAO = new OrderDAO();
        }

        public DataTable GetOrderHistory(string username)
        {
            int userId = _orderDAO.GetUserIdByUsername(username);

            if (userId == -1)
                throw new Exception("User not found or does not have permission to view orders.");

            return _orderDAO.GetOrdersByUserId(userId);
        }
    }
}
