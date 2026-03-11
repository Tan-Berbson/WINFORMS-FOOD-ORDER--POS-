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
    public partial class frm_reciept : Form
    {
        private readonly List<string[]> _orders;
        private readonly string _manager;
        private readonly string _cashier;
        private readonly string _customer;
        private readonly string _paymentMethod;
        private readonly string _dineType;
        private readonly string _ordernumber;
        auth sells = new auth();

        public frm_reciept(List<string[]> orders,
            string manager,
            string cashier,
            string customer,
            string paymentMethod,
            string dineType,
            string total, string ordernumber)
        {
            InitializeComponent();
            _orders = orders;
            _manager = manager;
            _cashier = cashier;
            _customer = customer;
            _paymentMethod = paymentMethod;
            _dineType = dineType;
            txt_customername.Text = customer;
            txt_ordernumber.Text = ordernumber;
            txt_payment.Text = paymentMethod;
            txt_total.Text = total;
            txt_managername.Text = manager;
            txt_cashiername.Text = cashier;
            _ordernumber = ordernumber;


            txt_payment.Text = paymentMethod;

            GenerateReceipt();
        }
        private void GenerateReceipt()
        {
            listBox1.Items.Clear();

            StringBuilder receipt = new StringBuilder();

            receipt.AppendLine("========================================");
            receipt.AppendLine("           Tan_food restaurant          ");
            receipt.AppendLine("              FOOD  POS                 ");
            receipt.AppendLine("========================================");
            receipt.AppendLine($"Date       : {DateTime.Now:MM/dd/yyyy hh:mm tt}");
            receipt.AppendLine($"Order No.  : {_ordernumber}");  // <-- Add this line
            receipt.AppendLine("-----------------------------------------");
            receipt.AppendLine($"Manager    : {_manager}");
            receipt.AppendLine($"Cashier    : {_cashier}");
            receipt.AppendLine($"Customer   : {_customer}");
            receipt.AppendLine($"Dine Type  : {_dineType}");
            receipt.AppendLine("----------------------------------------");
            receipt.AppendLine("ITEMS");
            receipt.AppendLine("----------------------------------------");

            decimal grandTotal = 0;

            foreach (var order in _orders)
            {
                string itemName = order[0];
                string addOn = order[1];
                decimal price = decimal.Parse(order[2]);

                grandTotal += price;

                receipt.AppendLine(itemName);

                if (!string.IsNullOrWhiteSpace(addOn))
                {
                    receipt.AppendLine("   + " + addOn);
                }

                receipt.AppendLine($"   ₱ {price:N2}");
                receipt.AppendLine("");
            }

            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine($"TOTAL        : ₱ {grandTotal:N2}");
            receipt.AppendLine($"Payment      : {_paymentMethod}");
            receipt.AppendLine("--------------------------------------");
            receipt.AppendLine("       Thank you for your order!");
            receipt.AppendLine("======================================");

            DisplayReceipt(receipt.ToString());
        }


        private void DisplayReceipt(string receiptText)
        {
            string[] lines = receiptText.Split(
                new[] { Environment.NewLine },
                StringSplitOptions.None);

            foreach (string line in lines)
            {
                listBox1.Items.Add(line);
            }
        }

        private void frm_reciept_Load(object sender, EventArgs e)
        {

        }
        private void calculatecustomerchange()
        {
            double total;
            double customermoney;

            double.TryParse(txt_total.Text, out total);
            double.TryParse(txt_customermoney.Text, out customermoney);

            if (customermoney < total)
            {
                txt_customerchange.Text = "Insufficient Money";
                txt_customerchange.Font = new Font("Segoe UI", 18, FontStyle.Bold);
                txt_customerchange.ForeColor = Color.Red;
            }
            else
            {
                double change = customermoney - total;
                txt_customerchange.Text = change.ToString("N2");
                txt_customerchange.Font = new Font("Segoe UI", 18, FontStyle.Regular);
                txt_customerchange.ForeColor = Color.Black;
            }
        }

        private void btn_neworder_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_customermoney.Text) || string.IsNullOrWhiteSpace(txt_customerchange.Text))
            {
                MessageBox.Show("Please enter customer money and change.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           

            else if (txt_customerchange.Text == "Insufficient Money")
            {
                MessageBox.Show("Customer money is not enough.", "Payment Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DialogResult result = MessageBox.Show(
    "Warning: Please confirm the total before proceeding to a new order.\n\nThis action cannot be undone.\n\nDo you want to proceed?",
    "Warning",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning);
            if (result == DialogResult.Cancel) 
            {
                return;
            }
             if (sells.cashiertotalsell(
                    txt_cashiername.Text,
                    txt_customername.Text,
                    txt_ordernumber.Text,
                    txt_payment.Text,
                    txt_total.Text,
                    txt_customermoney.Text,
                    txt_customerchange.Text))
            {
                MessageBox.Show("Order Completed!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


                // Optionally refresh dashboard
                frm_cashierDashboard f = (frm_cashierDashboard)Application.OpenForms["frm_cashierDashboard"];
                if (f != null)
                {
                    f.ClearOrders();
                    f.Show();
                }
                else
                {
                    f = new frm_cashierDashboard(txt_cashiername.Text);
                    f.Show();
                }
            }


            this.Close();
        }

        private void txt_customermoney_TextChanged(object sender, EventArgs e)
        {
            calculatecustomerchange();
        }

        private void txt_customermoney_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
                MessageBox.Show("Plss enter only numbers", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }
    }
}
