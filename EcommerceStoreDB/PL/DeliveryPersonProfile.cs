// UI/DeliveryPersonProfile.cs
using EcommerceStoreDB.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class DeliveryPersonProfile : Form
    {
        private string role;
        private string username;
        private DeliveryPersonBLL deliveryPersonBLL = new DeliveryPersonBLL();

        public DeliveryPersonProfile(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
            SetFieldsEditable(false);
            LoadDeliveryPersonDetails();
        }

        private void LoadDeliveryPersonDetails()
        {
            try
            {
                var details = deliveryPersonBLL.GetDeliveryPersonDetails(username);

                txtFirstName.Text = details["FIRSTNAME"];
                txtLastName.Text = details["LASTNAME"];
                txtEmail.Text = details["EMAIL"];
                txtPhoneNo.Text = details["PHONENUMBER"];
                txtAddress.Text = details["ADDRESS"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading delivery person details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) && string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                string.IsNullOrWhiteSpace(txtLastName.Text) && string.IsNullOrWhiteSpace(txtPhoneNo.Text) &&
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill in at least one field to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtEmail.Text) && !IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email format.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtPhoneNo.Text) && !long.TryParse(txtPhoneNo.Text, out _))
            {
                MessageBox.Show("Phone number must be numeric.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = deliveryPersonBLL.SaveDeliveryPersonDetails(username, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNo.Text, txtAddress.Text);

            if (success)
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetFieldsEditable(false);
            }
            else
            {
                MessageBox.Show("No changes were made.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
