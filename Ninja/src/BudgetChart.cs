// <copyright file="BudgetChart.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace BudgetExecution
{
    public class BudgetChart
    {
        // CONSTRUCTORS
        public BudgetChart() { }

        public BudgetChart(ChartControl chart, string title, Dictionary<string, double> data)
        {
            Chart = chart;
            Value = Stat.Total;
            SeriesType = ChartSeriesType.Column;
            if(Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            ConfigurePrimaryAxisTitle(new[]
            {
                title
            });
            DataSeries = GetSeriesTotals(data);
            DataSeries.Type = SeriesType;
            Chart.Series.Add(DataSeries);
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, DataBuilder data, Field filter)
        {
            SeriesType = ChartSeriesType.Column;
            Chart = chart;
            Configure3DMode(Chart);
            DbData = data;
            Source = data.Source;
            Value = Stat.Total;
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataTotals = Metric.GetChartTotals(Table, filter);
            if(Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            DataSeries = GetSeriesTotals(DataTotals);
            Chart.Series.Add(DataSeries);
            DataSeries.Type = SeriesType;
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
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
            if(Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            Table = DbData.Table;
            CarryOver = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2018")).Select(p => p).CopyToDataTable();
            CurrentYear = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2019")).Select(p => p).CopyToDataTable();
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            CurrentYearMetrics = Metric.GetChartMetrics(CurrentYear, filter);
            CarryOverMetrics = Metric.GetChartMetrics(CarryOver, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = type;
            CurrentYearSeries = GetSeriesTotals(GetMeasure(CurrentYearMetrics, Value), type);
            CurrentYearSeries.Type = type;
            CurrentYearSeries.Text = "Current Year";
            CarryOverSeries = GetSeriesTotals(GetMeasure(CarryOverMetrics, Value), type);
            CarryOverSeries.Type = type;
            CarryOverSeries.Text = "Carry Over";
            ConfigureSeries(CurrentYearSeries, Value);
            ConfigureSeries(CarryOverSeries, Value);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, DataBuilder data, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            if(Chart.Series != null)
            {
                Chart.Series.Clear();
                Chart.ShowToolTips = true;
            }

            DbData = data;
            Source = data.Source;
            Value = value;
            SeriesType = type;
            ConfigureMainTitle(title);
            Table = DbData.Table;
            CarryOver = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2018")).Select(p => p).CopyToDataTable();
            CurrentYear = DbData.Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2019")).Select(p => p).CopyToDataTable();
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            CurrentYearMetrics = Metric.GetChartMetrics(CurrentYear, filter);
            CarryOverMetrics = Metric.GetChartMetrics(CarryOver, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = type;
            DataSeries.Name = "Combined Years";
            CurrentYearSeries = GetSeriesTotals(GetMeasure(CurrentYearMetrics, Value), type);
            CurrentYearSeries.Type = type;
            CurrentYearSeries.Text = "Current Year";
            CurrentYearSeries.Name = "Current Year";
            CarryOverSeries = GetSeriesTotals(GetMeasure(CarryOverMetrics, Value), type);
            CarryOverSeries.Type = type;
            CarryOverSeries.Text = "Carry Over";
            CarryOverSeries.Name = "Carry Over";
            Chart.ShowToolTips = true;
            ConfigureSeries(CurrentYearSeries, Value);
            ConfigureSeries(CarryOverSeries, Value);
            Chart.Series?.Add(CurrentYearSeries);
            ConfigureToolTip(CurrentYearSeries);
            Chart.Series?.Add(CarryOverSeries);
            ConfigureToolTip(CarryOverSeries);
            Configure3DMode(Chart);
            ConfigurePrimaryAxisLabels(Chart);
            Chart.ShowLegend = true;
            ConfigureLegend(Chart);
        }

        public BudgetChart(ChartControl chart, string[] title, DataTable table, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            Table = table;
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            if(Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, Dictionary<string, double> data, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            if(Chart.Series.Count > 0)
            {
                Chart.Series.Clear();
            }

            DataSeries = new ChartSeries();
            ConfigureSeries(DataSeries, Value);
            DataSeries.Type = SeriesType;
            foreach(KeyValuePair<string, double> kvp in data)
            {
                DataSeries.Points.Add(kvp.Key, kvp.Value);
            }

            Chart.Series?.Add(DataSeries);
            Configure3DMode(Chart);
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
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
            if(Chart.Series != null)
            {
                Chart.Series.Clear();
            }

            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = SeriesType;
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, Source source, Dictionary<string, object> param, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            if(Chart.Series.Count > 0)
            {
                Chart.Series.Clear();
            }

            Configure3DMode(Chart);
            SeriesType = type;
            Source = source;
            Value = value;
            DbData = new DataBuilder(source, Provider.SQLite, param);
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), SeriesType);
            Chart.Series?.Add(DataSeries);
            ConfigureSeries(DataSeries, Value);
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            Chart.ShowToolTips = true;
        }

        // PROPERTIES
        public string[] AxisTitle { get; set; }

        public ChartControl Chart { get; set; }

        public DataBuilder DbData { get; }

        public PrcMetric Metric { get; }

        public BindingSource BindingSource { get; set; }

        public Dictionary<string, double[]> DataMetrics { get; set; }

        public Dictionary<string, double[]> CarryOverMetrics { get; set; }

        public Dictionary<string, double[]> CurrentYearMetrics { get; set; }

        public ChartSeries DataSeries { get; set; }

        public ChartSeries CarryOverSeries { get; set; }

        public ChartSeries CurrentYearSeries { get; set; }

        public Dictionary<string, double> DataTotals { get; set; }

        public Dictionary<string, double> CarryOverTotals { get; set; }

        public Dictionary<string, double> CurrentYearTotals { get; set; }

        public int[] Dimension { get; set; }

        public Source Source { get; }

        public Field Filter { get; }

        public ChartSeriesType SeriesType { get; set; }

        public Stat Value { get; set; }

        public ChartLegend Legend { get; set; }

        public string[] MainTitle { get; set; }

        public ChartDataBindModel Model { get; set; }

        public DataTable Table { get; set; }

        public DataTable CarryOver { get;set; }

        public DataTable CurrentYear { get; set; }

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
                    foreach(KeyValuePair<string, double> kvp in data)
                    {
                        series.Points.Add(kvp.Key, kvp.Value);
                    }
                }

                if(SeriesType == ChartSeriesType.Pie)
                {
                    foreach(KeyValuePair<string, double> kvp in data)
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
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        internal ChartSeries GetSeriesTotals(Dictionary<string, double> data, ChartSeriesType type)
        {
            try
            {
                DataSeries = new ChartSeries("Total", type);
                switch(type)
                {
                    case ChartSeriesType.Column:
                        foreach(KeyValuePair<string, double> kvp in data)
                        {
                            DataSeries.Points.Add(kvp.Key, kvp.Value);
                        }

                        return DataSeries;

                    case ChartSeriesType.Pie:
                        ArrayList list = new ArrayList();
                        foreach(KeyValuePair<string, double> kvp in data)
                        {
                            DataSeries.Points.Add(kvp.Key, kvp.Value);
                        }

                        return DataSeries;
                }

                return DataSeries;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        internal Dictionary<string, double> GetMeasure(Dictionary<string, double[]> data, Stat value)
        {
            try
            {
                Dictionary<string, double> total = new Dictionary<string, double>();
                foreach(KeyValuePair<string, double[]> kvp in data)
                {
                    total.Add(kvp.Key, kvp.Value[(int) value]);
                }

                return total;
            }
            catch(Exception ex)
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
                DataSeries.Style.TextFormat = "{0:N2}";
                DataSeries.PointsToolTipFormat = "Funding:{4}";
            }
            catch(Exception ex)
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
                if(Source == Source.FTE)
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
                if(SeriesType == ChartSeriesType.Column)
                {
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void ConfigureSeries(ChartSeries Series)
        {
            try
            {
                Series.SmartLabels = true;
                Series.SortPoints = true;
                Series.Style.DisplayText = true;
                Series.Style.TextOffset = 15.0F;
                Series.Style.TextOrientation = ChartTextOrientation.Up;
                Series.Style.DisplayShadow = true;
                Series.Style.TextColor = Color.White;
                Series.PointsToolTipFormat = "{0}-{1}";
                Series.Style.Font.Size = 12.0F;
                Series.Style.Font.Facename = "Segoe UI";
                Series.Style.Font.FontStyle = FontStyle.Bold;
                if(Source == Source.FTE)
                {
                    Series.Style.TextFormat = "{0}";
                }
                else
                {
                    Series.Style.TextFormat = "${0:N2}";
                }

                if(SeriesType == ChartSeriesType.Column)
                {
                    Series.SmartLabels = true;
                    Series.SortPoints = true;
                    Series.Style.DisplayText = true;
                    Series.Style.TextOffset = 15.0F;
                    Series.Style.TextOrientation = ChartTextOrientation.Up;
                    Series.Style.DisplayShadow = true;
                    Series.Style.TextColor = Color.White;
                    Series.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    Series.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    Series.ConfigItems.ColumnItem.PhongAlpha = 2;
                    ConfigureToolTip(Series);
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void ConfigureSeries(ChartSeries series, Stat value)
        {
            try
            {
                if(Source == Source.FTE)
                {
                    series.Style.TextFormat = "{0}";
                }
                else
                {
                    if(value == Stat.Total || value == Stat.Average)
                    {
                        series.Style.TextFormat = "{0:N2}";
                    }
                }

                if(value == Stat.Ratio)
                {
                    series.Style.TextFormat = "{0:P}";
                }

                if(value == Stat.Count)
                {
                    series.Style.TextFormat = "{0}";
                }

                if(series.Type == ChartSeriesType.Pie)
                {
                    for(int i = 0; i < series.Points.Count; i++)
                    {
                        series.Styles[i].ToolTip = $"{series.Points[i].Category}";
                    }

                    series.Style.DisplayText = true;
                    series.SmartLabels = true;
                    series.SortPoints = true;
                    series.Style.DisplayText = true;
                    series.Style.DisplayShadow = true;
                    series.Style.TextOffset = 20.0F;
                    series.Style.TextOrientation = ChartTextOrientation.Up;
                    series.Style.DisplayShadow = true;
                    series.Style.TextColor = Color.White;
                    series.Style.Font.Size = 10.0F;
                    series.Style.Font.FontStyle = FontStyle.Bold;
                    series.Style.Font.Facename = "SegoeUI";
                    series.ShowTicks = true;
                    Chart.Series[0].ConfigItems.PieItem.HeightCoeficient = 0.1f;
                    //ConfigurePieChart(series);
                    return;
                }

                if(series.Type == ChartSeriesType.Column)
                {
                    series.SmartLabels = true;
                    series.SortPoints = true;
                    series.Style.DisplayText = true;
                    if(Source == Source.FTE)
                    {
                        series.PointsToolTipFormat = "{0}\nFTE: {4:N}";
                    }

                    series.PointsToolTipFormat = "{0}\nFunding: {4:C}";
                    series.Style.TextOffset = 20.0F;
                    series.Style.TextOrientation = ChartTextOrientation.Up;
                    series.Style.DisplayShadow = true;
                    series.Style.TextColor = Color.White;
                    series.Style.Font.Size = 10.0F;
                    series.Style.Font.FontStyle = FontStyle.Bold;
                    series.Style.Font.Facename = "SegoeUI";
                    series.ShowTicks = true;
                    series.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    series.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    series.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void ConfigureToolTip(ChartSeries series)
        {
            for(int i = 0; i < series.Points.Count; i++)
            {
                series.Styles[0].ToolTip = $"{series.Points[i].Category}";
            }
        }

        internal void ConfigurePrimaryAxisLabels(ChartControl chart)
        {
            try
            {
                Chart = chart;
                Chart.PrimaryXAxis.Font = new Font("SegoeUI", 10F, FontStyle.Bold);
                Chart.PrimaryXAxis.ForeColor = SystemColors.MenuHighlight;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void Configure3DMode(ChartControl chart)
        {
            try
            {
                Chart = chart;
                Chart.Style3D = true;
                Chart.ChartArea.Series3D = true;
                if(SeriesType == ChartSeriesType.Column)
                {
                    Chart.Tilt = 1f;
                    Chart.Depth = 250;
                    Chart.Rotation = 10;
                    Chart.SpacingBetweenSeries = 1;
                    Chart.RealMode3D = true;
                    return;
                }

                if(SeriesType == ChartSeriesType.Pie)
                {
                    Chart.Tilt = -15f;
                    Chart.Depth = 250;
                    Chart.RealMode3D = false;
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void Configure3DMode(int[] dim)
        {
            try
            {
                if(SeriesType == ChartSeriesType.Column)
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
            catch(Exception e)
            {
                new Error(e).ShowDialog();
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
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal ChartDataBindModel GetDataBindingSource(Dictionary<string, double> data, Field filter)
        {
            try
            {
                SortedList<string, double> chartdata = new SortedList<string, double>();
                foreach(KeyValuePair<string, double> kvp in data)
                {
                    chartdata.Add(kvp.Key, kvp.Value);
                }

                ChartDataBindModel model = new ChartDataBindModel(chartdata);
                model.YNames = new[]
                {
                    filter.ToString()
                };
                return model;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal ChartLegend GetLegend(ChartControl chart)
        {
            try
            {
                if(Chart.Legends != null)
                {
                    Chart.Legends.Clear();
                }

                ChartLegend legend = new ChartLegend(Chart);
                foreach(string axislabel in Chart.PrimaryXAxis.Labels)
                {
                    ChartLegendItem item = new ChartLegendItem(axislabel);
                }

                legend.VisibleCheckBox = true;
                Chart.Legends.Add(legend);
                return legend;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }
        
        internal void ConfigureLegend(ChartControl chart)
        {
            try
            {
                chart.Legend.VisibleCheckBox = true;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        internal void ConfigureMainTitle(string[] t)
        {
            try
            {
                if(Chart.Titles != null)
                {
                    Chart.Titles.Clear();
                }

                foreach(string s in t)
                {
                    ChartTitle title = new ChartTitle();
                    title.Text = s;
                    title.ForeColor = Color.LightSteelBlue;
                    title.Font = new Font("Tahoma", 9f, FontStyle.Regular);
                    Chart.Titles.Add(title);
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }
    }
}
