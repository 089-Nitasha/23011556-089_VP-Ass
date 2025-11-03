using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program2_StudentSystem
{
    public partial class DashboardForm : Form
    {
        public static List<Student> Students = new List<Student>();

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            addForm.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            ViewStudentsForm viewForm = new ViewStudentsForm();
            viewForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
