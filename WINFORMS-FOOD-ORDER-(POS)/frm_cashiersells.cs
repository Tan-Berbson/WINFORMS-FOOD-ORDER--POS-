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
            dgv_totalsells.DataSource = null;
            dgv_totalsells.Columns.Clear();

            dgv_totalsells.DataSource = sells.loadSalesReportBycashier(cashier);
            dgv_totalsells.AutoGenerateColumns = false;


        }

        private void frm_cashiersells_Load(object sender, EventArgs e)
        {
            dgv_totalsells.DataSource = sells.loadSalesReportBycashier(cashier);
        }



        private void btn_logout_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cashier.Text) ||
        string.IsNullOrWhiteSpace(txt_totalsells.Text) ||
        string.IsNullOrWhiteSpace(cmb_evaluate.Text))
            {
                MessageBox.Show("Please fill out all fields",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // WARNING MESSAGE FIRST
            DialogResult result = MessageBox.Show(
                "Warning: All cashier sales data will be permanently deleted.\n\nDo you want to proceed with logout?",
                "Manager Confirmation",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);

            // IF CANCEL → STOP LOGOUT
            if (result == DialogResult.Cancel)
            {
                return;
            }
            string createdTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            // IF OK → CONTINUE PROCESS
            if (sells.insertcashierreport(txt_cashier.Text, txt_totalsells.Text, cmb_evaluate.Text, createdTime))
            {
                sells.DeleteSales(); // delete data from database

                dgv_totalsells.DataSource = null;

                MessageBox.Show("Save Successfully!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

                frm_login f = new frm_login();
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Save Failed!",
                                "Information",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_cashierlogoutauth f = new frm_cashierlogoutauth(cashier, manager);
            f.Show();
            this.Close();
        }
    }
}
