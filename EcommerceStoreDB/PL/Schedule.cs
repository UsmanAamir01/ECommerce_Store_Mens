using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class Schedule : Form
    {
        private String role;
        private String username;
        public Schedule(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminPortal adminPortal = new AdminPortal(role,username);
            this.Hide();
            adminPortal.Show();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
