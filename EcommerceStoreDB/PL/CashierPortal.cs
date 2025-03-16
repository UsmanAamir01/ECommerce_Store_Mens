using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcommerceStoreDB
{
    public partial class CashierPortal : Form
    {
        private String username;
        private String role;
        public CashierPortal(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
           
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnViewOrders_Click(object sender, EventArgs e)
        {
            ViewOrder viewOrder = new ViewOrder(role,username);
            this.Hide();
            viewOrder.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            CashierProfile cashierProfile = new CashierProfile(role,username);
            this.Hide();
            cashierProfile.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            GenerateInvoice generateInvoice = new GenerateInvoice(role, username);
            this.Hide();
            generateInvoice.Show();
        }

        private void btnRefundProcessing_Click(object sender, EventArgs e)
        {
            ViewRefunds viewRefunds = new ViewRefunds(role,username);
            this.Hide(); 
            viewRefunds.Show();
        }

        
    }
}
