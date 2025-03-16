using EcommerceStoreDB.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class CashierProfile : Form
    {
        private string role;
        private string username;
        private CashierService cashierService = new CashierService();

        public CashierProfile(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
            SetFieldsEditable(false);
            LoadCashierDetails();
        }

        private void LoadCashierDetails()
        {
            try
            {
                DataRow cashierDetails = cashierService.GetCashierDetails(username);

                if (cashierDetails != null)
                {
                    txtFirstName.Text = cashierDetails["FIRSTNAME"].ToString();
                    txtLastName.Text = cashierDetails["LASTNAME"].ToString();
                    txtEmail.Text = cashierDetails["EMAIL"].ToString();
                    txtPhoneNo.Text = cashierDetails["PHONENUMBER"].ToString();
                    txtAddress.Text = cashierDetails["ADDRESS"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading cashier details: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            CashierPortal cashierPortal = new CashierPortal(role, username);
            this.Hide();
            cashierPortal.Show();
        }

        // CashierProfile.cs
        private void btnSave_Click_1(object sender, EventArgs e)
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

            bool isUpdated = cashierService.UpdateCashierDetails(
                username,
                txtFirstName.Text.Trim(),
                txtLastName.Text.Trim(),
                txtEmail.Text.Trim(),
                txtPhoneNo.Text.Trim(),
                txtAddress.Text.Trim()
            );

            if (isUpdated)
            {
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetFieldsEditable(false); 
            }
            else
            {
                MessageBox.Show("No changes were made or update failed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            SetFieldsEditable(true);
        }

        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
