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
                    ColumnChart = chart;
                    ColumnChart.Series.Clear();
                    ColumnChart.PrimaryXAxis.Title = title;
                    ColumnChart.PrimaryXAxis.TitleColor = SystemColors.GradientInactiveCaption;
                    ColumnChart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9f);
                    ColumnSeries = new ChartSeries("Series", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        ColumnSeries.Points.Add(kvp.Key, kvp.Value);
                    }
                    ColumnChart.Series.Add(ColumnSeries);
                    GetRegionSeriesConfiguration(ColumnSeries);
                    ColumnSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    Get3DMode();                    
                }


                public BudgetChart(ChartControl chart, DataBuilder data, ChartFilter filter)
                {
                    ColumnChart = chart;
                    Data = data;
                    Metric = new DataMetric(Data);
                    DataTotals = Metric.GetChartTotals(Data.BudgetTable, filter.ToString());
                    ColumnSeries = GetSeriesTotalData(DataTotals);
                    GetRegionSeriesConfiguration(ColumnSeries);
                    ColumnChart.Series.Add(ColumnSeries);
                    ColumnChart.RealMode3D = true;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.Style3D = true;
                   
                }


                public BudgetChart(ChartControl chart, Source source, ChartFilter filter)
                {
                    ColumnChart = chart;
                    Data = new DataBuilder(source);
                    Metric = new DataMetric(Data);
                    DataTotals = Metric.GetChartTotals(Data.BudgetTable, filter.ToString());
                    ColumnSeries = GetSeriesTotalData(DataTotals);
                    GetRegionSeriesConfiguration(ColumnSeries);
                    ColumnChart.Series.Add(ColumnSeries);
                    ColumnChart.RealMode3D = true;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.Style3D = true;
                }
                
                //Properties
                public DataBuilder Data { get; }
                public DataMetric Metric { get; }
                public Dictionary<string, double> InputTotals { get; set; }
                public Dictionary<string, double[]> InputMetrics { get; set; }
                public BindingSource BindingSource { get; set; }
                public ChartDataBindModel Model { get; }
                public int[] Dimension { get; set; }
                public ChartControl Chart { get; set; }
                public ChartSeries Series { get; set; }
                public string[] MainTitle { get; set; }
                public string[] AxisTitle { get; set; }
                public ChartFilter Filter { get; set; }
                public ChartSeriesType SeriesType { get; set; }
                public ChartControl ColumnChart { get; set; }
                public ChartSeries ColumnSeries { get; set; }
                public Dictionary<string, double> DataTotals { get; set; }
                public bool Percentage { get; set; }
                public ChartControl PieChart { get; set; }
                public ChartSeries PieSeries { get; set; }
                public Dictionary<string, decimal> SeriesInfo { get; set; }
                public decimal Total { get; set; }


                //Methods
                internal ChartSeries GetSeriesTotalData(Dictionary<string, double> data)
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
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesTotalsData(Dictionary<string, double[]> data)
                {
                    try
                    {
                        var series = new ChartSeries();
                        foreach (KeyValuePair<string, double[]> kvp in data)
                        {
                            series.Points.Add(kvp.Key, kvp.Value[0]);
                            series.Name = "Total";
                        }
                        return series;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesCountData(Dictionary<string, double[]> data)
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
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesAverageData(Dictionary<string, double[]> data)
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
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal ChartSeries GetSeriesRatioData(Dictionary<string, double[]> data)
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
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }

                internal int[] GetDimensions(params int[] a)
                {
                    return new int[] { 2, 250, -10 };
                }

                internal ChartControl Activate()
                {
                    return ColumnChart;
                }
   
                private void Get3DBindingMode()
                {
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = 2;
                    ColumnChart.Depth = 150;
                    ColumnChart.Rotation = 5;
                    ColumnChart.SpacingBetweenSeries = 2;
                }

                private void Get3DMode()
                {
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = 2;
                    ColumnChart.Depth = 250;
                    ColumnChart.Rotation = -10;
                    ColumnChart.SpacingBetweenSeries = 2;
                }

                internal void GetPrimaryXaxis(ChartData data)
                {
                    ChartControl ColumnChart = data.Chart;
                    ColumnChart.PrimaryXAxis.Title = data.AxisTitle[0];
                    ColumnChart.PrimaryXAxis.TitleColor = SystemColors.GradientInactiveCaption;
                    ColumnChart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9f);
                    ColumnChart.Series[0].XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }

                private void Get3DMode(ChartData data)
                {
                    ColumnChart = data.Chart;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = data.Dimension[0];
                    ColumnChart.Depth = data.Dimension[1];
                    ColumnChart.Rotation = data.Dimension[2];
                    ColumnChart.SpacingBetweenSeries = 2;
                }

                private void Get3DMode(int[] rt)
                {
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = rt[0];
                    ColumnChart.Depth = 250;
                    ColumnChart.Rotation = rt[1];
                    ColumnChart.SpacingBetweenSeries = 10;
                }

                private void GetBindingSeriesConfiguration(ChartSeries series)
                {
                    ColumnSeries = series;
                    ColumnSeries.SmartLabels = true;
                    ColumnSeries.SortPoints = true;
                    ColumnSeries.Style.DisplayText = true;
                    ColumnSeries.Style.TextOffset = 15.0F;
                    ColumnSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    ColumnSeries.Style.DisplayShadow = true;
                    ColumnSeries.Style.TextColor = Color.White;
                    ColumnSeries.Style.TextFormat = "${0:N}";
                    ColumnSeries.PointsToolTipFormat = "Funding:{4}";
                    ColumnSeries.Style.Font.Size = 10.0F;
                    ColumnSeries.Style.Font.Facename = "Segoe UI";
                    ColumnSeries.Style.Font.FontStyle = FontStyle.Bold;
                    ColumnSeries.DrawSeriesNameInDepth = false;
                    ColumnSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    ColumnSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                    ColumnSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }

                private void GetRegionSeriesConfiguration(ChartSeries series)
                {
                    ColumnSeries = series;
                    ColumnSeries.SmartLabels = true;
                    ColumnSeries.SortPoints = true;
                    ColumnSeries.Style.DisplayText = true;
                    ColumnSeries.Style.TextOffset = 15.0F;
                    ColumnSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    ColumnSeries.Style.DisplayShadow = true;
                    ColumnSeries.Style.TextColor = Color.White;
                    ColumnSeries.Style.TextFormat = "${0:#,}";
                    ColumnSeries.PointsToolTipFormat = "Funding:{4:N}";
                    ColumnSeries.Style.Font.Size = 10.0F;
                    ColumnSeries.Style.Font.Facename = "SegoeUI";
                    ColumnSeries.Style.Font.FontStyle = FontStyle.Bold;
                    ColumnSeries.DrawSeriesNameInDepth = false;
                    ColumnSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    ColumnSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                    ColumnSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                }

                private void GetDivisionSeriesConfiguration(ChartSeries series)
                {
                    ColumnSeries = series;
                    ColumnSeries.SmartLabels = true;
                    ColumnSeries.SortPoints = true;
                    ColumnSeries.Style.DisplayText = true;
                    ColumnSeries.Style.TextOffset = 15.0F;
                    ColumnSeries.Style.TextOrientation = ChartTextOrientation.Up;
                    ColumnSeries.Style.DisplayShadow = true;
                    ColumnSeries.Style.TextColor = Color.White;
                    ColumnSeries.Style.TextFormat = "${0:N}";
                    ColumnSeries.PointsToolTipFormat = "Funding:{4:N}";
                    ColumnSeries.Style.Font.Size = 10.0F;
                    ColumnSeries.Style.Font.Facename = "Segoe UI";
                    ColumnSeries.Style.Font.FontStyle = FontStyle.Bold;
                    ColumnSeries.DrawSeriesNameInDepth = false;
                    ColumnSeries.ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                    ColumnSeries.ConfigItems.ColumnItem.LightColor = Color.DeepSkyBlue;
                    ColumnSeries.ConfigItems.ColumnItem.PhongAlpha = 2;
                    ColumnSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                }

                private void GetColumnSeriesData(string title, Dictionary<string, double> data)
                {
                    ColumnSeries = new ChartSeries("Amount", ChartSeriesType.Column);
                    ColumnChart.Series.Add(ColumnSeries);
                    ColumnSeries.XAxis.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    foreach (KeyValuePair<string, double> kvp in data)
                    {
                        ColumnSeries.Points.Add(kvp.Key, kvp.Value);
                    }
                }

                private void GetLegend(ChartSeries series)
                {
                    ChartLegendItemsCollection items = new ChartLegendItemsCollection();
                    ChartLegend legend = new ChartLegend(ColumnChart);
                    ChartLegendItem item = new ChartLegendItem();
                    item.Text = series.Name;
                    legend.Text = "Legend";
                    items.Add(item);
                    legend.VisibleCheckBox = true;
                    legend.ColumnsCount = 1;
                    ColumnChart.Legends.Add(legend);
                }

                private void GetMainTitle(string t)
                {
                    ColumnChart.Titles.Clear();
                    ChartTitle title = new ChartTitle();
                    title.Text = t;
                    title.ForeColor = Color.White;
                    title.Font = new Font("SegoeUI", 8, FontStyle.Regular);
                    ColumnChart.Titles.Add(title);
                }
            }
        }
    }
}