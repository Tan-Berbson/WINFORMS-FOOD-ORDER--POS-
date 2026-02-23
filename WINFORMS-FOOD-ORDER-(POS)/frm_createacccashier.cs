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
            if (cashier.signupcashier(txt_managername.Text, txt_username.Text, txt_password.Text))
            {
                MessageBox.Show("Cashier Account Create Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
            else
            {
               MessageBox.Show("Account Create Failed","Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
