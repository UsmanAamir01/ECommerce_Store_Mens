using EcommerceStoreDB.DAL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ViewProducts : Form
    {
        private string role;
        private string username;
        private ProductService productService;

        public ViewProducts(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            this.productService = new ProductService(); // Initialize the BLL
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(role, username);
            this.Hide();
            manageProduct.Show();
        }

        private void LoadProducts()
        {
            try
            {
                DataTable products = productService.GetAllProducts();
                dgvViewProducts.DataSource = products;
                dgvViewProducts.AutoGenerateColumns = true;
                dgvViewProducts.ReadOnly = true;
                dgvViewProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading products: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }
        private void dgvViewProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductID");
            dt.Columns.Add("ProductName");
            dt.Columns.Add("ProductCategory");
            dt.Columns.Add("ProductPrice");
            dt.Columns.Add("ProductStock");
            dt.Columns.Add("PRODUCTID");
            dt.Columns.Add("NAME");
            dt.Columns.Add("DESCRIPTION");
            dgvViewProducts.DataSource = dt;
            dgvViewProducts.AutoGenerateColumns = true;
            dgvViewProducts.ReadOnly = true;
            dgvViewProducts.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void pbHome_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }
    }
}
