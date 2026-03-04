namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_cashiersells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cashiersells));
            panel2 = new Panel();
            dgv_totalsells = new DataGridView();
            panel5 = new Panel();
            label2 = new Label();
            panel4 = new Panel();
            btn_logout = new Button();
            panel6 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            cmb_evaluate = new ComboBox();
            txt_totalsells = new TextBox();
            txt_cashier = new TextBox();
            panel7 = new Panel();
            label4 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            txt_cashiername = new TextBox();
            label3 = new Label();
            txt_managername = new TextBox();
            pictureboxlogo = new PictureBox();
            panel3 = new Panel();
            btn_back = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_totalsells).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel7.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_totalsells);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(12, 80);
            panel2.Name = "panel2";
            panel2.Size = new Size(628, 466);
            panel2.TabIndex = 0;
            // 
            // dgv_totalsells
            // 
            dgv_totalsells.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_totalsells.Location = new Point(3, 36);
            dgv_totalsells.Name = "dgv_totalsells";
            dgv_totalsells.Size = new Size(617, 427);
            dgv_totalsells.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 94, 104);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(628, 30);
            panel5.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(5, 4);
            label2.Name = "label2";
            label2.Size = new Size(84, 23);
            label2.TabIndex = 0;
            label2.Text = "Total Sells";
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_logout);
            panel4.Location = new Point(484, 552);
            panel4.Name = "panel4";
            panel4.Size = new Size(483, 50);
            panel4.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.BackColor = Color.FromArgb(52, 94, 104);
            btn_logout.FlatStyle = FlatStyle.Popup;
            btn_logout.Location = new Point(3, 3);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(480, 44);
            btn_logout.TabIndex = 6;
            btn_logout.Text = "Log Out / Save Data";
            btn_logout.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(242, 242, 242);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label5);
            panel6.Controls.Add(pictureBox1);
            panel6.Controls.Add(cmb_evaluate);
            panel6.Controls.Add(txt_totalsells);
            panel6.Controls.Add(txt_cashier);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(646, 80);
            panel6.Name = "panel6";
            panel6.Size = new Size(321, 466);
            panel6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(18, 348);
            label7.Name = "label7";
            label7.Size = new Size(138, 21);
            label7.TabIndex = 5;
            label7.Text = "Cashier Evaluation";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(19, 290);
            label6.Name = "label6";
            label6.Size = new Size(81, 21);
            label6.TabIndex = 4;
            label6.Text = "Total Sells:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 232);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 2;
            label5.Text = "Cashier:";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(82, 54);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 112);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // cmb_evaluate
            // 
            cmb_evaluate.Font = new Font("Segoe UI", 13F);
            cmb_evaluate.FormattingEnabled = true;
            cmb_evaluate.Items.AddRange(new object[] { "Exellent", "Very Good", "Good", "Fair", "Bad" });
            cmb_evaluate.Location = new Point(19, 372);
            cmb_evaluate.Name = "cmb_evaluate";
            cmb_evaluate.Size = new Size(285, 31);
            cmb_evaluate.TabIndex = 2;
            // 
            // txt_totalsells
            // 
            txt_totalsells.Font = new Font("Segoe UI", 13F);
            txt_totalsells.Location = new Point(19, 314);
            txt_totalsells.Name = "txt_totalsells";
            txt_totalsells.Size = new Size(285, 31);
            txt_totalsells.TabIndex = 1;
            // 
            // txt_cashier
            // 
            txt_cashier.Font = new Font("Segoe UI", 13F);
            txt_cashier.Location = new Point(18, 256);
            txt_cashier.Name = "txt_cashier";
            txt_cashier.Size = new Size(286, 31);
            txt_cashier.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 94, 104);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(321, 30);
            panel7.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(5, 4);
            label4.Name = "label4";
            label4.Size = new Size(151, 23);
            label4.TabIndex = 1;
            label4.Text = "Cashier Evaluation";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_cashiername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_managername);
            panel1.Controls.Add(pictureboxlogo);
            panel1.Location = new Point(0, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 57);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(412, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 12;
            label1.Text = "Cashier Name:";
            // 
            // txt_cashiername
            // 
            txt_cashiername.Font = new Font("Segoe UI", 12F);
            txt_cashiername.Location = new Point(496, 12);
            txt_cashiername.Name = "txt_cashiername";
            txt_cashiername.ReadOnly = true;
            txt_cashiername.Size = new Size(173, 29);
            txt_cashiername.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(118, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 10;
            label3.Text = "Manager Name:";
            // 
            // txt_managername
            // 
            txt_managername.Font = new Font("Segoe UI", 12F);
            txt_managername.Location = new Point(216, 12);
            txt_managername.Name = "txt_managername";
            txt_managername.ReadOnly = true;
            txt_managername.Size = new Size(173, 29);
            txt_managername.TabIndex = 11;
            // 
            // pictureboxlogo
            // 
            pictureboxlogo.Image = (Image)resources.GetObject("pictureboxlogo.Image");
            pictureboxlogo.Location = new Point(12, 4);
            pictureboxlogo.Name = "pictureboxlogo";
            pictureboxlogo.Size = new Size(82, 50);
            pictureboxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxlogo.TabIndex = 1;
            pictureboxlogo.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_back);
            panel3.Location = new Point(12, 552);
            panel3.Name = "panel3";
            panel3.Size = new Size(466, 50);
            panel3.TabIndex = 0;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(242, 242, 242);
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.Location = new Point(3, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(460, 44);
            btn_back.TabIndex = 7;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // frm_cashiersells
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 614);
            Controls.Add(panel1);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "frm_cashiersells";
            Text = "frm_cashiersells";
            Load += frm_cashiersells_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_totalsells).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private DataGridView dgv_totalsells;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private PictureBox pictureBox1;
        private ComboBox cmb_evaluate;
        private TextBox txt_totalsells;
        private TextBox txt_cashier;
        private Panel panel1;
        private Label label1;
        private TextBox txt_cashiername;
        private Label label3;
        private TextBox txt_managername;
        private PictureBox pictureboxlogo;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel3;
        private Button btn_logout;
        private Button btn_back;
    }
}