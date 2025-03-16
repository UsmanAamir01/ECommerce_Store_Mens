using Oracle.ManagedDataAccess.Client;
using System;
using System.Text;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public class Store
    {
        public Store() { }

        public void UpdateUser(string userId, string name, string email, string phoneNo, string salary = null)
        {
            if (string.IsNullOrEmpty(userId))
            {
                throw new ArgumentException("User ID cannot be null or empty.");
            }

            StringBuilder query = new StringBuilder("UPDATE USERS SET ");
            bool hasPreviousField = false;

            if (!string.IsNullOrEmpty(name))
            {
                query.Append("USERNAME = :name");
                hasPreviousField = true;
            }
            if (!string.IsNullOrEmpty(email))
            {
                if (hasPreviousField) query.Append(", ");
                query.Append("EMAIL = :email");
                hasPreviousField = true;
            }
            if (!string.IsNullOrEmpty(phoneNo))
            {
                if (hasPreviousField) query.Append(", ");
                query.Append("PHONENUMBER = :phoneNo");
                hasPreviousField = true;
            }
            if (!string.IsNullOrEmpty(salary))
            {
                if (hasPreviousField) query.Append(", ");
                query.Append("SALARY = :salary");
                hasPreviousField = true;
            }

            if (!hasPreviousField)
            {
                throw new InvalidOperationException("No fields to update. All provided values are null or empty.");
            }

            query.Append(" WHERE USERID = :userId");

            Database database = new Database();
            using (OracleConnection connection = database.GetConnection())
            {
                connection.Open();
                using (OracleCommand command = new OracleCommand(query.ToString(), connection))
                {
                    if (!string.IsNullOrEmpty(name))
                        command.Parameters.Add(new OracleParameter("name", name));
                    if (!string.IsNullOrEmpty(email))
                        command.Parameters.Add(new OracleParameter("email", email));
                    if (!string.IsNullOrEmpty(phoneNo))
                        command.Parameters.Add(new OracleParameter("phoneNo", phoneNo));
                    if (!string.IsNullOrEmpty(salary))
                        command.Parameters.Add(new OracleParameter("salary", salary));
                    command.Parameters.Add(new OracleParameter("userId", userId));

                    int rowsUpdated = command.ExecuteNonQuery();
                    Console.WriteLine($"{rowsUpdated} row(s) updated.");
                }
            }
        }

        public void InsertProduct(string name, string description, string category, string priceStr, string stockStr)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Product name cannot be null or empty.");
            }
            if (string.IsNullOrEmpty(priceStr) || !decimal.TryParse(priceStr, out decimal price) || price <= 0)
            {
                throw new ArgumentException("Invalid price. Price must be a positive number.");
            }
            if (string.IsNullOrEmpty(stockStr) || !int.TryParse(stockStr, out int stock))
            {
                throw new ArgumentException("Invalid stock. Stock must be a valid integer.");
            }

            StringBuilder query = new StringBuilder("INSERT INTO PRODUCTS (NAME, DESCRIPTION, CATEGORY, PRICE, STOCK) ");
            query.Append("VALUES (:name, :description, :category, :price, :stock)");
            ExecuteInsertProduct(query.ToString(), name, description, category, price, stock);
        }

        private void ExecuteInsertProduct(string query, string name, string description, string category, decimal price, int stock)
        {
            try
            {
                Database database = new Database();
                using (OracleConnection connection = database.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("name", name));
                        command.Parameters.Add(new OracleParameter("description", description));
                        command.Parameters.Add(new OracleParameter("category", category));
                        command.Parameters.Add(new OracleParameter("price", price));
                        command.Parameters.Add(new OracleParameter("stock", stock));
                        int rowsInserted = command.ExecuteNonQuery();
                        if (rowsInserted > 0)
                        {
                            string message = $"Product '{name}' has been successfully inserted into the database.\n"
                       + $"Category: {category ?? "N/A"}\n"
                       + $"Price: {price:C}\n"
                       + $"Stock: {stock}";
                            MessageBox.Show(message, "Product Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            Console.WriteLine("No rows inserted.");
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                Console.WriteLine("An error occurred while inserting the product: " + ex.Message);
            }
        }

        public void UpdateProduct(string productId, string name, string description, string category, string priceStr, string stockStr)
        {
            if (string.IsNullOrEmpty(productId))
            {
                throw new ArgumentException("Product ID cannot be null or empty.");
            }
            StringBuilder query = new StringBuilder("UPDATE PRODUCTS SET ");
            bool hasFieldsToUpdate = false;
            if (!string.IsNullOrEmpty(name))
            {
                query.Append("NAME = :name");
                hasFieldsToUpdate = true;
            }
            if (!string.IsNullOrEmpty(description))
            {
                if (hasFieldsToUpdate) query.Append(", ");
                query.Append("DESCRIPTION = :description");
                hasFieldsToUpdate = true;
            }
            if (!string.IsNullOrEmpty(category))
            {
                if (hasFieldsToUpdate) query.Append(", ");
                query.Append("CATEGORY = :category");
                hasFieldsToUpdate = true;
            }
            if (!string.IsNullOrEmpty(priceStr) && decimal.TryParse(priceStr, out decimal price))
            {
                if (hasFieldsToUpdate) query.Append(", ");
                query.Append("PRICE = :price");
                hasFieldsToUpdate = true;
            }
            if (!string.IsNullOrEmpty(stockStr) && int.TryParse(stockStr, out int stock))
            {
                if (hasFieldsToUpdate) query.Append(", ");
                query.Append("STOCK = :stock");
                hasFieldsToUpdate = true;
            }
            if (!hasFieldsToUpdate)
            {
                throw new InvalidOperationException("No valid fields provided to update.");
            }
            query.Append(" WHERE PRODUCTID = :productId");
            ExecuteUpdateProduct(query.ToString(), productId, name, description, category, priceStr, stockStr);
        }

        private void ExecuteUpdateProduct(string query, string productId, string name, string description, string category, string priceStr, string stockStr)
        {
            try
            {
                decimal parsedPrice = 0;
                int parsedStock = 0;
                Database database = new Database();
                using (OracleConnection connection = database.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (!string.IsNullOrEmpty(name))
                            command.Parameters.Add(new OracleParameter("name", name));
                        if (!string.IsNullOrEmpty(description))
                            command.Parameters.Add(new OracleParameter("description", description));
                        if (!string.IsNullOrEmpty(category))
                            command.Parameters.Add(new OracleParameter("category", category));
                        if (!string.IsNullOrEmpty(priceStr) && decimal.TryParse(priceStr, out parsedPrice))
                            command.Parameters.Add(new OracleParameter("price", parsedPrice));
                        if (!string.IsNullOrEmpty(stockStr) && int.TryParse(stockStr, out parsedStock))
                            command.Parameters.Add(new OracleParameter("stock", parsedStock));
                        command.Parameters.Add(new OracleParameter("productId", productId));
                        int rowsUpdated = command.ExecuteNonQuery();
                        if (rowsUpdated > 0)
                        {
                            string message = $"Product with ID '{productId}' has been successfully updated.\n"
                                           + $"Updated Fields:\n"
                                           + $"{(string.IsNullOrEmpty(name) ? "" : $"Name: {name}\n")}"
                                           + $"{(string.IsNullOrEmpty(description) ? "" : $"Description: {description}\n")}"
                                           + $"{(string.IsNullOrEmpty(category) ? "" : $"Category: {category}\n")}"
                                           + $"{(string.IsNullOrEmpty(priceStr) ? "" : $"Price: {parsedPrice:C}\n")}"
                                           + $"{(string.IsNullOrEmpty(stockStr) ? "" : $"Stock: {parsedStock}")}";
                            MessageBox.Show(message, "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows updated. Product ID may not exist.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"An error occurred while updating the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteProduct(string productId)
        {
            if (string.IsNullOrEmpty(productId))
            {
                throw new ArgumentException("Product ID cannot be null or empty.");
            }
            StringBuilder query = new StringBuilder("DELETE FROM PRODUCTS WHERE PRODUCTID = :productId");
            try
            {
                Database database = new Database();
                using (OracleConnection connection = database.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query.ToString(), connection))
                    {
                        command.Parameters.Add(new OracleParameter("productId", productId));
                        int rowsDeleted = command.ExecuteNonQuery();
                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show($"Product with ID '{productId}' has been successfully deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No rows deleted. Product ID may not exist.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                MessageBox.Show($"An error occurred while deleting the product: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ExecuteDeleteProduct(query.ToString(), productId);
        }

        private void ExecuteDeleteProduct(string query, string productId)
        {
            try
            {
                Database database = new Database();
                using (OracleConnection connection = database.GetConnection())
                {
                    connection.Open();
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter("productId", productId));
                        int rowsDeleted = command.ExecuteNonQuery();
                        if (rowsDeleted > 0)
                        {
                            string message = $"The product with ID '{productId}' has been successfully deleted from the database.";
                            MessageBox.Show(message, "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            string message = $"No product found with ID '{productId}'. Deletion was not performed.";
                            MessageBox.Show(message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
            }
            catch (OracleException ex)
            {
                string errorMessage = $"An error occurred while deleting the product:\n{ex.Message}";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
