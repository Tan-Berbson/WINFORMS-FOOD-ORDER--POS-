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
    public partial class frm_cashierDashboard : Form
    {
        string cashier { get; set; }
        public frm_cashierDashboard(string cashiers)
        {
            InitializeComponent();
            cashier = cashiers;
            txt_cashiername.Text = cashiers;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();   
        }
    }
}
