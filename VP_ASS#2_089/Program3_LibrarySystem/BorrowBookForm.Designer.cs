namespace VP_ASS_2_089.Program3_LibrarySystem
{
    partial class BorrowBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBoxBooks;
        private System.Windows.Forms.Button btnBorrow;

        private void InitializeComponent()
        {
            this.listBoxBooks = new System.Windows.Forms.ListBox();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxBooks
            // 
            this.listBoxBooks.Location = new System.Drawing.Point(30, 30);
            this.listBoxBooks.Size = new System.Drawing.Size(200, 100);
            // 
            // btnBorrow
            // 
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.Location = new System.Drawing.Point(30, 140);
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // BorrowBookForm
            // 
            this.ClientSize = new System.Drawing.Size(280, 200);
            this.Controls.Add(this.listBoxBooks);
            this.Controls.Add(this.btnBorrow);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            this.ResumeLayout(false);
        }
    }
}
