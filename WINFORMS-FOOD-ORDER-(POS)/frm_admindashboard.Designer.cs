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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_admindashboard));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txt_username = new TextBox();
            btn_sales = new Button();
            btn_cashier = new Button();
            btn_logout = new Button();
            panel2 = new Panel();
            dgv_product = new DataGridView();
            panel5 = new Panel();
            label5 = new Label();
            panel3 = new Panel();
            button1 = new Button();
            btn_addimage = new Button();
            panel6 = new Panel();
            label6 = new Label();
            btn_deleteproduct = new Button();
            btn_updateproductifno = new Button();
            label2 = new Label();
            label1 = new Label();
            btn_add = new Button();
            txt_productprice = new TextBox();
            txt_productname = new TextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            panel7 = new Panel();
            label4 = new Label();
            dgv_addson = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_product).BeginInit();
            panel5.SuspendLayout();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_addson).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(btn_sales);
            panel1.Controls.Add(btn_cashier);
            panel1.Controls.Add(btn_logout);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 57);
            panel1.TabIndex = 0;
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
            // btn_sales
            // 
            btn_sales.BackColor = Color.FromArgb(200, 205, 210);
            btn_sales.FlatStyle = FlatStyle.Popup;
            btn_sales.Location = new Point(696, 8);
            btn_sales.Name = "btn_sales";
            btn_sales.Size = new Size(122, 38);
            btn_sales.TabIndex = 12;
            btn_sales.Text = "Sales";
            btn_sales.UseVisualStyleBackColor = false;
            btn_sales.Click += btn_sales_Click;
            // 
            // btn_cashier
            // 
            btn_cashier.BackColor = Color.FromArgb(200, 205, 210);
            btn_cashier.FlatStyle = FlatStyle.Popup;
            btn_cashier.Location = new Point(832, 8);
            btn_cashier.Name = "btn_cashier";
            btn_cashier.Size = new Size(122, 38);
            btn_cashier.TabIndex = 11;
            btn_cashier.Text = "Manage Cashier";
            btn_cashier.UseVisualStyleBackColor = false;
            btn_cashier.Click += btn_cashier_Click;
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
            panel2.Controls.Add(panel5);
            panel2.Location = new Point(12, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(747, 513);
            panel2.TabIndex = 0;
            // 
            // dgv_product
            // 
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.BackgroundColor = Color.FromArgb(200, 205, 210);
            dgv_product.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_product.Location = new Point(4, 37);
            dgv_product.Name = "dgv_product";
            dgv_product.ReadOnly = true;
            dgv_product.Size = new Size(740, 473);
            dgv_product.TabIndex = 0;
            dgv_product.CellContentClick += dgv_product_CellContentClick;
            dgv_product.CellFormatting += dgv_product_CellFormatting;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(52, 94, 104);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(747, 35);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(4, 2);
            label5.Name = "label5";
            label5.Size = new Size(197, 28);
            label5.TabIndex = 0;
            label5.Text = "Product Information";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.Control;
            panel3.Controls.Add(button1);
            panel3.Controls.Add(btn_addimage);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(btn_deleteproduct);
            panel3.Controls.Add(btn_updateproductifno);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(btn_add);
            panel3.Controls.Add(txt_productprice);
            panel3.Controls.Add(txt_productname);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(765, 65);
            panel3.Name = "panel3";
            panel3.Size = new Size(322, 858);
            panel3.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 0, 0);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(35, 611);
            button1.Name = "button1";
            button1.Size = new Size(259, 38);
            button1.TabIndex = 9;
            button1.Text = "Add  New Adds-on";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btn_addimage
            // 
            btn_addimage.Location = new Point(219, 84);
            btn_addimage.Name = "btn_addimage";
            btn_addimage.Size = new Size(75, 23);
            btn_addimage.TabIndex = 3;
            btn_addimage.Text = "Add Image";
            btn_addimage.UseVisualStyleBackColor = true;
            btn_addimage.Click += btn_addimage_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(52, 94, 104);
            panel6.Controls.Add(label6);
            panel6.Location = new Point(0, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(322, 35);
            panel6.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(300, 28);
            label6.TabIndex = 1;
            label6.Text = "Add && Edit Product Information";
            // 
            // btn_deleteproduct
            // 
            btn_deleteproduct.BackColor = Color.FromArgb(200, 205, 210);
            btn_deleteproduct.FlatStyle = FlatStyle.Popup;
            btn_deleteproduct.Location = new Point(35, 766);
            btn_deleteproduct.Name = "btn_deleteproduct";
            btn_deleteproduct.Size = new Size(259, 38);
            btn_deleteproduct.TabIndex = 8;
            btn_deleteproduct.Text = "Delete Product";
            btn_deleteproduct.UseVisualStyleBackColor = false;
            // 
            // btn_updateproductifno
            // 
            btn_updateproductifno.BackColor = Color.FromArgb(200, 205, 210);
            btn_updateproductifno.FlatStyle = FlatStyle.Popup;
            btn_updateproductifno.Location = new Point(35, 687);
            btn_updateproductifno.Name = "btn_updateproductifno";
            btn_updateproductifno.Size = new Size(259, 38);
            btn_updateproductifno.TabIndex = 7;
            btn_updateproductifno.Text = "Update Product Information";
            btn_updateproductifno.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 453);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 6;
            label2.Text = "Product Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 397);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 5;
            label1.Text = "Product Name:";
            // 
            // btn_add
            // 
            btn_add.BackColor = Color.FromArgb(52, 94, 104);
            btn_add.FlatStyle = FlatStyle.Popup;
            btn_add.ForeColor = SystemColors.Control;
            btn_add.Location = new Point(35, 543);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(259, 38);
            btn_add.TabIndex = 4;
            btn_add.Text = "Add  New Product";
            btn_add.UseVisualStyleBackColor = false;
            btn_add.Click += btn_add_Click;
            // 
            // txt_productprice
            // 
            txt_productprice.Font = new Font("Segoe UI", 12F);
            txt_productprice.Location = new Point(121, 445);
            txt_productprice.Name = "txt_productprice";
            txt_productprice.Size = new Size(173, 29);
            txt_productprice.TabIndex = 3;
            txt_productprice.KeyPress += txt_productprice_KeyPress;
            // 
            // txt_productname
            // 
            txt_productname.Font = new Font("Segoe UI", 12F);
            txt_productname.Location = new Point(121, 397);
            txt_productname.Name = "txt_productname";
            txt_productname.Size = new Size(173, 29);
            txt_productname.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(52, 94, 104);
            pictureBox1.Location = new Point(35, 113);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 226);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel7);
            panel4.Controls.Add(dgv_addson);
            panel4.Location = new Point(12, 582);
            panel4.Name = "panel4";
            panel4.Size = new Size(747, 341);
            panel4.TabIndex = 1;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 94, 104);
            panel7.Controls.Add(label4);
            panel7.Location = new Point(-2, 3);
            panel7.Name = "panel7";
            panel7.Size = new Size(747, 35);
            panel7.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(4, 2);
            label4.Name = "label4";
            label4.Size = new Size(205, 28);
            label4.TabIndex = 0;
            label4.Text = "Adds On Information";
            // 
            // dgv_addson
            // 
            dgv_addson.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_addson.BackgroundColor = Color.FromArgb(200, 205, 210);
            dgv_addson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_addson.Location = new Point(0, 36);
            dgv_addson.Name = "dgv_addson";
            dgv_addson.ReadOnly = true;
            dgv_addson.Size = new Size(747, 300);
            dgv_addson.TabIndex = 0;
            dgv_addson.CellContentClick += dgv_addson_CellContentClick;
            dgv_addson.CellFormatting += dgv_addson_CellFormatting;
            // 
            // frm_admindashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1099, 881);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_admindashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_admindashboard";
            Load += frm_admindashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_product).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_addson).EndInit();
            ResumeLayout(false);
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
        private Button btn_logout;
        private Label label5;
        private Label label6;
        private Button btn_addimage;
        private Button button1;
        private Panel panel4;
        private Panel panel7;
        private Label label4;
        private DataGridView dgv_addson;
    }
}