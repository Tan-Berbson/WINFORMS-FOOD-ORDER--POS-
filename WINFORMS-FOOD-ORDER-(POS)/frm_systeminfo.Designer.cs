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
            panel8 = new Panel();
            label2 = new Label();
            panel6 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel6.SuspendLayout();
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
            // panel8
            // 
            panel8.Location = new Point(12, 116);
            panel8.Name = "panel8";
            panel8.Size = new Size(1073, 688);
            panel8.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(4, 9);
            label2.Name = "label2";
            label2.Size = new Size(260, 25);
            label2.TabIndex = 4;
            label2.Text = " What Does This System Do?";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 94, 104);
            panel6.Controls.Add(label2);
            panel6.Location = new Point(12, 67);
            panel6.Name = "panel6";
            panel6.Size = new Size(1073, 43);
            panel6.TabIndex = 2;
            // 
            // frm_systeminfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 803);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Name = "frm_systeminfo";
            Text = "frm_systeminfo";
            Load += frm_systeminfo_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox txt_username;
        private Button btn_dashboard;
        private Button btn_logout;
        private Panel panel8;
        private Label label2;
        private Panel panel6;
    }
}