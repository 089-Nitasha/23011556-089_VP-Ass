namespace VP_ASS_2_089.Program4_SimpleCalculator
{
    partial class LoginForm4
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button btnLogin;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.txtUser.Location = new System.Drawing.Point(40, 30);
            this.txtUser.PlaceholderText = "Username";
            this.txtUser.Size = new System.Drawing.Size(200, 23);

            this.txtPass.Location = new System.Drawing.Point(40, 70);
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.Size = new System.Drawing.Size(200, 23);
            this.txtPass.PasswordChar = '*';

            this.btnLogin.Location = new System.Drawing.Point(40, 110);
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);

            this.ClientSize = new System.Drawing.Size(280, 170);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.btnLogin);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Login - Simple Calculator";
            this.ResumeLayout(false);
        }
    }
}
