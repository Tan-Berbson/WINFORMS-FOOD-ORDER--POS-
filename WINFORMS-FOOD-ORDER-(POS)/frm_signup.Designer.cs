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
            btn_back = new Button();
            txt_password = new TextBox();
            label1 = new Label();
            btn_create = new Button();
            txt_username = new TextBox();
            SuspendLayout();
            // 
            // btn_back
            // 
            btn_back.Location = new Point(89, 282);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(147, 23);
            btn_back.TabIndex = 9;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(89, 176);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(147, 23);
            txt_password.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 67);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 7;
            label1.Text = "Sign Up";
            // 
            // btn_create
            // 
            btn_create.Location = new Point(89, 239);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(147, 23);
            btn_create.TabIndex = 6;
            btn_create.Text = "Create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(89, 131);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(147, 23);
            txt_username.TabIndex = 5;
            // 
            // frm_signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(312, 450);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(btn_create);
            Controls.Add(txt_username);
            Name = "frm_signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_back;
        private TextBox txt_password;
        private Label label1;
        private Button btn_create;
        private TextBox txt_username;
    }
}