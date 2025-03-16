using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;
using EcommerceStoreDB.BLL;
using Oracle.ManagedDataAccess.Client;

namespace EcommerceStoreDB
{
    
        public partial class AddToCart : Form
        {
            private string role;
            private string username;
            private string productName;
            private ProductManager productManager;

            public AddToCart(string role, string username, string productName)
            {
                InitializeComponent();
                this.role = role;
                this.username = username;
                this.productName = productName;
                this.productManager = new ProductManager();

                lblUsername.Text = username;
                LoadProductDetails();
            }

        public AddToCart(string role, string username, string productName, decimal price, string description, string imagePath) : this(role, username, productName)
        {
            this.price = price;
            this.description = description;
            this.imagePath = imagePath;
        }

        private void LoadProductDetails()
            {
                var productDetails = productManager.GetProductDetails(productName);

                if (productDetails != null)
                {
                    lblProductName.Text = productDetails.Name;
                    lblPrice.Text = $"Price: ${productDetails.Price:0.00}";
                    gnProductDescription.Text = productDetails.Description;
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }

            private void btnAddToCart_Click(object sender, EventArgs e)
            {
                bool success = productManager.AddProductToOrders(username, productName);

                if (success)
                {
                    MessageBox.Show("Product added to orders successfully!");
                    CheckoutPage checkout = new CheckoutPage(role, username);
                    this.Hide();
                    checkout.Show();
                }
                else
                {
                    MessageBox.Show("Failed to add product to orders.");
                }
            }

            private void btnAddtoWishlist_Click(object sender, EventArgs e)
            {
                bool success = productManager.AddProductToWishlist(username, productName);

                if (success)
                {
                    MessageBox.Show("Product added to wishlist successfully!");
                }
                else
                {
                    MessageBox.Show("Failed to add product to wishlist.");
                }
            }
        
       

        private Database db = new Database();
        private decimal price;
        private string description;
        private string imagePath;

        

        private void gnProductDescription_Enter(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Resize(object sender, EventArgs e)
        {

        }

        private void lblProductName_Click(object sender, EventArgs e)
        {

        }

        private void lblPrice_Click(object sender, EventArgs e)
        {

        }
        private void AddToCart_Load(object sender, EventArgs e)
        {
            lblProductName.Text = productName;

            CenterPanel();
            PositionPanelTopRight();
            PositionPanelLeftBottom();
            PositionPanelTopLeft();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (IsProductInCategory1(productName))
            {
                Category1 category1 = new Category1(role, username);
                this.Hide();
                category1.Show();
            }
            else if (IsProductInCategory2(productName))
            {
                Category2 category2 = new Category2(role, username);
                this.Hide();
                category2.Show();
            }
            else if (IsProductInCategory3(productName))
            {
                Category3 category3 = new Category3(role, username);
                this.Hide();
                category3.Show();
            }
            else
            {
                MessageBox.Show("Product does not belong to any category!");
            }
        }

        private bool IsProductInCategory1(string productName)
        {
            List<string> category1Products = new List<string>
            {
                "Pleated Pants",
                "Formal Trousers",
                "Tailored Chinos",
                "Cargo Pants",
                "Baggy Jeans",
                "Slim Fit Pants"
            };

            return category1Products.Contains(productName);
        }

        private bool IsProductInCategory2(string productName)
        {
            List<string> category2Products = new List<string>
            {
                "Ribbed Tank Tops",
                "Polo Shirts",
                "Button-Up Shirts",
                "Short Sleeve Shirts",
                "T-Shirts",
                "Full Sleeve Shirts"
            };

            return category2Products.Contains(productName);
        }

        private bool IsProductInCategory3(string productName)
        {
            List<string> category3Products = new List<string>
            {
                "Varsity Jackets",
                "Puffer Jackets",
                "Bomber Jackets",
                "Cardigans",
                "Overcoats",
                "Hoodies"
            };

            return category3Products.Contains(productName);
        }

        

        private void CenterPanel()
        {
            int panelWidth = panel2.Width;
            int panelHeight = panel2.Height;

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            panel2.Left = (formWidth - panelWidth) / 2;
            panel2.Top = (formHeight - panelHeight) / 2;
        }

        private void AddToCart_Resize(object sender, EventArgs e)
        {
            CenterPanel();
            PositionPanelTopRight();
            PositionPanelLeftBottom();
            PositionPanelTopLeft();
        }

        private void PositionPanelTopRight()
        {
            panel5.Left = this.ClientSize.Width - panel5.Width;
            panel5.Top = 0;
        }

        private void PositionPanelLeftBottom()
        {
            panel3.Left = 0;
            panel3.Top = this.ClientSize.Height - panel3.Height;
        }

        private void PositionPanelTopLeft()
        {
            panel1.Left = 0;
            panel1.Top = 0;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        
    }
}