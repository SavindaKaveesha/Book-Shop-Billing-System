namespace bookShop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            Myprogress = new ProgressBar();
            label2 = new Label();
            presentageLab = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(194, 82);
            label1.Name = "label1";
            label1.Size = new Size(473, 41);
            label1.TabIndex = 0;
            label1.Text = "Book Shop Management System";
            // 
            // Myprogress
            // 
            Myprogress.Location = new Point(12, 237);
            Myprogress.Name = "Myprogress";
            Myprogress.Size = new Size(781, 29);
            Myprogress.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.LimeGreen;
            label2.Location = new Point(12, 203);
            label2.Name = "label2";
            label2.Size = new Size(127, 31);
            label2.TabIndex = 2;
            label2.Text = "Loading......";
            // 
            // presentageLab
            // 
            presentageLab.AutoSize = true;
            presentageLab.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            presentageLab.ForeColor = Color.LimeGreen;
            presentageLab.Location = new Point(138, 205);
            presentageLab.Name = "presentageLab";
            presentageLab.Size = new Size(33, 31);
            presentageLab.TabIndex = 3;
            presentageLab.Text = "%";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(779, 2);
            label3.Name = "label3";
            label3.Size = new Size(24, 28);
            label3.TabIndex = 4;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(805, 292);
            Controls.Add(label3);
            Controls.Add(presentageLab);
            Controls.Add(label2);
            Controls.Add(Myprogress);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar Myprogress;
        private Label label2;
        private Label presentageLab;
        private System.Windows.Forms.Timer timer1;
        private Label label3;
    }
}