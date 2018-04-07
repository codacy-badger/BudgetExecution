using Budget.Ninja.Data;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ninja.Forms
{
    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            NinjaData = new FormData();
            R6 = new RegionalAuthority();
            Division = new DivisionAuthority();
            Timer = new Timer();
            Chart = new GetChart(GetMainChart);
            Values = new Dictionary<string, decimal>[] { R6.FundData, R6.BocData,
                R6.NpmData, R6.GoalData, Division.BocData, Division.NpmData, Division.GoalData };
            Title = GetChartTitles(Values);
            MainChart = Chart(MainChart, Title[1], Values[1]);
            RegionSummaryButton.Click += RegionSummaryButton_OnClick;
            DivisionSummaryButton.Click += DivisionSummaryButton_OnClick;
        }

        public GetChart Chart { get; set; }
        public int Counter { get; set; }
        public DivisionAuthority Division { get; }
        public FormData NinjaData { get; set; }
        public RegionalAuthority R6 { get; }
        public string[] Title { get; set; }
        public Dictionary<string, decimal>[] Values { get; set; }
        public System.Windows.Forms.Timer Timer { get; set; }

        private void ChartTimer(object sender, EventArgs e)
        {
            if (Counter >= Values.Length)
            {
                Counter = 0;
                MainChart = Chart(MainChart, Title[Counter], Values[Counter]);
                Counter++;
            }
            if (Counter < Values.Length)
            {
                MainChart = Chart(MainChart, Title[Counter], Values[Counter]);
                Counter++;
            }
        }

        private void DivisionSummaryButton_OnClick(object sender, EventArgs e)
        {
            var datamgr = new DataManager(Source.P8);
            datamgr.Show();
        }

        private string[] GetChartTitles(Dictionary<string, decimal>[] info)
        {
            var t = new string[info.Length];
            t[0] = "R6 Funds by Appropriation";
            t[1] = "R6 Funds by Object Class";
            t[2] = "R6 Funds by HQ NPM";
            t[3] = "R6 Funds by Agency Goal";
            t[4] = "Division Funds by Object Class";
            t[5] = "Division Funds by HQ NPM";
            t[6] = "Division Funds by Agency Goal";
            return t;
        }

        private ChartControl GetMainChart(ChartControl chart, string[] title, Dictionary<string, decimal> data)
        {
            MainChart = new Chart(chart, title[0], data).CreateColumn();
            return MainChart;
        }

        private ChartControl GetMainChart(ChartControl chart, string title, Dictionary<string, decimal> data)
        {
            MainChart = new Chart(chart, title, data).CreateColumn();
            return MainChart;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NinjaData.GetFormSettings(this);
            Counter = 0;
            Timer.Tick += ChartTimer;
            Timer.Enabled = true;
            Timer.Interval = 5000;
        }

        private void RegionSummaryButton_OnClick(object sender, EventArgs e)
        {
            var datamgr = new DataManager(Source.P7);
            datamgr.Show();
        }
    }
}