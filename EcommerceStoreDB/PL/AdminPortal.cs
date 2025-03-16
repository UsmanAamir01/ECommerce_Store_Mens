using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class AdminPortal : Form
    {
        private string username;
        private string role;
        public AdminPortal(string role, string username)
        {
            InitializeComponent();
            this.role = role;
            this.username = username;
            lblUsername.Text = username;  
        }
        private void lblUsername_Click(object sender, System.EventArgs e)
        {

        }

        private void btnSignOut_Click(object sender, System.EventArgs e)
        {
            Login login = new Login();  
            this.Hide();
            login.Show();
        }

        private void btnEditProfile_Click(object sender, System.EventArgs e)
        {
            AdminProfile adminProfile = new AdminProfile(role, username);
            this.Hide();
            adminProfile.Show();
        }

        private void btnManageSalary_Click(object sender, System.EventArgs e)
        {
            ViewSalary viewSalary = new ViewSalary(role, username);
            this.Hide();
            viewSalary.Show();
        }

        private void AdminPortal_Load(object sender, System.EventArgs e)
        {

        }

        private void btnManageRoles_Click(object sender, System.EventArgs e)
        {
            Roles roles = new Roles(role,username);
            this.Hide();
            roles.Show();
        }
        private void btnManageFeedback_Click(object sender, System.EventArgs e)
        {
            ReplyFeedback replyFeedback = new ReplyFeedback(role,username);
            this.Hide();
            replyFeedback.Show();

        }

        private void picLogo_Click(object sender, System.EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void picbgLogo_Click(object sender, System.EventArgs e)
        {
            MainPage mainPage = new MainPage();
            this.Hide();
            mainPage.Show();
        }

        private void btnManageReports_Click(object sender, System.EventArgs e)
        {
            ViewReports viewReports = new ViewReports(role,username);
            this.Hide();
            viewReports.Show();
        }

        private void btnManageSchedule_Click(object sender, System.EventArgs e)
        {
            Schedule schedule = new Schedule(role,username);
            this.Hide();
            schedule.Show();

        }
        private void label3_Click(object sender, System.EventArgs e)
        {

        }

        private void label2_Click(object sender, System.EventArgs e)
        {

        }

        private void label4_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, System.EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, System.EventArgs e)
        {

        }

        private void label5_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, System.EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, System.EventArgs e)
        {

        }

        private void label7_Click(object sender, System.EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, System.EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, System.EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {

        }

        private void label1_Click(object sender, System.EventArgs e)
        {

        }

        private void label9_Click(object sender, System.EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, System.EventArgs e)
        {

        }

        private void label10_Click(object sender, System.EventArgs e)
        {

        }

        private void label11_Click(object sender, System.EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, System.EventArgs e)
        {

        }

        private void label12_Click(object sender, System.EventArgs e)
        {

        }

        private void label13_Click(object sender, System.EventArgs e)
        {

        }
       
    }
}
