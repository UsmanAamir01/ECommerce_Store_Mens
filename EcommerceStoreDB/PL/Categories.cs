using System.Text;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class Categories : Form
    {
        private string role;
        private string username;
        public Categories(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
        }

        private void picHome_Click(object sender, System.EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();

        }

        private void lblPantsandTrousers_Click(object sender, System.EventArgs e)
        {
            Category1 category1 = new Category1(role,username);
            this.Hide();
            category1.Show();
        }

        private void lblTopsandTees_Click(object sender, System.EventArgs e)
        {
            Category2 category2 = new Category2(role,username);
            this.Hide();
            category2.Show();
        }

        private void lblOutwaersandJackets_Click(object sender, System.EventArgs e)
        {
            Category3 category3 = new Category3(role,username);
            this.Hide();
            category3.Show();
        }

        private void Categories_Load(object sender, System.EventArgs e)
        {

        }

        private void picPantsAndTrousers_Click(object sender, System.EventArgs e)
        {
            Category1 category1 = new Category1(role, username);
            this.Hide();
            category1.Show();
        }

        private void picTopsAndTees_Click(object sender, System.EventArgs e)
        {
            Category2 category2 = new Category2(role, username);
            this.Hide();
            category2.Show();
        }

        private void picOutwearsAndJackets_Click(object sender, System.EventArgs e)
        {
            Category3 category3 = new Category3(role, username);
            this.Hide();
            category3.Show();
        }

        private void btnBack_Click(object sender, System.EventArgs e)
        {
            Dashboard dashboard = new Dashboard(role, username);
            this.Hide();
            dashboard.Show();
        }

        private void btnSignOut_Click(object sender, System.EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
