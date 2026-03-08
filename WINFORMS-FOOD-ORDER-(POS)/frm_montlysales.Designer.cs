namespace WINFORMS_FOOD_ORDER__POS_
{
    partial class frm_montlysales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_montlysales));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panel1 = new Panel();
            btn_dashboard = new Button();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            txt_username = new TextBox();
            btn_logout = new Button();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panel5 = new Panel();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel7 = new Panel();
            btn_year = new Button();
            btn_month = new Button();
            btn_week = new Button();
            btn_day = new Button();
            comboBoxYear = new ComboBox();
            label7 = new Label();
            panel6 = new Panel();
            chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panel8 = new Panel();
            label6 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            panel7.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chart2).BeginInit();
            panel8.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 94, 104);
            panel1.Controls.Add(btn_dashboard);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txt_username);
            panel1.Controls.Add(btn_logout);
            panel1.Location = new Point(3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1099, 57);
            panel1.TabIndex = 1;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Location = new Point(837, 8);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(122, 38);
            btn_dashboard.TabIndex = 14;
            btn_dashboard.Text = "DashBoard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(102, 20);
            label3.Name = "label3";
            label3.Size = new Size(78, 15);
            label3.TabIndex = 9;
            label3.Text = "Admin Name";
            // 
            // txt_username
            // 
            txt_username.Font = new Font("Segoe UI", 12F);
            txt_username.Location = new Point(186, 12);
            txt_username.Name = "txt_username";
            txt_username.ReadOnly = true;
            txt_username.Size = new Size(173, 29);
            txt_username.TabIndex = 9;
            // 
            // btn_logout
            // 
            btn_logout.Location = new Point(965, 8);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(122, 38);
            btn_logout.TabIndex = 9;
            btn_logout.Text = "Log Out";
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Location = new Point(10, 86);
            panel2.Name = "panel2";
            panel2.Size = new Size(708, 116);
            panel2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 15);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 0;
            label1.Text = "Total Sales";
            // 
            // panel4
            // 
            panel4.Controls.Add(label5);
            panel4.Location = new Point(734, 86);
            panel4.Name = "panel4";
            panel4.Size = new Size(350, 116);
            panel4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 15);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 2;
            label5.Text = "Total Cashier";
            // 
            // panel5
            // 
            panel5.Controls.Add(chart1);
            panel5.Controls.Add(panel7);
            panel5.Location = new Point(12, 213);
            panel5.Name = "panel5";
            panel5.Size = new Size(711, 581);
            panel5.TabIndex = 0;
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(3, 36);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(703, 543);
            chart1.TabIndex = 5;
            chart1.Text = "chart1";
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(52, 94, 104);
            panel7.Controls.Add(btn_year);
            panel7.Controls.Add(btn_month);
            panel7.Controls.Add(btn_week);
            panel7.Controls.Add(btn_day);
            panel7.Controls.Add(comboBoxYear);
            panel7.Controls.Add(label7);
            panel7.Location = new Point(1, 1);
            panel7.Name = "panel7";
            panel7.Size = new Size(705, 31);
            panel7.TabIndex = 0;
            // 
            // btn_year
            // 
            btn_year.Location = new Point(621, 5);
            btn_year.Name = "btn_year";
            btn_year.Size = new Size(75, 23);
            btn_year.TabIndex = 8;
            btn_year.Text = "year";
            btn_year.UseVisualStyleBackColor = true;
            btn_year.Click += btn_year_Click;
            // 
            // btn_month
            // 
            btn_month.Location = new Point(540, 5);
            btn_month.Name = "btn_month";
            btn_month.Size = new Size(75, 23);
            btn_month.TabIndex = 7;
            btn_month.Text = "Month";
            btn_month.UseVisualStyleBackColor = true;
            btn_month.Click += btn_month_Click;
            // 
            // btn_week
            // 
            btn_week.Location = new Point(459, 5);
            btn_week.Name = "btn_week";
            btn_week.Size = new Size(75, 23);
            btn_week.TabIndex = 6;
            btn_week.Text = "week";
            btn_week.UseVisualStyleBackColor = true;
            btn_week.Click += btn_week_Click;
            // 
            // btn_day
            // 
            btn_day.Location = new Point(378, 5);
            btn_day.Name = "btn_day";
            btn_day.Size = new Size(75, 23);
            btn_day.TabIndex = 5;
            btn_day.Text = "day";
            btn_day.UseVisualStyleBackColor = true;
            btn_day.Click += btn_day_Click;
            // 
            // comboBoxYear
            // 
            comboBoxYear.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxYear.FormattingEnabled = true;
            comboBoxYear.Location = new Point(90, 5);
            comboBoxYear.Name = "comboBoxYear";
            comboBoxYear.Size = new Size(282, 23);
            comboBoxYear.TabIndex = 4;
            comboBoxYear.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = SystemColors.Control;
            label7.Location = new Point(8, 7);
            label7.Name = "label7";
            label7.Size = new Size(78, 19);
            label7.TabIndex = 4;
            label7.Text = "Yearly sales";
            // 
            // panel6
            // 
            panel6.Controls.Add(chart2);
            panel6.Location = new Point(734, 213);
            panel6.Name = "panel6";
            panel6.Size = new Size(350, 570);
            panel6.TabIndex = 0;
            // 
            // chart2
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea4.AxisY.Title = "Total Sells";
            chartArea4.Name = "ChartArea1";
            chart2.ChartAreas.Add(chartArea4);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            chart2.Legends.Add(legend4);
            chart2.Location = new Point(29, 60);
            chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series4.Color = Color.FromArgb(52, 152, 219);
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            chart2.Series.Add(series4);
            chart2.Size = new Size(339, 521);
            chart2.TabIndex = 0;
            chart2.Text = "chart2";
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(52, 94, 104);
            panel8.Controls.Add(label6);
            panel8.Location = new Point(734, 213);
            panel8.Name = "panel8";
            panel8.Size = new Size(350, 31);
            panel8.TabIndex = 1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(3, 6);
            label6.Name = "label6";
            label6.Size = new Size(149, 19);
            label6.TabIndex = 3;
            label6.Text = "Top performing cashier";
            // 
            // frm_montlysales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 806);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frm_montlysales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frm_montlysales";
            Load += frm_montlysales_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chart2).EndInit();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private TextBox txt_username;
        private Button btn_logout;
        private Panel panel2;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Label label1;
        private Panel panel7;
        private Panel panel8;
        private Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label7;
        private Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Button btn_dashboard;
        private ComboBox comboBoxYear;
        private Button btn_year;
        private Button btn_month;
        private Button btn_week;
        private Button btn_day;
    }
}