using System.Data;

namespace EcommerceStoreDB
{
    public class DeliveryBLL
    {
        private DeliveryDAL deliveryDAL = new DeliveryDAL();

        public DataTable LoadDeliveries()
        {
            return deliveryDAL.GetDeliveries();  
        }
    }
}
