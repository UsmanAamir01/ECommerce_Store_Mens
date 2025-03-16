using System;
using System.Windows.Forms;

namespace EcommerceStoreDB
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(965, 600);
            
        }

        private void lblLoginLink_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();   
            this.Hide();
            signup.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void MainPage_Resize(object sender, EventArgs e)
        {
            CenterPanel();
            PositionPanelTopRight();
        }

        private void CenterPanel()
        {
            int panelWidth = panel1.Width;
            int panelHeight = panel1.Height;

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            panel1.Left = (formWidth - panelWidth) / 2;
            panel1.Top = (formHeight - panelHeight) / 2;
        }
  
        private void MainPage_Load(object sender, EventArgs e)
        {
            CenterPanel();
            PositionPanelTopRight();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PositionPanelTopRight()
        {
            panel3.Left = this.ClientSize.Width - panel3.Width; 
            panel3.Top = 0; 
        }

        private void lblBrandName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }

}
