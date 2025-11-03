using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program3_LibrarySystem
{
    public partial class DashboardForm3 : Form
    {
        public static List<Book> Books = new List<Book>();

        public DashboardForm3()
        {
            InitializeComponent();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm addForm = new AddBookForm();
            addForm.ShowDialog();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBookForm borrowForm = new BorrowBookForm();
            borrowForm.ShowDialog();
        }

        private void btnViewBorrowed_Click(object sender, EventArgs e)
        {
            ViewBorrowedForm viewForm = new ViewBorrowedForm();
            viewForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
