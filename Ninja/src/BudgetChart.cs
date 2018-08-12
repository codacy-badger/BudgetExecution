// <copyright file="BudgetChart.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public class BudgetChart
    {
        // CONSTRUCTORS
        public BudgetChart()
        {
        }

        public BudgetChart(ChartControl chart, string title, Dictionary<string, double> data)
        {
            Chart = chart;
            Value = Stat.Total;
            SeriesType = ChartSeriesType.Column;
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            ConfigurePrimaryAxisTitle(new string[] { title });
            DataSeries = GetSeriesTotals(data);
            DataSeries.Type = SeriesType;
            Chart.Series.Add(DataSeries);
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, DataBuilder data, Field filter)
        {
            SeriesType = ChartSeriesType.Column;
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = Stat.Total;
            Table = DbData.DbTable;
            Metric = new PrcMetric(DbData);
            DataTotals = Metric.GetChartTotals(Table, filter);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            DataSeries = GetSeriesTotals(DataTotals);
            DataSeries.Type = SeriesType;
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, DataBuilder data, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            Table = DbData.DbTable;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = type;
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, DataBuilder data, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            Table = DbData.DbTable;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = type;
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
            
        }

        public BudgetChart(ChartControl chart, string[] title, DataTable table, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            Table = table;
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, Dictionary<string, double> data, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }
            DataSeries = new ChartSeries();
            DataSeries.Type = SeriesType;
            foreach (KeyValuePair<string, double> kvp in data)
                DataSeries.Points.Add(kvp.Key, kvp.Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, Source source, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Source = source;
            DbData = new DataBuilder(source, Provider.SQLite);
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            Table = DbData.DbTable;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = SeriesType;
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, Source source, Dictionary<string, object> param, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Source = source;
            DbData = new DataBuilder(source, Provider.SQLite, param);
            Metric = new PrcMetric(DbData);
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            Table = DbData.DbTable;
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = SeriesType;
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            ConfigureToolTip(DataSeries);
            Chart.ShowToolTips = true;
        }

        // PROPERTIES
        public string[] AxisTitle { get; set; }

        public ChartControl Chart { get; set; }

        public DataBuilder DbData { get; }

        public PrcMetric Metric { get; }

        public BindingSource BindingSource { get; set; }

        public Dictionary<string, double[]> DataMetrics { get; set; }

        public ChartSeries DataSeries { get; set; }

        public Dictionary<string, double> DataTotals { get; set; }

        public int[] Dimension { get; set; }

        public Source Source { get; }

        public Field Filter { get; }

        public ChartSeriesType SeriesType { get; set; }

        public Stat Value { get; set; }

        public Dictionary<string, double[]> InputMetrics { get; set; }

        public Dictionary<string, double> InputTotals { get; set; }

        public ChartLegend Legend { get; set; }

        public string[] MainTitle { get; set; }

        public ChartDataBindModel Model { get; set; }

        public DataTable Table { get; set; }

        private double Total { get; }

        // METHODS
        internal ChartControl Activate()
        {
            return Chart;
        }

        internal ChartSeries GetSeriesTotals(Dictionary<string, double> data)
        {
            try
            {
                ChartSeries series = new ChartSeries("Total", SeriesType);
                if(SeriesType == ChartSeriesType.Column)
                {
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        series.Points.Add(kvp.Key, kvp.Value);
                    }
                }
                if (SeriesType == ChartSeriesType.Pie)
                {
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        series.Style.DisplayText = true;
                        series.ExplodedAll = true;
                        series.ExplosionOffset = 20f;
                        series.ShowTicks = true;
                        series.SmartLabels = true;
                        series.SortPoints = true;
                        series.Style.TextOffset = 15.0F;
                        series.OptimizePiePointPositions = true;
                        series.Style.TextColor = Color.White;
                        series.Points.Add(kvp.Key, kvp.Value);
                    }
                }

                DataSeries = series;
                return DataSeries;
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
                return null;
            }
        }

        internal ChartSeries GetSeriesTotals(Dictionary<string, double> data, ChartSeriesType type)
        {
            try
            {
                ChartSeries series = new ChartSeries("Total", type);
                if (type == ChartSeriesType.Column)
                {
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        series.Points.Add(kvp.Key, kvp.Value);
                    }
                }
                if (type == ChartSeriesType.Pie)
                {
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        series.Points.Add(kvp.Key, kvp.Value);
                        series.Style.DisplayText = true;
                        series.Style.TextFormat = $"{kvp.Key}, {kvp.Value}";
                        series.ExplodedAll = true;
                        series.ExplosionOffset = 20f;
                        series.ShowTicks = true;
                        series.SmartLabels = true;
                        series.SortPoints = true;
                        series.Style.TextOffset = 15.0F;
                        series.OptimizePiePointPositions = true;
                        series.Style.TextColor = Color.White;
                    }
                }

                DataSeries = series;
                Chart.Series.Add(DataSeries);
                return DataSeries;
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
                return null;
            }
        }

        private Dictionary<string, double> GetMeasure(Dictionary<string, double[]> data, Stat value)
        {
            try
            {
                Dictionary<string, double> total = new Dictionary<string, double>();
                foreach (KeyValuePair<string, double[]> kvp in data)
                {
                    total.Add(kvp.Key, kvp.Value[(int)value]);
                }

                return total;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal void ConfigurePieChart(ChartSeries ds)
        {
            try
            {
                DataSeries = ds;
                DataSeries.ExplodedAll = true;
                DataSeries.ExplosionOffset = 20f;
                DataSeries.ShowTicks = true;
                DataSeries.Style.DisplayText = true;
                DataSeries.Style.TextFormat = "{0}, {1}";
                DataSeries.PointsToolTipFormat = "Funding:{3}";
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void ConfigureLargeNumberSeries(ChartSeries series)
        {
            try
            {
                DataSeries = series;
                DataSeries.SmartLabels = true;
                DataSeries.SortPoints = true;
                DataSeries.Style.DisplayText = true;
                DataSeries.Style.TextOffset = 20.0F;
                DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                DataSeries.Style.DisplayShadow = true;
                DataSeries.Style.TextColor = Color.White;
                if (Source == Source.FTE)
                {
                    DataSeries.Style.TextFormat = "{0}";
                }
                else
                {
                    DataSeries.Style.TextFormat = "${0:N2}";
                }

                DataSeries.PointsToolTipFormat = "Funding:{4:N}";
                DataSeries.Style.Font.Size = 10.0F;
                DataSeries.Style.Font.Facename = "SegoeUI";
                DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                if (SeriesType == ChartSeriesType.Column)
                {
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        internal void ConfigureSeries(ChartSeries series)
        {
            try
            {
                DataSeries = series;
                DataSeries.SmartLabels = true;
                DataSeries.SortPoints = true;
                DataSeries.Style.DisplayText = true;
                DataSeries.Style.TextOffset = 15.0F;
                DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                DataSeries.Style.DisplayShadow = true;
                DataSeries.Style.TextColor = Color.White;
                DataSeries.PointsToolTipFormat = "Funding:{0}-{4:N2}";
                DataSeries.Style.Font.Size = 12.0F;
                DataSeries.Style.Font.Facename = "Segoe UI";
                DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                if (Source == Source.FTE)
                {
                    DataSeries.Style.TextFormat = "{0}";
                }
                else
                {
                    DataSeries.Style.TextFormat = "${0:N2}";
                }
                if (SeriesType == ChartSeriesType.Column)
                {
                    DataSeries.SmartLabels = true;
                    DataSeries.SortPoints = true;
                    DataSeries.Style.DisplayText = true;
                    DataSeries.Style.TextOffset = 15.0F;
                    DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    DataSeries.Style.DisplayShadow = true;
                    DataSeries.Style.TextColor = Color.White;
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                    ConfigureToolTip(DataSeries);
                }
                
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        internal void ConfigureSeries(ChartSeries series, Stat value)
        {
            try
            {
                DataSeries = series;
                if (Source == Source.FTE)
                {
                    DataSeries.Style.TextFormat = "{0}";
                }
                else if (value == Stat.Total || value == Stat.Average)
                {
                    DataSeries.Style.TextFormat = "{0:N2}";
                }

                if (value == Stat.Ratio)
                {
                    DataSeries.Style.TextFormat = "{0:P}";
                }

                if (value == Stat.Count)
                {
                    DataSeries.Style.TextFormat = "{0}";
                }

                if (DataSeries.Type == ChartSeriesType.Pie)
                {

                    DataSeries.Style.DisplayText = true;
                    DataSeries.SmartLabels = true;
                    DataSeries.SortPoints = true;
                    DataSeries.Style.DisplayText = true;
                    DataSeries.Style.DisplayShadow = true;
                    DataSeries.Style.TextOffset = 20.0F;
                    DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    DataSeries.Style.DisplayShadow = true;
                    DataSeries.Style.TextColor = Color.White;
                    DataSeries.PointsToolTipFormat = "{0}-{4:N2}";
                    DataSeries.Style.Font.Size = 10.0F;
                    DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                    DataSeries.Style.Font.Facename = "SegoeUI";
                    DataSeries.ShowTicks = true;
                    Chart.Series[0].ConfigItems.PieItem.HeightCoeficient = 0.1f;
                }
                if (DataSeries.Type == ChartSeriesType.Column)
                {

                    DataSeries.SmartLabels = true;
                    DataSeries.SortPoints = true;
                    DataSeries.Style.DisplayText = true;
                    DataSeries.Style.TextOffset = 20.0F;
                    DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    DataSeries.Style.DisplayShadow = true;
                    DataSeries.Style.TextColor = Color.White;
                    DataSeries.Style.Font.Size = 10.0F;
                    DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                    DataSeries.Style.Font.Facename = "SegoeUI";
                    DataSeries.ShowTicks = true;
                    DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    DataSeries.Style.DisplayShadow = true;
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        private void ConfigureToolTip(ChartSeries series)
        {
            DataSeries = series;
            for (int i = 0; i < DataSeries.Points.Count; i++)
            {
                DataSeries.Styles[i].ToolTip = string.Format("{0}", DataSeries.Points[0].Category);
            }
        }

        private void ConfigurePrimaryAxisLabels(ChartControl chart)
        {
            try
            {
                Chart = chart;
                Chart.PrimaryXAxis.Font = new Font("SegoeUI", 9F, FontStyle.Bold);
                Chart.PrimaryXAxis.ForeColor = SystemColors.MenuHighlight;
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        private void Configure3DMode(ChartControl chart)
        {
            try
            {
                if (SeriesType == ChartSeriesType.Column)
                {
                    Chart = chart;
                    Chart.Style3D = true;
                    Chart.ChartArea.Series3D = true;
                    Chart.RealMode3D = true;
                    Chart.Tilt = 0.0f;
                    Chart.Depth = 250;
                    Chart.Rotation = 20;
                    Chart.SpacingBetweenSeries = 2;
                }

                if (SeriesType == ChartSeriesType.Pie)
                {
                    Chart = chart;
                    Chart.Style3D = true;
                    Chart.ChartArea.Series3D = true;
                    Chart.RealMode3D = true;
                    Chart.Tilt = -15f;
                    Chart.Depth = 250;
                    Chart.Rotation = 0;
                }
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        internal void Configure3DMode(int[] dim)
        {
            try
            {
                if (SeriesType == ChartSeriesType.Column)
                {
                    Chart.ChartArea.Series3D = true;
                    Chart.RealMode3D = true;
                    Chart.Style3D = true;
                    Chart.Tilt = dim[0];
                    Chart.Depth = dim[1];
                    Chart.Rotation = dim[2];
                    Chart.SpacingBetweenSeries = 2;
                }
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        internal void ConfigurePrimaryAxisTitle(string[] title)
        {
            try
            {
                Chart.PrimaryXAxis.Title = title[0];
                Chart.PrimaryXAxis.TitleColor = Color.LightSteelBlue;
                Chart.PrimaryXAxis.TitleFont = new Font("Segoe UI", 10f, FontStyle.Bold);
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }

        internal ChartDataBindModel GetDataBindingSource(Dictionary<string, double> data, Field filter)
        {
            try
            {
                SortedList<string, double> chartdata = new SortedList<string, double>();
                foreach (KeyValuePair<string, double> kvp in data)
                {
                    chartdata.Add(kvp.Key, kvp.Value);
                }

                ChartDataBindModel model = new ChartDataBindModel(chartdata);
                model.YNames = new string[] { filter.ToString() };
                return model;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal ChartLegend GetLegend(ChartControl chart)
        {
            try
            {
                if (Chart.Legends != null)
                {
                    Chart.Legends.Clear();
                }

                ChartLegend legend = new ChartLegend(Chart);
                foreach (string axislabel in Chart.PrimaryXAxis.Labels)
                {
                    ChartLegendItem item = new ChartLegendItem(axislabel);
                }

                legend.VisibleCheckBox = true;
                Chart.Legends.Add(legend);
                return legend;
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
                return null;
            }
        }

        internal void ConfigureMainTitle(string[] t)
        {
            try
            {
                if (Chart.Titles != null)
                {
                    Chart.Titles.Clear();
                }

                foreach (string s in t)
                {
                    ChartTitle title = new ChartTitle();
                    title.Text = s;
                    title.ForeColor = Color.LightSteelBlue;
                    title.Font = new Font("Tahoma", 9f, FontStyle.Regular);
                    Chart.Titles.Add(title);
                }
            }
            catch (Exception e)
            {
                DialogResult  _ = new Error(e).ShowDialog();
            }
        }
    }
}