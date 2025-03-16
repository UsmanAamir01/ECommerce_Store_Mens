using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class Category3 : Form
    {
        private string role;
        private string username;
        private Dictionary<string, (decimal Price, string Description, string ImagePath)> productDetails = new Dictionary<string, (decimal, string, string)>
        {
            { "Varsity Jackets", (55.99m, "Stylish varsity jackets with bold lettering, perfect for a casual, sporty look.", "images/varsity_jackets.jpg") },
            { "Puffer Jackets", (70.50m, "Warm and insulated puffer jackets, ideal for cold weather.", "images/puffer_jackets.jpg") },
            { "Bomber Jackets", (65.20m, "Trendy bomber jackets, designed for comfort and style.", "images/bomber_jackets.jpg") },
            { "Cardigans", (40.75m, "Soft and cozy cardigans, perfect for layering in colder months.", "images/cardigans.jpg") },
            { "Overcoats", (80.99m, "Elegant overcoats made for both warmth and sophisticated style.", "images/overcoats.jpg") },
            { "Hoodies", (45.20m, "Comfortable and casual hoodies, great for everyday wear.", "images/hoodies.jpg") }
        };

        public Category3(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories(role, username);
            this.Hide();
            categories.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void picVarsityJackets_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Varsity Jackets");
        }

        private void lblVarsityJackets_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Varsity Jackets");
        }

        private void picPufferJackets_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Puffer Jackets");
        }

        private void lblPufferJackets_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Puffer Jackets");
        }

        private void picBomberJackets_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Bomber Jackets");
        }

        private void lblBomberJackets_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Bomber Jackets");
        }

        private void picCardigans_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Cardigans");
        }

        private void lblCardigans_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Cardigans");
        }

        private void picOvercoats_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Overcoats");
        }

        private void lblOvercoats_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Overcoats");
        }

        private void picHoodies_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Hoodies");
        }

        private void lblHoodies_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Hoodies");
        }

        private void NavigateToAddToCart(string productName)
        {
            var (price, description, imagePath) = productDetails[productName];
            AddToCart addToCart = new AddToCart(role, username, productName, price, description, imagePath);
            this.Hide();
            addToCart.Show();
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }
    }
}
