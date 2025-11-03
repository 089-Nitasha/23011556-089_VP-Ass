namespace VP_ASS_2_089.Program2_StudentSystem
{
    partial class AddStudentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Button btnSave;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox() { Left = 100, Top = 20, Width = 120, Height = 22 };
            this.txtAge = new System.Windows.Forms.TextBox() { Left = 100, Top = 60, Width = 120, Height = 22 };
            this.txtClass = new System.Windows.Forms.TextBox() { Left = 100, Top = 100, Width = 120,Height = 22 };
            this.btnSave = new System.Windows.Forms.Button() { Left = 100, Top = 140, Width = 150, Text = "Save" };
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.Controls.Add(new Label() { Left = 20, Top = 20, Text = "Name:" });
            this.Controls.Add(new Label() { Left = 20, Top = 60, Text = "Age:" });
            this.Controls.Add(new Label() { Left = 20, Top = 100, Text = "Class:" });
            this.Controls.Add(txtName);
            this.Controls.Add(txtAge);
            this.Controls.Add(txtClass);
            this.Controls.Add(btnSave);

            this.ClientSize = new System.Drawing.Size(280, 200);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Student";
        }
    }
}
