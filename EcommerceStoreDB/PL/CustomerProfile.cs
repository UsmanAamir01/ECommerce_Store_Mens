// Presentation Layer: CustomerProfile.cs
using System;
using System.Drawing;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;
using EcommerceStoreDB.Models;

namespace EcommerceStoreDB
{
    public partial class CustomerProfile : Form
    {
        private string role;
        private string username;
        private CustomerBLL customerBLL = new CustomerBLL();

        public CustomerProfile(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
            SetFieldsEditable(false);
            LoadCustomerDetails();
        }

        private void LoadCustomerDetails()
        {
            try
            {
                var customer = customerBLL.GetCustomerDetails(username);
                if (customer != null)
                {
                    txtFirstName.Text = customer.FirstName;
                    txtLastName.Text = customer.LastName;
                    txtEmail.Text = customer.Email;
                    txtPhoneNo.Text = customer.PhoneNumber;
                    txtAddress.Text = customer.Address;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading customer details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFieldsEditable(bool isEditable)
        {
            txtFirstName.ReadOnly = !isEditable;
            txtLastName.ReadOnly = !isEditable;
            txtEmail.ReadOnly = !isEditable;
            txtPhoneNo.ReadOnly = !isEditable;
            txtAddress.ReadOnly = !isEditable;

            Color editableColor = isEditable ? Color.LightGray : Color.White;
            txtFirstName.BackColor = editableColor;
            txtLastName.BackColor = editableColor;
            txtEmail.BackColor = editableColor;
            txtPhoneNo.BackColor = editableColor;
            txtAddress.BackColor = editableColor;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetFieldsEditable(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var customer = new Customer
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    PhoneNumber = txtPhoneNo.Text.Trim(),
                    Address = txtAddress.Text.Trim()
                };

                bool result = customerBLL.UpdateCustomerProfile(username, customer);
                if (result)
                {
                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetFieldsEditable(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
