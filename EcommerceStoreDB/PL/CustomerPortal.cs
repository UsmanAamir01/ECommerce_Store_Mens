using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace EcommerceStoreDB
{
    public partial class CustomerPortal : Form
    {
        private String role;
        private String username;
        private int productID;
        public CustomerPortal(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
        }

        private void btnFeedback_Click(object sender, EventArgs e)
        {
            Feedback feedback = new Feedback(role,username,productID);
            this.Hide();
            feedback.Show();


        }

      

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }


        private void btnNotifications_Click(object sender, EventArgs e)
        {
            ViewNotifications viewNotifications = new ViewNotifications(role,username);
            this.Hide();
            viewNotifications.Show();
        }

        private void btnWishList_Click(object sender, EventArgs e)
        {
            MyWishList myWishList = new MyWishList(role,username);
            this.Hide();
            myWishList.Show();
        }

        private void btnRefundRequests_Click(object sender, EventArgs e)
        {
            RefundRequests refundRequests = new RefundRequests(role,username);
            this.Hide();
            refundRequests.Show();
        }

        private void CustomerPortal_Load(object sender, EventArgs e)
        {

        }
    }
}
