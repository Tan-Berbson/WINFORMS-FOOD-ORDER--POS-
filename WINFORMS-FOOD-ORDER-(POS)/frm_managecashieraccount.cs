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
    public partial class frm_managecashieraccount : Form
    {
        string manager { get; set; }
        auth cashieraccount = new auth();
        public frm_managecashieraccount(string managername)
        {
            InitializeComponent();
            manager = managername;
            txt_username.Text = manager;
            dgv_allcashieracc.DataSource = cashieraccount.loadcashieraccount(manager);
            dgv_allcashieracc.CellFormatting += DataGridView1_CellFormatting;
            dgv_cashierreport.DataSource = cashieraccount.loadcashierreport(manager);
          
        }
        bool isPasswordHidden = true;
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgv_allcashieracc.Columns[e.ColumnIndex].Name == "password" && e.Value != null && isPasswordHidden)
            {
                e.Value = new string('●', e.Value.ToString().Length);
            }
        }
        private void frm_managecashieraccount_Load(object sender, EventArgs e)
        {

        }

        private void btn_createcashieracc_Click(object sender, EventArgs e)
        {

            frm_createacccashier f = new frm_createacccashier(txt_username.Text);
            f.Show();
            this.Hide();

        }

        private void btn_showpassword_Click(object sender, EventArgs e)
        {
            // Toggle the boolean
            isPasswordHidden = !isPasswordHidden;

            // Change button text for better UX
            btn_showpassword.Text = isPasswordHidden ? "Show Passwords" : "Hide Passwords";

            // Refresh the grid to trigger CellFormatting again
            dgv_allcashieracc.Invalidate();
        }
    }
}
