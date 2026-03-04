namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_cashierlogoutauth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_cashierlogoutauth));
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            txt_managername = new TextBox();
            btn_procced = new Button();
            txt_password = new TextBox();
            label1 = new Label();
            label7 = new Label();
            txt_cashiername = new TextBox();
            btn_back = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 614);
            panel1.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(129, 198, 200);
            label6.Location = new Point(161, 371);
            label6.Name = "label6";
            label6.Size = new Size(153, 31);
            label6.TabIndex = 11;
            label6.Text = "System (POS)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(118, 332);
            label5.Name = "label5";
            label5.Size = new Size(245, 46);
            label5.TabIndex = 10;
            label5.Text = "Food Ordering";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(14, 585);
            label4.Name = "label4";
            label4.Size = new Size(451, 20);
            label4.TabIndex = 10;
            label4.Text = "© 2025 Food Ordering System(POS) Since 2025. All rights reserved.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 189);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(45, 60, 70);
            label3.Location = new Point(600, 349);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 17;
            label3.Text = "Manager Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = Color.FromArgb(45, 60, 70);
            label2.Location = new Point(600, 200);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 16;
            label2.Text = "Manager Name";
            // 
            // txt_managername
            // 
            txt_managername.Font = new Font("Segoe UI", 13F);
            txt_managername.Location = new Point(600, 223);
            txt_managername.Name = "txt_managername";
            txt_managername.ReadOnly = true;
            txt_managername.Size = new Size(266, 31);
            txt_managername.TabIndex = 12;
            // 
            // btn_procced
            // 
            btn_procced.BackColor = Color.FromArgb(52, 94, 104);
            btn_procced.FlatStyle = FlatStyle.Popup;
            btn_procced.ForeColor = SystemColors.Control;
            btn_procced.Location = new Point(600, 421);
            btn_procced.Name = "btn_procced";
            btn_procced.Size = new Size(266, 34);
            btn_procced.TabIndex = 13;
            btn_procced.Text = "Procced";
            btn_procced.UseVisualStyleBackColor = false;
            btn_procced.Click += btn_procced_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 13F);
            txt_password.Location = new Point(600, 372);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(266, 31);
            txt_password.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 60, 70);
            label1.Location = new Point(550, 125);
            label1.Name = "label1";
            label1.Size = new Size(356, 47);
            label1.TabIndex = 14;
            label1.Text = "Manager Permission";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F);
            label7.ForeColor = Color.FromArgb(45, 60, 70);
            label7.Location = new Point(600, 276);
            label7.Name = "label7";
            label7.Size = new Size(101, 20);
            label7.TabIndex = 19;
            label7.Text = "Cashier Name";
            // 
            // txt_cashiername
            // 
            txt_cashiername.Font = new Font("Segoe UI", 13F);
            txt_cashiername.Location = new Point(600, 299);
            txt_cashiername.Name = "txt_cashiername";
            txt_cashiername.ReadOnly = true;
            txt_cashiername.Size = new Size(266, 31);
            txt_cashiername.TabIndex = 18;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(52, 94, 104);
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.ForeColor = SystemColors.Control;
            btn_back.Location = new Point(600, 472);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(266, 34);
            btn_back.TabIndex = 20;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // frm_cashierlogoutauth
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 614);
            Controls.Add(btn_back);
            Controls.Add(label7);
            Controls.Add(txt_cashiername);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txt_managername);
            Controls.Add(txt_password);
            Controls.Add(btn_procced);
            Name = "frm_cashierlogoutauth";
            Text = "frm_cashierlogoutauth";
            Load += frm_cashierlogoutauth_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox txt_managername;
        private Button btn_procced;
        private TextBox txt_password;
        private Label label1;
        private Label label7;
        private TextBox txt_cashiername;
        private Button btn_back;
    }
}