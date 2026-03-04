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
    public partial class frm_cashiersells : Form
    {
        auth sells = new auth();

        string manager { get; set; }
        string cashier { get; set; }
        public frm_cashiersells(string managername, string cashiername)
        {
            InitializeComponent();
            cashier = cashiername;
            manager = managername;
            txt_managername.Text = managername;
            txt_cashiername.Text = cashiername;
            dgv_totalsells.DataSource = sells.loadSalesReportBycashier(cashier);
        
        }

        private void frm_cashiersells_Load(object sender, EventArgs e)
        {
            dgv_totalsells.DataSource = sells.loadSalesReportBycashier(cashier);
        }
    }
}
