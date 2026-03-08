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
    public partial class frm_montlysales : Form
    {
        string adminuser { get; set; }
        string currentFilter = "month"; // default filter
        auth sales = new auth();
        public frm_montlysales(string managername)
        {
            InitializeComponent();
            this.adminuser = managername;
            txt_username.Text = managername;
        }

        private void frm_montlysales_Load(object sender, EventArgs e)
        {
            int year = DateTime.Now.Year;
            if (!comboBoxYear.Items.Contains(year))
                comboBoxYear.Items.Add(year);
            comboBoxYear.SelectedItem = year;

            LoadChart(currentFilter, year);
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f = new frm_login();
            f.Show();
            this.Close();
        }
        void LoadChart(string filter, int year)
        {
            DataTable dt = sales.GetSales(filter, year);

            chart1.Series[0].Points.Clear(); // clear chart

            foreach (DataRow row in dt.Rows)
            {
                string label = row["Period"].ToString();

                if (filter == "month")
                {
                    int m = Convert.ToInt32(label);
                    label = new DateTime(year, m, 1).ToString("MMM");
                }

                chart1.Series[0].Points.AddXY(label, Convert.ToDouble(row["TotalSales"]));
            }

            // Auto-add year sa comboBox kung wala pa
            if (!comboBoxYear.Items.Contains(year))
                comboBoxYear.Items.Add(year);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadChart(currentFilter, Convert.ToInt32(comboBoxYear.SelectedItem));
        }

        private void btn_day_Click(object sender, EventArgs e)
        {
            currentFilter = "day";
            LoadChart(currentFilter, Convert.ToInt32(comboBoxYear.SelectedItem));
        }

        private void btn_week_Click(object sender, EventArgs e)
        {
            currentFilter = "week";
            LoadChart(currentFilter, Convert.ToInt32(comboBoxYear.SelectedItem));
        }

        private void btn_month_Click(object sender, EventArgs e)
        {
            currentFilter = "month";
            LoadChart(currentFilter, Convert.ToInt32(comboBoxYear.SelectedItem));
        }

        private void btn_year_Click(object sender, EventArgs e)
        {
            currentFilter = "year";
            LoadChart(currentFilter, Convert.ToInt32(comboBoxYear.SelectedItem));
        }
    }
}
