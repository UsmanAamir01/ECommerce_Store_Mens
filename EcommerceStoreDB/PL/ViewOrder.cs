using System;
using System.Data;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class ViewOrder : Form
    {
        private string role;
        private string username;

        private OrderProcessor orderProcessor;

        public ViewOrder(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;

            orderProcessor = new OrderProcessor();

            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvViewOrder.Columns.Clear();

            dgvViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Order ID",
                DataPropertyName = "ORDERID",
                Name = "ColumnOrderID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                DataPropertyName = "USERID",
                Name = "ColumnUserID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Amount",
                DataPropertyName = "TOTALAMOUNT",
                Name = "ColumnTotalAmount",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "STATUS",
                Name = "ColumnStatus",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewOrder.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Order Date",
                DataPropertyName = "ORDERDATE",
                Name = "ColumnOrderDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewOrder.AutoGenerateColumns = false;
        }

        private void LoadOrderData()
        {
            try
            {
                DataTable dt = orderProcessor.GetOrderData();

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvViewOrder.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvViewOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CashierPortal cashierPortal = new CashierPortal(role, username);
            this.Hide();
            cashierPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void ViewOrder_Load(object sender, EventArgs e)
        {
            LoadOrderData();
        }
    }
}