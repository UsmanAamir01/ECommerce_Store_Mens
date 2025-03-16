using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcommerceStoreDB
{
    public partial class ManagerPortal : Form
    {
        private String username;
        private String role;
        public ManagerPortal(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
          
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnGenerateReports_Click(object sender, EventArgs e)
        {
            Report report = new Report(role,username);
            this.Hide();
            report.Show();
        }

        

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            ManageProduct manageProduct = new ManageProduct(role, username);
            this.Hide();
            manageProduct.Show();
        }

        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            ManageOrders manageOrders = new ManageOrders(role, username);
            this.Hide();
            manageOrders.Show();
        }

        private void btnManageInventory_Click(object sender, EventArgs e)
        {
            ManageInventory manageInventory = new ManageInventory(role, username);
            this.Hide();
            manageInventory.Show();
        }

        

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void ManagerPortal_Load(object sender, EventArgs e)
        {

        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            ManagerProfile managerProfile = new ManagerProfile(role,username);
            this.Hide();
            managerProfile.Show();
        }
    }
}