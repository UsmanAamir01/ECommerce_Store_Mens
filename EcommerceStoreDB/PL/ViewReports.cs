using EcommerceStoreDB.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ViewReports : Form
    {
        private readonly string role;
        private readonly string username;
        private readonly ReportBLL reportBLL;

        public ViewReports(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            reportBLL = new ReportBLL();
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

        private void ViewReports_Load(object sender, EventArgs e)
        {
            LoadReports();
        }
        private void lblMessage_Click(object sender, EventArgs e) { }
        private void LoadReports()
        {
            try
            {
                DataTable reports = reportBLL.LoadReports();
                if (reports.Rows.Count > 0)
                {
                    dgvReports.DataSource = reports;
                    dgvReports.Columns.Clear();

                    foreach (DataColumn column in reports.Columns)
                    {
                        DataGridViewColumn dgvColumn;

                        switch (column.DataType.Name)
                        {
                            case "Int32":
                            case "Decimal":
                                dgvColumn = new DataGridViewTextBoxColumn();
                                dgvColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                                break;

                            case "String":
                            case "DateTime":
                            default:
                                dgvColumn = new DataGridViewTextBoxColumn();
                                break;
                        }

                        dgvColumn.Name = column.ColumnName;
                        dgvColumn.DataPropertyName = column.ColumnName;
                        dgvColumn.HeaderText = column.ColumnName.Replace("_", " ");
                        dgvReports.Columns.Add(dgvColumn);
                    }

                    dgvReports.Columns["REPORTID"].Width = 100;
                    dgvReports.Columns["REPORTNAME"].Width = 200;
                    dgvReports.Columns["GENERATEDATE"].Width = 150;
                    dgvReports.Columns["TOTALREVENUE"].Width = 120;
                    dgvReports.Columns["REPORTDESCRIPTION"].Width = 250;
                    dgvReports.Columns["STATUS"].Width = 120;
                }
                else
                {
                    MessageBox.Show("No report data found.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnApproveReport_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                int reportId = Convert.ToInt32(dgvReports.SelectedRows[0].Cells["REPORTID"].Value);
                if (reportBLL.ApproveReport(reportId))
                {
                    lblMessage.Text = "The report has been approved.";
                    lblMessage.ForeColor = Color.Green;
                    LoadReports();
                }
                else
                {
                    MessageBox.Show("Error: Report approval failed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a report to approve.");
            }
        }

        private void btnDeclineReport_Click(object sender, EventArgs e)
        {
            if (dgvReports.SelectedRows.Count > 0)
            {
                int reportId = Convert.ToInt32(dgvReports.SelectedRows[0].Cells["REPORTID"].Value);
                if (reportBLL.DeclineReport(reportId))
                {
                    lblMessage.Text = "The report has been declined.";
                    lblMessage.ForeColor = Color.Red;
                    LoadReports();
                }
                else
                {
                    MessageBox.Show("Error: Report decline failed.");
                }
            }
            else
            {
                MessageBox.Show("Please select a report to decline.");
            }
        }
        private void dgvReports_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void pbHome_Click(object sender, EventArgs e)
        {
            AdminPortal adminPortal = new AdminPortal(role, username);
            this.Hide();
            adminPortal.Show();
        }
    }
}