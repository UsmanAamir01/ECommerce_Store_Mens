using EcommerceStoreDB.DAL;
using EcommerceStoreDB.Models;

namespace EcommerceStoreDB.BLL
{
    public class ProductManager
    {
        private ProductRepository productRepository;

        public ProductManager()
        {
            productRepository = new ProductRepository();
        }

        public Product GetProductDetails(string productName)
        {
            return productRepository.GetProductDetails(productName);
        }

        public bool AddProductToOrders(string username, string productName)
        {
            int userId = productRepository.GetUserId(username);
            if (userId == -1) return false;

            int orderId = productRepository.GenerateNextOrderId();
            decimal price = productRepository.GetProductPrice(productName);

            return productRepository.AddOrder(orderId, userId, price);
        }

        public bool AddProductToWishlist(string username, string productName)
        {
            int userId = productRepository.GetUserId(username);
            int productId = productRepository.GetProductId(productName);

            if (userId == -1 || productId == -1) return false;

            return productRepository.AddWishlist(userId, productId, productName);
        }
    }
}
