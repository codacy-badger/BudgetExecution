using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
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
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    GetAxisTitle(Chart, new string[] { title });
                    DataSeries = GetSeriesTotals(data);
                    Chart.Series.Add(DataSeries);
                    GetRegionSeriesConfiguration(DataSeries);
                    Get3DMode(Chart);
                }

                public BudgetChart(ChartControl chart, DataBuilder data, PrcFilter filter, Stat value)
                {
                    Chart = chart;
                    Data = data;
                    Table = Data.QueryTable;
                    Metric = new DataMetric(Data);
                    Value = value;
                    DataMetrics = Metric.GetChartMetrics(Table, filter);
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    DataSeries = GetSeriesTotals(GetSingleValue(DataMetrics, Value));
                    Chart.Series.Add(DataSeries);
                    GetSeriesConfiguration(DataSeries, Value);
                    Get3DMode(Chart);
                }

                public BudgetChart(ChartControl chart, Source source, PrcFilter filter)
                {
                    Chart = chart;
                    Data = new DataBuilder(source);
                    Metric = new DataMetric(Data);
                    Table = Data.QueryTable;
                    Value = Stat.Total;
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    DataSeries = GetSeriesTotals(GetSingleValue(DataMetrics, Value));
                    Chart.Series.Add(DataSeries);
                    GetSeriesConfiguration(DataSeries, Value);
                    Get3DMode(Chart);
                }

                public string[] AxisTitle { get; set; }

                public BindingSource BindingSource { get; set; }

                //Properties
                public ChartControl Chart { get; }

                public DataBuilder Data { get; }
                public Dictionary<string, double[]> DataMetrics { get; set; }
                public ChartSeries DataSeries { get; set; }
                public Dictionary<string, double> DataTotals { get; set; }
                public int[] Dimension { get; set; }
                public PrcFilter Filter { get; }
                public Dictionary<string, double[]> InputMetrics { get; set; }
                public Dictionary<string, double> InputTotals { get; set; }
                public ChartLegend Legend { get; set; }
                public string[] MainTitle { get; set; }
                public DataMetric Metric { get; }
                public ChartDataBindModel Model { get; set; }
                public ChartSeriesType SeriesType { get; set; }
                public DataTable Table { get; set; }
                public Stat Value { get; set; }
                private double Total { get; }

                internal ChartControl Activate()
                {
                    return Chart;
                }

                internal void Get3DMode(int[] dim)
                {
                    try
                    {
                        Chart.ChartArea.Series3D = true;
                        Chart.RealMode3D = true;
                        Chart.Style3D = true;
                        Chart.Tilt = dim[0];
                        Chart.Depth = dim[1];
                        Chart.Rotation = dim[2];
                        Chart.SpacingBetweenSeries = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetAxisTitle(ChartControl chart, string[] title)
                {
                    try
                    {
                        Chart.PrimaryXAxis.Title = title[0];
                        Chart.PrimaryXAxis.TitleColor = Color.LightSteelBlue;
                        Chart.PrimaryXAxis.TitleFont = new Font("Segoe UI", 9f, FontStyle.Bold);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal ChartDataBindModel GetDataBinding(Dictionary<string, double> data, PrcFilter filter)
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

                internal int[] GetDimensions(params int[] a)
                {
                    return new int[] { 2, 250, -10 };
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

                internal void GetMainTitle(ChartControl chart, string[] t)
                {
                    try
                    {
                        Chart.Titles.Clear();
                        ChartTitle title = new ChartTitle();
                        title.Text = t[0];
                        title.ForeColor = Color.BlanchedAlmond;
                        title.Font = new Font("SegoeUI", 10, FontStyle.Regular);
                        Chart.Titles.Add(title);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetRegionSeriesConfiguration(ChartSeries series)
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
                        DataSeries.DrawSeriesNameInDepth = false;
                        DataSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                        DataSeries.XAxis.LabelRotate = true;
                        DataSeries.XAxis.ForeColor = SystemColors.MenuHighlight;
                        DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        DataSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                        DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetSeriesConfiguration(ChartSeries series)
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
                        DataSeries.PointsToolTipFormat = "Funding:{4:N}";
                        DataSeries.Style.Font.Size = 12.0F;
                        DataSeries.Style.Font.Facename = "Segoe UI";
                        DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                        DataSeries.DrawSeriesNameInDepth = false;
                        DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        DataSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                        DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetSeriesConfiguration(ChartSeries series, Stat value)
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
                        if (value == Ninja.Data.Stat.Total || value == Ninja.Data.Stat.Average)
                            DataSeries.Style.TextFormat = "${0:N}";
                        if (value == Ninja.Data.Stat.Ratio)
                            DataSeries.Style.TextFormat = "{0:P}";
                        if (value == Ninja.Data.Stat.Count)
                            DataSeries.Style.TextFormat = "{0}";
                        DataSeries.PointsToolTipFormat = "Funding:{4:N}";
                        DataSeries.Style.Font.Size = 12.0F;
                        DataSeries.Style.Font.Facename = "Segoe UI";
                        DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                        DataSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                        DataSeries.XAxis.LabelRotate = true;
                        DataSeries.XAxis.ForeColor = SystemColors.MenuHighlight;
                        DataSeries.DrawSeriesNameInDepth = false;
                        DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        DataSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                        DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                //Methods
                internal ChartSeries GetSeriesTotals(Dictionary<string, double> data)
                {
                    try
                    {
                        var series = new ChartSeries("Total");
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

                private void Get3DMode(ChartControl chart)
                {
                    try
                    {
                        Chart.ChartArea.Series3D = true;
                        Chart.RealMode3D = true;
                        Chart.Style3D = true;
                        Chart.Tilt = 2;
                        Chart.Depth = 250;
                        Chart.Rotation = -10;
                        Chart.SpacingBetweenSeries = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                private ChartSeries GetAccountSeries(KeyValuePair<string, double[]> data)
                {
                    try
                    {
                        var series = new ChartSeries("Accounts");
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
                        var series = new ChartSeries("Average");
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
                        var series = new ChartSeries("Ratio");
                        series.Points.Add(data.Key, data.Value[3]);
                        GetSeriesConfiguration(series);
                        series.Style.TextFormat = "{0:P}";
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
                        var series = new ChartSeries("Totals");
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
            }
        }
    }
}