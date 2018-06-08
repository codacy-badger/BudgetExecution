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
                Chart.Series.Clear();
            ConfigurePrimaryAxisTitle(new string[] { title });
            DataSeries = GetSeriesTotals(data);
            DataSeries.Type = SeriesType;
            Chart.Series.Add(DataSeries);
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Configure3DMode(Chart);
        }

        public BudgetChart(ChartControl chart, DataBuilder data, PrcField filter)
        {
            SeriesType = ChartSeriesType.Column;
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = Stat.Total;
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataTotals = Metric.GetChartTotals(Table, filter);
            if (Chart.Series != null)
                Chart.Series.Clear();
            DataSeries = GetSeriesTotals(DataTotals);
            DataSeries.Type = SeriesType;
            ConfigureLargeNumberSeries(DataSeries);
            ConfigurePrimaryAxisLabels(Chart);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);

        }

        public BudgetChart(ChartControl chart, DataBuilder data, PrcField filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            if (Chart.Series != null)
                Chart.Series.Clear();
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            if (SeriesType == ChartSeriesType.Pie)
                ConfigurePieChart(Chart, DbData);
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, DataBuilder data, PrcField filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            DbData = data;
            Source = data.Source;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
                Chart.Series.Clear();
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            if (SeriesType == ChartSeriesType.Pie)
                ConfigurePieChart(Chart, DbData);
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, DataTable table, PrcField filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            Table = table;
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            if (Chart.Series != null)
                Chart.Series.Clear();
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value));
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
        }

        public BudgetChart(ChartControl chart, string[] title, Source source, PrcField filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Source = source;
            DbData = new DataBuilder(source, Provider.SQLite);
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
                Chart.Series.Clear();
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            if (SeriesType == ChartSeriesType.Pie)
                ConfigurePieChart(Chart, DbData);
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
            Chart.ShowToolTips = true;
        }

        public BudgetChart(ChartControl chart, string[] title, Source source, Dictionary<string, object> param, PrcField filter, Stat value, ChartSeriesType type)
        {
            Chart = chart;
            Source = source;
            DbData = new DataBuilder(source, Provider.SQLite, param);
            Value = value;
            SeriesType = type;
            ConfigurePrimaryAxisLabels(Chart);
            ConfigureMainTitle(title);
            if (Chart.Series != null)
                Chart.Series.Clear();
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            DataMetrics = Metric.GetChartMetrics(Table, filter);
            DataSeries = GetSeriesTotals(GetMeasure(DataMetrics, Value));
            DataSeries.Type = SeriesType;
            if (SeriesType == ChartSeriesType.Pie)
                ConfigurePieChart(Chart, DbData);
            ConfigureSeries(DataSeries, Value);
            Chart.Series.Add(DataSeries);
            Configure3DMode(Chart);
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

        public PrcField Filter { get; }

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

        private Dictionary<string, double> GetMeasure(Dictionary<string, double[]> data, Stat value)
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

        internal void ConfigurePieChart(ChartControl Chart, DataBuilder data)
        {
            try
            {
                Chart.Legend.Visible = true;
                Chart.Series[0].ExplodedAll = true;
                Chart.Series[0].ExplosionOffset = 20f;
                Chart.Series[0].ShowTicks = true;
                Chart.Series[0].Style.DisplayText = true;
                Chart.Series[0].PointsToolTipFormat = "Funding:{4:N2}";
                Chart.Series[0].ExplodedAll = true;
                Chart.Series[0].ExplosionOffset = 20f;
                var bm = new ChartDataBindModel(data.BindingSource);
                Chart.Series[0].SeriesIndexedModelImpl = bm;
                bm.YNames = new string[] { Value.ToString() };
                Chart.Series[0].SeriesModel = bm;
                Chart.Series[0].ConfigItems.PieItem.ShowDataBindLabels = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
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
                    DataSeries.Style.TextFormat = "{0}";
                else
                    DataSeries.Style.TextFormat = "${0:N2}";
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
                if (Source == Source.FTE)
                    DataSeries.Style.TextFormat = "{0}";
                else
                    DataSeries.Style.TextFormat = "${0:N2}";
                DataSeries.PointsToolTipFormat = "Funding:{4:N2}";
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
                if (Source == Source.FTE)
                    DataSeries.Style.TextFormat = "{0}";
                else if (value == Stat.Total || value == Stat.Average)
                    DataSeries.Style.TextFormat = "${0:N2}";
                if (value == Stat.Ratio)
                    DataSeries.Style.TextFormat = "{0:P}";
                if (value == Stat.Count)
                    DataSeries.Style.TextFormat = "{0}";
                DataSeries.Style.Font.Size = 10.0F;
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
                Chart.PrimaryXAxis.Font = new Font("SegoeUI", 9F, FontStyle.Bold);
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

        internal ChartDataBindModel GetDataBindingSource(Dictionary<string, double> data, PrcField filter)
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
                foreach (string s in t)
                {
                    ChartTitle title = new ChartTitle();
                    title.Text = s;
                    title.ForeColor = Color.LightSteelBlue;
                    title.Font = new Font("Tahoma", 9f, FontStyle.Regular);
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