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
        TextBox[] addonPriceTextBoxes;
        Image productImage { get; set; }
        CheckBox[] addonBoxes;
        PictureBox[] addonImages;
        
        List<Class1.auth.addsonlist> addons = new List<Class1.auth.addsonlist>();

        private frm_cashierDashboard _dashboard; // ← dagdag na field
        public frm_Addson(string cashiers, string managername, string productsname, string productporices, Image productImage, frm_cashierDashboard dashboard)
        {
            InitializeComponent();
            _dashboard = dashboard;
            this.ControlBox = false;
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
            _dashboard.Show(); // ← direkta, safe
            this.Close();
        }
        

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string addonsText = "";
            foreach (CheckBox chk in addonBoxes)
            {
                if (chk.Visible && chk.Checked)
                {
                    addonsText += chk.Text + ", ";
                }
            }

            int qty = int.Parse(txt_quantity.Text);
            int total = int.Parse(txt_ordertotal.Text);
            string orderName = txt_ordername.Text + " x" + qty;

            // ← Palitan ang Application.OpenForms ng _dashboard
            if (_dashboard.OrderExists(orderName))
            {
                MessageBox.Show(
                    "Order already in the list.\nIf you want to proceed, delete it first.",
                    "Duplicate Order",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            bool added = _dashboard.AddOrderWithCheck(orderName, addonsText, total.ToString());

            if (added)
            {
                // ← Hindi na kailangan ng f.Show() dahil ShowDialog() ang ginamit
                //    sa pag-open ng frm_Addson, awtomatiko bumabalik sa dashboard
                this.Close();
            }

        }
        private void CalculateTotal()
        {
            int addonTotal = 0;

            for (int i = 0; i < addonBoxes.Length; i++)
            {
                if (addonBoxes[i].Visible && addonBoxes[i].Checked)
                {
                    addonTotal += int.Parse(addonPriceTextBoxes[i].Text);
                }
            }

            if (txt_quantity.Text == "") return;

            int qty = int.Parse(txt_quantity.Text);
            int basePrice = int.Parse(txt_price.Text);

            int total = (basePrice * qty) + addonTotal;

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
        private void LoadAddons()
        {
            Class1.auth db = new Class1.auth();
            addons = db.loadaddson(manager);

            for (int i = 0; i < addonBoxes.Length; i++)
            {
                if (i < addons.Count)
                {
                    // Checkbox = pangalan lang
                    addonBoxes[i].Text = addons[i].addsonName;
                    addonBoxes[i].Visible = true;

                    // TextBox = presyo
                    addonPriceTextBoxes[i].Text = addons[i].addsonprice;
                    addonPriceTextBoxes[i].Visible = true;
                    addonPriceTextBoxes[i].ReadOnly = true;

                    // Picture
                    byte[] img = addons[i].addsonImage;
                    using (MemoryStream ms = new MemoryStream(img))
                    {
                        addonImages[i].Image = Image.FromStream(ms);
                    }
                    addonImages[i].SizeMode = PictureBoxSizeMode.StretchImage;
                    addonImages[i].Visible = true;
                }
                else
                {
                    addonBoxes[i].Visible = false;
                    addonImages[i].Visible = false;
                    addonPriceTextBoxes[i].Visible = false;
                }
            }
        }

        private void frm_Addson_Load(object sender, EventArgs e)
        {
            addonBoxes = new CheckBox[]
     {
        checkBox1,
        checkBox2,
        checkBox3,
        checkBox4,
        checkBox5,
        checkBox6
     };
            addonImages = new PictureBox[]
{
    pictureBox2,
    pictureBox3,
    pictureBox4,
    pictureBox5,
    pictureBox6,
    pictureBox7
}; addonPriceTextBoxes = new TextBox[]
{
    textBox1,
    textBox2,
    textBox3,
    textBox4,
    textBox5,
    textBox6
};

            LoadAddons();
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
