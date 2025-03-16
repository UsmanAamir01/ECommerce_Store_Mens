using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class InventoryRepository
    {
        public DataTable GetInventory()
        {
            DataTable dataTable = new DataTable();

            using (var connection = new Database().GetConnection())
            {
                connection.Open();

                string query = "SELECT INVENTORYID, NUM_PRODUCTS, NUM_CATEGORIES, STATUS, TOTAL_ORDERS, CURRENT_STOCK, PRODUCTID FROM Inventory";

                using (var command = new OracleCommand(query, connection))
                using (var adapter = new OracleDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
            }

            return dataTable;
        }
    }
}