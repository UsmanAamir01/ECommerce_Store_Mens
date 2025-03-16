using Oracle.ManagedDataAccess.Client;
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
    public partial class Notifications : Form
    {
        private String role;
        private String username;
        public Notifications(String role, String username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void picHome_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role,username);
            this.Hide();
            managerPortal.Show();
        }

        private void Notifications_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ManagerPortal managerPortal = new ManagerPortal(role, username);
            this.Hide();
            managerPortal.Show();
        }
    }
}
