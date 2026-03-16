using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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
            listView1.Items.Clear();

        }
        public void ClearOrders()
        {
            listView1.Items.Clear();   // Clear all existing orders
            txt_total.Text = "0";      // Reset total
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_cashierlogoutauth f = new frm_cashierlogoutauth(cashier, txt_managername.Text, this);
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
        void ShowOrHideProduct(List<Class1.auth.produtlist> products, int index,
             PictureBox pic, TextBox name, TextBox price, Button btn)
        {
            if (products.Count > index)
            {
                ShowProduct(products[index], pic, name, price);
            }
            else
            {
                HideProduct(pic, name, price, btn);
            }
        }
        private void LoadProductsEasy()
        {
            var products = db.loadproducts(txt_managername.Text);

            ShowOrHideProduct(products, 0, pictureBox1, txt_productnanme1, txt_productprice1, btn_order1);
            ShowOrHideProduct(products, 1, pictureBox2, txt_productnanme2, txt_productprice2, btn_order2);
            ShowOrHideProduct(products, 2, pictureBox3, txt_productnanme3, txt_productprice3, btn_order3);
            ShowOrHideProduct(products, 3, pictureBox4, txt_productnanme4, txt_productprice4, btn_order4);
            ShowOrHideProduct(products, 4, pictureBox_5, txt_productnanme5, txt_productprice5, btn_order5);
            ShowOrHideProduct(products, 5, pictureBox__6, txt_productnanme6, txt_productprice6, btn_order6);
            ShowOrHideProduct(products, 6, pictureBox_7, txt_productnanme7, txt_productprice7, btn_order7);
            ShowOrHideProduct(products, 7, pictureBox_8, txt_productnanme8, txt_productprice8, btn_order8);
            ShowOrHideProduct(products, 8, pictureBox_9, txt_productnanme9, txt_productprice9, btn_order9);
            ShowOrHideProduct(products, 9, pictureBox_10, txt_productnanme10, txt_productprice10, btn_order10);
        }

        private void frm_cashierDashboard_Load(object sender, EventArgs e)
        {
            LoadProductsEasy();
            listView1.Columns.Add("Order Details", 120);
            listView1.Columns.Add("Order Adds-On", 120);
            listView1.Columns.Add("Total", 120);

        }
        public bool OrderExists(string productName)
        {
            if (string.IsNullOrWhiteSpace(productName))
                return false;

            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text
                    .ToLower()
                    .Contains(productName.Trim().ToLower()))
                {
                    return true;
                }
            }

            return false;
        }
        private void btn_order1_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme1.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox1.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme1.Text,
                txt_productprice1.Text,
                productImage,
                this
            );

            f.ShowDialog();



        }
        // 🔹 TATAWAGIN NI FORM2

        // 🔹 Put AddOrderWithCheck right here
        public bool AddOrderWithCheck(string orderName, string addons, string total)
        {
            // 🔹 Check if order already exists
            if (OrderExists(orderName))
            {
                MessageBox.Show(
                    "Order already exists in the list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return false; // Do not add the order
            }

            // 🔹 Add the order
            ListViewItem newItem = new ListViewItem(orderName);
            newItem.SubItems.Add(addons);
            newItem.SubItems.Add(total);
            listView1.Items.Add(newItem);

            // 🔹 Update grand total
            CalculateGrandTotal();

            return true; // Added successfully
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
            if (listView1.Items.Count == 0)
            {
                MessageBox.Show("No orders to checkout.", "Empty Order List",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var orders = GetOrders();
            frm_orderconfimation f = new frm_orderconfimation(
                orders,
                txt_managername.Text,
                txt_cashiername.Text,
                this // ← i-pass ang sarili
            );
            f.Show();
            this.Hide();

        }

        private void btn_order2_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme2.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox2.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme2.Text,
                txt_productprice2.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order3_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme3.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox3.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme3.Text,
                txt_productprice3.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order4_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme4.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox4.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme4.Text,
                txt_productprice4.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order5_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme5.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox_5.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme5.Text,
                txt_productprice5.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order6_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme6.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox__6.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme6.Text,
                txt_productprice6.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order7_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme7.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox_7.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme7.Text,
                txt_productprice7.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order8_Click(object sender, EventArgs e)
        {

            string productName = txt_productnanme8.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox_8.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme8.Text,
                txt_productprice8.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order9_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme9.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox_9.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme9.Text,
                txt_productprice9.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_order10_Click(object sender, EventArgs e)
        {
            string productName = txt_productnanme10.Text;

            // Check if product already exists
            if (OrderExists(productName))
            {
                MessageBox.Show(
                    "This product is already in the order list.\n" +
                    "If you want to add it again, delete the existing order first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return; // Stop here
            }

            // Open add-ons form
            Image productImage = pictureBox_10.Image;

            frm_Addson f = new frm_Addson(
                txt_cashiername.Text,
                txt_managername.Text,
                txt_productnanme10.Text,
                txt_productprice10.Text,
                productImage,
                this
            );

            f.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                listView1.Items.Remove(item);
            }
            CalculateGrandTotal();
        }
        void HideProduct(PictureBox pic, TextBox name, TextBox price, Button btn)
        {
            pic.Visible = false;
            name.Visible = false;
            price.Visible = false;
            btn.Visible = false;
        }
    }
}
