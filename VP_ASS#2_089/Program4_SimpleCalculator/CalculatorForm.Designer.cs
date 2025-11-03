namespace VP_ASS_2_089.Program4_SimpleCalculator
{
    partial class CalculatorForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMul;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnShowHistory;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMul = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnShowHistory = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();

            this.txtNum1.Location = new System.Drawing.Point(30, 20);
            this.txtNum1.PlaceholderText = "First number";
            this.txtNum2.Location = new System.Drawing.Point(30, 60);
            this.txtNum2.PlaceholderText = "Second number";

            this.btnAdd.Location = new System.Drawing.Point(30, 100);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnSub.Location = new System.Drawing.Point(120, 100);
            this.btnSub.Text = "Subtract";
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);

            this.btnMul.Location = new System.Drawing.Point(30, 140);
            this.btnMul.Text = "Multiply";
            this.btnMul.Click += new System.EventHandler(this.btnMul_Click);

            this.btnDiv.Location = new System.Drawing.Point(120, 140);
            this.btnDiv.Text = "Divide";
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);

            this.lblResult.Location = new System.Drawing.Point(30, 180);
            this.lblResult.Size = new System.Drawing.Size(200, 25);
            this.lblResult.Text = "Result:";

            this.btnShowHistory.Location = new System.Drawing.Point(30, 210);
            this.btnShowHistory.Text = "Show History";
            this.btnShowHistory.Click += new System.EventHandler(this.btnShowHistory_Click);

            this.ClientSize = new System.Drawing.Size(280, 260);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnMul);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnShowHistory);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Simple Calculator - by Zeshan Javed";
            this.ResumeLayout(false);
        }
    }
}
