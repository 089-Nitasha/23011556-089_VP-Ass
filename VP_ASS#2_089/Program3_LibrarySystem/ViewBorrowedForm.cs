using System.Linq;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program3_LibrarySystem
{
    public partial class ViewBorrowedForm : Form
    {
        public ViewBorrowedForm()
        {
            InitializeComponent();
            dataGridView1.DataSource = DashboardForm3.Books.Where(b => !b.IsAvailable).Select(b => new { b.Title, b.Author }).ToList();
        }
    }
}
