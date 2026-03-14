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
    public partial class frm_systeminfo : Form
    {
        public frm_systeminfo()
        {
            InitializeComponent();
        }

        private void frm_systeminfo_Load(object sender, EventArgs e)
        {

        }

        private void linklbl_guide_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }
    }
}
