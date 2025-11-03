using System;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program4_SimpleCalculator
{
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (string record in CalculatorForm.history)
            {
                listBox1.Items.Add(record);
            }
        }
    }
}
