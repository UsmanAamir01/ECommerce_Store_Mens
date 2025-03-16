using EcommerceStoreDB.BLL;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class ReplyFeedback : Form
    {
        private string role;
        private string username;
        private FeedbackBLL feedbackBLL;

        public ReplyFeedback(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            feedbackBLL = new FeedbackBLL();
            LoadFeedbackData();
        }

        private void LoadFeedbackData()
        {
            try
            {
                DataTable feedbackData = feedbackBLL.LoadFeedbackData();

                dgvManageFeedback.DataSource = feedbackData;

                dgvManageFeedback.Columns["FEEDBACKID"].HeaderText = "Feedback ID";
                dgvManageFeedback.Columns["USERID"].HeaderText = "User ID";
                dgvManageFeedback.Columns["PRODUCTID"].HeaderText = "Product ID";
                dgvManageFeedback.Columns["RATING"].HeaderText = "Rating";
                dgvManageFeedback.Columns["COMMENTS"].HeaderText = "Comments";
                dgvManageFeedback.Columns["FEEDBACKDATE"].HeaderText = "Feedback Date";
                dgvManageFeedback.Columns["PRODUCTNAME"].HeaderText = "Product Name";

                dgvManageFeedback.Columns["FEEDBACKID"].Width = 100;
                dgvManageFeedback.Columns["USERID"].Width = 100;
                dgvManageFeedback.Columns["PRODUCTID"].Width = 100;
                dgvManageFeedback.Columns["RATING"].Width = 80;
                dgvManageFeedback.Columns["COMMENTS"].Width = 250;
                dgvManageFeedback.Columns["FEEDBACKDATE"].Width = 150;
                dgvManageFeedback.Columns["PRODUCTNAME"].Width = 150;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while retrieving feedback data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPortal adminPortal = new AdminPortal(role, username);
            this.Hide();
            adminPortal.Show();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AdminPortal adminPortal = new AdminPortal(role, username);
            this.Hide();
            adminPortal.Show();
        }

        private void dgvManageFeedback_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvManageFeedback.Rows[e.RowIndex];
                int feedbackId = Convert.ToInt32(row.Cells["FEEDBACKID"].Value);
                MessageBox.Show($"Feedback ID: {feedbackId}");
            }
        }

        private void ReplyFeedback_Load(object sender, EventArgs e)
        {
            
        }
    }
}
