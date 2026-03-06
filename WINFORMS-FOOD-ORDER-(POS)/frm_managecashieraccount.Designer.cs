namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_managecashieraccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_managecashieraccount));
            panel1 = new Panel();
            btn_dashboard = new Button();
            btn_createcashieracc = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txt_username = new TextBox();
            btn_logout = new Button();
            panel2 = new Panel();
            dgv_allcashieracc = new DataGridView();
            panel5 = new Panel();
            btn_showpassword = new Button();
            label1 = new Label();
            panel3 = new Panel();
            dgv_cashierreport = new DataGridView();
            panel4 = new Panel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_allcashieracc).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_cashierreport).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(btn_createcashieracc);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(btn_logout);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 57);
            panel1.TabIndex = 1;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Location = new Point(709, 8);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(122, 38);
            btn_dashboard.TabIndex = 15;
            btn_dashboard.Text = "Dash Board";
            btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // btn_createcashieracc
            // 
            btn_createcashieracc.Location = new Point(837, 8);
            btn_createcashieracc.Name = "btn_createcashieracc";
            btn_createcashieracc.Size = new Size(122, 38);
            btn_createcashieracc.TabIndex = 14;
            btn_createcashieracc.Text = "Create Cashier Account";
            btn_createcashieracc.UseVisualStyleBackColor = true;
            btn_createcashieracc.Click += btn_createcashieracc_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(102, 20);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Admin Name";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(186, 12);
            txt_username.Name = "txt_username";
            txt_username.ReadOnly = true;
            txt_username.Size = new Size(173, 29);
            txt_username.TabIndex = 9;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(965, 8);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(122, 38);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_allcashieracc);
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(14, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(529, 717);
            panel2.TabIndex = 2;
            // 
            // dgv_allcashieracc
            // 
            dgv_allcashieracc.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_allcashieracc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_allcashieracc.Location = new Point(3, 47);
            dgv_allcashieracc.Name = "dgv_allcashieracc";
            dgv_allcashieracc.Size = new Size(523, 667);
            dgv_allcashieracc.TabIndex = 1;
            dgv_allcashieracc.CellContentClick += dgv_allcashieracc_CellContentClick;
            dgv_allcashieracc.SelectionChanged += dgv_allcashieracc_SelectionChanged;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 94, 104);
            panel5.Controls.Add(btn_showpassword);
            panel5.Controls.Add(label1);
            panel5.Location = new Point(3, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(523, 41);
            panel5.TabIndex = 1;
            // 
            // btn_showpassword
            // 
            btn_showpassword.Location = new Point(419, 7);
            btn_showpassword.Name = "btn_showpassword";
            btn_showpassword.Size = new Size(101, 27);
            btn_showpassword.TabIndex = 16;
            btn_showpassword.Text = "Show Password";
            btn_showpassword.UseVisualStyleBackColor = true;
            btn_showpassword.Click += btn_showpassword_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(103, 25);
            label1.TabIndex = 3;
            label1.Text = "All Cashier";
            // 
            // panel3
            // 
            panel3.Controls.Add(dgv_cashierreport);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(549, 77);
            panel3.Name = "panel3";
            panel3.Size = new Size(547, 717);
            panel3.TabIndex = 3;
            // 
            // dgv_cashierreport
            // 
            dgv_cashierreport.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_cashierreport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_cashierreport.Location = new Point(0, 47);
            dgv_cashierreport.Name = "dgv_cashierreport";
            dgv_cashierreport.Size = new Size(544, 667);
            dgv_cashierreport.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 94, 104);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(544, 41);
            panel4.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(12, 8);
            label2.Name = "label2";
            label2.Size = new Size(186, 25);
            label2.TabIndex = 4;
            label2.Text = "Cashier Sales Report";
            // 
            // frm_managecashieraccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 806);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_managecashieraccount";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_managecashieraccount";
            Load += frm_managecashieraccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_allcashieracc).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_cashierreport).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_dashboard;
        private Button btn_createcashieracc;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox txt_username;
        private Button btn_logout;
        private Panel panel2;
        private DataGridView dgv_allcashieracc;
        private Panel panel5;
        private Panel panel3;
        private DataGridView dgv_cashierreport;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Button btn_showpassword;
    }
}