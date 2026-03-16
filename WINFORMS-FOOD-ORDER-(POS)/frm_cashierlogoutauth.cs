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
    public partial class frm_cashierlogoutauth : Form
    {
        auth logout = new auth();

        string cashier { get; set; }
        string manager { get; set; }
        private frm_cashierDashboard _dashboard; // ← dagdag
        private frm_cashiersells frm_cashiersells;

        public frm_cashierlogoutauth(string cashiername, string managername, frm_cashierDashboard dashboard)
        {
            InitializeComponent();
            cashier = cashiername;
            manager = managername;
            txt_cashiername.Text = cashiername;
            txt_managername.Text = managername;
            txt_password.UseSystemPasswordChar = true;
            _dashboard = dashboard;
        }

        public frm_cashierlogoutauth(string cashier, string manager, frm_cashiersells frm_cashiersells)
        {
            this.cashier = cashier;
            this.manager = manager;
            this.frm_cashiersells = frm_cashiersells;
        }

        private void frm_cashierlogoutauth_Load(object sender, EventArgs e)
        {

        }

        private void btn_procced_Click(object sender, EventArgs e)
        {
            if (logout.loginadmin(txt_managername.Text, txt_password.Text))
            {
                MessageBox.Show("Logout Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_cashiersells f = new frm_cashiersells(txt_managername.Text, txt_cashiername.Text);
                f.Show();
                this.Hide();



            }
            else
            {
                MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            _dashboard?.Show(); // Use stored reference instead (as discussed before)
            this.Close();
        }

        private void chk_showpass_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !chk_showpass.Checked;
        }
    }
}
