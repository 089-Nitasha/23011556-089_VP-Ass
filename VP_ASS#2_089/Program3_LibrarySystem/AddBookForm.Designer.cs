namespace VP_ASS_2_089.Program3_LibrarySystem
{
    partial class AddBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSave;

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Text = "Title:";
            this.lblTitle.Location = new System.Drawing.Point(30, 30);
            // 
            // lblAuthor
            // 
            this.lblAuthor.Text = "Author:";
            this.lblAuthor.Location = new System.Drawing.Point(30, 70);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(100, 30);
            this.txtTitle.Size = new System.Drawing.Size(150, 22);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(100, 70);
            this.txtAuthor.Size = new System.Drawing.Size(150, 22);
            // 
            // btnSave
            // 
            this.btnSave.Text = "Save";
            this.btnSave.Location = new System.Drawing.Point(100, 110);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // AddBookForm
            // 
            this.ClientSize = new System.Drawing.Size(300, 170);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnSave);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Book";
            this.ResumeLayout(false);
        }
    }
}
