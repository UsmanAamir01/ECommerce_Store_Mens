// FeedbackForm.cs
using EcommerceStoreDB.BLL;
using System;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class Feedback : Form
    {
        private readonly string role;
        private readonly string username;
        private readonly FeedbackService feedbackService;
        private int productID;

        public Feedback(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            feedbackService = new FeedbackService();
        }

        public Feedback(string role, string username, int productID) : this(role, username)
        {
            this.productID = productID;
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            cmbRating.Items.AddRange(new string[] { "1", "2", "3", "4", "5" });
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string comments = txtComments.Text;
            string rating = cmbRating.SelectedItem?.ToString();

            if (string.IsNullOrWhiteSpace(productName) || string.IsNullOrWhiteSpace(comments) || string.IsNullOrWhiteSpace(rating))
            {
                MessageBox.Show("Please provide all the details for feedback.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isFeedbackSubmitted = feedbackService.SubmitFeedback(username, productName, rating, comments);

            if (isFeedbackSubmitted)
            {
                MessageBox.Show("Thank you for your feedback!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
            }
            else
            {
                MessageBox.Show("Failed to submit feedback. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearForm()
        {
            cmbRating.SelectedIndex = -1;
            txtProductName.Clear();
            txtComments.Clear();
        }

        private void txtComments_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbRating_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }
    }
}
