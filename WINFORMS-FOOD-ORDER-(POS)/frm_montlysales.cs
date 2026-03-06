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
    public partial class frm_montlysales : Form
    {
        string manager { get; set; }
        public frm_montlysales(string managername)
        {
            InitializeComponent();
            txt_username.Text = manager;
        }

        private void frm_montlysales_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            frm_admindashboard f = new frm_admindashboard(txt_username.Text);
            f.Show();
            this.Close();
        }
    }
}
