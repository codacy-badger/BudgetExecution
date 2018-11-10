// <copyright file="MainForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;

    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public partial class MainForm : MetroForm
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
            Values = new[] { Metric.GetChartTotals(R6.Table, Field.Fund), Metric.GetChartTotals(R6.Table, Field.BOC), Metric.GetChartTotals(D6.Table, Field.Fund), Metric.GetChartTotals(R6.Table, Field.NPM), Metric.GetChartTotals(D6.Table, Field.NPM), Metric.GetChartTotals(R6.Table, Field.GoalName), Metric.GetChartTotals(D6.Table, Field.GoalName) };
            Title = GetChartTitles(Values);
            Chart = GetMainChart;
            MainChart = new BudgetChart(MainChart, Title[1], Values[1]).Activate();
        }

        // PROPERTIES
        public ChartDelegate Chart { get; set; }

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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
            }
        }

        private void DataButton_OnClick(object sender, EventArgs e)
        {
            FunctionSelector dm = new FunctionSelector();
            dm.Show();
        }

        private void DivisionSummaryButton_OnClick(object sender, EventArgs e)
        {
            SummaryForm summary = new SummaryForm(Source.DivisionAccounts, Provider.SQLite);
            summary.Show();
        }

        private string[] GetChartTitles(Dictionary<string, double>[] info)
        {
            try
            {
                string[] t = new string[info.Length];
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private void RegionSummaryButton_OnClick(object sender, EventArgs e)
        {
            SummaryForm datamgr = new SummaryForm(Source.RegionalAccounts, Provider.SQLite);
            datamgr.Show();
        }

        private void TransferButton_OnClick(object sender, EventArgs e)
        {
            SummaryForm dm = new SummaryForm(Source.MM, Provider.SQLite);
            dm.Show();
        }

        public void DivisionDataTile_OnClick(object sender, EventArgs e)
        {
            Selector s = new Selector(Info.DivisionImages);
            s.Show();
        }

        public void SummaryTile_OnClick(object sender, EventArgs e)
        {
            Selector summary = new Selector(Info.SummaryImages);
            summary.Show();
        }

        public void EnterTile_OnClick(object sender, EventArgs e)
        {
            Selector summary = new Selector(Info.EnterImages);
            summary.Show();
        }

        public void FunctionalityTile_OnClick(object sender, EventArgs e)
        {
            Selector s = new Selector(Info.FunctionImages);
            s.Show();
        }

        public void DatabaseTile_OnClick(object sender, EventArgs e)
        {
            FunctionSelector dm = new FunctionSelector();
            dm.Show();
        }

        private void TransferButton_Click(object sender, EventArgs e)
        {
        }
    }
}
