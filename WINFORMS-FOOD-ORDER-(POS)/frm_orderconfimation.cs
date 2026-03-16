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
    public partial class frm_orderconfimation : Form
    {
        public static class SessionManager
        {
            // Key = cashier + date
            private static Dictionary<string, int> cashierDailyCounters
                = new Dictionary<string, int>();

            public static int GetNextOrderNumber(string cashierUsername)
            {
                string today = DateTime.Now.ToString("yyyyMMdd");

                string key = cashierUsername + "_" + today;

                if (!cashierDailyCounters.ContainsKey(key))
                    cashierDailyCounters[key] = 1;
                else
                    cashierDailyCounters[key]++;

                return cashierDailyCounters[key];
            }
        }
        List<string[]> orderList = new List<string[]>();
        string manager { get; set; }
        string cashier { get; set; }
        private frm_cashierDashboard _parentDashboard;

        // Update constructor
        public frm_orderconfimation(List<string[]> orders, string managername,
            string cashiername, frm_cashierDashboard parent) // ← dagdag na parameter
        {
            InitializeComponent();
            orderList = orders;
            cashier = cashiername;
            manager = managername;
            _parentDashboard = parent; // ← i-store ang reference
            txt_cashiername.Text = cashiername;
            txt_managername.Text = managername;
            LoadOrdersToListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void LoadOrdersToListView()
        {
            foreach (var order in orderList)
            {
                ListViewItem item = new ListViewItem(order[0]);
                item.SubItems.Add(order[1]);
                item.SubItems.Add(order[2]);
                listView1.Items.Add(item);
            }
        }

        private void frm_orderconfimation_Load(object sender, EventArgs e)
        {

            listView1.Columns.Add("Order Details", 120);
            listView1.Columns.Add("Order Adds-On", 120);
            listView1.Columns.Add("Total", 120);
            int nextNumber = SessionManager.GetNextOrderNumber(cashier);

            string datePart = DateTime.Now.ToString("yyyyMMdd");
            string cashierPart = cashier.ToUpper();

            txt_ordernumber.Text =
                cashierPart + "-" +
                datePart + "-" +
                nextNumber.ToString("D4");
            CalculateGrandTotal();

        }
        private void CalculateGrandTotal()
        {
            int grandTotal = 0;

            foreach (ListViewItem item in listView1.Items)
            {
                grandTotal += int.Parse(item.SubItems[2].Text);
            }

            txt_ordertotal.Text = grandTotal.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _parentDashboard.Show(); // ← direkta, hindi na OpenForms
            this.Close();


        }
        private string GetSelectedPaymentMethod()
        {
            if (rb_cash.Checked) return "Cash";
            if (rb_gcash.Checked) return "GCash";
            if (rb_creditcard.Checked) return "Credit Card";
            return "N/A";
        }

        private string GetSelectedDineType()
        {
            if (rb_dinein.Checked) return "Dine-In";
            if (rb_takeout.Checked) return "Take-Out";
            return "N/A";
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_customername.Text) || string.IsNullOrWhiteSpace(txt_ordernumber.Text))
            {
                MessageBox.Show("Plss Enter CustomerName Both OrderNumber ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!rb_dinein.Checked && !rb_takeout.Checked)
            {
                MessageBox.Show("Plss Select Dine Options", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!rb_cash.Checked && !rb_gcash.Checked && !rb_creditcard.Checked)
            {
                MessageBox.Show("Plss Select Payment Options",  "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                string customerName = txt_customername.Text;
                string paymentMethod = GetSelectedPaymentMethod();
                string dineType = GetSelectedDineType();
                string total = txt_ordertotal.Text;
                string ordernumber = txt_ordernumber.Text;

                frm_reciept receiptForm = new frm_reciept(
                    orderList,
                    manager,
                    cashier,
                    customerName,
                    paymentMethod,
                    dineType,
                    total,
                    ordernumber
                );
                receiptForm.Show();
                this.Hide();
            }

        }

        private void rb_dinein_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_dinein.Checked)
            {
                txt_dinetype.Text = "Dine in";
            }
        }

        private void rb_takeout_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_takeout.Checked)
            {
                txt_dinetype.Text = "Take Out";
            }
        }

        private void txt_ordernumber_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
