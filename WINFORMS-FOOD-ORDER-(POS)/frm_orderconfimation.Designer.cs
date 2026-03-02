namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_orderconfimation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_orderconfimation));
            panel1 = new Panel();
            label1 = new Label();
            txt_managername = new TextBox();
            txt_cashiername = new TextBox();
            pictureboxlogo = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            listView1 = new ListView();
            panel3 = new Panel();
            panel12 = new Panel();
            label11 = new Label();
            panel6 = new Panel();
            rb_creditcard = new RadioButton();
            rb_cash = new RadioButton();
            rb_gcash = new RadioButton();
            panel11 = new Panel();
            label10 = new Label();
            panel10 = new Panel();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            txt_customername = new TextBox();
            panel9 = new Panel();
            rb_takeout = new RadioButton();
            rb_dinein = new RadioButton();
            panel5 = new Panel();
            label4 = new Label();
            btn_back = new Button();
            panel8 = new Panel();
            label8 = new Label();
            txt_ordertotal = new TextBox();
            panel7 = new Panel();
            btn_confirm = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel12.SuspendLayout();
            panel6.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_managername);
            panel1.Controls.Add(txt_cashiername);
            panel1.Controls.Add(pictureboxlogo);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 57);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(403, 20);
            label1.Name = "label1";
            label1.Size = new Size(84, 15);
            label1.TabIndex = 17;
            label1.Text = "Cashier Name:";
            // 
            // txt_managername
            // 
            txt_managername.Font = new Font("Segoe UI", 12F);
            txt_managername.Location = new Point(207, 12);
            txt_managername.Name = "txt_managername";
            txt_managername.ReadOnly = true;
            txt_managername.Size = new Size(173, 29);
            txt_managername.TabIndex = 16;
            // 
            // txt_cashiername
            // 
            txt_cashiername.Font = new Font("Segoe UI", 12F);
            txt_cashiername.Location = new Point(487, 12);
            txt_cashiername.Name = "txt_cashiername";
            txt_cashiername.ReadOnly = true;
            txt_cashiername.Size = new Size(173, 29);
            txt_cashiername.TabIndex = 18;
            // 
            // pictureboxlogo
            // 
            pictureboxlogo.Image = (Image)resources.GetObject("pictureboxlogo.Image");
            pictureboxlogo.Location = new Point(10, 4);
            pictureboxlogo.Name = "pictureboxlogo";
            pictureboxlogo.Size = new Size(88, 50);
            pictureboxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxlogo.TabIndex = 14;
            pictureboxlogo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(109, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 15;
            label3.Text = "Manager Name:";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(listView1);
            panel2.Location = new Point(1, 83);
            panel2.Name = "panel2";
            panel2.Size = new Size(431, 510);
            panel2.TabIndex = 19;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(52, 94, 104);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(431, 35);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(6, 5);
            label2.Name = "label2";
            label2.Size = new Size(165, 25);
            label2.TabIndex = 20;
            label2.Text = "Order Information";
            // 
            // listView1
            // 
            listView1.GridLines = true;
            listView1.LabelEdit = true;
            listView1.Location = new Point(4, 40);
            listView1.Name = "listView1";
            listView1.Size = new Size(422, 466);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel12);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel10);
            panel3.Controls.Add(panel9);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(438, 83);
            panel3.Name = "panel3";
            panel3.Size = new Size(431, 510);
            panel3.TabIndex = 20;
            // 
            // panel12
            // 
            panel12.BackColor = Color.FromArgb(52, 94, 104);
            panel12.Controls.Add(label11);
            panel12.Location = new Point(6, 418);
            panel12.Name = "panel12";
            panel12.Size = new Size(407, 33);
            panel12.TabIndex = 1;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13F);
            label11.ForeColor = SystemColors.Control;
            label11.Location = new Point(3, 1);
            label11.Name = "label11";
            label11.Size = new Size(90, 25);
            label11.TabIndex = 25;
            label11.Text = "Dine Type";
            // 
            // panel6
            // 
            panel6.Controls.Add(rb_creditcard);
            panel6.Controls.Add(rb_cash);
            panel6.Controls.Add(rb_gcash);
            panel6.Controls.Add(panel11);
            panel6.Location = new Point(6, 324);
            panel6.Name = "panel6";
            panel6.Size = new Size(407, 88);
            panel6.TabIndex = 24;
            // 
            // rb_creditcard
            // 
            rb_creditcard.AutoSize = true;
            rb_creditcard.Location = new Point(283, 52);
            rb_creditcard.Name = "rb_creditcard";
            rb_creditcard.Size = new Size(85, 19);
            rb_creditcard.TabIndex = 4;
            rb_creditcard.TabStop = true;
            rb_creditcard.Text = "Credit Card";
            rb_creditcard.UseVisualStyleBackColor = true;
            // 
            // rb_cash
            // 
            rb_cash.AutoSize = true;
            rb_cash.Location = new Point(44, 52);
            rb_cash.Name = "rb_cash";
            rb_cash.Size = new Size(51, 19);
            rb_cash.TabIndex = 1;
            rb_cash.TabStop = true;
            rb_cash.Text = "Cash";
            rb_cash.UseVisualStyleBackColor = true;
            // 
            // rb_gcash
            // 
            rb_gcash.AutoSize = true;
            rb_gcash.Location = new Point(168, 52);
            rb_gcash.Name = "rb_gcash";
            rb_gcash.Size = new Size(64, 19);
            rb_gcash.TabIndex = 0;
            rb_gcash.TabStop = true;
            rb_gcash.Text = "G-Cash";
            rb_gcash.UseVisualStyleBackColor = true;
            // 
            // panel11
            // 
            panel11.BackColor = Color.FromArgb(52, 94, 104);
            panel11.Controls.Add(label10);
            panel11.Location = new Point(0, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(407, 33);
            panel11.TabIndex = 0;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13F);
            label10.ForeColor = SystemColors.Control;
            label10.Location = new Point(3, 1);
            label10.Name = "label10";
            label10.Size = new Size(148, 25);
            label10.TabIndex = 25;
            label10.Text = "Payment Method";
            // 
            // panel10
            // 
            panel10.BackColor = Color.FromArgb(200, 205, 210);
            panel10.Controls.Add(pictureBox1);
            panel10.Controls.Add(label7);
            panel10.Controls.Add(label6);
            panel10.Controls.Add(label5);
            panel10.Controls.Add(textBox3);
            panel10.Controls.Add(textBox2);
            panel10.Controls.Add(txt_customername);
            panel10.Location = new Point(6, 41);
            panel10.Name = "panel10";
            panel10.Size = new Size(407, 276);
            panel10.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(161, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 84);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13F);
            label7.Location = new Point(57, 232);
            label7.Name = "label7";
            label7.Size = new Size(94, 25);
            label7.TabIndex = 23;
            label7.Text = "Dine Type:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13F);
            label6.Location = new Point(30, 186);
            label6.Name = "label6";
            label6.Size = new Size(121, 25);
            label6.TabIndex = 22;
            label6.Text = "Order Numer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F);
            label5.Location = new Point(6, 142);
            label5.Name = "label5";
            label5.Size = new Size(145, 25);
            label5.TabIndex = 21;
            label5.Text = "Customer Name:";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 13F);
            textBox3.Location = new Point(161, 232);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(217, 31);
            textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 13F);
            textBox2.Location = new Point(161, 186);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(210, 31);
            textBox2.TabIndex = 3;
            // 
            // txt_customername
            // 
            txt_customername.Font = new Font("Segoe UI", 13F);
            txt_customername.Location = new Point(161, 142);
            txt_customername.Name = "txt_customername";
            txt_customername.Size = new Size(217, 31);
            txt_customername.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(rb_takeout);
            panel9.Controls.Add(rb_dinein);
            panel9.Location = new Point(6, 418);
            panel9.Name = "panel9";
            panel9.Size = new Size(407, 88);
            panel9.TabIndex = 23;
            // 
            // rb_takeout
            // 
            rb_takeout.AutoSize = true;
            rb_takeout.Location = new Point(249, 51);
            rb_takeout.Name = "rb_takeout";
            rb_takeout.Size = new Size(73, 19);
            rb_takeout.TabIndex = 3;
            rb_takeout.TabStop = true;
            rb_takeout.Text = "Take-Out";
            rb_takeout.UseVisualStyleBackColor = true;
            // 
            // rb_dinein
            // 
            rb_dinein.AutoSize = true;
            rb_dinein.Location = new Point(91, 51);
            rb_dinein.Name = "rb_dinein";
            rb_dinein.Size = new Size(64, 19);
            rb_dinein.TabIndex = 2;
            rb_dinein.TabStop = true;
            rb_dinein.Text = "Dine-In";
            rb_dinein.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 94, 104);
            panel5.Controls.Add(label4);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(431, 35);
            panel5.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(6, 5);
            label4.Name = "label4";
            label4.Size = new Size(197, 25);
            label4.TabIndex = 20;
            label4.Text = "Customer Information";
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(200, 205, 210);
            btn_back.FlatStyle = FlatStyle.Popup;
            btn_back.Location = new Point(3, 3);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(419, 38);
            btn_back.TabIndex = 2;
            btn_back.Text = "Back";
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(52, 94, 104);
            panel8.Controls.Add(label8);
            panel8.Controls.Add(txt_ordertotal);
            panel8.Location = new Point(4, 599);
            panel8.Name = "panel8";
            panel8.Size = new Size(852, 47);
            panel8.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13F);
            label8.ForeColor = SystemColors.Control;
            label8.Location = new Point(12, 9);
            label8.Name = "label8";
            label8.Size = new Size(104, 25);
            label8.TabIndex = 11;
            label8.Text = "Order Total:";
            // 
            // txt_ordertotal
            // 
            txt_ordertotal.Font = new Font("Segoe UI", 13F);
            txt_ordertotal.Location = new Point(122, 9);
            txt_ordertotal.Name = "txt_ordertotal";
            txt_ordertotal.ReadOnly = true;
            txt_ordertotal.Size = new Size(725, 31);
            txt_ordertotal.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.Controls.Add(btn_confirm);
            panel7.Controls.Add(btn_back);
            panel7.Location = new Point(4, 652);
            panel7.Name = "panel7";
            panel7.Size = new Size(852, 44);
            panel7.TabIndex = 13;
            // 
            // btn_confirm
            // 
            btn_confirm.BackColor = Color.FromArgb(52, 94, 104);
            btn_confirm.FlatStyle = FlatStyle.Popup;
            btn_confirm.Location = new Point(428, 1);
            btn_confirm.Name = "btn_confirm";
            btn_confirm.Size = new Size(419, 38);
            btn_confirm.TabIndex = 3;
            btn_confirm.Text = "Confirm";
            btn_confirm.UseVisualStyleBackColor = false;
            btn_confirm.Click += btn_confirm_Click;
            // 
            // frm_orderconfimation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(876, 710);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_orderconfimation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_orderconfimation";
            Load += frm_orderconfimation_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox txt_managername;
        private TextBox txt_cashiername;
        private PictureBox pictureboxlogo;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private ListView listView1;
        private Button btn_back;
        private Panel panel8;
        private Label label8;
        private TextBox txt_ordertotal;
        private Panel panel7;
        private Button btn_confirm;
        private Panel panel4;
        private Label label2;
        private Panel panel5;
        private Label label4;
        private Panel panel12;
        private Panel panel6;
        private RadioButton rb_creditcard;
        private RadioButton rb_cash;
        private RadioButton rb_gcash;
        private Panel panel11;
        private Panel panel10;
        private Panel panel9;
        private RadioButton rb_takeout;
        private RadioButton rb_dinein;
        private TextBox txt_customername;
        private Label label11;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox2;
    }
}