using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class Category2 : Form
    {
        private string role;
        private string username;

        private Dictionary<string, (decimal Price, string Description, string ImagePath)> productDetails = new Dictionary<string, (decimal, string, string)>
        {
            { "Ribbed Tank Tops", (15.99m, "Lightweight and breathable ribbed tank tops for everyday comfort.", "images/ribbed_tank_tops.jpg") },
            { "Polo Shirts", (25.50m, "Classic polo shirts made with premium cotton for a casual yet refined look.", "images/polo_shirts.jpg") },
            { "Button-Up Shirts", (35.75m, "Formal button-up shirts, perfect for work and formal events.", "images/button_up_shirts.jpg") },
            { "Short Sleeve Shirts", (20.40m, "Cool and comfortable short-sleeve shirts for summer.", "images/short_sleeve_shirts.jpg") },
            { "T-Shirts", (18.99m, "High-quality T-shirts available in various colors and designs.", "images/t_shirts.jpg") },
            { "Full Sleeve Shirts", (28.20m, "Stylish full-sleeve shirts for a sharp appearance and comfort.", "images/full_sleeve_shirts.jpg") }
        };

        public Category2(string role, string username)
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

        private void Category2_Load(object sender, EventArgs e)
        {
           
        }

        private void picRibbedTankTops_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Ribbed Tank Tops");
        }

        private void lblRibbedTankTops_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Ribbed Tank Tops");
        }

        private void picPoloShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Polo Shirts");
        }

        private void lblPoloShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Polo Shirts");
        }

        private void picButtonUpShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Button-Up Shirts");
        }

        private void lblButtonUpShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Button-Up Shirts");
        }

        private void picShortSleeveShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Short Sleeve Shirts");
        }

        private void lblShortSleeveShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Short Sleeve Shirts");
        }

        private void picTShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("T-Shirts");
        }

        private void lblTShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("T-Shirts");
        }

        private void picFullSleeveShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Full Sleeve Shirts");
        }

        private void lblFullSleeveShirts_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Full Sleeve Shirts");
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
