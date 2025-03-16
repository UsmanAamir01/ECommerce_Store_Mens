using EcommerceStoreDB.BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ManagerProfile : Form
    {
        private readonly ManagerProfileBO profileBO = new ManagerProfileBO();
        private readonly string username;

        public ManagerProfile(string role, string username)
        {
            InitializeComponent();
            this.username = username;
            lblUsername.Text = username;
            SetFieldsEditable(false);
            LoadManagerDetails();
        }

        private void LoadManagerDetails()
        {
            try
            {
                Dictionary<string, string> details = profileBO.GetProfileDetails(username);
                txtFirstName.Text = details.TryGetValue("FirstName", out string firstName) ? firstName : string.Empty;
                txtLastName.Text = details.TryGetValue("LastName", out string lastName) ? lastName : string.Empty;
                txtEmail.Text = details.TryGetValue("Email", out string email) ? email : string.Empty;
                txtPhoneNo.Text = details.TryGetValue("PhoneNumber", out string phoneNo) ? phoneNo : string.Empty;
                txtAddress.Text = details.TryGetValue("Address", out string address) ? address : string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading profile details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                profileBO.UpdateProfile(username, txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhoneNo.Text, txtAddress.Text);
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetFieldsEditable(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving profile: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal("Manager", username);
            this.Hide();
            managerPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
