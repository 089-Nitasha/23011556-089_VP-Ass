using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VP_ASS_2_089.Program4_SimpleCalculator
{
    public partial class CalculatorForm : Form
    {
        public static List<string> history = new List<string>();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) => Calculate("+");
        private void btnSub_Click(object sender, EventArgs e) => Calculate("-");
        private void btnMul_Click(object sender, EventArgs e) => Calculate("*");
        private void btnDiv_Click(object sender, EventArgs e) => Calculate("/");

        private void Calculate(string op)
        {
            try
            {
                double num1 = double.Parse(txtNum1.Text);
                double num2 = double.Parse(txtNum2.Text);
                double result = 0;

                switch (op)
                {
                    case "+": result = num1 + num2; break;
                    case "-": result = num1 - num2; break;
                    case "*": result = num1 * num2; break;
                    case "/":
                        if (num2 == 0) throw new DivideByZeroException();
                        result = num1 / num2;
                        break;
                }

                string record = $"{num1} {op} {num2} = {result}";
                history.Add(record);
                lblResult.Text = "Result: " + result;
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter valid numbers!");
            }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            HistoryForm hf = new HistoryForm();
            hf.Show();
        }
    }
}
