using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program1_LoginNavigation
{
    public partial class HomePage : Form
    {
        private string currentUser;

        public HomePage(string username)
        {
            InitializeComponent(); // Calls Designer
            currentUser = username;
            lblWelcome.Text = $"Welcome, {currentUser}!";
            this.BackColor = System.Drawing.Color.LightSkyBlue; // your unique color
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Profile page is under construction!", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings page is under construction!", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }
    }
}
