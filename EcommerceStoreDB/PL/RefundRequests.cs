using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class RefundRequests : Form
    {
        private string role;
        private string username;
        private RefundRequestBLL refundRequestBLL;

        public RefundRequests(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            refundRequestBLL = new RefundRequestBLL();
            ConfigureDataGridView();
        }

        private void ConfigureDataGridView()
        {
            dgvRefundRequests.Columns.Clear();

            dgvRefundRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Order ID",
                DataPropertyName = "ORDERID",
                Name = "ColumnOrderID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefundRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "User ID",
                DataPropertyName = "USERID",
                Name = "ColumnUserID",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefundRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Total Amount",
                DataPropertyName = "TOTALAMOUNT",
                Name = "ColumnTotalAmount",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefundRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Status",
                DataPropertyName = "STATUS",
                Name = "ColumnStatus",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefundRequests.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Order Date",
                DataPropertyName = "ORDERDATE",
                Name = "ColumnOrderDate",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dgvRefundRequests.AutoGenerateColumns = false;
        }

        private void LoadRefundRequests()
        {
            try
            {
                DataTable dt = refundRequestBLL.GetRefundRequests();
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No orders found.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvRefundRequests.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading refund requests: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRequestRefund_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text) || string.IsNullOrWhiteSpace(txtReason.Text) || string.IsNullOrWhiteSpace(txtRefundAmount.Text))
            {
                lblMessage.Text = "Please fill in all fields.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            if (!decimal.TryParse(txtRefundAmount.Text, out decimal refundAmount) || refundAmount <= 0)
            {
                lblMessage.Text = "Enter a valid refund amount.";
                lblMessage.ForeColor = Color.Red;
                return;
            }

            try
            {
                string resultMessage = refundRequestBLL.ProcessRefundRequest(Convert.ToInt32(txtOrderID.Text), txtReason.Text, refundAmount);
                lblMessage.Text = resultMessage;

                if (resultMessage.StartsWith("Refund"))
                {
                    lblMessage.ForeColor = Color.Green;
                    LoadRefundRequests();
                }
                else
                {
                    lblMessage.ForeColor = Color.Red;
                }

                txtOrderID.Clear();
                txtReason.Clear();
                txtRefundAmount.Clear();
            }
            catch (Exception ex)
            {
                lblMessage.Text = $"Error: {ex.Message}";
                lblMessage.ForeColor = Color.Red;
            }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal(role, username);
            this.Hide();
            customerPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }


        private void dgvRefundRequests_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void txtOrderID_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtReason_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtRefundAmount_TextChanged(object sender, EventArgs e)
        {
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void RefundRequests_Load_1(object sender, EventArgs e)
        {
            LoadRefundRequests();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            CashierPortal cashierPortal = new CashierPortal(role, username);
            this.Hide();
            cashierPortal.Show();
        }

    }
}
