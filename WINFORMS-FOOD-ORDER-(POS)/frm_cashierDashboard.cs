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
        string manager { get; set; }
        string productname { get; set; }
        string productprice { get; set; }
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
        private void LoadProductManually()
        {
            using (var reader = db.loadProductsByAdmin(txt_managername.Text))
            {
                while (reader.Read())
                {
                    int productId = Convert.ToInt32(reader["id"]);
                    byte[] imgBytes = (byte[])reader["PRODUCTIMAGE"];
                    string name = reader["PRODUCTNAME"].ToString();
                    string price = reader["PRODUCTPRICE"].ToString();

                    // Product 1
                    SetProduct(1, pictureBox1, txt_productnanme1, txt_productprice1,
                               productId, imgBytes, name, price);

                    // Product 2 (example)
                    SetProduct(2, pictureBox2, txt_productnanme2, txt_productprice2,
                                productId, imgBytes, name, price);

                    SetProduct(3, pictureBox3, txt_productnanme3, txt_productprice3,
                               productId, imgBytes, name, price);

                    SetProduct(4, pictureBox4, txt_productnanme4, txt_productprice4,
                               productId, imgBytes, name, price);
                }
            }
        }
        private void SetProduct(
    int targetId,
    PictureBox pic,
    TextBox txtName,
    TextBox txtPrice,
    int productId,
    byte[] imgBytes,
    string name,
    string price)
        {
            if (productId != targetId) return;

            txtName.Text = name;
            txtPrice.Text = price;

            using (MemoryStream ms = new MemoryStream(imgBytes))
            {
                pic.Image = Image.FromStream(ms);
            }
        }

        private void frm_cashierDashboard_Load(object sender, EventArgs e)
        {
            LoadProductManually();
            listView1.Columns.Add("Order Details", 120);
            listView1.Columns.Add("Order Adds-On", 120);
            listView1.Columns.Add("Total", 120);
           
        }

        private void btn_order1_Click(object sender, EventArgs e)
        {
            frm_Addson f = new frm_Addson(txt_cashiername.Text, txt_managername.Text, txt_productnanme1.Text, txt_productprice1.Text);
            f.Show();
            
           
        }
        // 🔹 TATAWAGIN NI FORM2
        public void AddOrder(string orderName, string addons, string total)
        {
            ListViewItem item = new ListViewItem(orderName);
            item.SubItems.Add(addons);
            item.SubItems.Add(total);

            listView1.Items.Add(item);
        }
    }
}
