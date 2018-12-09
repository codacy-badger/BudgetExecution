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

    /// <summary>
    /// Defines the <see cref="BudgetChart" />
    /// </summary>
    public class BudgetChart
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        public BudgetChart()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="title">The title<see cref="string"/></param>
        /// <param name="data">The data<see cref="Dictionary{string, double}"/></param>
        public BudgetChart(ChartControl chart, string title, Dictionary<string, double> data)
        {
            Chart = chart;
            Value = Stat.Total;
            SeriesType = ChartSeriesType.Column;
            Chart.Series?.Clear();

            ConfigurePrimaryAxisTitle(new[] { title });
            DataSeries = GetSeriesTotals(data);
            DataSeries.Type = SeriesType;
            Chart.Series?.Add(DataSeries);
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="data">The data<see cref="DataBuilder"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
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
            Chart.Series?.Clear();

            DataSeries = GetSeriesTotals(DataTotals);
            Chart.Series?.Add(DataSeries);
            DataSeries.Type = SeriesType;
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Chart.ShowToolTips = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="data">The data<see cref="DataBuilder"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
        public BudgetChart(ChartControl chart, DataBuilder data, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            Chart.Series?.Clear();

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
            ConfigurePrimaryAxisLabels(Chart);
            Chart.ShowLegend = true;
            ConfigureLegend(Chart);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="title">The title<see cref="string[]"/></param>
        /// <param name="data">The data<see cref="DataBuilder"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
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

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
        public BudgetChart(ChartControl chart, DataTable table, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            Table = table;
            CarryOver = Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2018")).Select(p => p).CopyToDataTable();
            CurrentYear = Table.AsEnumerable().Where(p => p.Field<string>("BFY").Equals("2019")).Select(p => p).CopyToDataTable();
            Metric = new PrcMetric(Table, filter, filter.ToString());
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

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="title">The title<see cref="string[]"/></param>
        /// <param name="data">The data<see cref="Dictionary{string, double}"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
        public BudgetChart(ChartControl chart, string[] title, Dictionary<string, double> data, Stat value, ChartSeriesType type)
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

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="title">The title<see cref="string[]"/></param>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
        public BudgetChart(ChartControl chart, string[] title, Source source, Field filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Source = source;
            DbData = new DataBuilder(source);
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            Chart.Series?.Clear();
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value), type);
            DataSeries.Type = SeriesType;
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetChart"/> class.
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <param name="title">The title<see cref="string[]"/></param>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="param">The param<see cref="Dictionary{string, object}"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
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
        /// <summary>
        /// Gets or sets the AxisTitle
        /// </summary>
        public string[] AxisTitle { get; set; }

        /// <summary>
        /// Gets or sets the Chart
        /// </summary>
        public ChartControl Chart { get; set; }

        /// <summary>
        /// Gets the DbData
        /// </summary>
        public DataBuilder DbData { get; }

        /// <summary>
        /// Gets the Metric
        /// </summary>
        public PrcMetric Metric { get; }

        /// <summary>
        /// Gets or sets the BindingSource
        /// </summary>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the DataMetrics
        /// </summary>
        public Dictionary<string, double[]> DataMetrics { get; set; }

        /// <summary>
        /// Gets or sets the CarryOverMetrics
        /// </summary>
        public Dictionary<string, double[]> CarryOverMetrics { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYearMetrics
        /// </summary>
        public Dictionary<string, double[]> CurrentYearMetrics { get; set; }

        /// <summary>
        /// Gets or sets the DataSeries
        /// </summary>
        public ChartSeries DataSeries { get; set; }

        /// <summary>
        /// Gets or sets the CarryOverSeries
        /// </summary>
        public ChartSeries CarryOverSeries { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYearSeries
        /// </summary>
        public ChartSeries CurrentYearSeries { get; set; }

        /// <summary>
        /// Gets or sets the DataTotals
        /// </summary>
        public Dictionary<string, double> DataTotals { get; set; }

        /// <summary>
        /// Gets or sets the CarryOverTotals
        /// </summary>
        public Dictionary<string, double> CarryOverTotals { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYearTotals
        /// </summary>
        public Dictionary<string, double> CurrentYearTotals { get; set; }

        /// <summary>
        /// Gets or sets the Dimension
        /// </summary>
        public int[] Dimension { get; set; }

        /// <summary>
        /// Gets the Source
        /// </summary>
        public Source Source { get; }

        /// <summary>
        /// Gets or sets the SeriesType
        /// </summary>
        public ChartSeriesType SeriesType { get; set; }

        /// <summary>
        /// Gets or sets the Value
        /// </summary>
        public Stat Value { get; set; }

        /// <summary>
        /// Gets or sets the Legend
        /// </summary>
        public ChartLegend Legend { get; set; }

        /// <summary>
        /// Gets or sets the MainTitle
        /// </summary>
        public string[] MainTitle { get; set; }

        /// <summary>
        /// Gets or sets the Model
        /// </summary>
        public ChartDataBindModel Model { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the CarryOver
        /// </summary>
        public DataTable CarryOver { get; set; }

        /// <summary>
        /// Gets or sets the CurrentYear
        /// </summary>
        public DataTable CurrentYear { get; set; }

        // METHODS
        /// <summary>
        /// The Activate
        /// </summary>
        /// <returns>The <see cref="ChartControl"/></returns>
        internal ChartControl Activate()
        {
            return Chart;
        }

        /// <summary>
        /// The GetSeriesTotals
        /// </summary>
        /// <param name="data">The data<see cref="Dictionary{string, double}"/></param>
        /// <returns>The <see cref="ChartSeries"/></returns>
        internal ChartSeries GetSeriesTotals(Dictionary<string, double> data)
        {
            try
            {
                ChartSeries series = new ChartSeries("Total", SeriesType);
                switch(SeriesType)
                {
                    case ChartSeriesType.Column:
                    case ChartSeriesType.Line:
                    case ChartSeriesType.Spline:
                    case ChartSeriesType.SplineArea:
                    case ChartSeriesType.StackingColumn:
                    {
                        foreach(KeyValuePair<string, double> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value);
                        }

                        break;
                    }
                    case ChartSeriesType.Pie:
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

                        break;
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

        /// <summary>
        /// The GetSeriesTotals
        /// </summary>
        /// <param name="data">The data<see cref="Dictionary{string, double}"/></param>
        /// <param name="type">The type<see cref="ChartSeriesType"/></param>
        /// <returns>The <see cref="ChartSeries"/></returns>
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

                    case ChartSeriesType.Area:
                        foreach(KeyValuePair<string, double> kvp in data)
                        {
                            DataSeries.Points.Add(kvp.Key, kvp.Value);
                        }

                        return DataSeries;

                    case ChartSeriesType.Pie:
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

        /// <summary>
        /// The GetMeasure
        /// </summary>
        /// <param name="data">The data<see cref="Dictionary{string, double[]}"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        /// <returns>The <see cref="Dictionary{string, double}"/></returns>
        internal Dictionary<string, double> GetMeasure(Dictionary<string, double[]> data, Stat value)
        {
            try
            {
                Dictionary<string, double> total = new Dictionary<string, double>();
                foreach(KeyValuePair<string, double[]> kvp in data)
                {
                    total.Add(kvp.Key, kvp.Value[(int)value]);
                }

                return total;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The ConfigurePieChart
        /// </summary>
        /// <param name="ds">The ds<see cref="ChartSeries"/></param>
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

        /// <summary>
        /// The ConfigureLargeNumberSeries
        /// </summary>
        /// <param name="series">The series<see cref="ChartSeries"/></param>
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

        /// <summary>
        /// The ConfigureSeries
        /// </summary>
        /// <param name="series">The series<see cref="ChartSeries"/></param>
        internal void ConfigureSeries(ChartSeries series)
        {
            try
            {
                series.SmartLabels = true;
                series.SortPoints = true;
                series.Style.DisplayText = true;
                series.Style.TextOffset = 15.0F;
                series.Style.TextOrientation = ChartTextOrientation.Up;
                series.Style.DisplayShadow = true;
                series.Style.TextColor = Color.White;
                series.PointsToolTipFormat = "{0}-{1}";
                series.Style.Font.Size = 12.0F;
                series.Style.Font.Facename = "Segoe UI";
                series.Style.Font.FontStyle = FontStyle.Bold;
                if(Source == Source.FTE)
                {
                    series.Style.TextFormat = "{0}";
                }
                else
                {
                    series.Style.TextFormat = "${0:N2}";
                }

                if(SeriesType == ChartSeriesType.Column)
                {
                    series.SmartLabels = true;
                    series.SortPoints = true;
                    series.Style.DisplayText = true;
                    series.Style.TextOffset = 15.0F;
                    series.Style.TextOrientation = ChartTextOrientation.Up;
                    series.Style.DisplayShadow = true;
                    series.Style.TextColor = Color.White;
                    series.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    series.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    series.ConfigItems.ColumnItem.PhongAlpha = 2;
                    ConfigureToolTip(series);
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        /// <summary>
        /// The ConfigureSeries
        /// </summary>
        /// <param name="series">The series<see cref="ChartSeries"/></param>
        /// <param name="value">The value<see cref="Stat"/></param>
        internal void ConfigureSeries(ChartSeries series, Stat value)
        {
            try
            {
                switch(value)
                {
                    case Stat.Total:
                    case Stat.Average:
                        series.Style.TextFormat = "{0:C}";
                        break;
                    case Stat.Ratio:
                        series.Style.TextFormat = "{0:P}";
                        break;
                    case Stat.Count:
                        series.Style.TextFormat = "{0}";
                        break;
                }

                if(series.Type == ChartSeriesType.Area ||
                   series.Type == ChartSeriesType.Column)
                {
                    series.SmartLabels = true;
                    series.SortPoints = true;
                    series.Style.DisplayText = true;
                    series.Style.TextOffset = 20.0F;
                    series.Style.TextOrientation = ChartTextOrientation.Up;
                    series.Style.DisplayShadow = true;
                    series.Style.TextColor = Color.White;
                    series.Style.Font.Size = 11F;
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

        /// <summary>
        /// The ConfigureToolTip
        /// </summary>
        /// <param name="series">The series<see cref="ChartSeries"/></param>
        internal void ConfigureToolTip(ChartSeries series)
        {
            for(int i = 0; i < series.Points.Count; i++)
            {
                series.Styles[0].ToolTip = $"{series.Points[i].Category}";
            }
        }

        /// <summary>
        /// The ConfigurePrimaryAxisLabels
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        internal void ConfigurePrimaryAxisLabels(ChartControl chart)
        {
            try
            {
                Chart = chart;
                Chart.PrimaryXAxis.Font = new Font("SegoeUI", 10F, FontStyle.Bold);
                Chart.PrimaryXAxis.ForeColor = SystemColors.MenuHighlight;
                Chart.PrimaryXAxis.ValueType = ChartValueType.Category;
                if(Source != Source.FTE)
                {
                    Chart.PrimaryYAxis.Format = "C";
                }

                if(Source == Source.FTE)
                {
                    Chart.PrimaryYAxis.Format = "N";
                }

                if(Value == Stat.Ratio)
                {
                    Chart.PrimaryYAxis.Format = "P";
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        /// <summary>
        /// The Configure3DMode
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        internal void Configure3DMode(ChartControl chart)
        {
            try
            {
                Chart = chart;
                Chart.Style3D = true;
                Chart.ChartArea.Series3D = true;
                switch(SeriesType)
                {
                    case ChartSeriesType.Column:
                        Chart.Tilt = 1f;
                        Chart.Depth = 250;
                        Chart.Rotation = 10;
                        Chart.SpacingBetweenSeries = 1;
                        Chart.RealMode3D = true;
                        return;
                    case ChartSeriesType.Pie:
                        Chart.Tilt = -15f;
                        Chart.Depth = 250;
                        Chart.RealMode3D = false;
                        break;
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }

        /// <summary>
        /// The Configure3DMode
        /// </summary>
        /// <param name="dim">The dim<see cref="int[]"/></param>
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

        /// <summary>
        /// The ConfigurePrimaryAxisTitle
        /// </summary>
        /// <param name="title">The title<see cref="string[]"/></param>
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

        /// <summary>
        /// The GetDataBindingSource
        /// </summary>
        /// <param name="data">The data<see cref="Dictionary{string, double}"/></param>
        /// <param name="filter">The filter<see cref="Field"/></param>
        /// <returns>The <see cref="ChartDataBindModel"/></returns>
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
                model.YNames = new[] { filter.ToString() };
                return model;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetLegend
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
        /// <returns>The <see cref="ChartLegend"/></returns>
        internal ChartLegend GetLegend(ChartControl chart)
        {
            try
            {
                Chart.Legends?.Clear();

                ChartLegend legend = new ChartLegend(Chart);
                foreach(string axislabel in Chart.PrimaryXAxis.Labels)
                {
                    new ChartLegendItem(axislabel);
                }

                legend.VisibleCheckBox = true;
                Chart.Legends?.Add(legend);
                return legend;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The ConfigureLegend
        /// </summary>
        /// <param name="chart">The chart<see cref="ChartControl"/></param>
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

        /// <summary>
        /// The ConfigureMainTitle
        /// </summary>
        /// <param name="t">The t<see cref="string[]"/></param>
        internal void ConfigureMainTitle(string[] t)
        {
            try
            {
                Chart.Titles?.Clear();

                foreach(string s in t)
                {
                    ChartTitle title = new ChartTitle();
                    title.Text = s;
                    title.ForeColor = Color.LightSteelBlue;
                    title.Font = new Font("Tahoma", 9f, FontStyle.Regular);
                    Chart.Titles?.Add(title);
                }
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
            }
        }
    }
}
