using System;
using System.Windows.Forms;
using VP_ASS_2_089.Program1_LoginNavigation; // Add this using
using VP_ASS_2_089.Program2_StudentSystem; // This is Program 2 namespace
using VP_ASS_2_089.Program3_LibrarySystem;
using VP_ASS_2_089.Program4_SimpleCalculator;

namespace VP_ASS_2_089
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnProgram1_Click(object sender, EventArgs e)
        {
            // Open Program1 LoginForm
            LoginForm login = new LoginForm();
            login.Show();
        }
        private void btnProgram2_Click(object sender, EventArgs e)
        {
            LoginForm2 login2 = new LoginForm2(); // Correct
            login2.Show();
        }
        private void btnProgram3_Click(object sender, EventArgs e)
        {
            LoginForm3 login3 = new LoginForm3();
            login3.Show();
        }
        private void btnProgram4_Click(object sender, EventArgs e)
        {
            LoginForm4 login4 = new LoginForm4();
            login4.Show();
        }


    }
}
