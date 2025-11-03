namespace VP_ASS_2_089.Program2_StudentSystem
{
    partial class ViewStudentsForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Button btnDelete;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView() { Left = 20, Top = 20, Width = 400, Height = 200 };
            this.btnDelete = new System.Windows.Forms.Button() { Left = 20, Top = 230, Width = 120, Text = "Delete Selected" };
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.Controls.Add(dgvStudents);
            this.Controls.Add(btnDelete);

            this.ClientSize = new System.Drawing.Size(450, 280);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Students";
        }
    }
}
