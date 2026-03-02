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
    public partial class frm_login : Form
    {
        auth login = new auth();
       
        public frm_login()
        {
            InitializeComponent();
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login.loginadmin(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Log In Successfully Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_admindashboard f = new frm_admindashboard(txt_username.Text);
                f.Show();
                this.Hide();
            }
            else if (login.logincashier(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Log In Successfully Cashier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_cashierDashboard f = new frm_cashierDashboard(txt_username.Text);
                f.Show();
                this.Hide();

            }
            else if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("Please enter username and password.",
                                "Warning",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Log In Failed Check Your Username and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_signup_Click(object sender, EventArgs e)
        {
            frm_signup f = new frm_signup();
            f.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !checkBox1.Checked;
        }
    }
}
