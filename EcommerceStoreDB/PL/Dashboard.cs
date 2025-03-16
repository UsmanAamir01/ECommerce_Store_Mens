using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class Dashboard : Form
    {
        private string role;
        private string username;
        private int productID = 0;

        public Dashboard(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;

            LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                Database db = new Database();
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT PRODUCTID, NAME, DESCRIPTION, CATEGORY, PRICE, STOCK FROM PRODUCTS";
                    OracleDataAdapter adapter = new OracleDataAdapter(query, connection);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvProducts.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching products: " + ex.Message);
            }
        }

        private void SearchProducts()
        {
            try
            {
                Database db = new Database();
                using (OracleConnection connection = db.GetConnection())
                {
                    connection.Open();

                    string query = "SELECT PRODUCTID, NAME, DESCRIPTION, CATEGORY, PRICE, STOCK FROM PRODUCTS WHERE 1=1";

                    if (chbSearchbyID.Checked && int.TryParse(txtSearch.Text, out int id))
                    {
                        query += " AND PRODUCTID = :productID";
                    }
                    else if (chbSearchbyName.Checked && !string.IsNullOrEmpty(txtSearch.Text))
                    {
                        query += " AND LOWER(NAME) LIKE :productName";
                    }
                    else if (chbSearchbyRange.Checked)
                    {
                        if (nudMinPrice.Value > nudMaxPrice.Value)
                        {
                            MessageBox.Show("Minimum price cannot be greater than maximum price.", "Invalid Range", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return; 
                        }

                        query += " AND PRICE BETWEEN :minPrice AND :maxPrice";
                    }

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        if (chbSearchbyID.Checked && int.TryParse(txtSearch.Text, out id))
                        {
                            command.Parameters.Add(new OracleParameter("productID", id));
                        }
                        else if (chbSearchbyName.Checked && !string.IsNullOrEmpty(txtSearch.Text))
                        {
                            command.Parameters.Add(new OracleParameter("productName", $"%{txtSearch.Text.ToLower()}%"));
                        }
                        else if (chbSearchbyRange.Checked)
                        {
                            command.Parameters.Add(new OracleParameter("minPrice", nudMinPrice.Value));
                            command.Parameters.Add(new OracleParameter("maxPrice", nudMaxPrice.Value));
                        }

                        OracleDataAdapter adapter = new OracleDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dgvProducts.DataSource = dt; 

                        
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching products: " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void chbSearchbyRange_CheckedChanged(object sender, EventArgs e)
        {

           nudMinPrice.Enabled = chbSearchbyRange.Checked;
           nudMaxPrice.Enabled = chbSearchbyRange.Checked;

            txtSearch.Enabled = !chbSearchbyRange.Checked;
            SearchProducts();
            
        }

        private void picSearch_Click(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void chbSearchbyID_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSearchbyID.Checked)
            {

                SearchProducts();
                chbSearchbyName.Checked = false;
                chbSearchbyRange.Checked = false;
                txtSearch.Enabled = true;
                nudMinPrice.Enabled = false;
                nudMaxPrice.Enabled = false;
            }
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(role, username);
            this.Hide();
            settings.Show();
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SearchProducts();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnCategories_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories(role, username);
            this.Hide();
            categories.Show();
        }

        

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(role, username, productID);
            this.Hide();
            feedback.Show();
        }
        private void btnPortal_Click(object sender, EventArgs e)
        {
            CustomerPortal customerPortal = new CustomerPortal(role, username);
            this.Hide();
            customerPortal.Show();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            CustomerProfile customerProfile = new CustomerProfile(role, username);
            this.Hide();
            customerProfile.Show();
        }
        private void chbSearchbyName_CheckedChanged(object sender, EventArgs e)
        {
            if (chbSearchbyName.Checked)
            {
                SearchProducts();
                chbSearchbyID.Checked = false;
                chbSearchbyRange.Checked = false;
                txtSearch.Enabled = true;
                nudMinPrice.Enabled = false;
                nudMaxPrice.Enabled = false;
            }
        }

        private void nudMaxPrice_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void nudMinPrice_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            CheckoutPage checkoutPage = new CheckoutPage(role, username);
            this.Hide();
            checkoutPage.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            ViewOrderHistory viewOrderHistory = new ViewOrderHistory(role, username);
            this.Hide();
            viewOrderHistory.Show();
        }
    }
}