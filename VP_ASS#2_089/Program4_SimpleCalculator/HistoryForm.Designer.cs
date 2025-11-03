namespace VP_ASS_2_089.Program4_SimpleCalculator
{
    partial class HistoryForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox listBox1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.ItemHeight = 15;

            this.ClientSize = new System.Drawing.Size(280, 260);
            this.Controls.Add(this.listBox1);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Calculation History";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.ResumeLayout(false);
        }
    }
}
