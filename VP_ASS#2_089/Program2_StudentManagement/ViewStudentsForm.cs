using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program2_StudentSystem
{
    public partial class ViewStudentsForm : Form
    {
        public ViewStudentsForm()
        {
            InitializeComponent();
            dgvStudents.DataSource = null;
            dgvStudents.DataSource = DashboardForm.Students;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow != null)
            {
                DashboardForm.Students.RemoveAt(dgvStudents.CurrentRow.Index);
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = DashboardForm.Students;
            }
        }
    }
}
