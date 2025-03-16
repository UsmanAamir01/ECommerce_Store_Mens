using EcommerceStoreDB.BLL;
using EcommerceStoreDB.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EcommerceStoreDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            cmbRole.Items.Add("Customer");
            cmbRole.Items.Add("Admin");
            cmbRole.Items.Add("DeliveryPerson");
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Cashier");
            cmbRole.SelectedIndex = -1;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void lblSignUpLink_Click(object sender, System.EventArgs e)
        {
            SignUp signUp = new SignUp();
            this.Hide();
            signUp.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (cmbRole.SelectedIndex != -1 && !string.IsNullOrEmpty(txtUsername.Text) && !string.IsNullOrEmpty(txtPassword.Text))
            {
                string selectedRole = cmbRole.SelectedItem.ToString();
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                if (!IsPasswordStrong(password))
                {
                    MessageBox.Show("Password is not strong enough. Use at least 8 characters including uppercase, lowercase, digits, and special characters.",
                                    "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                AuthLogic authLogic = new AuthLogic();
                User loggedInUser = authLogic.Login(username, password, selectedRole);

                if (loggedInUser != null)
                {
                    if (selectedRole == "Admin")
                    {
                        AdminPortal adminPortal = new AdminPortal(selectedRole, username);
                        this.Hide();
                        adminPortal.Show();
                    }
                    else if (selectedRole == "Customer")
                    {
                        Dashboard dashboard = new Dashboard(selectedRole, username);
                        this.Hide();
                        dashboard.Show();
                    }
                    else if (selectedRole == "Cashier")
                    {
                        CashierPortal cashierPortal = new CashierPortal(selectedRole, username);
                        this.Hide();
                        cashierPortal.Show();
                    }
                    else if (selectedRole == "DeliveryPerson")
                    {
                        DeliveryPersonPortal deliveryPersonPortal = new DeliveryPersonPortal(selectedRole, username);
                        this.Hide();
                        deliveryPersonPortal.Show();
                    }
                    else if (selectedRole == "Manager")
                    {
                        ManagerPortal managerPortal = new ManagerPortal(selectedRole, username);
                        this.Hide();
                        managerPortal.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role. Please try again.", "Login Failed");
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields (Username, Password, and Role).", "Missing Information");
            }
        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chbLogin.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtUsername_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, System.EventArgs e)
        {

        }

        private void cmbRole_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void picUserProfile_Click(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CenterPanel()
        {
            int panelWidth = panel3.Width;
            int panelHeight = panel3.Height;
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            panel3.Left = (formWidth - panelWidth) / 2;
            panel3.Top = (formHeight - panelHeight) / 2;
        }

        private void Login_Resize(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void picKey_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            if (!IsPasswordStrong(password))
            {
                MessageBox.Show("Your password is too weak! Please use a stronger password with at least 8 characters, including uppercase, lowercase, digits, and special characters.",
                                "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("Your password is strong. Proceeding with the login process.", "Strong Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private bool IsPasswordStrong(string password)
        {
            string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            return Regex.IsMatch(password, pattern);
        }
    }
}