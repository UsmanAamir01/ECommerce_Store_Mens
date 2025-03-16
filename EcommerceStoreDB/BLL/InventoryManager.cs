using EcommerceStoreDB.DAL;
using System.Data;

namespace EcommerceStoreDB.BLL
{
    public class InventoryManager
    {
        private readonly InventoryRepository _inventoryRepository;

        public InventoryManager()
        {
            _inventoryRepository = new InventoryRepository();
        }

        public DataTable LoadInventory()
        {
            return _inventoryRepository.GetInventory();
        }
    }
}
