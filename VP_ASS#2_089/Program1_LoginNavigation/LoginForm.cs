using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program1_LoginNavigation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent(); // Calls your Designer file
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (username == "nitasha" && password == "12345")
            {
                HomePage home = new HomePage(username); // pass username
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }
    }
}
