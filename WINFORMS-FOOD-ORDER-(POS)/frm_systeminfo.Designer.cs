namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_systeminfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_systeminfo));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txt_username = new TextBox();
            btn_dashboard = new Button();
            btn_logout = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(btn_logout);
            panel1.Location = new Point(1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 57);
            panel1.TabIndex = 1;
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
            // btn_dashboard
            // 
            btn_dashboard.BackColor = Color.FromArgb(200, 205, 210);
            btn_dashboard.FlatStyle = FlatStyle.Popup;
            btn_dashboard.Location = new Point(837, 8);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(122, 38);
            btn_dashboard.TabIndex = 10;
            btn_dashboard.Text = "Dash Board";
            btn_dashboard.UseVisualStyleBackColor = false;
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
            panel2.Location = new Point(12, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(530, 698);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(560, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(530, 698);
            panel3.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 94, 104);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(528, 44);
            panel4.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 94, 104);
            panel5.Location = new Point(13, 93);
            panel5.Name = "panel5";
            panel5.Size = new Size(528, 44);
            panel5.TabIndex = 1;
            // 
            // frm_systeminfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 803);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_systeminfo";
            Text = "frm_systeminfo";
            Load += frm_systeminfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox txt_username;
        private Button btn_dashboard;
        private Button btn_logout;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}