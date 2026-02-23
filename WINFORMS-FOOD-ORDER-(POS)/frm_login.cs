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
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (login.loginadmin(txt_username.Text,txt_password.Text))
            {
                MessageBox.Show("Log In Successfully Admin", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                frm_admindashboard f = new frm_admindashboard(txt_username.Text);
                f.Show();
                this.Hide();
            }
            else if(login.logincashier(txt_username.Text,txt_password.Text))
            {
                MessageBox.Show("Log In Successfully Cashier", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}
