using EcommerceStoreDB.DAL;
using System;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class MyWishList : Form
    {
        private readonly string role;
        private readonly string username;
        private readonly WishlistBLL wishlistBLL;

        public MyWishList(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            this.wishlistBLL = new WishlistBLL();

            ConfigureListView();
        }

        private void MyWishList_Load(object sender, EventArgs e)
        {
            LoadWishListData();
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

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (wishlistListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to remove.");
                return;
            }

            string wishlistId = wishlistListView.SelectedItems[0].SubItems[0].Text;

            if (wishlistBLL.RemoveItem(wishlistId))
            {
                MessageBox.Show("Item removed successfully.");
                LoadWishListData();
            }
            else
            {
                MessageBox.Show("Error removing item.");
            }
        }

        private void btnMoveToCart_Click(object sender, EventArgs e)
        {
            if (wishlistListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select an item to move to the cart.");
                return;
            }

            string wishlistId = wishlistListView.SelectedItems[0].SubItems[0].Text;
            string productId = wishlistListView.SelectedItems[0].SubItems[1].Text;
            string productName = wishlistListView.SelectedItems[0].SubItems[2].Text;

            if (wishlistBLL.MoveToCart(username, role, wishlistId, productId, productName))
            {
                MessageBox.Show("Item moved to cart successfully.");
                LoadWishListData();
            }
            else
            {
                MessageBox.Show("Error moving item to cart.");
            }
        }

        private void ConfigureListView()
        {
            wishlistListView.View = View.Details;
            wishlistListView.FullRowSelect = true;
            wishlistListView.Columns.Add("Wishlist ID", 100);
            wishlistListView.Columns.Add("Product ID", 100);
            wishlistListView.Columns.Add("Product Name", 200);
        }
        private void wishlistListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LoadWishListData()
        {
            var wishlistData = wishlistBLL.GetWishlist(username, role);

            wishlistListView.Items.Clear();
            foreach (var item in wishlistData)
            {
                var listViewItem = new ListViewItem(item.WishlistId.ToString());
                listViewItem.SubItems.Add(item.ProductId);
                listViewItem.SubItems.Add(item.ProductName);
                wishlistListView.Items.Add(listViewItem);
            }
        }

        private void pbHome_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }
    }
}
