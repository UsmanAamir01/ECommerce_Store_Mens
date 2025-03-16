using EcommerceStoreDB.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ViewOrdersofManager : Form
    {
        private string role;
        private string username;
        private OrderService orderService;

        public ViewOrdersofManager(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            this.orderService = new OrderService();
        }

        private void LoadOrders()
        {
            try
            {
                DataTable orders = orderService.GetAllOrders();
                if (orders.Rows.Count > 0)
                {
                    dgvViewOrderManager.DataSource = orders;

                    dgvViewOrderManager.AutoGenerateColumns = false;

                    dgvViewOrderManager.Columns.Clear();

                    dgvViewOrderManager.Columns.Add("ORDERID", "Order ID");
                    dgvViewOrderManager.Columns["ORDERID"].DataPropertyName = "ORDERID";
                    dgvViewOrderManager.Columns["ORDERID"].Width = 100;

                    dgvViewOrderManager.Columns.Add("USERID", "User ID");
                    dgvViewOrderManager.Columns["USERID"].DataPropertyName = "USERID";
                    dgvViewOrderManager.Columns["USERID"].Width = 100;

                    dgvViewOrderManager.Columns.Add("TOTALAMOUNT", "Total Amount");
                    dgvViewOrderManager.Columns["TOTALAMOUNT"].DataPropertyName = "TOTALAMOUNT";
                    dgvViewOrderManager.Columns["TOTALAMOUNT"].Width = 150;
                    dgvViewOrderManager.Columns["TOTALAMOUNT"].DefaultCellStyle.Format = "C2";

                    dgvViewOrderManager.Columns.Add("STATUS", "Status");
                    dgvViewOrderManager.Columns["STATUS"].DataPropertyName = "STATUS";
                    dgvViewOrderManager.Columns["STATUS"].Width = 150;

                    dgvViewOrderManager.Columns.Add("ORDERDATE", "Order Date");
                    dgvViewOrderManager.Columns["ORDERDATE"].DataPropertyName = "ORDERDATE";
                    dgvViewOrderManager.Columns["ORDERDATE"].Width = 200;
                }
                else
                {
                    MessageBox.Show("No orders found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvViewOrderManager_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ViewOrders_Manager__Load_1(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders(role, username);
            this.Hide();
            manageOrders.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }
    }
}
