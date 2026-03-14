namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_createacccashier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_createacccashier));
            txt_managername = new TextBox();
            btn_create = new Button();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_back = new Button();
            panel2 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            lbl_warningusername = new Label();
            lbl_warningpassword = new Label();
            chk_showpass = new CheckBox();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_managername
            // 
            txt_managername.Font = new Font("Segoe UI", 13F);
            txt_managername.Location = new Point(110, 185);
            txt_managername.Name = "txt_managername";
            txt_managername.ReadOnly = true;
            txt_managername.Size = new Size(267, 31);
            txt_managername.TabIndex = 0;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.FromArgb(52, 94, 104);
            btn_create.FlatStyle = FlatStyle.Popup;
            btn_create.Location = new Point(111, 381);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(266, 34);
            btn_create.TabIndex = 1;
            btn_create.Text = "create";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 13F);
            txt_username.Location = new Point(111, 253);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(266, 31);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 13F);
            txt_password.Location = new Point(110, 320);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(266, 31);
            txt_password.TabIndex = 4;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(200, 205, 210);
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.ForeColor = Color.FromArgb(45, 60, 70);
            btn_back.Location = new Point(111, 439);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(266, 34);
            btn_back.TabIndex = 5;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 94, 104);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(487, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(483, 614);
            panel2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 17F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(129, 198, 200);
            label6.Location = new Point(178, 378);
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
            label5.Location = new Point(131, 332);
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
            label4.Location = new Point(20, 584);
            label4.Name = "label4";
            label4.Size = new Size(451, 20);
            label4.TabIndex = 10;
            label4.Text = "© 2025 Food Ordering System(POS) Since 2025. All rights reserved.";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(87, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(318, 197);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F);
            label3.ForeColor = Color.FromArgb(45, 60, 70);
            label3.Location = new Point(65, 73);
            label3.Name = "label3";
            label3.Size = new Size(351, 45);
            label3.TabIndex = 12;
            label3.Text = "Create Cashier Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.FromArgb(45, 60, 70);
            label1.Location = new Point(111, 161);
            label1.Name = "label1";
            label1.Size = new Size(72, 21);
            label1.TabIndex = 13;
            label1.Text = "Manager";
            // 
            // lbl_warningusername
            // 
            lbl_warningusername.AutoSize = true;
            lbl_warningusername.Font = new Font("Segoe UI", 12F);
            lbl_warningusername.ForeColor = Color.FromArgb(45, 60, 70);
            lbl_warningusername.Location = new Point(111, 229);
            lbl_warningusername.Name = "lbl_warningusername";
            lbl_warningusername.Size = new Size(88, 21);
            lbl_warningusername.TabIndex = 14;
            lbl_warningusername.Text = "User Name";
            // 
            // lbl_warningpassword
            // 
            lbl_warningpassword.AutoSize = true;
            lbl_warningpassword.Font = new Font("Segoe UI", 12F);
            lbl_warningpassword.ForeColor = Color.FromArgb(45, 60, 70);
            lbl_warningpassword.Location = new Point(111, 296);
            lbl_warningpassword.Name = "lbl_warningpassword";
            lbl_warningpassword.Size = new Size(76, 21);
            lbl_warningpassword.TabIndex = 15;
            lbl_warningpassword.Text = "Password";
            // 
            // chk_showpass
            // 
            chk_showpass.AutoSize = true;
            chk_showpass.Location = new Point(358, 328);
            chk_showpass.Name = "chk_showpass";
            chk_showpass.Size = new Size(15, 14);
            chk_showpass.TabIndex = 16;
            chk_showpass.UseVisualStyleBackColor = true;
            chk_showpass.CheckedChanged += chk_showpass_CheckedChanged;
            // 
            // frm_createacccashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 614);
            Controls.Add(chk_showpass);
            Controls.Add(lbl_warningpassword);
            Controls.Add(lbl_warningusername);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(txt_managername);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(btn_create);
            Name = "frm_createacccashier";
            Text = "frm_createacccashier";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_managername;
        private Button btn_create;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_back;
        private Panel panel2;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label1;
        private Label lbl_warningusername;
        private Label lbl_warningpassword;
        private CheckBox chk_showpass;
    }
}