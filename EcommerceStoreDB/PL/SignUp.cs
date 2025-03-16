using EcommerceStoreDB.BLL;
using EcommerceStoreDB.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class SignUp : Form
    {
        private readonly AuthLogic authLogic;
        public SignUp()
        {
            InitializeComponent();
            authLogic = new AuthLogic();
            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("DeliveryPerson");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Cashier");
            cmbRole.SelectedIndex = -1;
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNo.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    string.IsNullOrWhiteSpace(txtAddress.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtConfirmPassword.Text) ||
                    cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPassword.Text != txtConfirmPassword.Text)
                {
                    MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsStrongPassword(txtPassword.Text))
                {
                    MessageBox.Show("Password is not strong enough. It must be at least 8 characters long and include uppercase, lowercase, digits, and special characters.",
                                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidEmail(txtEmail.Text))
                {
                    MessageBox.Show("Please enter a valid email address.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!IsValidPhoneNumber(txtPhoneNo.Text))
                {
                    MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string selectedRole = cmbRole.SelectedItem.ToString();
                if (selectedRole == "Admin")
                {
                    MessageBox.Show("The Admin role can only be added manually. Please choose a different role.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = new User
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    PhoneNumber = txtPhoneNo.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Role = selectedRole
                };

                bool isSignedUp = authLogic.Signup(user);

                if (isSignedUp)
                {
                    MessageBox.Show("Sign-up successful! Please login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Sign-up failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void picLogo_Click(object sender, EventArgs e)
        {

        }

        private void SignUp_Load(object sender, EventArgs e)
        {
            CenterPanel8();
        }

        private bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;
            var emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(?<!\.)$";
            return Regex.IsMatch(email, emailRegex);
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {
            return !string.IsNullOrWhiteSpace(phoneNumber) &&
                   Regex.IsMatch(phoneNumber, @"^\d{10,15}$");
        }

        private bool IsStrongPassword(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
            return Regex.IsMatch(password, pattern);
        }

        private void SignUp_Resize(object sender, EventArgs e)
        {
            CenterPanel8();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblConfirmPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void CenterPanel8()
        {
            int panelWidth = panel8.Width;
            int panelHeight = panel8.Height;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            panel8.Left = (formWidth - panelWidth) / 2;
            panel8.Top = (formHeight - panelHeight) / 2;
        }
    }
}