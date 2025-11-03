namespace VP_ASS_2_089.Program3_LibrarySystem
{
    partial class LoginForm3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Text = "Username:";
            this.lblUsername.Location = new System.Drawing.Point(30, 30);
            // 
            // lblPassword
            // 
            this.lblPassword.Text = "Password:";
            this.lblPassword.Location = new System.Drawing.Point(30, 70);
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(120, 30);
            this.txtUsername.Size = new System.Drawing.Size(150, 22);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(120, 70);
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(150, 22);
            // 
            // btnLogin
            // 
            this.btnLogin.Text = "Login";
            this.btnLogin.Location = new System.Drawing.Point(120, 110);
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // LoginForm3
            // 
            this.ClientSize = new System.Drawing.Size(320, 170);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.btnLogin);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Login";
            this.ResumeLayout(false);
        }
    }
}
