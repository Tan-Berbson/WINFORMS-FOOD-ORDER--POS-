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
            txt_username = new TextBox();
            btn_login = new Button();
            label1 = new Label();
            txt_password = new TextBox();
            btn_signup = new Button();
            SuspendLayout();
            // 
            // txt_username
            // 
            txt_username.Location = new Point(91, 150);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(147, 23);
            txt_username.TabIndex = 0;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(91, 258);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(147, 23);
            btn_login.TabIndex = 1;
            btn_login.Text = "Log In";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 86);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 2;
            label1.Text = "Log In";
            // 
            // txt_password
            // 
            txt_password.Location = new Point(91, 195);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(147, 23);
            txt_password.TabIndex = 3;
            // 
            // btn_signup
            // 
            btn_signup.Location = new Point(91, 301);
            btn_signup.Name = "btn_signup";
            btn_signup.Size = new Size(147, 23);
            btn_signup.TabIndex = 4;
            btn_signup.Text = "Sign up";
            btn_signup.UseVisualStyleBackColor = true;
            btn_signup.Click += btn_signup_Click;
            // 
            // frm_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(329, 450);
            Controls.Add(btn_signup);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(txt_username);
            Name = "frm_login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_username;
        private Button btn_login;
        private Label label1;
        private TextBox txt_password;
        private Button btn_signup;
    }
}
