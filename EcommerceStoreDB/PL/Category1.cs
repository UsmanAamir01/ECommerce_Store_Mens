using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace EcommerceStoreDB
{
    public partial class Category1 : Form
    {
        private string role;
        private string username;

        private Dictionary<string, (decimal Price, string Description, string ImagePath)> productDetails = new Dictionary<string, (decimal, string, string)>
        {
            { "Pleated Pants", (25.99m, "Classic pleated pants, perfect for formal occasions.", "images/pleated_pants.jpg") },
            { "Formal Trousers", (30.50m, "Elegant formal trousers, ideal for office wear.", "images/formal_trousers.jpg") },
            { "Tailored Chinos", (28.75m, "Stylish tailored chinos, comfortable and trendy.", "images/tailored_chinos.jpg") },
            { "Cargo Pants", (35.40m, "Durable cargo pants with multiple pockets.", "images/cargo_pants.jpg") },
            { "Baggy Jeans", (40.99m, "Relaxed fit baggy jeans for a casual look.", "images/baggy_jeans.jpg") },
            { "Slim Fit Pants", (32.20m, "Modern slim-fit pants for a sharp appearance.", "images/slim_fit_pants.jpg") }
        };

        public Category1(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void Category1_Load(object sender, EventArgs e)
        {
            LoadProductImages();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void LoadProductImages()
        {
            foreach (var product in productDetails)
            {
                string productName = product.Key;
                string imagePath = "images/" + productName.Replace(" ", "_").ToLower() + ".jpg";

                PictureBox pictureBox = Controls.Find("pic" + productName.Replace(" ", ""), true).FirstOrDefault() as PictureBox;
                if (pictureBox != null && File.Exists(imagePath))
                {
                    pictureBox.ImageLocation = imagePath; 
                }
            }
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

        private void picPleatedPants_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Pleated Pants");
        }

        private void lblPleatedPants_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Pleated Pants");
        }

        private void picFormalTrousers_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Formal Trousers");
        }

        private void lblFormalTrousers_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Formal Trousers");
        }

        private void picTailoredChinos_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Tailored Chinos");
        }

        private void lblTailoredChinos_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Tailored Chinos");
        }

        private void picCargoPants_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Cargo Pants");
        }

        private void lblCargoPants_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Cargo Pants");
        }

        private void picBaggyJeans_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Baggy Jeans");
        }

        private void lblBaggyJeans_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Baggy Jeans");
        }

        private void picSlimFitPants_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Slim Fit Pants");
        }

        private void lblSlimFitPants_Click(object sender, EventArgs e)
        {
            NavigateToAddToCart("Slim Fit Pants");
        }

        private void NavigateToAddToCart(string productName)
        {
            if (productDetails.ContainsKey(productName))
            {
                var (price, description, imagePath) = productDetails[productName];

                AddToCart addToCart = new AddToCart(role, username, productName, price, description, imagePath);
                this.Hide();
                addToCart.Show();
            }
            else
            {
                MessageBox.Show("Product details not found.");
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role,username);
            this.Hide();
            dashboard.Show();
        }
    }
}
