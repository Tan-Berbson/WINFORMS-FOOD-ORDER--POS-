namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            txt_username = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            txt_password = new TextBox();
            btn_signup = new Button();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            lbl_warningusername = new Label();
            lbl_warningpassword = new Label();
            checkBox1 = new CheckBox();
            linllbl_systeminfo = new LinkLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 13F);
            txt_username.Location = new Point(609, 231);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(266, 31);
            txt_username.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(52, 94, 104);
            btn_login.FlatStyle = FlatStyle.Popup;
            btn_login.ForeColor = SystemColors.Control;
            btn_login.Location = new Point(609, 356);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(266, 34);
            btn_login.TabIndex = 1;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(45, 60, 70);
            label1.Location = new Point(679, 101);
            label1.Name = "label1";
            label1.Size = new Size(123, 47);
            label1.TabIndex = 2;
            label1.Text = "Log In";
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 13F);
            txt_password.Location = new Point(609, 301);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(266, 31);
            txt_password.TabIndex = 3;
            // 
            // btn_signup
            // 
            btn_signup.BackColor = Color.FromArgb(200, 205, 210);
            btn_signup.FlatStyle = FlatStyle.Popup;
            btn_signup.ForeColor = Color.FromArgb(45, 60, 70);
            btn_signup.Location = new Point(609, 409);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(266, 34);
            btn_signup.TabIndex = 4;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = false;
            btn_signup.Click += btn_signup_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 614);
            panel1.TabIndex = 5;
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
            // lbl_warningusername
            // 
            lbl_warningusername.AutoSize = true;
            lbl_warningusername.Font = new Font("Segoe UI", 11F);
            lbl_warningusername.ForeColor = Color.FromArgb(45, 60, 70);
            lbl_warningusername.Location = new Point(609, 208);
            lbl_warningusername.Name = "lbl_warningusername";
            lbl_warningusername.Size = new Size(82, 20);
            lbl_warningusername.TabIndex = 6;
            lbl_warningusername.Text = "User Name";
            // 
            // lbl_warningpassword
            // 
            lbl_warningpassword.AutoSize = true;
            lbl_warningpassword.Font = new Font("Segoe UI", 11F);
            lbl_warningpassword.ForeColor = Color.FromArgb(45, 60, 70);
            lbl_warningpassword.Location = new Point(609, 278);
            lbl_warningpassword.Name = "lbl_warningpassword";
            lbl_warningpassword.Size = new Size(70, 20);
            lbl_warningpassword.TabIndex = 7;
            lbl_warningpassword.Text = "Password";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(856, 309);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 8;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linllbl_systeminfo
            // 
            linllbl_systeminfo.AutoSize = true;
            linllbl_systeminfo.Font = new Font("Segoe UI", 10F);
            linllbl_systeminfo.ForeColor = Color.FromArgb(40, 90, 160);
            linllbl_systeminfo.Location = new Point(679, 588);
            linllbl_systeminfo.Name = "linllbl_systeminfo";
            linllbl_systeminfo.Size = new Size(163, 19);
            linllbl_systeminfo.TabIndex = 9;
            linllbl_systeminfo.TabStop = true;
            linllbl_systeminfo.Text = "How to Use the System? ";
            linllbl_systeminfo.LinkClicked += linllbl_systeminfo_LinkClicked;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(967, 614);
            Controls.Add(linllbl_systeminfo);
            Controls.Add(checkBox1);
            Controls.Add(lbl_warningpassword);
            Controls.Add(lbl_warningusername);
            Controls.Add(btn_signup);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += frm_login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private Button btn_login;
        private Label label1;
        private TextBox txt_password;
        private Button btn_signup;
        private Panel panel1;
        private Label lbl_warningpassword;
        private CheckBox checkBox1;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private LinkLabel linllbl_systeminfo;
        private Label label6;
        private Label lbl_warningusername;
    }
}
