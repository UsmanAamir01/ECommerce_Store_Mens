using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    public class WishlistDAL
    {
        private readonly Database db;

        public WishlistDAL()
        {
            db = new Database();
        }

        public int GetUserId(string username, string role)
        {
            string query = "SELECT USERID FROM USERS WHERE USERNAME = :Username AND ROLE = :Role";

            using (OracleConnection connection = db.GetConnection())
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter(":Username", username));
                    command.Parameters.Add(new OracleParameter(":Role", role));

                    object result = command.ExecuteScalar();
                    return result == null ? -1 : Convert.ToInt32(result);
                }
            }
        }

        public List<WishlistItem> FetchWishlistItems(int userId)
        {
            string query = "SELECT WISHLISTID, PRODUCTID, PRODUCTNAME FROM WISHLISTS WHERE USERID = :UserId";
            var wishlistItems = new List<WishlistItem>();

            using (OracleConnection connection = db.GetConnection())
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter(":UserId", userId));

                    using (OracleDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            wishlistItems.Add(new WishlistItem
                            {
                                WishlistId = reader["WISHLISTID"].ToString(),
                                ProductId = reader["PRODUCTID"].ToString(),
                                ProductName = reader["PRODUCTNAME"].ToString()
                            });
                        }
                    }
                }
            }

            return wishlistItems;
        }

        public bool DeleteWishlistItem(string wishlistId)
        {
            string query = "DELETE FROM WISHLISTS WHERE WISHLISTID = :WishlistId";

            using (OracleConnection connection = db.GetConnection())
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter(":WishlistId", wishlistId));
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AddToCart(int userId, string productId, string productName)
        {
            string query = @"
                INSERT INTO shoppingcart (CARTID, USERID, PRODUCTID, QUANTITY, PRODUCTNAME) 
                VALUES (shoppingcart_seq.NEXTVAL, :UserId, :ProductId, :Quantity, :ProductName)";

            using (OracleConnection connection = db.GetConnection())
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query, connection))
                {
                    command.Parameters.Add(new OracleParameter(":UserId", userId));
                    command.Parameters.Add(new OracleParameter(":ProductId", productId));
                    command.Parameters.Add(new OracleParameter(":Quantity", 1));
                    command.Parameters.Add(new OracleParameter(":ProductName", productName));

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }

    public class WishlistItem
    {
        public string WishlistId { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}