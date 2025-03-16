using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using EcommerceStoreDB.BLL;
using EcommerceStoreDB.DAL;

namespace EcommerceStoreDB
{
    public partial class Settings : Form
    {
        private string role;
        private string username;
        private SettingsBLL settingsBLL;

        public Settings(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            this.settingsBLL = new SettingsBLL();
            lblUsername.Text = username;
        }

        private void btnUpdatePassword_Click(object sender, EventArgs e)
        {
            string currentPassword = txtCurrentPassword.Text;
            string newPassword = txtNewPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrWhiteSpace(currentPassword) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("All fields are required.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("New password and confirm password do not match.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Database db = new Database();
                using (OracleConnection conn = db.GetConnection())
                {
                    conn.Open();

                    // Verify the current password
                    if (!settingsBLL.VerifyPassword(username, currentPassword, conn))
                    {
                        MessageBox.Show("Current password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update the password
                    if (settingsBLL.UpdatePassword(username, newPassword, conn))
                    {
                        MessageBox.Show("Password updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void picHome_Click(object sender, EventArgs e)
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
        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation or feedback here if necessary
        }
        private void txtNewPassword_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation or feedback here if necessary
        }
        private void txtCurrentPassword_TextChanged(object sender, EventArgs e)
        {
            // Optional: Add real-time validation or feedback here if necessary
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }
    }
}
