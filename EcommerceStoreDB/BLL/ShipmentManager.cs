using System;
using System.Data;
using EcommerceStoreDB.DAL; // Add reference to the Data Access Layer

namespace EcommerceStoreDB.BLL
{
    public class ShipmentManager
    {
        private ShipmentDataAccess shipmentDataAccess;

        public ShipmentManager()
        {
            shipmentDataAccess = new ShipmentDataAccess(); // Initialize DAL class
        }

        // Method to update shipment status
        public bool UpdateShipmentStatus(string shipmentId, string newStatus)
        {
            try
            {
                // Call DAL to update shipment and delivery statuses
                return shipmentDataAccess.UpdateShipmentStatus(shipmentId, newStatus);
            }
            catch (Exception)
            {
                return false;
            }
        }

        // Method to get all shipments data
        public DataTable GetShipmentsData()
        {
            return shipmentDataAccess.GetShipmentsData();
        }
    }
}
