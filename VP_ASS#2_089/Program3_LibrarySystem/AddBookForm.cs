using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program3_LibrarySystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Book book = new Book
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                IsAvailable = true
            };
            DashboardForm3.Books.Add(book);
            MessageBox.Show("Book added successfully!");
            this.Close();
        }
    }
}
