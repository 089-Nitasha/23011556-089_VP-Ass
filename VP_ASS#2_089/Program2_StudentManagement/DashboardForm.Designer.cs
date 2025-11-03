namespace VP_ASS_2_089.Program2_StudentSystem
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(50, 30);
            this.btnAdd.Size = new System.Drawing.Size(120, 30);
            this.btnAdd.Text = "Add Student";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // btnView
            this.btnView.Location = new System.Drawing.Point(50, 70);
            this.btnView.Size = new System.Drawing.Size(120, 30);
            this.btnView.Text = "View Students";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);

            // btnExit
            this.btnExit.Location = new System.Drawing.Point(50, 110);
            this.btnExit.Size = new System.Drawing.Size(120, 30);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);

            // DashboardForm
            this.ClientSize = new System.Drawing.Size(220, 160);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnExit);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student System by Ali";
            this.ResumeLayout(false);
        }
    }
}
