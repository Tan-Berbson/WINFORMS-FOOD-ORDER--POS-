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
    public partial class frm_admindashboard : Form
    {
        string adminuser { get; set; }
        public frm_admindashboard(string username)
        {
            InitializeComponent();
            adminuser = username;
            txt_username.Text = adminuser;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }
    }
}
