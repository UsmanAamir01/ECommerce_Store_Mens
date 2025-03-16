using System;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;

namespace EcommerceStoreDB
{
    public partial class ViewRefunds : Form
    {
        private string role;
        private string username;
        private RefundManager refundManager;

        public ViewRefunds(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            refundManager = new RefundManager();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvRefunds.Columns.Clear();

            dgvRefunds.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Refund ID",
                DataPropertyName = "REFUNDID",
                Name = "ColumnRefundID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefunds.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Order ID",
                DataPropertyName = "ORDERID",
                Name = "ColumnOrderID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefunds.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Reason",
                DataPropertyName = "REASON",
                Name = "ColumnReason",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefunds.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Refund Amount",
                DataPropertyName = "REFUNDAMOUNT",
                Name = "ColumnRefundAmount",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefunds.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Refund Date",
                DataPropertyName = "REFUNDDATE",
                Name = "ColumnRefundDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefunds.AutoGenerateColumns = false;
        }

        private void LoadRefundData()
        {
            try
            {
                dgvRefunds.DataSource = refundManager.GetRefunds();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIssueRefund_Click(object sender, EventArgs e)
        {
            if (dgvRefunds.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvRefunds.SelectedRows[0];
                int refundID = Convert.ToInt32(selectedRow.Cells["ColumnRefundID"].Value);
                string orderID = selectedRow.Cells["ColumnOrderID"].Value.ToString();
                string reason = selectedRow.Cells["ColumnReason"].Value.ToString();
                decimal refundAmount = Convert.ToDecimal(selectedRow.Cells["ColumnRefundAmount"].Value);
                DateTime refundDate = Convert.ToDateTime(selectedRow.Cells["ColumnRefundDate"].Value);

                refundManager.IssueRefund(refundID, username, role, orderID, reason, refundAmount, refundDate);
                MessageBox.Show("Refund issued successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadRefundData();
            }
            else
            {
                MessageBox.Show("Please select a refund to issue.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            CashierPortal cashierPortal = new CashierPortal(role, username);
            this.Hide();
            cashierPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void dgvRefunds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ViewRefunds_Load(object sender, EventArgs e)
        {
            LoadRefundData();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            CashierPortal cashierPortal = new CashierPortal(role, username);
            this.Hide();
            cashierPortal.Show();
        }
    }
}
