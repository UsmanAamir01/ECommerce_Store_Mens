using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class AdminProfile : Form
    {
        private string role;
        private string username;
        private UserService userService = new UserService();

        public AdminProfile(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
            SetFieldsEditable(false);
            LoadAdminDetails();
        }

        private void LoadAdminDetails()
        {
            try
            {
                Dictionary<string, string> details = userService.GetAdminDetails(username);
                txtFirstName.Text = details["FIRSTNAME"];
                txtLastName.Text = details["LASTNAME"];
                txtEmail.Text = details["EMAIL"];
                txtPhoneNo.Text = details["PHONENUMBER"];
                txtAddress.Text = details["ADDRESS"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading admin details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (userService.UpdateAdminDetails(
                        username,
                        txtFirstName.Text,
                        txtLastName.Text,
                        txtEmail.Text,
                        txtPhoneNo.Text,
                        txtAddress.Text))
                {
                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetFieldsEditable(false);
                }
                else
                {
                    MessageBox.Show("No changes were made.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving changes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {
        }

        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetFieldsEditable(true);
        }

    }

}
