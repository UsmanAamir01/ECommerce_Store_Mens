using System;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    public partial class Report : Form
    {
        private readonly ReportBO reportBO;
        private readonly string role;
        private readonly string username;

        public Report(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            reportBO = new ReportBO();
        }

        private void btnAddReport_Click(object sender, EventArgs e)
        {
            string reportID = txtReportID.Text.Trim();
            string reportName = txtReportName.Text.Trim();
            string generateDate = dtpGenerateDate.Value.ToString("yyyy-MM-dd");
            string totalRevenue = txtTotalRevenue.Text.Trim();
            string reportDescription = txtReportDescription.Text.Trim();

            if (string.IsNullOrEmpty(reportID) || string.IsNullOrEmpty(reportName) || string.IsNullOrEmpty(totalRevenue))
            {
                MessageBox.Show("Please fill all required fields (Report ID, Report Name, Total Revenue).");
                return;
            }

            try
            {
                bool isAdded = reportBO.AddReport(reportID, reportName, generateDate, totalRevenue, reportDescription);

                if (isAdded)
                {
                    MessageBox.Show("Report added successfully!");
                    ClearFields();
                    LoadReports();
                }
                else
                {
                    MessageBox.Show("Failed to add the report.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            string reportName = txtViewReport.Text.Trim();

            if (string.IsNullOrEmpty(reportName))
            {
                MessageBox.Show("Please enter a Report Name to view.");
                return;
            }

            try
            {
                dgvViewReport.DataSource = reportBO.GetReportByName(reportName);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnDeleteReport_Click(object sender, EventArgs e)
        {
            string reportID = txtReportIDD.Text.Trim();

            if (string.IsNullOrEmpty(reportID))
            {
                MessageBox.Show("Please enter a Report ID to delete.");
                return;
            }

            try
            {
                bool isDeleted = reportBO.DeleteReport(reportID);

                if (isDeleted)
                {
                    MessageBox.Show("Report deleted successfully!");
                    ClearFields();
                    LoadReports();
                }
                else
                {
                    MessageBox.Show("No report found with the given ID.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadReports()
        {
            try
            {
                dgvViewReport.DataSource = reportBO.GetAllReports();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            txtReportID.Clear();
            txtReportName.Clear();
            txtTotalRevenue.Clear();
            txtReportDescription.Clear();
            txtViewReport.Clear();
            txtReportIDD.Clear();
        }

        private void Report_Load(object sender, EventArgs e)
        {
            dtpGenerateDate.Format = DateTimePickerFormat.Custom;
            dtpGenerateDate.CustomFormat = "yyyy-MM-dd";
            LoadReports();
        }
        private void txtViewReport_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReportID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtReportName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtReportIDD_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpGenerateDate_ValueChanged(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }

        private void dgvViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void txtReportDescription_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnTotalRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new Database().GetConnection())
                {
                    connection.Open();
                    // Query to sum the TotalAmount in the Orders table
                    string query = "SELECT TotalRevenue() FROM DUAL";

                    using (var command = new OracleCommand(query, connection))
                    {
                        object result = command.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            decimal totalRevenue = Convert.ToDecimal(result);
                            txtTotalRevenue.Text = totalRevenue.ToString("0.00");
                        }
                        else
                        {
                            MessageBox.Show("Failed to retrieve total revenue.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtTotalRevenue_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
