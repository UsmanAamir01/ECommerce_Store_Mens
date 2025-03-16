using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ManageProduct : Form
    {
        private string role;
        private string username;
        public ManageProduct(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProducts viewProducts = new ViewProducts(role, username);
            this.Hide();
            viewProducts.Show();
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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.InsertProduct(txtProductName.Text, txtProductDescription.Text, cmbCategory.Text, txtProductPrice.Text, txtProductStock.Text);
        }

        private void txtProductID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.DeleteProduct(txtProductID.Text);
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.UpdateProduct(txtProductID.Text,txtProductName.Text, txtProductDescription.Text, cmbCategory.Text, txtProductPrice.Text, txtProductStock.Text);

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClearProduct_Click(object sender, EventArgs e)
        {
            txtProductID.Text = string.Empty;      
            txtProductName.Text = string.Empty;          
            txtProductDescription.Text = string.Empty;     
            cmbCategory.Text = string.Empty;      
            txtProductPrice.Text = string.Empty;           
            txtProductStock.Text = string.Empty;
            cmbCategory.SelectedIndex = -1;       
            
        }

        private void ManageProduct_Load(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
