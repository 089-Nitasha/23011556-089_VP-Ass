using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program4_SimpleCalculator
{
    public partial class LoginForm4 : Form
    {
        public LoginForm4()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == "nitasha" && txtPass.Text == "12345")
            {
                CalculatorForm calc = new CalculatorForm();
                calc.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password!");
            }
        }
    }
}
