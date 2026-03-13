namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_signup));
            btn_back = new Button();
            txt_password = new TextBox();
            btn_create = new Button();
            txt_username = new TextBox();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            lbl_warningusername = new Label();
            lbl_warningpassword = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(200, 205, 210);
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.ForeColor = Color.FromArgb(45, 60, 70);
            btn_back.Location = new Point(104, 429);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(266, 34);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // txt_password
            // 
            txt_password.Font = new Font("Segoe UI", 13F);
            txt_password.Location = new Point(104, 300);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(266, 31);
            txt_password.TabIndex = 8;
            // 
            // btn_create
            // 
            btn_create.BackColor = Color.FromArgb(52, 94, 104);
            btn_create.FlatStyle = FlatStyle.Popup;
            btn_create.Location = new Point(104, 363);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(266, 34);
            btn_create.TabIndex = 6;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = false;
            btn_create.Click += btn_create_Click;
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 13F);
            txt_username.Location = new Point(104, 226);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(266, 31);
            txt_username.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(484, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(483, 614);
            panel1.TabIndex = 10;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(45, 60, 70);
            label2.Location = new Point(165, 89);
            label2.Name = "label2";
            label2.Size = new Size(150, 47);
            label2.TabIndex = 11;
            label2.Text = "Sign Up";
            // 
            // lbl_warningusername
            // 
            lbl_warningusername.AutoSize = true;
            lbl_warningusername.Font = new Font("Segoe UI", 12F);
            lbl_warningusername.ForeColor = Color.FromArgb(45, 60, 70);
            lbl_warningusername.Location = new Point(104, 202);
            lbl_warningusername.Name = "lbl_warningusername";
            lbl_warningusername.Size = new Size(88, 21);
            lbl_warningusername.TabIndex = 12;
            lbl_warningusername.Text = "User Name";
            // 
            // lbl_warningpassword
            // 
            lbl_warningpassword.AutoSize = true;
            lbl_warningpassword.Font = new Font("Segoe UI", 12F);
            lbl_warningpassword.ForeColor = Color.FromArgb(45, 60, 70);
            lbl_warningpassword.Location = new Point(104, 276);
            lbl_warningpassword.Name = "lbl_warningpassword";
            lbl_warningpassword.Size = new Size(76, 21);
            lbl_warningpassword.TabIndex = 13;
            lbl_warningpassword.Text = "Password";
            // 
            // frm_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(242, 242, 242);
            ClientSize = new Size(967, 614);
            Controls.Add(lbl_warningpassword);
            Controls.Add(lbl_warningusername);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(btn_create);
            Controls.Add(txt_username);
            Name = "frm_signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_signup";
            Load += frm_signup_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private TextBox txt_password;
        private Button btn_create;
        private TextBox txt_username;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label lbl_warningusername;
        private Label lbl_warningpassword;
    }
}