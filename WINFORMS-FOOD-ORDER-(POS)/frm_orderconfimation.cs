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
        List<string[]> orderList = new List<string[]>();
        string manager { get; set; }
        string cashier { get; set; }
        public frm_orderconfimation(List<string[]> orders, string managername, string cashiername)
        {
            InitializeComponent();

            orderList = orders;
            cashier = cashiername;
            manager = managername;
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
            frm_cashierDashboard f =
                (frm_cashierDashboard)Application.OpenForms["frm_cashierDashboard"];
            f.Show();
            this.Close();
            

        }
    }
}
