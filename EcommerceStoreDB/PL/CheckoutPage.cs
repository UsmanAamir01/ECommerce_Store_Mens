using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    public partial class CheckoutPage : Form
    {
        private string role;
        private string username;
        private int userId;

        private Database db = new Database(); 
        private decimal price;
        private string description;
        private string imagePath;

        public CheckoutPage(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;

            LoadCustomerId();
        }

        private void CheckoutPage_Load(object sender, EventArgs e)
        {
            LoadUserDetails();
            LoadOrderDetails();
        }

        private void LoadCustomerId()
        {
            string query = @"SELECT USERID FROM USERS WHERE USERNAME = :Username AND ROLE = 'Customer'";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":Username", username));

                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            userId = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Customer not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (OracleException ex) when (ex.Number == 942) 
            {
                MessageBox.Show("The USERS table or schema is missing. Please verify your database setup.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while fetching the customer ID: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserDetails()
        {
            string query = @"SELECT FirstName || ' ' || LastName AS Name, Email, PhoneNumber, Address
                             FROM USERS WHERE USERID = :UserID";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":UserID", userId));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["Name"]?.ToString() ?? string.Empty;
                                textBox2.Text = reader["Email"]?.ToString() ?? string.Empty;
                                textBox3.Text = reader["PhoneNumber"]?.ToString() ?? string.Empty;
                                textBox4.Text = reader["Address"]?.ToString() ?? string.Empty;
                            }
                            else
                            {
                                MessageBox.Show("No user found with the specified ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (OracleException ex) when (ex.Number == 942) 
            {
                MessageBox.Show("The USERS table or schema is missing. Please verify your database setup.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading user details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadOrderDetails()
        {
            string query = @"SELECT ORDERID, TOTALAMOUNT, STATUS, TO_CHAR(ORDERDATE, 'YYYY-MM-DD HH24:MI:SS') AS ORDERDATE
                             FROM ORDERS WHERE USERID = :UserID";

            try
            {
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":UserID", userId));

                        using (OracleDataReader reader = command.ExecuteReader())
                        {
                            var dataTable = new System.Data.DataTable();
                            dataTable.Load(reader);

                            dgvCheckout.DataSource = dataTable; 
                        }
                    }
                }
            }
            catch (OracleException ex) when (ex.Number == 942)
            {
                MessageBox.Show("The ORDERS table or schema is missing. Please verify your database setup.", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbtnDebitCard_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnCreditCard_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void rbtnCashOnDelivery_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void dgvCheckout_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

 
        private int CustomerID(string username1)
        {
            using (OracleConnection connection = db.GetConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT userid FROM users WHERE username = :username1";
                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        command.Parameters.Add(new OracleParameter(":username1", username1));

                        object result = command.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int userid))
                        {
                            return userid;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to load user ID: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return -1;
                }
            }
        }




        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            if (dgvCheckout.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to place.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow selectedRow = dgvCheckout.SelectedRows[0];
            string orderId = selectedRow.Cells["ORDERID"].Value.ToString();
            int orderUserId = CustomerID("Ramis");

            if (orderUserId <= 0)
            {
                MessageBox.Show("The user ID could not be retrieved or is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; 
            }

            if (orderUserId == -1)
            {
                MessageBox.Show("Invalid user or user does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId = -1;
            using (OracleConnection connection = db.GetConnection())
            {
                connection.Open();
                string fetchUserIdQuery = "SELECT USERID FROM USERS WHERE ROLE = 'customer' AND USERID = :UserId";
                using (OracleCommand fetchUserCmd = new OracleCommand(fetchUserIdQuery, connection))
                {
                    fetchUserCmd.Parameters.Add(new OracleParameter("UserId", orderUserId));

                    object result = fetchUserCmd.ExecuteScalar();

                    if (result != null && int.TryParse(result.ToString(), out int fetchedUserId))
                    {
                        userId = fetchedUserId;
                    }
                }
                userId = 126;

                if (userId == -1)
                {
                    MessageBox.Show("The user is not a customer or does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string carrier = "FedEx"; 
            string trackingNumber = Guid.NewGuid().ToString().Substring(0, 10); 

            string paymentMethod = rbtnCreditCard.Checked ? "CreditCard" :
                                   rbtnPaypal.Checked ? "DebitCard" : "CashOnDelivery";

            DateTime deliveryDate = DateTime.Now.AddDays(3); 

            using (OracleConnection connection = db.GetConnection())
            {
                connection.Open();
                OracleTransaction transaction = connection.BeginTransaction();
                try
                {
                    string insertPaymentQuery = @"INSERT INTO PAYMENTS (PAYMENTID, ORDERID, PAYMENTMETHOD, PAYMENTDATE) 
VALUES (PAYMENT_SEQ.NEXTVAL, :OrderId, :PaymentMethod, CURRENT_TIMESTAMP)";
                    using (OracleCommand paymentCmd = new OracleCommand(insertPaymentQuery, connection))
                    {
                        paymentCmd.Transaction = transaction;
                        paymentCmd.Parameters.Add(new OracleParameter("OrderId", orderId));
                        paymentCmd.Parameters.Add(new OracleParameter("PaymentMethod", paymentMethod));
                        paymentCmd.ExecuteNonQuery();
                    }
                    
                    string insertShipmentQuery = @"INSERT INTO SHIPMENTS (SHIPMENTID, ORDERID, CARRIER, TRACKINGNUMBER, SHIPPEDDATE, DELIVERYDATE) 
 VALUES (SHIPMENT_SEQ.NEXTVAL, :OrderId, :Carrier, :TrackingNumber, CURRENT_TIMESTAMP, :DeliveryDate)";
                    using (OracleCommand shipmentCmd = new OracleCommand(insertShipmentQuery, connection))
                    {
                        shipmentCmd.Transaction = transaction;
                        shipmentCmd.Parameters.Add(new OracleParameter("OrderId", orderId));
                        shipmentCmd.Parameters.Add(new OracleParameter("Carrier", carrier));
                        shipmentCmd.Parameters.Add(new OracleParameter("TrackingNumber", trackingNumber));
                        shipmentCmd.Parameters.Add(new OracleParameter("DeliveryDate", deliveryDate)); // Add delivery date
                        shipmentCmd.ExecuteNonQuery();
                    }

                    int deliveryPersonId = -1;
                    string fetchDeliveryPersonQuery = "SELECT USERID FROM USERS WHERE ROLE = 'DeliveryPerson'"; // Fetch the first delivery person
                    using (OracleCommand fetchDeliveryPersonCmd = new OracleCommand(fetchDeliveryPersonQuery, connection))
                    {
                        object result = fetchDeliveryPersonCmd.ExecuteScalar();
                        if (result != null && int.TryParse(result.ToString(), out int fetchedDeliveryPersonId))
                        {
                            deliveryPersonId = fetchedDeliveryPersonId;
                        }
                    }

                    if (deliveryPersonId == -1)
                    {
                        MessageBox.Show("No delivery person found or there is an issue with the delivery person assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

         
                    {
                        string deliveryAddress = "DHA PHASE V"; 
                        string insertDeliveryQuery = @"INSERT INTO DELIVERY (DELIVERYID, SHIPMENTID, DELIVERYPERSONID, DELIVERYDATE, DELIVERYSTATUS, DELIVERYADDRESS)
                                VALUES (DELIVERY_SEQ.NEXTVAL, (SELECT SHIPMENTID FROM SHIPMENTS WHERE ORDERID = :OrderId), :DeliveryPersonId, :DeliveryDate, 'Pending', :DeliveryAddress)";

                        using (OracleCommand deliveryCmd = new OracleCommand(insertDeliveryQuery, connection))
                        {
                            deliveryCmd.Transaction = transaction;
                            deliveryCmd.Parameters.Add(new OracleParameter("OrderId", orderId));
                            deliveryCmd.Parameters.Add(new OracleParameter("DeliveryPersonId", deliveryPersonId));
                            deliveryCmd.Parameters.Add(new OracleParameter("DeliveryDate", deliveryDate)); 
                            deliveryCmd.Parameters.Add(new OracleParameter("DeliveryAddress", deliveryAddress)); 
                            deliveryCmd.ExecuteNonQuery();
                        }



                        transaction.Commit();
                        MessageBox.Show("Order placed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LoadOrderDetails();
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"An error occurred while placing the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }







        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (dgvCheckout.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an order to cancel.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int orderId = Convert.ToInt32(dgvCheckout.SelectedRows[0].Cells["ORDERID"].Value);

                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string checkOrderQuery = "SELECT STATUS FROM ORDERS WHERE ORDERID = :OrderId";
                    string orderStatus = null;

                    using (OracleCommand checkOrderCommand = new OracleCommand(checkOrderQuery, connection))
                    {
                        checkOrderCommand.Parameters.Add(new OracleParameter(":OrderId", orderId));
                        using (OracleDataReader reader = checkOrderCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                orderStatus = reader["STATUS"]?.ToString();
                            }
                        }
                    }

                    if (string.IsNullOrEmpty(orderStatus))
                    {
                        MessageBox.Show("The selected order does not exist in the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (orderStatus.Equals("Shipping", StringComparison.OrdinalIgnoreCase))
                    {
                        MessageBox.Show("Cannot cancel an order that is already in 'Shipping' status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string deleteOrderQuery = "DELETE FROM ORDERS WHERE ORDERID = :OrderId";
                    using (OracleCommand deleteOrderCommand = new OracleCommand(deleteOrderQuery, connection))
                    {
                        deleteOrderCommand.Parameters.Add(new OracleParameter(":OrderId", orderId));
                        int rowsDeleted = deleteOrderCommand.ExecuteNonQuery();

                        if (rowsDeleted > 0)
                        {
                            MessageBox.Show("Order and its associated details were successfully cancelled.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadOrderDetails();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the order. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while cancelling the order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }
    }
}
