using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    Chart.PrimaryXAxis.Title = title;
                    Chart.PrimaryXAxis.TitleColor = SystemColors.GradientInactiveCaption;
                    Chart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9f);
                    DataSeries = new ChartSeries("Series", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        DataSeries.Points.Add(kvp.Key, kvp.Value);
                    }
                    Chart.Series.Add(DataSeries);
                    GetRegionSeriesConfiguration(DataSeries);
                    DataSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    Get3DMode(chart);
                }

                public BudgetChart(ChartControl chart, DataBuilder data, ChartFilter filter)
                {
                    Chart = chart;
                    Data = data;
                    Table = Data.BudgetTable;
                    Metric = new DataMetric(Data);
                    DataTotals = Metric.GetChartTotals(Table, filter.ToString());
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    DataSeries = GetSeriesTotals(DataTotals);
                    GetRegionSeriesConfiguration(DataSeries);
                    Chart.Series.Add(DataSeries);
                    Chart.RealMode3D = true;
                    Chart.ChartArea.Series3D = true;
                    Chart.Style3D = true;

                }

                public BudgetChart(ChartControl chart, DataBuilder data, ChartFilter filter, ChartSeriesType type)
                {
                    Chart = chart;
                    Filter = filter;
                    SeriesType = type;
                    Data = data;
                    Table = Data.BudgetTable;
                    Metric = new DataMetric(Data);
                    DataTotals = Metric.GetChartTotals(Table, filter.ToString());
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    DataSeries = GetSeriesTotals(DataTotals);
                    GetRegionSeriesConfiguration(DataSeries);
                    Chart.Series.Add(DataSeries);
                    Chart.RealMode3D = true;
                    Chart.ChartArea.Series3D = true;
                    Chart.Style3D = true;
                }

                public BudgetChart(ChartControl chart, Source source, PrcFilter filter)
                {
                    Chart = chart;
                    Data = new DataBuilder(source);
                    Metric = new DataMetric(Data);
                    Table = Data.BudgetTable;
                    DataTotals = Metric.GetChartTotals(Table, filter.ToString());
                    if (Chart.Series != null)
                        Chart.Series.Clear();
                    DataSeries = GetSeriesTotals(DataTotals);
                    GetRegionSeriesConfiguration(DataSeries);
                    Chart.Series.Add(DataSeries);
                    Chart.RealMode3D = true;
                    Chart.ChartArea.Series3D = true;
                    Chart.Style3D = true;
                }

                //Properties
                public ChartControl Chart { get; set; }
                public DataBuilder Data { get; set; }
                public DataMetric Metric { get; set; }
                public DataTable Table { get; set; }
                public Dictionary<string, double> InputTotals { get; set; }
                public Dictionary<string, double[]> InputMetrics { get; set; }
                public BindingSource BindingSource { get; set; }
                public ChartDataBindModel Model { get; set; }
                public int[] Dimension { get; set; }
                public string[] MainTitle { get; set; }
                public string[] AxisTitle { get; set; }
                public ChartFilter Filter { get; set; }
                public ChartSeriesType SeriesType { get; set; }
                public ChartSeries DataSeries { get; set; }
                public Dictionary<string, double> DataTotals { get; set; }
                public Dictionary<string, double[]> DataMetrics { get; set; }
                double Total { get; set; }

                //Methods
                internal ChartSeries GetSeriesTotals(Dictionary<string, double> data)
                {
                    try
                    {
                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value);
                            series.Name = kvp.Key;
                        }
                        return series;
                    }
                    catch (System.Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesMetrics(Dictionary<string, double[]> data)
                {
                    try
                    {
                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double[]> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value);
                            series.Name = "Total";
                        }
                        return series;
                    }
                    catch (System.Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesValue(Dictionary<string, double[]> data, Metric value)
                {
                    try
                    {
                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double[]> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value[(int)value]);
                            series.Name = "Total";
                        }
                        return series;
                    }
                    catch (System.Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesCount(Dictionary<string, double[]> data)
                {
                    try
                    {
                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double[]> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value[1]);
                            series.Name = "Count";
                        }
                        return series;
                    }
                    catch (System.Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesAverage(Dictionary<string, double[]> data)
                {
                    try
                    {
                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double[]> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value[2]);
                            series.Name = "Average";
                        }
                        return series;
                    }
                    catch (System.Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesRatio(Dictionary<string, double[]> data)
                {
                    try
                    {

                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double[]> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value[3]);
                            series.Name = "Percentage";
                        }
                        return series;
                    }
                    catch (System.Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetColumnSeries(Dictionary<string, double> data)
                {
                    try
                    {
                        var series = new ChartSeries("Amount", ChartSeriesType.Column);
                        Chart.Series.Add(series);
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

                internal ChartControl Activate()
                {
                    return Chart;
                }

                void Get3DBindingMode()
                {
                    try
                    {
                        Chart.ChartArea.Series3D = true;
                        Chart.RealMode3D = true;
                        Chart.Style3D = true;
                        Chart.Tilt = 2;
                        Chart.Depth = 150;
                        Chart.Rotation = 5;
                        Chart.SpacingBetweenSeries = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                void Get3DMode(ChartControl chart)
                {
                    try
                    {
                        Chart = chart;
                        Chart.ChartArea.Series3D = true;
                        Chart.RealMode3D = true;
                        Chart.Style3D = true;
                        Chart.Tilt = 2;
                        Chart.Depth = 250;
                        Chart.Rotation = -5;
                        Chart.SpacingBetweenSeries = 2;
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetPrimaryXaxis(string[] title)
                {
                    try
                    {
                        Chart.PrimaryXAxis.Title = title[0];
                        Chart.PrimaryXAxis.TitleColor = SystemColors.GradientInactiveCaption;
                        Chart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9f);
                        Chart.Series[0].XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
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

                internal void GetBindingSeriesConfiguration(ChartSeries series)
                {
                    DataSeries = series;
                    DataSeries.SmartLabels = true;
                    DataSeries.SortPoints = true;
                    DataSeries.Style.DisplayText = true;
                    DataSeries.Style.TextOffset = 15.0F;
                    DataSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    DataSeries.Style.DisplayShadow = true;
                    DataSeries.Style.TextColor = Color.White;
                    DataSeries.Style.TextFormat = "${0:N}";
                    DataSeries.PointsToolTipFormat = "Funding:{4}";
                    DataSeries.Style.Font.Size = 10.0F;
                    DataSeries.Style.Font.Facename = "Segoe UI";
                    DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                    DataSeries.DrawSeriesNameInDepth = false;
                    DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    DataSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                    DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }

                internal void GetRegionSeriesConfiguration(ChartSeries series)
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
                        DataSeries.Style.Font.Size = 10.0F;
                        DataSeries.Style.Font.Facename = "SegoeUI";
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

                internal void GetDivisionSeriesConfiguration(ChartSeries series)
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
                        DataSeries.Style.TextFormat = "${0:N}";
                        DataSeries.PointsToolTipFormat = "Funding:{4:N}";
                        DataSeries.Style.Font.Size = 10.0F;
                        DataSeries.Style.Font.Facename = "Segoe UI";
                        DataSeries.Style.Font.FontStyle = FontStyle.Bold;
                        DataSeries.DrawSeriesNameInDepth = false;
                        DataSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        DataSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                        DataSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                        DataSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetLegend(ChartSeries series)
                {
                    try
                    {
                        ChartLegendItemsCollection items = new ChartLegendItemsCollection();
                        ChartLegend legend = new ChartLegend(Chart);
                        ChartLegendItem item = new ChartLegendItem();
                        item.Text = series.Name;
                        legend.Text = "Legend";
                        items.Add(item);
                        legend.VisibleCheckBox = true;
                        legend.ColumnsCount = 1;
                        Chart.Legends.Add(legend);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }

                internal void GetMainTitle(string[] t)
                {
                    try
                    {
                        Chart.Titles.Clear();
                        ChartTitle title = new ChartTitle();
                        title.Text = t[0];
                        title.ForeColor = Color.White;
                        title.Font = new Font("SegoeUI", 8, FontStyle.Regular);
                        Chart.Titles.Add(title);
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.Message + e.StackTrace);
                    }
                }
            }
        }
    }
}