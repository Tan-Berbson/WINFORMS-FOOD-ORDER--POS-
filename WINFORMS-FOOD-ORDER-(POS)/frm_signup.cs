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
    public partial class frm_signup : Form
    {
        auth signup = new auth();
        public frm_signup()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_username.Text) || string.IsNullOrWhiteSpace(txt_password.Text))
            {
                MessageBox.Show("PLSS ENTER YOUR NAME AND PASSWORD DONT LEAVE BLANK SPACES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (signup.signupadmin(txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("CREATE ADMIN ACCOUNT SUCCESFULLY", "INFORMATION SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Username already exists. Please choose another username.", "Create Account",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
