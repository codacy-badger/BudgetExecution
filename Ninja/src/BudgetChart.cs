using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace BudgetExecution
{
    public class BudgetChart
    {
        //Constructors
        public BudgetChart()
        {
        }
        public BudgetChart(ChartControl chart, string title, Dictionary<string, double> data)
        {
            Chart = chart;
            Value = Stat.Total;
            SeriesType = ChartSeriesType.Column;
            if (Chart.Series != null)
                Chart.Series.Clear();
            ConfigurePrimaryAxisTitle(new string[] { title });
            DataSeries = GetSeriesTotals(data);
            DataSeries.Type = SeriesType;
            Chart.Series.Add(DataSeries);
            ConfigureLargeNumberSeries(DataSeries);
            Configure3DMode(Chart);
        }
        public BudgetChart(ChartControl chart, DataBuilder data, PrcField filter)
        {
            SeriesType = ChartSeriesType.Column;
            Chart = chart;
            Data = data;
            Value = Stat.Total;
            Table = Data.QueryTable;
            Metric = new PrcMetric(Data);
            DataTotals = Metric.GetChartTotals(Table, filter);
            if (Chart.Series != null)
                Chart.Series.Clear();
            DataSeries = GetSeriesTotals(DataTotals);
            DataSeries.Type = SeriesType;
            ConfigureLargeNumberSeries(DataSeries);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);

        }
        public BudgetChart(ChartControl chart, DataBuilder data, PrcField filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Data = data;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            if (Chart.Series != null)
                Chart.Series.Clear();
            Table = Data.QueryTable;
            Metric = new PrcMetric(Data);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetSingleValue(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
            if (SeriesType == ChartSeriesType.Pie)
            {
                Chart.Legend.Visible = true;
                Chart.Series[0].ExplodedAll = true;
                Chart.Series[0].ExplosionOffset = 20f;
            }
        }
        public BudgetChart(ChartControl chart, PrcMetric metric, PrcField field, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            Metric = metric;
            Table = Metric.Table;
            ConfigurePrimaryAxisLabels(Chart);
            DataMetrics = Metric.GetChartMetrics(Table, field);
            if (Chart.Series != null)
                Chart.Series.Clear();
            DataSeries = GetSeriesTotals(GetSingleValue(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            ConfigureToolTip(DataSeries);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
            if (SeriesType == ChartSeriesType.Pie)
            {
                Chart.Legend.Visible = true;
                Chart.Series[0].ExplodedAll = true;
                Chart.Series[0].ExplosionOffset = 20f;
            }
        }
        public BudgetChart(ChartControl chart, DataTable table, PrcField prcfilter, Stat value)
        {
            Chart = chart;
            Value = value;
            SeriesType = ChartSeriesType.Column;
            ConfigurePrimaryAxisLabels(Chart);
            Table = table;
            DataMetrics = Metric.GetChartMetrics(Table, prcfilter);
            if (Chart.Series != null)
                Chart.Series.Clear();
            DataSeries = GetSeriesTotals(GetSingleValue(DataMetrics, Value));
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
        }              
        public BudgetChart(ChartControl chart, Source source, PrcField filter)
        {
            Chart = chart;
            SeriesType = ChartSeriesType.Column;
            Data = new DataBuilder(source);
            Metric = new PrcMetric(Data);
            Table = Data.QueryTable;
            Value = Stat.Total;
            if (Chart.Series != null)
                Chart.Series.Clear();
            DataSeries = GetSeriesTotals(GetSingleValue(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            Chart.Series.Add(DataSeries);
            ConfigureSeries(DataSeries, Value);
            Configure3DMode(Chart);
        }

        //Properties
        public string[] AxisTitle { get; set; }
        public BindingSource BindingSource { get; set; }
        public ChartControl Chart { get; set; }
        public DataBuilder Data { get; }
        public Dictionary<string, double[]> DataMetrics { get; set; }
        public ChartSeries DataSeries { get; set; }
        public Dictionary<string, double> DataTotals { get; set; }
        public int[] Dimension { get; set; }
        public PrcField Filter { get; }
        public Dictionary<string, double[]> InputMetrics { get; set; }
        public Dictionary<string, double> InputTotals { get; set; }
        public ChartLegend Legend { get; set; }
        public string[] MainTitle { get; set; }
        public PrcMetric Metric { get; }
        public ChartDataBindModel Model { get; set; }
        public ChartSeriesType SeriesType { get; set; }
        public DataTable Table { get; set; }
        public Stat Value { get; set; }
        private double Total { get; }

        //Methods
        internal ChartControl Activate()
        {
            return Chart;
        }
        private ChartSeries GetAccountSeries(KeyValuePair<string, double[]> data)
        {
            try
            {
                var series = new ChartSeries("Accounts", SeriesType);
                series.Points.Add(data.Key, data.Value[1]);
                series.Style.TextFormat = "{0:N}";
                return series;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        private ChartSeries GetAverageSeries(KeyValuePair<string, double[]> data)
        {
            try
            {
                var series = new ChartSeries("Average", SeriesType);
                series.Points.Add(data.Key, data.Value[2]);
                return series;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        private ChartSeries GetRatioSeries(KeyValuePair<string, double[]> data)
        {
            try
            {
                var series = new ChartSeries("Ratio", SeriesType);
                series.Points.Add(data.Key, data.Value[3]);
                ConfigureSeries(series);
                series.Style.TextFormat = "{0:P}";
                return series;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        internal ChartSeries GetSeriesTotals(Dictionary<string, double> data)
        {
            try
            {
                var series = new ChartSeries("Total", SeriesType);
                foreach (KeyValuePair<string, double> kvp in data)
                {
                    series.Points.Add(kvp.Key, kvp.Value);
                }
                return series;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        private Dictionary<string, double> GetSingleValue(Dictionary<string, double[]> data, Stat value)
        {
            try
            {
                var total = new Dictionary<string, double>();
                foreach (KeyValuePair<string, double[]> kvp in data)
                {
                    total.Add(kvp.Key, kvp.Value[(int)value]);
                }
                return total;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        private ChartSeries GetTotalSeries(KeyValuePair<string, double[]> data)
        {
            try
            {
                var series = new ChartSeries("Totals", SeriesType);
                series.Points.Add(data.Key, data.Value[0]);
                series.Style.TextFormat = "${0:#,}";
                return series;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
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
                DataSeries.Style.TextFormat = "${0:#,}";
                DataSeries.PointsToolTipFormat = "Funding:{4:N}";
                DataSeries.Style.Font.Size = 12.0F;
                DataSeries.Style.Font.Facename = "SegoeUI";
                DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                if (SeriesType == ChartSeriesType.Column)
                {
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
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
                DataSeries.Style.TextFormat = "${0:#,}";
                DataSeries.PointsToolTipFormat = "Funding:{4:N}";
                DataSeries.Style.Font.Size = 12.0F;
                DataSeries.Style.Font.Facename = "Segoe UI";
                DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                if (SeriesType == ChartSeriesType.Column)
                {
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
                if(SeriesType == ChartSeriesType.Pie)
                {
                    DataSeries.ConfigItems.PieItem.ShowDataBindLabels = true;
                    
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        internal void ConfigureSeries(ChartSeries series, Stat value)
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
                if (value == Stat.Total || value == Stat.Average)
                    DataSeries.Style.TextFormat = "${0:#,}";
                if (value == Stat.Ratio)
                    DataSeries.Style.TextFormat = "{0:P}";
                if (value == Stat.Count)
                    DataSeries.Style.TextFormat = "{0}";
                DataSeries.Style.Font.Size = 12.0F;
                DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                DataSeries.Style.Font.Facename = "SegoeUI";
                DataSeries.ShowTicks = true;
                if (SeriesType == ChartSeriesType.Column)
                {
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.SteelBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void ConfigureToolTip(ChartSeries series)
        {
            DataSeries = series;
            for(int i = 0; i < DataSeries.Points.Count; i++)
            {
                DataSeries.Styles[i].ToolTip = string.Format("{0}", DataSeries.Points[0].ToString());
            }
        }
        private void ConfigurePrimaryAxisLabels(ChartControl chart)
        {
            try
            {
                Chart = chart;
                Chart.PrimaryXAxis.Font = new Font("SegoeUI", 8F, FontStyle.Bold);
                Chart.PrimaryXAxis.ForeColor = SystemColors.MenuHighlight;
                
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        private void Configure3DMode(ChartControl chart)
        {
            try
            {
                if (SeriesType == ChartSeriesType.Column)
                {
                    Chart = chart;
                    Chart.ChartArea.Series3D = true;
                    Chart.RealMode3D = true;
                    Chart.Style3D = true;
                    Chart.Tilt = 0.0f;
                    Chart.Depth = 250;
                    Chart.Rotation = 20;
                    Chart.SpacingBetweenSeries = 2;
                }
                if (SeriesType == ChartSeriesType.Pie)
                {
                    Chart = chart;
                    Chart.ChartArea.Series3D = true;
                    Chart.RealMode3D = true;
                    Chart.Style3D = true;
                    Chart.Tilt = -15f;
                    Chart.Depth = 250;
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
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
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
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
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
        internal ChartDataBindModel GetDataBinding(Dictionary<string, double> data, PrcField filter)
        {
            try
            {
                var chartdata = new SortedList<string, double>();
                foreach (KeyValuePair<string, double> kvp in data)
                {
                    chartdata.Add(kvp.Key, kvp.Value);
                }
                var model = new ChartDataBindModel(chartdata);
                model.YNames = new string[] { filter.ToString() };
                return model;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        internal ChartLegend GetLegend(ChartControl chart)
        {
            try
            {
                if (Chart.Legends != null)
                    Chart.Legends.Clear();
                var legend = new ChartLegend(Chart);
                foreach (string axislabel in Chart.PrimaryXAxis.Labels)
                {
                    var item = new ChartLegendItem(axislabel);
                }
                legend.VisibleCheckBox = true;
                Chart.Legends.Add(legend);
                return legend;
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
            }
        }
        internal void ConfigureMainTitle(string[] t)
        {
            try
            {
                if(Chart.Titles != null)
                    Chart.Titles.Clear();
                for (int i = 0; i < t.Length; i++)
                {
                    ChartTitle title = new ChartTitle();
                    title.Text = t[i];
                    title.ForeColor = Color.LightSteelBlue;
                    title.Font = new Font("SegoeUI", 9f, FontStyle.Regular);
                    Chart.Titles.Add(title);
                }
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message + e.StackTrace);
            }
        }
    }
        
}