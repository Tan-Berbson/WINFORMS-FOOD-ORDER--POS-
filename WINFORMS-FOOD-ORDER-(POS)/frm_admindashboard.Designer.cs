namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_admindashboard
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
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txt_username = new TextBox();
            btn_sales = new Button();
            btn_cashier = new Button();
            btn_systeminfo = new Button();
            btn_logout = new Button();
            panel2 = new Panel();
            dgv_product = new DataGridView();
            panel3 = new Panel();
            btn_addimage = new Button();
            btn_deleteproduct = new Button();
            btn_updateproductifno = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_add = new Button();
            txt_productprice = new TextBox();
            txt_productname = new TextBox();
            pictureBox1 = new PictureBox();
            panel5 = new Panel();
            label5 = new Label();
            panel6 = new Panel();
            label6 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(btn_sales);
            panel1.Controls.Add(btn_cashier);
            panel1.Controls.Add(btn_systeminfo);
            panel1.Controls.Add(btn_logout);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 57);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(135, 20);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Admin Name";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(219, 12);
            txt_username.Name = "txt_username";
            txt_username.ReadOnly = true;
            txt_username.Size = new Size(173, 29);
            txt_username.TabIndex = 9;
            // 
            // btn_sales
            // 
            btn_sales.Location = new Point(581, 8);
            btn_sales.Name = "btn_sales";
            btn_sales.Size = new Size(122, 38);
            btn_sales.TabIndex = 12;
            btn_sales.Text = "Sales";
            btn_sales.UseVisualStyleBackColor = true;
            // 
            // btn_cashier
            // 
            btn_cashier.Location = new Point(709, 8);
            btn_cashier.Name = "btn_cashier";
            btn_cashier.Size = new Size(122, 38);
            btn_cashier.TabIndex = 11;
            btn_cashier.Text = "Cashier account";
            btn_cashier.UseVisualStyleBackColor = true;
            // 
            // btn_systeminfo
            // 
            btn_systeminfo.Location = new Point(837, 8);
            btn_systeminfo.Name = "btn_systeminfo";
            btn_systeminfo.Size = new Size(122, 38);
            btn_systeminfo.TabIndex = 10;
            btn_systeminfo.Text = "System Info";
            btn_systeminfo.UseVisualStyleBackColor = true;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(965, 8);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(122, 38);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(dgv_product);
            panel2.Location = new Point(12, 149);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 639);
            panel2.TabIndex = 0;
            // 
            // dgv_product
            // 
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(3, 43);
            dgv_product.Name = "dgv_product";
            dgv_product.Size = new Size(740, 583);
            dgv_product.TabIndex = 0;
            dgv_product.CellFormatting += dgv_product_CellFormatting;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_addimage);
            panel3.Controls.Add(btn_deleteproduct);
            panel3.Controls.Add(btn_updateproductifno);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_add);
            panel3.Controls.Add(txt_productprice);
            panel3.Controls.Add(txt_productname);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(765, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 639);
            panel3.TabIndex = 0;
            // 
            // btn_addimage
            // 
            btn_addimage.Location = new Point(219, 44);
            btn_addimage.Name = "btn_addimage";
            btn_addimage.Size = new Size(75, 23);
            btn_addimage.TabIndex = 3;
            btn_addimage.Text = "Add Image";
            btn_addimage.UseVisualStyleBackColor = true;
            btn_addimage.Click += btn_addimage_Click;
            // 
            // btn_deleteproduct
            // 
            btn_deleteproduct.Location = new Point(35, 588);
            btn_deleteproduct.Name = "btn_deleteproduct";
            btn_deleteproduct.Size = new Size(259, 38);
            btn_deleteproduct.TabIndex = 8;
            btn_deleteproduct.Text = "Delete Product";
            btn_deleteproduct.UseVisualStyleBackColor = true;
            // 
            // btn_updateproductifno
            // 
            btn_updateproductifno.Location = new Point(35, 525);
            btn_updateproductifno.Name = "btn_updateproductifno";
            btn_updateproductifno.Size = new Size(259, 38);
            btn_updateproductifno.TabIndex = 7;
            btn_updateproductifno.Text = "Update Product Information";
            btn_updateproductifno.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 392);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Product Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 336);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Product Name:";
            // 
            // btn_add
            // 
            btn_add.Location = new Point(35, 457);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(259, 38);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add  New Product";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // txt_productprice
            // 
            txt_productprice.Font = new Font("Segoe UI", 12F);
            txt_productprice.Location = new Point(121, 384);
            txt_productprice.Name = "txt_productprice";
            txt_productprice.Size = new Size(173, 29);
            txt_productprice.TabIndex = 3;
            // 
            // txt_productname
            // 
            txt_productname.Font = new Font("Segoe UI", 12F);
            txt_productname.Location = new Point(121, 328);
            txt_productname.Name = "txt_productname";
            txt_productname.Size = new Size(173, 29);
            txt_productname.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(35, 69);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Location = new Point(11, 150);
            panel5.Name = "panel5";
            panel5.Size = new Size(747, 35);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(4, 2);
            label5.Name = "label5";
            label5.Size = new Size(197, 28);
            label5.TabIndex = 0;
            label5.Text = "Product Information";
            label5.Click += label5_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label6);
            panel6.Location = new Point(765, 152);
            panel6.Name = "panel6";
            panel6.Size = new Size(322, 35);
            panel6.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(300, 28);
            label6.TabIndex = 1;
            label6.Text = "Add && Edit Product Information";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(389, 77);
            label4.Name = "label4";
            label4.Size = new Size(283, 45);
            label4.TabIndex = 2;
            label4.Text = "Admin Dashboard";
            // 
            // frm_admindashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 806);
            Controls.Add(label4);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_admindashboard";
            Text = "frm_admindashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView dgv_product;
        private Panel panel3;
        private TextBox txt_productname;
        private PictureBox pictureBox1;
        private Panel panel5;
        private Panel panel6;
        private Button btn_deleteproduct;
        private Button btn_updateproductifno;
        private Label label2;
        private Label label1;
        private Button btn_add;
        private TextBox txt_productprice;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox txt_username;
        private Button btn_sales;
        private Button btn_cashier;
        private Button btn_systeminfo;
        private Button btn_logout;
        private Label label5;
        private Label label4;
        private Label label6;
        private Button btn_addimage;
    }
}