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
    public partial class frm_createacccashier : Form
    {
        auth cashier = new auth();
        string adminusername { get; set; }
        public frm_createacccashier(string usernameadmin)
        {
            InitializeComponent();
            txt_managername.Text = usernameadmin;
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (txt_username.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("PLSS ENTER YOUR NAME AND PASSWORD DONT LEAVE BLANK SPACES", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (txt_username.Text == "")
            {
                lbl_warningusername.ForeColor = Color.Red;
                lbl_warningusername.Text = "Username is required.";
            }
            if(txt_password.Text == "")
            {
                lbl_warningpassword.ForeColor = Color.Red;
                lbl_warningpassword.Text = "Password is required.";
            }
            else if (cashier.signupcashier(txt_managername.Text, txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Cashier Account Create Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            else
            {
                MessageBox.Show("Username already exists. Please choose another username.", "Create Account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_managecashieraccount f = new frm_managecashieraccount(txt_managername.Text);
            f.Show();
            this.Close();
        }
    }
}
