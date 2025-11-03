namespace VP_ASS_2_089
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnProgram1;
        private System.Windows.Forms.Button btnProgram2;
        private System.Windows.Forms.Button btnProgram3;
        private System.Windows.Forms.Button btnProgram4;



        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnProgram1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProgram1
            // 
            this.btnProgram1.Location = new System.Drawing.Point(50, 30);
            this.btnProgram1.Name = "btnProgram1";
            this.btnProgram1.Size = new System.Drawing.Size(200, 40);
            this.btnProgram1.TabIndex = 0;
            this.btnProgram1.Text = "Program 1: Login Navigation";
            this.btnProgram1.UseVisualStyleBackColor = true;
            this.btnProgram1.Click += new System.EventHandler(this.btnProgram1_Click);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(300, 120);
            this.Controls.Add(this.btnProgram1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multi Program Main Menu";
            this.ResumeLayout(false);

            // btnProgram2
            this.btnProgram2 = new System.Windows.Forms.Button();
            this.btnProgram2.Location = new System.Drawing.Point(50, 80);
            this.btnProgram2.Name = "btnProgram2";
            this.btnProgram2.Size = new System.Drawing.Size(200, 40);
            this.btnProgram2.TabIndex = 1;
            this.btnProgram2.Text = "Program 2: Student System";
            this.btnProgram2.UseVisualStyleBackColor = true;
            this.btnProgram2.Click += new System.EventHandler(this.btnProgram2_Click);

            // Add button to form
            this.Controls.Add(this.btnProgram2);

            this.btnProgram3 = new System.Windows.Forms.Button();
            this.btnProgram3.Location = new System.Drawing.Point(50, 130);
            this.btnProgram3.Size = new System.Drawing.Size(200, 40);
            this.btnProgram3.Text = "Program 3: Library System";
            this.btnProgram3.Click += new System.EventHandler(this.btnProgram3_Click);
            this.Controls.Add(this.btnProgram3);

            // btnProgram4
            this.btnProgram4 = new System.Windows.Forms.Button();
            this.btnProgram4.Location = new System.Drawing.Point(50, 180);
            this.btnProgram4.Name = "btnProgram4";
            this.btnProgram4.Size = new System.Drawing.Size(200, 40);
            this.btnProgram4.TabIndex = 3;
            this.btnProgram4.Text = "Program 4: Calculator";
            this.btnProgram4.UseVisualStyleBackColor = true;
            this.btnProgram4.Click += new System.EventHandler(this.btnProgram4_Click);
            this.Controls.Add(this.btnProgram4);


        }
    }
}
