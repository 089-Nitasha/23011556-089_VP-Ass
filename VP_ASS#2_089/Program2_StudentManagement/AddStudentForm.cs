using System;
using System.Formats.Asn1;
using System.Windows.Forms;
using System.Xml.Linq;

namespace VP_ASS_2_089.Program2_StudentSystem
{
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtAge.Text) || string.IsNullOrWhiteSpace(txtClass.Text))
            {
                MessageBox.Show("Fill all fields!");
                return;
            }

            DashboardForm.Students.Add(new Student
            {
                Name = txtName.Text,
                Age = int.Parse(txtAge.Text),
                Class = txtClass.Text
            });

            MessageBox.Show("Student added!");
            this.Close();
        }
    }
}
