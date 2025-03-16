using System;
using System.Drawing;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class ShipmentStatus : Form
    {
        private string role;
        private string username;
        private ShipmentManager shipmentManager; 

        public ShipmentStatus(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            shipmentManager = new ShipmentManager();
            cmbStatus.Items.Add("Pending");
            cmbStatus.Items.Add("In Transit");
            cmbStatus.Items.Add("Delivered");
            cmbStatus.SelectedIndex = 0;
            LoadShipmentsData();
        }

        private void btnUpdateStatus_Click(object sender, EventArgs e)
        {
            string shipmentID = txtShipmentID.Text;
            string newStatus = cmbStatus.SelectedItem.ToString();

            if (string.IsNullOrEmpty(shipmentID))
            {
                lblMessage.Text = "Please enter a shipment ID.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            bool isUpdated = shipmentManager.UpdateShipmentStatus(shipmentID, newStatus);

            if (isUpdated)
            {
                lblMessage.Text = "Shipment status updated successfully.";
                lblMessage.ForeColor = Color.Green;
                LoadShipmentsData(); 
            }
            else
            {
                lblMessage.Text = "Error: Shipment not found or update failed.";
                lblMessage.ForeColor = Color.Red;
            }
        }

        private void LoadShipmentsData()
        {
            try
            {
                var shipmentsData = shipmentManager.GetShipmentsData();
                dgvShipments.DataSource = shipmentsData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dgvShipments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void ShipmentStatus_Load(object sender, EventArgs e)
        {
           
        }
    }
}
