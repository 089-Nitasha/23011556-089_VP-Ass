using System;
using System.Linq;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program3_LibrarySystem
{
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
            LoadBooks();
        }

        private void LoadBooks()
        {
            listBoxBooks.Items.Clear();
            foreach (var book in DashboardForm3.Books.Where(b => b.IsAvailable))
                listBoxBooks.Items.Add(book.Title);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (listBoxBooks.SelectedItem != null)
            {
                var book = DashboardForm3.Books.FirstOrDefault(b => b.Title == listBoxBooks.SelectedItem.ToString());
                if (book != null)
                {
                    book.IsAvailable = false;
                    MessageBox.Show($"You borrowed: {book.Title}");
                    LoadBooks();
                }
            }
        }
    }
}
