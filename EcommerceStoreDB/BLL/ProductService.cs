using EcommerceStoreDB.DAL;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class ProductService
    {
        private ProductsDAL productsDAL;

        public ProductService()
        {
            productsDAL = new ProductsDAL();
        }

        public DataTable GetAllProducts()
        {
            return productsDAL.FetchAllProducts();
        }
    }
}