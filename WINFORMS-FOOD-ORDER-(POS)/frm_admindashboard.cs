using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WINFORMS_FOOD_ORDER__POS_.Class1;

namespace WINFORMS_FOOD_ORDER__POS_
{
    public partial class frm_admindashboard : Form
    {
        auth admin = new auth();
        string adminuser { get; set; }
        public frm_admindashboard(string username)
        {
            InitializeComponent();
            adminuser = username;
            txt_username.Text = username;
            LoadProducts();

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }

        private void btn_addimage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select Product Image";
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                pictureBox1.Tag = ofd.FileName;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Please select an image first.");
                return;
            }

            auth a = new auth();
            a.InsertProduct(
                txt_username.Text,
                pictureBox1.Tag.ToString(), // 👈 image path
                txt_productname.Text,
                txt_productprice.Text
            );

            MessageBox.Show("Product saved!");
            LoadProducts();
            pictureBox1.Image = null;
            pictureBox1.Tag = null;

            txt_productname.Clear();
            txt_productprice.Clear();
        }
        void LoadProducts()
        {
            dgv_product.DataSource = null;
            dgv_product.AutoGenerateColumns = false; // use custom columns
            dgv_product.Columns.Clear();


            DataGridViewTextBoxColumn numberCol = new DataGridViewTextBoxColumn();
            numberCol.HeaderText = "Product Number";
            numberCol.DataPropertyName = "ProductNumber"; // uses computed property
            dgv_product.Columns.Add(numberCol);

            // Image column
            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol.HeaderText = "Image";
            imgCol.DataPropertyName = "ProductImage";
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dgv_product.Columns.Add(imgCol);

            // Product Name column
            DataGridViewTextBoxColumn nameCol = new DataGridViewTextBoxColumn();
            nameCol.HeaderText = "Product Name";
            nameCol.DataPropertyName = "ProductName";
            dgv_product.Columns.Add(nameCol);

            // Price column
            DataGridViewTextBoxColumn priceCol = new DataGridViewTextBoxColumn();
            priceCol.HeaderText = "Price";
            priceCol.DataPropertyName = "Productprice";
            dgv_product.Columns.Add(priceCol);

            dgv_product.DataSource = admin.loadproducts(adminuser);

            dgv_product.RowTemplate.Height = 100;
            dgv_product.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_product.AllowUserToResizeRows = false;
            dgv_product.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_product.MultiSelect = false;
            dgv_product.ReadOnly = true;
        }

        private void dgv_product_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgv_product.Columns[e.ColumnIndex].Name == "ProductImage"
        && e.Value != null)
            {
                byte[] bytes = (byte[])e.Value;

                using (MemoryStream ms = new MemoryStream(bytes))
                {
                    e.Value = Image.FromStream(ms);
                }
            }
        }
    }
}
