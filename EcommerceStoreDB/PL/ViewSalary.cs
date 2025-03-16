using System;
using System.Data;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class ViewSalary : Form
    {
        private readonly SalaryManager salaryManager;
        private string role;
        private string username;

        public ViewSalary(string role, string username)
        {
            InitializeComponent();
            salaryManager = new SalaryManager();
            this.role = role;
            this.username = username;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRole = cmbRole.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(selectedRole))
            {
                LoadSalaryData(selectedRole);
            }
        }

        private void LoadSalaryData(string role)
        {
            try
            {
                DataTable salaryData = salaryManager.GetSalariesByRole(role);

                ConfigureDataGridView();
                dgvSalary.DataSource = salaryData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving salary data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void dgvSalary_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ConfigureDataGridView()
        {
            dgvSalary.Columns.Clear();

            dgvSalary.AutoGenerateColumns = false;

            dgvSalary.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserID",
                HeaderText = "User ID",
                Width = 100
            });

            dgvSalary.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "EMAIL",
                HeaderText = "Email",
                Width = 200
            });

            dgvSalary.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Name",
                HeaderText = "Name",
                Width = 150
            });

            dgvSalary.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ROLE",
                HeaderText = "Role",
                Width = 100
            });

            dgvSalary.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Salary",
                HeaderText = "Salary",
                Width = 100
            });

            dgvSalary.AllowUserToAddRows = false;
            dgvSalary.AllowUserToDeleteRows = false;
            dgvSalary.ReadOnly = true;
            dgvSalary.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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

        private void ViewSalary_Load(object sender, EventArgs e)
        {
            cmbRole.Items.Add("Manager");
            cmbRole.Items.Add("Cashier");
            cmbRole.Items.Add("DeliveryPerson");
        }
    }
}