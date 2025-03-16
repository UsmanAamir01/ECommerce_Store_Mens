using EcommerceStoreDB.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ManageOrders : Form
    {
        private string role;
        private string username;
        private OrderManager orderManager;

        public ManageOrders(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            orderManager = new OrderManager();
        }

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable ordersTable = orderManager.GetOrders();
                dgvOrders.DataSource = ordersTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}");
            }
        }

        private void dgvOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvOrders.Rows[e.RowIndex];
                    txtOrderID.Text = selectedRow.Cells["ORDERID"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while handling the cell click: {ex.Message}");
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }
        private void btnRefund_Click(object sender, EventArgs e)
        {

        }
        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrdersofManager viewOrderManager = new ViewOrdersofManager(role, username);
            this.Hide();
            viewOrderManager.Show();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnNotify_Click(object sender, EventArgs e)
        {
            ViewNotifications viewNotifications = new ViewNotifications(role, username);
            this.Hide();
            viewNotifications.Show();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }
    }
}
