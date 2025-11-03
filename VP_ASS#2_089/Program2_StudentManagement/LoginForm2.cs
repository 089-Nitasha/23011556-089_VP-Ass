using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program2_StudentSystem
{
    public partial class LoginForm2 : Form
    {
        public LoginForm2()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text.Trim() == "nitasha" && txtPassword.Text == "12345")
            {
                DashboardForm dash = new DashboardForm();
                dash.Show();
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
