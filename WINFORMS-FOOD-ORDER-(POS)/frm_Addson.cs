using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WINFORMS_FOOD_ORDER__POS_
{
    public partial class frm_Addson : Form
    {
        string cashier { get; set; }
        string manager { get; set; }
        string productname { get; set; }
        string productprice { get; set; }
        Image productImage { get; set; }

        public frm_Addson(string cashiers, string managername, string productsname, string productporices, Image productImage)
        {
            InitializeComponent();
            cashier = cashiers;
            manager = managername;
            productname = productsname;
            productprice = productporices;
            txt_cashiername.Text = cashiers;
            txt_managername.Text = managername;
            txt_ordername.Text = productsname;
            txt_price.Text = productporices;
            pictureBox1.Image = productImage;      
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_cashierDashboard f = new frm_cashierDashboard(txt_cashiername.Text);
            f.Show();
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            int addonPrice = 30;
            int addonCount = 0;
            string addons = "";

            if (checkBox1.Checked) { addons += "Add-on1, "; addonCount++; }
            if (checkBox2.Checked) { addons += "Add-on2, "; addonCount++; }
            if (checkBox3.Checked) { addons += "Add-on3, "; addonCount++; }
            if (checkBox4.Checked) { addons += "Add-on4, "; addonCount++; }
            if (checkBox5.Checked) { addons += "Add-on5, "; addonCount++; }
            if (checkBox6.Checked) { addons += "Add-on6, "; addonCount++; }

            int qty = int.Parse(txt_quantity.Text);
            int basePrice = int.Parse(txt_price.Text);

            int total = (basePrice * qty) + (addonCount * addonPrice);

            string orderName = txt_ordername.Text + " x" + qty;

            // 🔹 KUNIN ANG EXISTING FORM1
            frm_cashierDashboard f =
                (frm_cashierDashboard)Application.OpenForms["frm_cashierDashboard"];

            // 🔹 ADD SA LISTVIEW
            f.AddOrder(orderName, addons, total.ToString());

            // 🔹 BUMALIK SA FORM1
            this.Close();


        }
        private void CalculateTotal()
        {
            int addonPrice = 30;
            int addonCount = 0;

            if (checkBox1.Checked) addonCount++;
            if (checkBox2.Checked) addonCount++;
            if (checkBox3.Checked) addonCount++;
            if (checkBox4.Checked) addonCount++;
            if (checkBox5.Checked) addonCount++;
            if (checkBox6.Checked) addonCount++;

            if (txt_quantity.Text == "") return;

            int qty = int.Parse(txt_quantity.Text);
            int basePrice = int.Parse(txt_price.Text);

            int total = (basePrice * qty) + (addonCount * addonPrice);

            txt_ordertotal.Text = total.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void txt_ordertotal_TextChanged(object sender, EventArgs e)
        {
            if (txt_quantity.Text != "")
            {
                CalculateTotal();
            }
        }

        private void frm_Addson_Load(object sender, EventArgs e)
        {
            CalculateTotal();
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txt_quantity.Text);

            if (qty > 0)
            {
                qty--;
                txt_quantity.Text = qty.ToString();
                CalculateTotal();
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            int qty = int.Parse(txt_quantity.Text);

            if (qty < 100)
            {
                qty++;
                txt_quantity.Text = qty.ToString();
                CalculateTotal();
            }
            else
            {
                MessageBox.Show("Maximum order is 100 only.");
            }
        }
    }
}
