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
    public partial class DeliveryPersonPortal : Form
    {
        private String role;
        private String username;
        public DeliveryPersonPortal(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;
        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }

        private void btnSignOut_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnAssignedDeliveries_Click(object sender, EventArgs e)
        {
            ViewDeliveries viewDeliveries = new ViewDeliveries(role,username);
            this.Hide();
            viewDeliveries.Show();
        }

        private void btnShipmentstatus_Click(object sender, EventArgs e)
        {
            ShipmentStatus shipmentstatus = new ShipmentStatus(role, username);
            this.Hide();
            shipmentstatus.Show();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            DeliveryPersonProfile deliveryPersonProfile = new DeliveryPersonProfile(role,username);
            this.Hide();
            deliveryPersonProfile.Show();
        }

        private void btnRefundRequests_Click(object sender, EventArgs e)
        {

        }
    }
}