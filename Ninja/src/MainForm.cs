using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;


namespace BudgetExecution
{
    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        //Constructors
        public MainForm()
        {
            InitializeComponent();
            NinjaData = new FormData();
            R6 = new DataBuilder(Source.RegionAccount);
            D6 = new DataBuilder(Source.DivisionAccount);
            Metric = new DataMetric(R6);
            Timer = new Timer();
            Values = new Dictionary<string, double>[] { Metric.GetChartTotals(R6.QueryTable, PrcField.Fund), Metric.GetChartTotals(R6.QueryTable, PrcField.BOC),
                Metric.GetChartTotals(D6.QueryTable, PrcField.Fund), Metric.GetChartTotals(R6.QueryTable, PrcField.NPM), Metric.GetChartTotals(D6.QueryTable, PrcField.NPM),
                Metric.GetChartTotals(R6.QueryTable, PrcField.GoalName), Metric.GetChartTotals(D6.QueryTable, PrcField.GoalName)};
            Title = GetChartTitles(Values);
            Chart = new GetChart(GetMainChart);
            MainChart = new BudgetChart(MainChart, Title[1], Values[1]).Activate();
            RegionSummaryButton.Click += RegionSummaryButton_OnClick;
            DivisionSummaryButton.Click += DivisionSummaryButton_OnClick;
            TransferButton.Click += TransferButton_OnClick;
        }

        //Properties
        public GetChart Chart { get; set; }

        public int Counter { get; set; }
        public DataBuilder D6 { get; set; }
        public DataMetric Metric { get; set; }
        public FormData NinjaData { get; set; }
        public DataBuilder R6 { get; set; }
        public string[] Title { get; set; }
        public Dictionary<string, double>[] Values { get; set; }
        public Timer Timer { get; set; }

        //Methods

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                NinjaData.ConfigureFormSettings(this);
                Counter = 0;
                Timer.Tick += ChartTimer;
                Timer.Enabled = true;
                Timer.Interval = 5000;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void ChartTimer(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void DataButton_OnClick(object sender, EventArgs e)
        {
            var dm = new DataMaster();
            dm.Show();
        }
        private void DivisionSummaryButton_OnClick(object sender, EventArgs e)
        {
            var datamgr = new SummaryForm(Source.DivisionAccount);
            datamgr.Show();
        }
        private string[] GetChartTitles(Dictionary<string, double>[] info)
        {
            try
            {
                var t = new string[info.Length];
                t[0] = "R6 Funds by Appropriation";
                t[1] = "R6 Funds by Object Class";
                t[2] = "Division Funds by Appropriation";
                t[3] = "Division Funds by HQ NPM";
                t[4] = "R6 Funds by Agency Goal";
                t[5] = "Division Funds by Agency Goal";
                t[6] = "Division Funds by HQ NPM";
                return t;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        private ChartControl GetMainChart(ChartControl chart, string[] title, Dictionary<string, double> data)
        {
            try
            {
                MainChart = new BudgetChart(chart, title[0], data).Activate();
                return MainChart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        private ChartControl GetMainChart(ChartControl chart, string title, Dictionary<string, double> data)
        {
            try
            {
                MainChart = new BudgetChart(chart, title, data).Activate();
                return MainChart;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        private void RegionSummaryButton_OnClick(object sender, EventArgs e)
        {
            var datamgr = new SummaryForm(Source.RegionAccount);
            datamgr.Show();
        }
        private void TransferButton_OnClick(object sender, EventArgs e)
        {
            var dm = new SummaryForm("06J");
            dm.Show();
        }
        private void DataTile_OnClick(object sender, EventArgs e)
        {
            var s = new Selector(Info.DivisionImages);
            s.Show();
        }
        private void SummaryTile_OnClick(object sender, EventArgs e)
        {
            var s = new Selector(Info.SummaryImages);
            s.Show();
        }
        private void DocumentButton_OnClick(object sender, EventArgs e)
        {
            var s = new FunctionalityForm();
            s.Show();
        }
        private void TransferButton_Click(object sender, EventArgs e)
        {

        }
    }
}