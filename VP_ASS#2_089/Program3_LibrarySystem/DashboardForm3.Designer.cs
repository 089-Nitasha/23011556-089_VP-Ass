namespace VP_ASS_2_089.Program3_LibrarySystem
{
    partial class DashboardForm3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnViewBorrowed;
        private System.Windows.Forms.Button btnExit;

        private void InitializeComponent()
        {
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnViewBorrowed = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.BackColor = System.Drawing.Color.LightGreen; // <— Different color for originality
            this.btnAddBook.Location = new System.Drawing.Point(50, 30);
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.Location = new System.Drawing.Point(50, 80);
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnViewBorrowed
            // 
            this.btnViewBorrowed.Text = "View Borrowed Books";
            this.btnViewBorrowed.Location = new System.Drawing.Point(50, 130);
            this.btnViewBorrowed.Click += new System.EventHandler(this.btnViewBorrowed_Click);
            // 
            // btnExit
            // 
            this.btnExit.Text = "Exit";
            this.btnExit.Location = new System.Drawing.Point(50, 180);
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DashboardForm3
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnBorrowBook);
            this.Controls.Add(this.btnViewBorrowed);
            this.Controls.Add(this.btnExit);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Library Dashboard";
            this.ResumeLayout(false);
        }
    }
}
