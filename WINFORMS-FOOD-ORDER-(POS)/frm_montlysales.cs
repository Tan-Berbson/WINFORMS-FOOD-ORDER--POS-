using System;
using System.Data;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static WINFORMS_FOOD_ORDER__POS_.Class1;

namespace WINFORMS_FOOD_ORDER__POS_
{
    public partial class frm_montlysales : Form
    {
        string adminuser { get; set; }
        auth sales = new auth();

        private readonly string[] monthNames = { "January", "February", "March", "April",
                                                "May", "June", "July", "August",
                                                "September", "October", "November", "December" };

        public frm_montlysales(string managername)
        {
            InitializeComponent();
            this.adminuser = managername;
            txt_username.Text = managername;
        }

        private void frm_montlysales_Load(object sender, EventArgs e)
        {
            LoadYears();
            UpdateChart();
        }

        void LoadYears()
        {
            comboBoxYear.DataSource = sales.GetAvailableYears();
            comboBoxYear.DisplayMember = "SaleYear";
            comboBoxYear.ValueMember = "SaleYear";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChart();
        }

        void UpdateChart()
        {
            if (comboBoxYear.SelectedValue == null)
                return;

            if (!int.TryParse(comboBoxYear.SelectedValue.ToString(), out int selectedYear))
                return;

            DataTable dt = sales.GetMonthlySales(selectedYear);

            chart1.Series.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();

            // ✅ ENHANCED: Use Spline for smooth curves
            Series s = new Series("MONTHLY SALES");
            s.ChartType = SeriesChartType.Spline;
            s.IsValueShownAsLabel = true;
            s.LabelFormat = "#,##0";

            // ✅ ENHANCED STYLING - Professional & Bold
            s.BorderWidth = 4;
            s.Color = System.Drawing.Color.FromArgb(31, 119, 180);
            s.MarkerStyle = MarkerStyle.Circle;
            s.MarkerSize = 10;
            s.MarkerColor = System.Drawing.Color.FromArgb(255, 127, 14);
            s.MarkerBorderColor = System.Drawing.Color.White;
            s.MarkerBorderWidth = 2;
            s.LabelForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            s.Font = new System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Bold);

            chart1.Series.Add(s);

            foreach (DataRow row in dt.Rows)
            {
                int monthNumber = Convert.ToInt32(row["MonthNumber"]);
                double totalSales = Convert.ToDouble(row["TotalSales"]);
                s.Points.AddXY(monthNumber, totalSales);
            }

            ChartArea chartArea = chart1.ChartAreas[0];

            // ✅ MAXIMIZE CHART AREA - Remove excess padding
            chartArea.Position.X = 5;      // ✅ 5% from left
            chartArea.Position.Y = 5;      // ✅ 5% from top
            chartArea.Position.Width = 90; // ✅ 90% width (maximize)
            chartArea.Position.Height = 85; // ✅ 85% height (leave room for legend)

            // ✅ Chart Area Background
            chartArea.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            chartArea.AxisX.Minimum = 0.5;
            chartArea.AxisX.Maximum = 12.5;
            chartArea.AxisX.Interval = 1;

            // ✅ X-Axis Labels
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            chartArea.AxisX.LabelStyle.Angle = -45;
            chartArea.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            for (int i = 1; i <= 12; i++)
            {
                CustomLabel label = new CustomLabel();
                label.FromPosition = i - 0.5;
                label.ToPosition = i + 0.5;
                label.Text = monthNames[i - 1];
                chartArea.AxisX.CustomLabels.Add(label);
            }

            // ✅ Y-Axis Styling
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.IsStartedFromZero = true;
            chartArea.AxisY.LabelStyle.Enabled = true;
            chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
            chartArea.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);

            // ✅ Auto-calculate Y-axis interval
            double maxValue = 0;
            foreach (DataRow row in dt.Rows)
            {
                double val = Convert.ToDouble(row["TotalSales"]);
                if (val > maxValue) maxValue = val;
            }

            int interval = (int)(maxValue / 50000) * 5000;
            if (interval < 5000) interval = 5000;
            if (interval > 20000) interval = 10000;

            chartArea.AxisY.Interval = interval;

            // ✅ Horizontal Grid Lines
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(200, 200, 200);
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            chartArea.AxisY.MajorGrid.LineWidth = 1;

            // ✅ Vertical Grid Lines for Month Guides
            chartArea.AxisX.MajorGrid.Enabled = true;
            chartArea.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(220, 220, 220);
            chartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            chartArea.AxisX.MajorGrid.LineWidth = 1;

            // ✅ Axis Titles
            chartArea.AxisY.Title = "Total Sales";
            chartArea.AxisY.TitleFont = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            chartArea.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(40, 40, 40);

            // ✅ MAXIMIZE: Hide Month title to save space
            chartArea.AxisX.Title = "";
            chartArea.AxisX.TitleFont = new System.Drawing.Font("Arial", 11, System.Drawing.FontStyle.Bold);
            chartArea.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(40, 40, 40);

            // ✅ Legend - Let it float below the chart
            if (chart1.Legends.Count > 0)
            {
                chart1.Legends[0].Enabled = true;
                chart1.Legends[0].Font = new System.Drawing.Font("Arial", 10, System.Drawing.FontStyle.Bold);
                chart1.Legends[0].ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            }

            // ✅ Overall Chart Appearance
            chart1.BackColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(100, 100, 100);
            chart1.BorderlineWidth = 1;

            chart1.Invalidate();
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
    }
}