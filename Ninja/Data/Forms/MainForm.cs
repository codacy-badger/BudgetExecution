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
            R6 = new DataBuilder(Source.P7);
            D6 = new DataBuilder(Source.P8);
            Metric = new DataMetric(R6);
            Timer = new Timer();
            Values = new Dictionary<string, double>[] { new ChartData(R6, ChartFilter.Fund).InputTotals, new ChartData(R6, ChartFilter.BocName).InputTotals,
                new ChartData(R6, ChartFilter.NPM).InputTotals, new ChartData(R6, ChartFilter.GoalName).InputTotals,
                new ChartData(D6, ChartFilter.BocName).InputTotals, new ChartData(R6, ChartFilter.NPM).InputTotals,
                new ChartData(R6, ChartFilter.GoalName).InputTotals };
            Title = GetChartTitles(Values);
            Chart = new GetChart(GetMainChart);
            MainChart = new BudgetChart(MainChart, Title[1], Values[1]).Activate();
            RegionSummaryButton.Click += RegionSummaryButton_OnClick;
            DivisionSummaryButton.Click += DivisionSummaryButton_OnClick;
        }

        public GetChart Chart { get; set; }
        public int Counter { get; set; }
        public DataBuilder D6 { get; }
        public DataBuilder R6{ get; set; }
        public DataMetric Metric { get; set; }
        public FormData NinjaData { get; set; }
        public string[] Title { get; set; }
        public Dictionary<string, double>[] Values { get; set; }
        public System.Windows.Forms.Timer Timer { get; set; }

        private void ChartTimer(object sender, EventArgs e)
        {
            if (Counter >= Values.Length)
            {
                Counter = 0;
                MainChart = new BudgetChart(MainChart, Title[Counter], Values[Counter]).Activate();
                Counter++;
            }
            if (Counter < Values.Length)
            {
                MainChart = new BudgetChart(MainChart, Title[Counter], Values[Counter]).Activate();
                Counter++;
            }
        }

        private string[] GetChartTitles(Dictionary<string, double>[] info)
        {
            var t = new string[info.Length];
            t[0] = "R6 Funds by Appropriation (in thousands)";
            t[1] = "R6 Funds by Object Class (in thousands)";
            t[2] = "R6 Funds by HQ NPM (in thousands)";
            t[3] = "R6 Funds by Agency Goal (in thousands)";
            t[4] = "Division Funds by Object (in thousands) ";
            t[5] = "Division Funds by HQ NPM (in thousands)";
            t[6] = "Division Funds by Agency Goal (in thousands)";
            return t;
        }

        private ChartControl GetMainChart(ChartControl chart, string[] title, Dictionary<string, double> data)
        {
            var db = new DataBuilder(Source.P7);
            var dm = new DataMetric(db);
            return new BudgetChart(MainChart, title[0], data).Activate();
        }

        private ChartControl GetMainChart(ChartControl chart, string title, Dictionary<string, double> data)
        {
            var db = new DataBuilder(Source.P7);
            var dm = new DataMetric(db);
            return new BudgetChart(MainChart, title, data).Activate();
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
            var datamgr = new SummaryForm(Source.P7);
            datamgr.Show();
        }

        private void DivisionSummaryButton_OnClick(object sender, EventArgs e)
        {
            var datamgr = new SummaryForm(Source.P8);
            datamgr.Show();
        }
    }
}