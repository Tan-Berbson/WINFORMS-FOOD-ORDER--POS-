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

            // ✅ SERIES 1: COLUMNS (Monthly Sales Background)
            Series columnseries = new Series("Monthly Sales");
            columnseries.ChartType = SeriesChartType.Column;
            columnseries.IsValueShownAsLabel = false;

            // ✅ COLUMN STYLING - Light blue background
            columnseries.Color = System.Drawing.Color.FromArgb(200, 220, 240);
            columnseries.BorderColor = System.Drawing.Color.FromArgb(200, 220, 240);
            columnseries.BorderWidth = 0;
            columnseries.YAxisType = AxisType.Primary;

            chart1.Series.Add(columnseries);

            // ✅ SERIES 2: LINE (Trend Line)
            Series lineseries = new Series("Sales Trend");
            lineseries.ChartType = SeriesChartType.Line;
            lineseries.IsValueShownAsLabel = true;
            lineseries.LabelFormat = "$#,##0";

            // ✅ LINE STYLING - Professional dark red
            lineseries.BorderWidth = 4;
            lineseries.Color = System.Drawing.Color.FromArgb(178, 34, 34);
            lineseries.MarkerStyle = MarkerStyle.Circle;
            lineseries.MarkerSize = 10;
            lineseries.MarkerColor = System.Drawing.Color.FromArgb(178, 34, 34);
            lineseries.MarkerBorderColor = System.Drawing.Color.White;
            lineseries.MarkerBorderWidth = 2;
            lineseries.LabelForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            lineseries.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            lineseries.YAxisType = AxisType.Primary;

            chart1.Series.Add(lineseries);

            // ✅ ADD DATA TO BOTH SERIES
            foreach (DataRow row in dt.Rows)
            {
                int monthNumber = Convert.ToInt32(row["MonthNumber"]);
                double totalSales = Convert.ToDouble(row["TotalSales"]);

                columnseries.Points.AddXY(monthNumber, totalSales);
                lineseries.Points.AddXY(monthNumber, totalSales);
            }

            ChartArea chartArea = chart1.ChartAreas[0];

            // ✅ MAXIMIZE CHART AREA - Clean layout
            chartArea.Position.X = 7;
            chartArea.Position.Y = 16;  // ✅ Less space (no subtitle)
            chartArea.Position.Width = 88;
            chartArea.Position.Height = 72;  // ✅ More chart height

            // ✅ PROFESSIONAL BACKGROUND
            chartArea.BackColor = System.Drawing.Color.FromArgb(250, 250, 255);

            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 13;
            chartArea.AxisX.Interval = 1;

            // ✅ X-AXIS MONTH LABELS
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
            chartArea.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
            chartArea.AxisX.LabelStyle.Interval = 1;

            // ✅ CUSTOM LABELS FOR MONTHS
            for (int i = 1; i <= 12; i++)
            {
                CustomLabel label = new CustomLabel();
                label.FromPosition = i - 0.5;
                label.ToPosition = i + 0.5;
                label.Text = monthNames[i - 1].Substring(0, 3);
                chartArea.AxisX.CustomLabels.Add(label);
            }

            // ✅ Y-AXIS STYLING
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.IsStartedFromZero = true;
            chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
            chartArea.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            chartArea.AxisY.LabelStyle.Format = "$#,##0";

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

            // ✅ PROFESSIONAL GRID LINES
            chartArea.AxisY.MajorGrid.Enabled = true;
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(220, 220, 230);
            chartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Solid;
            chartArea.AxisY.MajorGrid.LineWidth = 1;

            // ✅ REMOVE X-AXIS GRID
            chartArea.AxisX.MajorGrid.Enabled = false;

            // ✅ AXIS TITLES
            chartArea.AxisY.Title = "Sales ($)";
            chartArea.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            chartArea.AxisY.TitleForeColor = System.Drawing.Color.FromArgb(40, 40, 40);

            chartArea.AxisX.Title = "";
            chartArea.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);
            chartArea.AxisX.TitleForeColor = System.Drawing.Color.FromArgb(40, 40, 40);

            // ✅ LEGEND - Small, clean, centered under title
            if (chart1.Legends.Count > 0)
            {
                chart1.Legends[0].Enabled = true;
                chart1.Legends[0].Docking = Docking.Top;  // ✅ Under title
                chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;  // ✅ Centered
                chart1.Legends[0].Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Regular);  // ✅ Small font
                chart1.Legends[0].ForeColor = System.Drawing.Color.FromArgb(80, 80, 80);
                chart1.Legends[0].BorderColor = System.Drawing.Color.FromArgb(200, 200, 200);
                chart1.Legends[0].BorderWidth = 1;
            }

            // ✅ OVERALL APPEARANCE
            chart1.BackColor = System.Drawing.Color.White;
            chart1.BorderlineColor = System.Drawing.Color.FromArgb(100, 100, 100);
            chart1.BorderlineWidth = 1;

            // ✅ CHART TITLE - Simple, clean, bold
            Title chartTitle = new Title();
            chartTitle.Text = "Monthly Sales";  // ✅ Simple title
            chartTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);  // ✅ Segoe UI 14pt Bold
            chartTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartTitle.Alignment = System.Drawing.ContentAlignment.TopCenter;

            chart1.Titles.Clear();
            chart1.Titles.Add(chartTitle);
            // ✅ No subtitle - clean design

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