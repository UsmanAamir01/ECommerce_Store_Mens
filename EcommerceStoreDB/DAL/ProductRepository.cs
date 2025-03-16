using System;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using EcommerceStoreDB.Models;

namespace EcommerceStoreDB.DAL
{
    public class ProductRepository
    {
        private Database db = new Database();

        public Product GetProductDetails(string productName)
        {
            string query = "SELECT NAME, DESCRIPTION, PRICE FROM PRODUCTS WHERE NAME = :Name";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":Name", productName));

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return new Product
                        {
                            Name = reader["NAME"].ToString(),
                            Description = reader["DESCRIPTION"].ToString(),
                            Price = Convert.ToDecimal(reader["PRICE"])
                        };
                    }
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return null;
        }

        public int GetUserId(string username)
        {
            string query = "SELECT USERID FROM USERS WHERE USERNAME = :Username AND ROLE = 'Customer'";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":Username", username));

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["USERID"]);
                    }
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return -1;
        }

        public int GenerateNextOrderId()
        {
            string query = "SELECT NVL(MAX(ORDERID), 0) + 1 AS NEXT_ORDER_ID FROM ORDERS";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["NEXT_ORDER_ID"]);
                    }
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return -1;
        }

        public decimal GetProductPrice(string productName)
        {
            string query = "SELECT PRICE FROM PRODUCTS WHERE NAME = :Name";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":Name", productName));

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return Convert.ToDecimal(reader["PRICE"]);
                    }
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return 0;
        }

        public bool AddOrder(int orderId, int userId, decimal totalAmount)
        {
            string query = "INSERT INTO ORDERS (ORDERID, USERID, TOTALAMOUNT, STATUS, ORDERDATE) VALUES (:OrderId, :UserId, :TotalAmount, 'Processing', :OrderDate)";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":OrderId", orderId));
                command.Parameters.Add(new OracleParameter(":UserId", userId));
                command.Parameters.Add(new OracleParameter(":TotalAmount", totalAmount));
                command.Parameters.Add(new OracleParameter(":OrderDate", DateTime.Now));

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return false;
        }

        public bool AddWishlist(int userId, int productId, string productName)
        {
            string query = "INSERT INTO WISHLISTS (USERID, PRODUCTID, PRODUCTNAME) VALUES (:UserId, :ProductId, :ProductName)";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":UserId", userId));
                command.Parameters.Add(new OracleParameter(":ProductId", productId));
                command.Parameters.Add(new OracleParameter(":ProductName", productName));

                try
                {
                    connection.Open();
                    return command.ExecuteNonQuery() > 0;
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return false;
        }

        public int GetProductId(string productName)
        {
            string query = "SELECT PRODUCTID FROM PRODUCTS WHERE NAME = :Name";
            using (OracleConnection connection = db.GetConnection())
            {
                OracleCommand command = new OracleCommand(query, connection);
                command.Parameters.Add(new OracleParameter(":Name", productName));

                try
                {
                    connection.Open();
                    OracleDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        return Convert.ToInt32(reader["PRODUCTID"]);
                    }
                }
                catch (Exception)
                {
                    // Log error
                }
            }
            return -1; // Return -1 if product is not found
        }

    }
}
