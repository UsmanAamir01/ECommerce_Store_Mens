using EcommerceStoreDB.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ManageInventory : Form
    {
        private readonly InventoryManager _inventoryManager;
        private string role;
        private string username;

        public ManageInventory(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            _inventoryManager = new InventoryManager();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void dgvInventory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void dgvInventory_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (e.Exception != null)
            {
                MessageBox.Show($"Error: {e.Exception.Message}", "Data Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.ThrowException = false;
            }

            if (e.ColumnIndex == dgvInventory.Columns["NUM_PRODUCTS"].Index ||
                e.ColumnIndex == dgvInventory.Columns["NUM_CATEGORIES"].Index ||
                e.ColumnIndex == dgvInventory.Columns["TOTAL_ORDERS"].Index ||
                e.ColumnIndex == dgvInventory.Columns["CURRENT_STOCK"].Index)
            {
                if (!int.TryParse(e.RowIndex.ToString(), out int value) || value < 0)
                {
                    MessageBox.Show("Please enter a valid positive number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
        }
        private void LoadInventory()
        {
            try
            {
                DataTable dataTable = _inventoryManager.LoadInventory();

                if (dataTable.Rows.Count > 0)
                {
                    dgvInventory.DataSource = dataTable;

                    dgvInventory.Columns["INVENTORYID"].Width = 100;
                    dgvInventory.Columns["NUM_PRODUCTS"].Width = 150;
                    dgvInventory.Columns["NUM_CATEGORIES"].Width = 150;
                    dgvInventory.Columns["STATUS"].Width = 120;
                    dgvInventory.Columns["TOTAL_ORDERS"].Width = 120;
                    dgvInventory.Columns["CURRENT_STOCK"].Width = 150;
                    dgvInventory.Columns["PRODUCTID"].Width = 120;
                }
                else
                {
                    MessageBox.Show("No inventory data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ManageInventory_Load(object sender, EventArgs e)
        {
            LoadInventory();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
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