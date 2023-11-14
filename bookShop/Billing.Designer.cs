namespace bookShop
{
    partial class Billing
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Billing));
            bookGDV = new DataGridView();
            label4 = new Label();
            resetBtn = new Button();
            qtyTxt = new TextBox();
            priceTxt = new TextBox();
            label12 = new Label();
            label11 = new Label();
            addToBillBtn = new Button();
            label8 = new Label();
            panel1 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel7 = new Panel();
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            panel6 = new Panel();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            totalLbl = new Label();
            label3 = new Label();
            printBtn = new Button();
            billGDV = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            itemTxt = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel5 = new Panel();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)bookGDV).BeginInit();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)billGDV).BeginInit();
            SuspendLayout();
            // 
            // bookGDV
            // 
            bookGDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bookGDV.BackgroundColor = Color.White;
            bookGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookGDV.Location = new Point(48, 210);
            bookGDV.Name = "bookGDV";
            bookGDV.RowHeadersWidth = 51;
            bookGDV.RowTemplate.Height = 29;
            bookGDV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            bookGDV.Size = new Size(833, 191);
            bookGDV.TabIndex = 19;
            bookGDV.CellContentClick += bookGDV_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(429, 416);
            label4.Name = "label4";
            label4.Size = new Size(45, 31);
            label4.TabIndex = 18;
            label4.Text = "Bill";
            // 
            // resetBtn
            // 
            resetBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            resetBtn.Location = new Point(716, 163);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(165, 41);
            resetBtn.TabIndex = 16;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // qtyTxt
            // 
            qtyTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            qtyTxt.Location = new Point(227, 170);
            qtyTxt.Name = "qtyTxt";
            qtyTxt.Size = new Size(121, 34);
            qtyTxt.TabIndex = 11;
            // 
            // priceTxt
            // 
            priceTxt.Enabled = false;
            priceTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            priceTxt.Location = new Point(367, 170);
            priceTxt.Name = "priceTxt";
            priceTxt.Size = new Size(156, 34);
            priceTxt.TabIndex = 10;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(410, 133);
            label12.Name = "label12";
            label12.Size = new Size(64, 31);
            label12.TabIndex = 9;
            label12.Text = "Price";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(267, 133);
            label11.Name = "label11";
            label11.Size = new Size(50, 31);
            label11.TabIndex = 8;
            label11.Text = "Qty";
            // 
            // addToBillBtn
            // 
            addToBillBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            addToBillBtn.Location = new Point(541, 163);
            addToBillBtn.Name = "addToBillBtn";
            addToBillBtn.Size = new Size(165, 41);
            addToBillBtn.TabIndex = 5;
            addToBillBtn.Text = "Add To Bill";
            addToBillBtn.UseVisualStyleBackColor = true;
            addToBillBtn.Click += addToBillBtn_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.RoyalBlue;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(1127, 9);
            label8.Name = "label8";
            label8.Size = new Size(29, 31);
            label8.TabIndex = 10;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(panel9);
            panel1.Controls.Add(panel8);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, -11);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 768);
            panel1.TabIndex = 8;
            // 
            // panel9
            // 
            panel9.BackColor = SystemColors.Window;
            panel9.Location = new Point(-1, 738);
            panel9.Name = "panel9";
            panel9.Size = new Size(270, 10);
            panel9.TabIndex = 25;
            // 
            // panel8
            // 
            panel8.BackColor = SystemColors.Window;
            panel8.Location = new Point(-4, 660);
            panel8.Name = "panel8";
            panel8.Size = new Size(270, 10);
            panel8.TabIndex = 17;
            // 
            // panel7
            // 
            panel7.BackColor = SystemColors.Window;
            panel7.Location = new Point(-2, 580);
            panel7.Name = "panel7";
            panel7.Size = new Size(270, 10);
            panel7.TabIndex = 16;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(pictureBox1);
            panel4.Controls.Add(label5);
            panel4.Location = new Point(21, 598);
            panel4.Name = "panel4";
            panel4.Size = new Size(211, 53);
            panel4.TabIndex = 15;
            panel4.Click += panel4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.right_2767192;
            pictureBox1.Location = new Point(-18, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(83, 9);
            label5.Name = "label5";
            label5.Size = new Size(118, 31);
            label5.TabIndex = 7;
            label5.Text = "Properties";
            label5.Click += label5_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Transparent;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(pictureBox3);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(21, 679);
            panel6.Name = "panel6";
            panel6.Size = new Size(211, 53);
            panel6.TabIndex = 14;
            panel6.Click += panel6_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.right_2767192;
            pictureBox3.Location = new Point(-18, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(104, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(83, 9);
            label6.Name = "label6";
            label6.Size = new Size(92, 31);
            label6.TabIndex = 7;
            label6.Text = "Log out";
            label6.Click += label6_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gainsboro;
            panel2.Location = new Point(522, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(453, 523);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(totalLbl);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(printBtn);
            panel3.Controls.Add(billGDV);
            panel3.Controls.Add(bookGDV);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(resetBtn);
            panel3.Controls.Add(qtyTxt);
            panel3.Controls.Add(priceTxt);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(addToBillBtn);
            panel3.Controls.Add(itemTxt);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(238, -8);
            panel3.Name = "panel3";
            panel3.Size = new Size(926, 759);
            panel3.TabIndex = 9;
            // 
            // totalLbl
            // 
            totalLbl.AutoSize = true;
            totalLbl.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            totalLbl.Location = new Point(437, 649);
            totalLbl.Name = "totalLbl";
            totalLbl.Size = new Size(0, 31);
            totalLbl.TabIndex = 23;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(339, 649);
            label3.Name = "label3";
            label3.Size = new Size(86, 31);
            label3.TabIndex = 22;
            label3.Text = "Total  : ";
            // 
            // printBtn
            // 
            printBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            printBtn.Location = new Point(367, 695);
            printBtn.Name = "printBtn";
            printBtn.Size = new Size(165, 41);
            printBtn.TabIndex = 21;
            printBtn.Text = "Print";
            printBtn.UseVisualStyleBackColor = true;
            printBtn.Click += printBtn_Click;
            // 
            // billGDV
            // 
            billGDV.BackgroundColor = SystemColors.ButtonHighlight;
            billGDV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            billGDV.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            billGDV.Location = new Point(133, 450);
            billGDV.Name = "billGDV";
            billGDV.RowHeadersWidth = 51;
            billGDV.RowTemplate.Height = 29;
            billGDV.Size = new Size(680, 188);
            billGDV.TabIndex = 20;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Iteam";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Qty";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Total";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // itemTxt
            // 
            itemTxt.Enabled = false;
            itemTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemTxt.Location = new Point(48, 170);
            itemTxt.Name = "itemTxt";
            itemTxt.Size = new Size(153, 34);
            itemTxt.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(51, 133);
            label2.Name = "label2";
            label2.Size = new Size(139, 31);
            label2.TabIndex = 1;
            label2.Text = "Iteam Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.RoyalBlue;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(296, 49);
            label1.Name = "label1";
            label1.Size = new Size(246, 46);
            label1.TabIndex = 0;
            label1.Text = "Billing System";
            // 
            // panel5
            // 
            panel5.BackColor = Color.RoyalBlue;
            panel5.Location = new Point(-1, -15);
            panel5.Name = "panel5";
            panel5.Size = new Size(924, 126);
            panel5.TabIndex = 24;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // Billing
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 752);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Billing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Billing";
            ((System.ComponentModel.ISupportInitialize)bookGDV).EndInit();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)billGDV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView bookGDV;
        private Label label4;
        private Button resetBtn;
        private TextBox qtyTxt;
        private TextBox priceTxt;
        private Label label12;
        private Label label11;
        private Button addToBillBtn;
        private Label label8;
        private Panel panel1;
        private Panel panel6;
        private PictureBox pictureBox3;
        private Label label6;
        private Panel panel2;
        private Panel panel3;
        private TextBox itemTxt;
        private Label label2;
        private Label label1;
        private DataGridView billGDV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button printBtn;
        private Label totalLbl;
        private Label label3;
        private Panel panel4;
        private PictureBox pictureBox1;
        private Label label5;
        private Panel panel5;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
        private Panel panel9;
        private Panel panel8;
        private Panel panel7;
    }
}