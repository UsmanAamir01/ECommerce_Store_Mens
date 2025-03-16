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
    public partial class Roles : Form
    {
        private string role;
        private string username;
        public Roles(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPortal adminPortal = new AdminPortal(role, username);
            this.Hide();
            adminPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnEditCashier_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.UpdateUser(txtCashierID.Text, txtCashierUsername.Text, txtCashierEmail.Text, txtCashierPhoneNo.Text, txtCashierSalary.Text);
        }

        private void txtCashierID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashierName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashierEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashierPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCashierSalary_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEditManager_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.UpdateUser(txtManagerID.Text, txtManagerUsername.Text, txtManagerEmail.Text, txtManagerPhoneNo.Text, txtManagerSalary.Text);
        }

        private void btnEditDeliveryPersonnel_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.UpdateUser(txtDeliveryPersonID.Text, txtDeliveryPersonUsername.Text, txtDeliveryPersonEmail.Text, txtDeliveryPersonPhoneNo.Text, txtDeliveryPersonSalary.Text);
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            Store store = new Store();
            store.UpdateUser(txtCustomerID.Text, txtCustomerUsername.Text, txtCustomerEmail.Text, txtCustomerPhoneNo.Text);
        }
    }
}