using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program3_LibrarySystem
{
    public partial class LoginForm3 : Form
    {
        public LoginForm3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "nitasha" && txtPassword.Text == "12345")
            {
                DashboardForm3 dash = new DashboardForm3();
                dash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
