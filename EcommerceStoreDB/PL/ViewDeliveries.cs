using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ViewDeliveries : Form
    {
        private string role;
        private string username;
        private DeliveryBLL deliveryBLL;

        public ViewDeliveries(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            deliveryBLL = new DeliveryBLL();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            dgvViewDelivery.Columns.Clear();
            dgvViewDelivery.AutoGenerateColumns = false;
            dgvViewDelivery.AllowUserToAddRows = false;

            dgvViewDelivery.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DELIVERYID",
                HeaderText = "Delivery ID",
                DataPropertyName = "DELIVERYID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewDelivery.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "SHIPMENTID",
                HeaderText = "Shipment ID",
                DataPropertyName = "SHIPMENTID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewDelivery.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DELIVERYPERSONID",
                HeaderText = "Delivery Person ID",
                DataPropertyName = "DELIVERYPERSONID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewDelivery.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DELIVERYDATE",
                HeaderText = "Delivery Date",
                DataPropertyName = "DELIVERYDATE",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewDelivery.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DELIVERYSTATUS",
                HeaderText = "Delivery Status",
                DataPropertyName = "DELIVERYSTATUS",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvViewDelivery.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DELIVERYADDRESS",
                HeaderText = "Delivery Address",
                DataPropertyName = "DELIVERYADDRESS",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private void LoadDeliveries()
        {
            try
            {
                DataTable dt = deliveryBLL.LoadDeliveries();
                dgvViewDelivery.DataSource = dt;  
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            DeliveryPersonPortal deliveryPersonPortal = new DeliveryPersonPortal(role, username);
            this.Hide();
            deliveryPersonPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void dgvViewDelivery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewDeliveries_Load_1(object sender, EventArgs e)
        {
            LoadDeliveries();  
        }
    }
}
