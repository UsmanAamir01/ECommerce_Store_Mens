using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

namespace EcommerceStoreDB.DAL
{
    public class ShipmentDataAccess
    {
        private Database database;

        public ShipmentDataAccess()
        {
            database = new Database(); // Create an instance of the Database class
        }

        // Method to update shipment and delivery status
        public bool UpdateShipmentStatus(string shipmentId, string newStatus)
        {
            using (var connection = database.GetConnection()) // Use the GetConnection method of Database class
            {
                try
                {
                    connection.Open();

                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Update SHIPMENTS table
                            string updateShipmentsQuery = @"
                                UPDATE SHIPMENTS 
                                SET STATUS = :status, DELIVERYDATE = :deliveryDate 
                                WHERE SHIPMENTID = :shipmentId";
                            using (var command = new OracleCommand(updateShipmentsQuery, connection))
                            {
                                command.Transaction = transaction;
                                command.Parameters.Add(new OracleParameter(":status", newStatus));
                                command.Parameters.Add(new OracleParameter(":deliveryDate", DateTime.Now));
                                command.Parameters.Add(new OracleParameter(":shipmentId", shipmentId));
                                command.ExecuteNonQuery();
                            }

                            // Update DELIVERY table
                            string updateDeliveryQuery = @"
                                UPDATE DELIVERY 
                                SET DELIVERYSTATUS = :deliveryStatus, DELIVERYDATE = :deliveryDate 
                                WHERE SHIPMENTID = :shipmentId";
                            using (var command = new OracleCommand(updateDeliveryQuery, connection))
                            {
                                command.Transaction = transaction;
                                command.Parameters.Add(new OracleParameter(":deliveryStatus", newStatus));
                                command.Parameters.Add(new OracleParameter(":deliveryDate", DateTime.Now));
                                command.Parameters.Add(new OracleParameter(":shipmentId", shipmentId));
                                command.ExecuteNonQuery();
                            }

                            // Commit the transaction
                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            // Rollback if any error occurs
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }

        // Method to retrieve all shipments data
        public DataTable GetShipmentsData()
        {
            using (var connection = database.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT SHIPMENTID, ORDERID, CARRIER, TRACKINGNUMBER, SHIPPEDDATE, DELIVERYDATE, STATUS FROM SHIPMENTS";
                    using (var command = new OracleCommand(query, connection))
                    {
                        OracleDataAdapter dataAdapter = new OracleDataAdapter(command);
                        DataTable dataTable = new DataTable();
                        dataAdapter.Fill(dataTable);
                        return dataTable;
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
