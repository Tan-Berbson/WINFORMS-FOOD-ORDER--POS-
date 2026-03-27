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
            if (comboBoxYear.Items.Count == 0)
            {
                MessageBox.Show(
           "No sales data available.\nPlease create a sale first.",
           "No Data Available",
           MessageBoxButtons.OK,
           MessageBoxIcon.Warning);
                this.Close();
                return;


            }
            LoadYears();
            UpdateChart();
            UpdateChart2();
        }

        void LoadYears()
        {
            comboBoxYear.DataSource = sales.GetAvailableYears(adminuser); // ← pass adminuser
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
            // 1. Validation
            if (comboBoxYear.SelectedValue == null) return;
            if (!int.TryParse(comboBoxYear.SelectedValue.ToString(), out int selectedYear)) return;

            // ✅ Pass adminuser here
            DataTable dt = sales.GetMonthlySales(selectedYear, adminuser);

            // 3. Reset Chart State
            chart1.Series.Clear();
            chart1.Titles.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();

            // 4. Create Column Series
            Series columnseries = new Series("Monthly Sales");
            columnseries.ChartType = SeriesChartType.Column;

            // Show the total amounts on top of the bars
            columnseries.IsValueShownAsLabel = true;
            columnseries.LabelFormat = "$#,##0";

            // Professional Styling
            columnseries.Color = System.Drawing.Color.FromArgb(200, 220, 240); // Light blue fill
            columnseries.BorderColor = System.Drawing.Color.FromArgb(178, 34, 34); // Dark red border
            columnseries.BorderWidth = 1;
            columnseries.LabelForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            columnseries.Font = new System.Drawing.Font("Segoe UI", 9, System.Drawing.FontStyle.Bold);
            columnseries.YAxisType = AxisType.Primary;

            chart1.Series.Add(columnseries);

            // 5. Populate Data
            foreach (DataRow row in dt.Rows)
            {
                int monthNumber = Convert.ToInt32(row["MonthNumber"]);
                double totalSales = Convert.ToDouble(row["TotalSales"]);
                columnseries.Points.AddXY(monthNumber, totalSales);
            }

            // 6. Chart Area Configuration
            ChartArea chartArea = chart1.ChartAreas[0];

            // ✨ FIX 1: Auto-positioning ensures large labels on the left aren't cut off
            chartArea.Position.Auto = true;
            chartArea.InnerPlotPosition.Auto = true;

            chartArea.BackColor = System.Drawing.Color.FromArgb(250, 250, 255);

            // X-Axis Scaling
            chartArea.AxisX.Minimum = 0;
            chartArea.AxisX.Maximum = 13;
            chartArea.AxisX.Interval = 1;
            chartArea.AxisX.MajorGrid.Enabled = false; // Keep it clean

            // X-Axis Month Labels
            chartArea.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
            for (int i = 1; i <= 12; i++)
            {
                CustomLabel label = new CustomLabel();
                label.FromPosition = i - 0.5;
                label.ToPosition = i + 0.5;
                label.Text = monthNames[i - 1].Substring(0, 3);
                chartArea.AxisX.CustomLabels.Add(label);
            }

            // Y-Axis Scaling & Formatting
            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.IsStartedFromZero = true;
            chartArea.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 10, System.Drawing.FontStyle.Regular);
            chartArea.AxisY.LabelStyle.Format = "$#,##0";

            // ✨ FIX 2: Auto-calculate interval to prevent "squished" labels on the left
            chartArea.AxisY.Interval = double.NaN;

            // Grid Lines
            chartArea.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(220, 220, 230);

            // Axis Titles
            chartArea.AxisY.Title = "Sales ($)";
            chartArea.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 11, System.Drawing.FontStyle.Bold);

            // 7. Legend & Global Appearance
            if (chart1.Legends.Count > 0)
            {
                chart1.Legends[0].Enabled = true;
                chart1.Legends[0].Docking = Docking.Top;
                chart1.Legends[0].Alignment = System.Drawing.StringAlignment.Center;
            }

            chart1.BackColor = System.Drawing.Color.White;

            // 8. Title
            Title chartTitle = new Title();
            chartTitle.Text = $"Monthly Sales Report - {selectedYear}";
            chartTitle.Font = new System.Drawing.Font("Segoe UI", 14, System.Drawing.FontStyle.Bold);
            chart1.Titles.Add(chartTitle);

            // Refresh
            chart1.Invalidate();
        }
        // ✅ UpdateChart2 remains exactly the same
        void UpdateChart2()
        {
            // 1. Validation
            if (comboBoxYear.SelectedValue == null) return;
            if (!int.TryParse(comboBoxYear.SelectedValue.ToString(), out int selectedYear)) return;

            // ✅ Pass adminuser here
            DataTable dt = sales.GetCashierRankingByYear(selectedYear, adminuser);
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

                // Pin the Cashier Name directly to this specific bar's position
                chartArea2.AxisX.CustomLabels.Add(positionIndex - 0.5, positionIndex + 0.5, cashierName);

                positionIndex++;
            }
            chart2.Series.Add(barseries);

            // 6. Axis Styling
            // X-AXIS (Vertical - The Names)
            chartArea2.AxisX.Interval = 1;

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