namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_reciept
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
            btn_print = new Button();
            label1 = new Label();
            txt_managername = new TextBox();
            txt_cashiername = new TextBox();
            pictureboxlogo = new PictureBox();
            label3 = new Label();
            panel2 = new Panel();
            panel7 = new Panel();
            label7 = new Label();
            txt_customerchange = new TextBox();
            panel6 = new Panel();
            label8 = new Label();
            txt_customermoney = new TextBox();
            panel3 = new Panel();
            listBox1 = new ListBox();
            panel9 = new Panel();
            label9 = new Label();
            panel5 = new Panel();
            btn_neworder = new Button();
            panel4 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            txt_payment = new TextBox();
            txt_total = new TextBox();
            txt_ordernumber = new TextBox();
            txt_customername = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).BeginInit();
            panel2.SuspendLayout();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel9.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(btn_print);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_managername);
            panel1.Controls.Add(txt_cashiername);
            panel1.Controls.Add(pictureboxlogo);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(770, 57);
            panel1.TabIndex = 2;
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.FromArgb(200, 205, 210);
            btn_print.FlatStyle = FlatStyle.Popup;
            btn_print.Location = new Point(651, 10);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(102, 39);
            btn_print.TabIndex = 12;
            btn_print.Text = "Print";
            btn_print.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 20);
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
            txt_managername.Size = new Size(136, 29);
            txt_managername.TabIndex = 16;
            // 
            // txt_cashiername
            // 
            txt_cashiername.Font = new Font("Segoe UI", 12F);
            txt_cashiername.Location = new Point(439, 12);
            txt_cashiername.Name = "txt_cashiername";
            txt_cashiername.ReadOnly = true;
            txt_cashiername.Size = new Size(173, 29);
            txt_cashiername.TabIndex = 18;
            // 
            // pictureboxlogo
            // 
            pictureboxlogo.Location = new Point(3, 4);
            pictureboxlogo.Name = "pictureboxlogo";
            pictureboxlogo.Size = new Size(100, 50);
            pictureboxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureboxlogo.TabIndex = 14;
            pictureboxlogo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 20);
            label3.Name = "label3";
            label3.Size = new Size(92, 15);
            label3.TabIndex = 15;
            label3.Text = "Manager Name:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 94, 104);
            panel2.Controls.Add(panel7);
            panel2.Controls.Add(panel6);
            panel2.Location = new Point(10, 333);
            panel2.Name = "panel2";
            panel2.Size = new Size(335, 327);
            panel2.TabIndex = 3;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(200, 205, 210);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(txt_customerchange);
            panel7.Location = new Point(5, 162);
            panel7.Name = "panel7";
            panel7.Size = new Size(323, 143);
            panel7.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F);
            label7.Location = new Point(13, 29);
            label7.Name = "label7";
            label7.Size = new Size(135, 21);
            label7.TabIndex = 27;
            label7.Text = "Customer Change";
            // 
            // txt_customerchange
            // 
            txt_customerchange.Font = new Font("Segoe UI", 24F);
            txt_customerchange.Location = new Point(13, 67);
            txt_customerchange.Name = "txt_customerchange";
            txt_customerchange.Size = new Size(295, 50);
            txt_customerchange.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(200, 205, 210);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(txt_customermoney);
            panel6.Location = new Point(5, 19);
            panel6.Name = "panel6";
            panel6.Size = new Size(321, 118);
            panel6.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F);
            label8.Location = new Point(13, 13);
            label8.Name = "label8";
            label8.Size = new Size(130, 21);
            label8.TabIndex = 28;
            label8.Text = "Customer Money";
            // 
            // txt_customermoney
            // 
            txt_customermoney.Font = new Font("Segoe UI", 24F);
            txt_customermoney.Location = new Point(13, 49);
            txt_customermoney.Name = "txt_customermoney";
            txt_customermoney.Size = new Size(295, 50);
            txt_customermoney.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(listBox1);
            panel3.Controls.Add(panel9);
            panel3.Location = new Point(344, 62);
            panel3.Name = "panel3";
            panel3.Size = new Size(428, 643);
            panel3.TabIndex = 4;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(5, 34);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(417, 604);
            listBox1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(52, 94, 104);
            panel9.Controls.Add(label9);
            panel9.Location = new Point(0, 0);
            panel9.Name = "panel9";
            panel9.Size = new Size(425, 29);
            panel9.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F);
            label9.ForeColor = SystemColors.Control;
            label9.Location = new Point(3, 3);
            label9.Name = "label9";
            label9.Size = new Size(61, 21);
            label9.TabIndex = 27;
            label9.Text = "Reciept";
            // 
            // panel5
            // 
            panel5.Controls.Add(btn_neworder);
            panel5.Location = new Point(5, 663);
            panel5.Name = "panel5";
            panel5.Size = new Size(340, 45);
            panel5.TabIndex = 1;
            // 
            // btn_neworder
            // 
            btn_neworder.BackColor = Color.FromArgb(52, 94, 104);
            btn_neworder.FlatStyle = FlatStyle.Popup;
            btn_neworder.Location = new Point(11, 3);
            btn_neworder.Name = "btn_neworder";
            btn_neworder.Size = new Size(320, 39);
            btn_neworder.TabIndex = 11;
            btn_neworder.Text = "New Order";
            btn_neworder.UseVisualStyleBackColor = false;
            btn_neworder.Click += btn_neworder_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 205, 210);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txt_payment);
            panel4.Controls.Add(txt_total);
            panel4.Controls.Add(txt_ordernumber);
            panel4.Controls.Add(txt_customername);
            panel4.Location = new Point(5, 65);
            panel4.Name = "panel4";
            panel4.Size = new Size(333, 262);
            panel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F);
            label6.Location = new Point(7, 140);
            label6.Name = "label6";
            label6.Size = new Size(128, 21);
            label6.TabIndex = 26;
            label6.Text = "Payment Method";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(48, 200);
            label5.Name = "label5";
            label5.Size = new Size(90, 21);
            label5.TabIndex = 25;
            label5.Text = "Order Total:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(51, 86);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 24;
            label4.Text = "Order Id#:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(11, 26);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 23;
            label2.Text = "Customer Name:";
            // 
            // txt_payment
            // 
            txt_payment.Font = new Font("Segoe UI", 12F);
            txt_payment.Location = new Point(137, 136);
            txt_payment.Name = "txt_payment";
            txt_payment.ReadOnly = true;
            txt_payment.Size = new Size(158, 29);
            txt_payment.TabIndex = 22;
            // 
            // txt_total
            // 
            txt_total.Font = new Font("Segoe UI", 12F);
            txt_total.Location = new Point(137, 197);
            txt_total.Name = "txt_total";
            txt_total.ReadOnly = true;
            txt_total.Size = new Size(158, 29);
            txt_total.TabIndex = 21;
            // 
            // txt_ordernumber
            // 
            txt_ordernumber.Font = new Font("Segoe UI", 12F);
            txt_ordernumber.Location = new Point(137, 81);
            txt_ordernumber.Name = "txt_ordernumber";
            txt_ordernumber.ReadOnly = true;
            txt_ordernumber.Size = new Size(158, 29);
            txt_ordernumber.TabIndex = 20;
            // 
            // txt_customername
            // 
            txt_customername.Font = new Font("Segoe UI", 12F);
            txt_customername.Location = new Point(137, 22);
            txt_customername.Name = "txt_customername";
            txt_customername.ReadOnly = true;
            txt_customername.Size = new Size(158, 29);
            txt_customername.TabIndex = 19;
            // 
            // frm_reciept
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 710);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_reciept";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_reciept";
            Load += frm_reciept_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureboxlogo).EndInit();
            panel2.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Panel panel5;
        private TextBox txt_customermoney;
        private Panel panel6;
        private ListBox listBox1;
        private Panel panel4;
        private Panel panel9;
        private Button button11;
        private Label label2;
        private TextBox txt_payment;
        private TextBox txt_total;
        private TextBox txt_ordernumber;
        private TextBox txt_customername;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btn_neworder;
        private Label label7;
        private TextBox txt_customerchange;
        private Panel panel7;
        private Label label8;
        private Label label9;
        private Button btn_print;
    }
}