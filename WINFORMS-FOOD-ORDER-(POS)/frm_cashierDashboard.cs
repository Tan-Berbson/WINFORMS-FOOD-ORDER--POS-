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
    public partial class frm_cashierDashboard : Form
    {
        string cashier { get; set; }

        auth db = new auth();
        public frm_cashierDashboard(string cashiers)
        {
            InitializeComponent();

            cashier = cashiers;
            txt_cashiername.Text = cashiers;
            txt_managername.Text = db.loadmanagername(cashiers);
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }
        private void ShowProduct(
    Class1.auth.produtlist p,
    PictureBox pic,
    TextBox txtName,
    TextBox txtPrice)
        {
            txtName.Text = p.ProductName;
            txtPrice.Text = p.Productprice;

            using (var ms = new MemoryStream(p.ProductImage))
            {
                pic.Image = Image.FromStream(ms);
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
        private void LoadProductsEasy()
        {
            var products = db.loadproducts(txt_managername.Text);

            if (products.Count > 0)
                ShowProduct(products[0], pictureBox1, txt_productnanme1, txt_productprice1);

            if (products.Count > 1)
                ShowProduct(products[1], pictureBox2, txt_productnanme2, txt_productprice2);

            if (products.Count > 2)
                ShowProduct(products[2], pictureBox3, txt_productnanme3, txt_productprice3);

            if (products.Count > 3)
                ShowProduct(products[3], pictureBox4, txt_productnanme4, txt_productprice4);
        }

        private void frm_cashierDashboard_Load(object sender, EventArgs e)
        {
            LoadProductsEasy();
            listView1.Columns.Add("Order Details", 120);
            listView1.Columns.Add("Order Adds-On", 120);
            listView1.Columns.Add("Total", 120);

        }

        private void btn_order1_Click(object sender, EventArgs e)
        {
            Image productImage = pictureBox1.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme1.Text,
                txt_productprice1.Text,
                productImage   // 👈 PASS IMAGE
            );

            f.Show();


        }
        // 🔹 TATAWAGIN NI FORM2
        public void AddOrder(string orderName, string addons, string total)
        {
            ListViewItem item = new ListViewItem(orderName);
            item.SubItems.Add(addons);
            item.SubItems.Add(total);

            listView1.Items.Add(item);
            CalculateGrandTotal();
        }
        private void CalculateGrandTotal()
        {
            int grandTotal = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                grandTotal += int.Parse(item.SubItems[2].Text);
            }

            txt_total.Text = grandTotal.ToString();
        }
        public List<string[]> GetOrders()
        {
            List<string[]> orders = new List<string[]>();

            foreach (ListViewItem item in listView1.Items)
            {
                string[] orderData = new string[3];
                orderData[0] = item.SubItems[0].Text; // Order Name
                orderData[1] = item.SubItems[1].Text; // Add-ons
                orderData[2] = item.SubItems[2].Text; // Total
                orders.Add(orderData);
            }

            return orders;
        }
        private void txt_total_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            var orders = GetOrders(); // Kunin lahat ng orders mula sa cashierDashboard
            frm_orderconfimation f = new frm_orderconfimation(orders);
            f.Show();
            this.Hide();
        }
    }
}
