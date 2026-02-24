namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_cashierDashboard
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
            panel1 = new Panel();
            btn_logout = new Button();
            label1 = new Label();
            txt_cashiername = new TextBox();
            label3 = new Label();
            txt_managername = new TextBox();
            pictureboxlogo = new PictureBox();
            panel2 = new Panel();
            panel11 = new Panel();
            panel9 = new Panel();
            panel8 = new Panel();
            panel10 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            panel7 = new Panel();
            btn_checkout = new Button();
            listView1 = new ListView();
            panel6 = new Panel();
            label2 = new Label();
            txt_total = new TextBox();
            panel5 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btn_logout);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_cashiername);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_managername);
            panel1.Controls.Add(pictureboxlogo);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 57);
            panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(965, 8);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(122, 38);
            btn_logout.TabIndex = 14;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(412, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 12;
            label1.Text = "Cashier Name:";
            // 
            // txt_cashiername
            // 
            txt_cashiername.Font = new Font("Segoe UI", 12F);
            txt_cashiername.Location = new Point(496, 12);
            txt_cashiername.Name = "txt_cashiername";
            txt_cashiername.ReadOnly = true;
            txt_cashiername.Size = new Size(173, 29);
            txt_cashiername.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 10;
            label3.Text = "Manager Name:";
            // 
            // txt_managername
            // 
            txt_managername.Font = new Font("Segoe UI", 12F);
            txt_managername.Location = new Point(216, 12);
            txt_managername.Name = "txt_managername";
            txt_managername.ReadOnly = true;
            txt_managername.Size = new Size(173, 29);
            txt_managername.TabIndex = 11;
            // 
            // pictureboxlogo
            // 
            pictureboxlogo.Location = new Point(12, 4);
            pictureboxlogo.Name = "pictureboxlogo";
            pictureboxlogo.Size = new Size(100, 50);
            pictureboxlogo.TabIndex = 1;
            pictureboxlogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel11);
            panel2.Controls.Add(panel9);
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel10);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(10, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(735, 708);
            panel2.TabIndex = 15;
            // 
            // panel11
            // 
            panel11.Location = new Point(391, 408);
            panel11.Name = "panel11";
            panel11.Size = new Size(268, 288);
            panel11.TabIndex = 4;
            // 
            // panel9
            // 
            panel9.Location = new Point(65, 408);
            panel9.Name = "panel9";
            panel9.Size = new Size(268, 288);
            panel9.TabIndex = 4;
            // 
            // panel8
            // 
            panel8.Location = new Point(391, 82);
            panel8.Name = "panel8";
            panel8.Size = new Size(268, 288);
            panel8.TabIndex = 4;
            // 
            // panel10
            // 
            panel10.Location = new Point(65, 82);
            panel10.Name = "panel10";
            panel10.Size = new Size(268, 288);
            panel10.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Location = new Point(3, 2);
            panel4.Name = "panel4";
            panel4.RightToLeft = RightToLeft.No;
            panel4.Size = new Size(732, 35);
            panel4.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(panel6);
            panel3.Location = new Point(751, 86);
            panel3.Name = "panel3";
            panel3.Size = new Size(336, 708);
            panel3.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_checkout);
            panel7.Location = new Point(6, 649);
            panel7.Name = "panel7";
            panel7.Size = new Size(327, 56);
            panel7.TabIndex = 17;
            // 
            // btn_checkout
            // 
            btn_checkout.Location = new Point(6, 9);
            btn_checkout.Name = "btn_checkout";
            btn_checkout.Size = new Size(321, 38);
            btn_checkout.TabIndex = 15;
            btn_checkout.Text = "Check Out";
            btn_checkout.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 41);
            listView1.Name = "listView1";
            listView1.Size = new Size(330, 539);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel6
            // 
            panel6.Controls.Add(label2);
            panel6.Controls.Add(txt_total);
            panel6.Location = new Point(3, 588);
            panel6.Name = "panel6";
            panel6.Size = new Size(330, 55);
            panel6.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F);
            label2.Location = new Point(9, 17);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 2;
            label2.Text = "Total:";
            // 
            // txt_total
            // 
            txt_total.Font = new Font("Segoe UI", 13F);
            txt_total.Location = new Point(68, 11);
            txt_total.Name = "txt_total";
            txt_total.Size = new Size(260, 31);
            txt_total.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.Location = new Point(751, 86);
            panel5.Name = "panel5";
            panel5.RightToLeft = RightToLeft.No;
            panel5.Size = new Size(336, 35);
            panel5.TabIndex = 2;
            // 
            // frm_cashierDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 806);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_cashierDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_cashierDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureboxlogo;
        private Label label1;
        private TextBox txt_cashiername;
        private Label label3;
        private TextBox txt_managername;
        private Button btn_logout;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private ListView listView1;
        private TextBox txt_total;
        private Button btn_checkout;
        private Panel panel6;
        private Panel panel5;
        private Panel panel7;
        private Label label2;
        private Panel panel11;
        private Panel panel9;
        private Panel panel8;
        private Panel panel10;
    }
}