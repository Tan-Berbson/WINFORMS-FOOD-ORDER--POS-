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
            txt_managername = new TextBox();
            btn_create = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_back = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_managername
            // 
            txt_managername.Location = new Point(326, 12);
            txt_managername.Name = "txt_managername";
            txt_managername.ReadOnly = true;
            txt_managername.Size = new Size(100, 23);
            txt_managername.TabIndex = 0;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(100, 264);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(163, 23);
            btn_create.TabIndex = 1;
            btn_create.Text = "create";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 93);
            label1.Name = "label1";
            label1.Size = new Size(134, 15);
            label1.TabIndex = 2;
            label1.Text = "Create Casher Acccount";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_managername);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(438, 58);
            panel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 15);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 6;
            label2.Text = "manager";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(100, 156);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(163, 23);
            txt_username.TabIndex = 1;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(100, 207);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(163, 23);
            txt_password.TabIndex = 4;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(100, 304);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(163, 23);
            btn_back.TabIndex = 5;
            btn_back.Text = "back";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // frm_createacccashier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 450);
            Controls.Add(btn_back);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(btn_create);
            Name = "frm_createacccashier";
            Text = "frm_createacccashier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_managername;
        private Button btn_create;
        private Label label1;
        private Panel panel1;
        private Label label2;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_back;
    }
}