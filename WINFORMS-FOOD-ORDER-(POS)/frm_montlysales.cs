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
            UpdateChart2();
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
            UpdateChart2();
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
            chartArea.Position.Y = 16;
            chartArea.Position.Width = 88;
            chartArea.Position.Height = 72;

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
                chart1.Legends[0].Docking = Docking.Top;
                chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
                chart1.Legends[0].Font = new System.Drawing.Font("Segoe UI", 8, System.Drawing.FontStyle.Regular);
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
            chartTitle.Text = "Monthly Sales";
            chartTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            chartTitle.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            chartTitle.Alignment = System.Drawing.ContentAlignment.TopCenter;

            chart1.Titles.Clear();
            chart1.Titles.Add(chartTitle);

            chart1.Invalidate();
        }

        // ✅ UpdateChart2 - EXACT SAME APPROACH AS CHART1
        void UpdateChart2()
        {
            // 1. Validation
            if (comboBoxYear.SelectedValue == null) return;
            if (!int.TryParse(comboBoxYear.SelectedValue.ToString(), out int selectedYear)) return;

            // 2. Data Fetching
            DataTable dt = sales.GetCashierRankingByYear(selectedYear);
            if (chart2 == null || dt.Rows.Count == 0) return;

            // 3. Reset Chart
            chart2.Series.Clear();
            chart2.Titles.Clear();
            ChartArea chartArea2 = chart2.ChartAreas[0];
            chartArea2.AxisX.CustomLabels.Clear();
            chartArea2.AxisY.CustomLabels.Clear();

            // 4. Create Series (Bar Type)
            Series barseries = new Series("Sales Volume");
            barseries.ChartType = SeriesChartType.Bar; // Horizontal
            barseries.IsValueShownAsLabel = true;
            barseries.LabelFormat = "$#,##0";

            // Design
            barseries.Color = System.Drawing.Color.FromArgb(200, 220, 240);
            barseries.BorderColor = System.Drawing.Color.FromArgb(178, 34, 34);
            barseries.BorderWidth = 1;
            barseries.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);

            // 5. Explicit Data Point Mapping & CUSTOM LABELS
            int positionIndex = 1;
            foreach (DataRow row in dt.Rows)
            {
                string cashierName = row["CASHIERNAME"].ToString();
                double totalSales = Convert.ToDouble(row["TotalSales"]);

                // Plot explicitly at X=1, X=2, X=3...
                barseries.Points.AddXY(positionIndex, totalSales);

                // ✨ THE FIX: Pin the Cashier Name directly to this specific bar's position
                chartArea2.AxisX.CustomLabels.Add(positionIndex - 0.5, positionIndex + 0.5, cashierName);

                positionIndex++;
            }
            chart2.Series.Add(barseries);

            // 6. Axis Styling
            // X-AXIS (Vertical - The Names)
            chartArea2.AxisX.Interval = 1;

            // ✨ Font set to Segoe UI 11 as requested!
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Regular);

            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisX.IsReversed = true; // Puts #1 at the top
            chartArea2.AxisX.Minimum = 0.5;
            chartArea2.AxisX.Maximum = dt.Rows.Count + 0.5;

            // Y-AXIS (Horizontal - The Money)
            chartArea2.AxisY.LabelStyle.Format = "$#,##0";
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9);
            chartArea2.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(230, 230, 230);
            chartArea2.AxisY.Minimum = 0;

            // 7. Visual Layout
            chartArea2.BackColor = System.Drawing.Color.White;
            chartArea2.Position.Auto = true;

            // Title
            Title chartTitle = new Title($"Top Performing Cashiers ({selectedYear})", Docking.Top,
                                new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold),
                                System.Drawing.Color.FromArgb(40, 40, 40));
            chart2.Titles.Add(chartTitle);

            chart2.Invalidate();
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

        private void chart2_Click(object sender, EventArgs e)
        {
        }
    }
}