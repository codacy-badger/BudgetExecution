// <copyright file="MainForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public partial class MainForm : Syncfusion.Windows.Forms.MetroForm
    {
        // CONSTRUCTORS
        public MainForm()
        {
            InitializeComponent();
            NinjaData = new FormData();
            R6 = new DataBuilder(Source.RegionalAccounts, Provider.SQLite);
            D6 = new DataBuilder(Source.DivisionAccounts, Provider.SQLite);
            Metric = new PrcMetric(R6);
            Timer = new Timer();
            Values = new Dictionary<string, double>[]
            {
                Metric.GetChartTotals(R6.DbTable, PrcField.Fund), Metric.GetChartTotals(R6.DbTable, PrcField.BOC),
                Metric.GetChartTotals(D6.DbTable, PrcField.Fund), Metric.GetChartTotals(R6.DbTable, PrcField.NPM), Metric.GetChartTotals(D6.DbTable, PrcField.NPM),
                Metric.GetChartTotals(R6.DbTable, PrcField.GoalName), Metric.GetChartTotals(D6.DbTable, PrcField.GoalName)
            };
            Title = GetChartTitles(Values);
            Chart = new GetChart(GetMainChart);
            MainChart = new BudgetChart(MainChart, Title[1], Values[1]).Activate();
            SummaryTile.Click += SummaryTile_OnClick;
            DivisionBudgetTile.Click += DivisionDataTile_OnClick;
            DataMasterTile.Click += DatabaseTile_OnClick;
        }

        // PROPERTIES
        public GetChart Chart { get; set; }

        public int Counter { get; set; }

        public DataBuilder D6 { get; set; }

        public PrcMetric Metric { get; set; }

        public FormData NinjaData { get; set; }

        public DataBuilder R6 { get; set; }

        public string[] Title { get; set; }

        public Dictionary<string, double>[] Values { get; set; }

        public Timer Timer { get; set; }

        private string[] Images { get; set; }

        // METHODS
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
            var dm = new FunctionSelector();
            dm.Show();
        }

        private void DivisionSummaryButton_OnClick(object sender, EventArgs e)
        {
            var summary = new SummaryForm(Source.DivisionAccounts);
            summary.Show();
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
            var datamgr = new SummaryForm(Source.RegionalAccounts);
            datamgr.Show();
        }

        private void TransferButton_OnClick(object sender, EventArgs e)
        {
            var dm = new SummaryForm("06J");
            dm.Show();
        }

        private void DivisionDataTile_OnClick(object sender, EventArgs e)
        {
            var s = new Selector(Info.DivisionImages);
            s.Show();
        }

        private void SummaryTile_OnClick(object sender, EventArgs e)
        {
            var summary = new Selector(Info.SummaryImages);
            summary.Show();
        }

        private void FunctionalityTile_OnClick(object sender, EventArgs e)
        {
            var s = new Selector(Info.FunctionImages);
            s.Show();
        }

        private void DatabaseTile_OnClick(object sender, EventArgs e)
        {
            var dm = new FunctionSelector();
            dm.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
        }
    }
}