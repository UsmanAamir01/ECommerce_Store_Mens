using System;
using System.Data;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class ViewOrderHistory : Form
    {
        private string role;
        private string username;
        private readonly OrderHandler _orderHandler;

        public ViewOrderHistory(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            _orderHandler = new OrderHandler();
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

        private void LoadOrderHistory()
        {
            try
            {
                DataTable orderHistory = _orderHandler.GetOrderHistory(username);

                if (orderHistory.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvViewOrderHistory.AutoGenerateColumns = true;
                dgvViewOrderHistory.DataSource = orderHistory;

                dgvViewOrderHistory.Columns["ORDERID"].HeaderText = "Order ID";
                dgvViewOrderHistory.Columns["TOTALAMOUNT"].HeaderText = "Total Amount";
                dgvViewOrderHistory.Columns["STATUS"].HeaderText = "Order Status";
                dgvViewOrderHistory.Columns["ORDERDATE"].HeaderText = "Order Date";

                dgvViewOrderHistory.Columns["ORDERDATE"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order history: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewOrderHistory_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }
        private void dgvViewOrderHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
