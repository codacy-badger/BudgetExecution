using Syncfusion.Windows.Forms.Chart;
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
            public class BudgetChart : ChartControl 
            {

                //Constructors
                public BudgetChart()
                {
                }

                public BudgetChart(ChartControl chart, string title, Dictionary<string, double> data)
                {
                    ColumnChart = new ChartControl();
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

                public BudgetChart(string title, DivisionAuthority P8, BindingSource bs)
                {
                    var table = (DataTable)bs.DataSource;
                    int i = bs.Position;
                    var values = table.Rows[i];
                    var value = (decimal)values["Amount"];
                    string pp = values["ProgramProjectName"].ToString();
                    var data = P8.ProjectData;
                    Series.Clear();
                    Legends.Clear();
                    ColumnSeries = new ChartSeries("Allocation", ChartSeriesType.Column);
                    var series = new ChartSeries("Total", ChartSeriesType.Column);
                    foreach (string key in data.Keys)
                    {
                        if (key == pp)
                        {
                            ColumnSeries.Points.Add($"{values["BocName"].ToString()}", (double)value);
                            GetBindingSeriesConfiguration(ColumnSeries);
                            Series.Add(ColumnSeries);
                            decimal total = P8.Data.BudgetTable.AsEnumerable()
                                .Where(p => p.Field<string>("ProgramProjectName").Equals(pp))
                                .Select(p => p.Field<decimal>("Amount")).Sum();
                            PrimaryXAxis.Title = $"{ (value / total) * 100:N}% of { pp} Total Funding";
                            PrimaryXAxis.TitleColor = SystemColors.Info;
                            PrimaryXAxis.TitleFont = new Font("Segoe UI", 10f);
                            series.Points.Add("Total", (double)total);
                            GetBindingSeriesConfiguration(series);
                            Series.Add(series);
                        }
                    }
                    Get3DBindingMode();
                }

                public BudgetChart(string title, RegionalAuthority P7, BindingSource bs)
                {
                    int i = bs.Position;
                    var table = (DataTable)bs.DataSource;
                    var values = table.Rows[i];
                    var value = (decimal)values["Amount"];
                    string pp = values["ProgramProjectName"].ToString();
                    var data = new RegionalAuthority().ProjectData;
                    ColumnSeries = new ChartSeries("Allocation", ChartSeriesType.Column);
                    var series = new ChartSeries("Total", ChartSeriesType.Column);
                    foreach (string key in data.Keys)
                    {
                        if (key == pp)
                        {
                            ColumnSeries.Points.Add($"{values["BocName"].ToString()}", (double)value);
                            GetBindingSeriesConfiguration(ColumnSeries);
                            Series.Add(ColumnSeries);
                            decimal total = P7.Data.BudgetTable.AsEnumerable()
                                .Where(p => p.Field<string>("ProgramProjectName").Equals(pp))
                                .Select(p => p.Field<decimal>("Amount")).Sum();
                            PrimaryXAxis.Title = $"{ (value / total) * 100:N}% of {pp} Total Funding";
                            PrimaryXAxis.TitleColor = SystemColors.Info;
                            PrimaryXAxis.TitleFont = new Font("SegoeUI", 9f);
                            series.Points.Add("Total", (double)total);
                            GetBindingSeriesConfiguration(series);
                            Series.Add(series);
                        }
                        ColumnSeries.XAxis.Font = new Font("Segoe UI", 10F);
                    }
                    Get3DBindingMode();
                }

                public BudgetChart(ChartData data)
                {
                    ColumnSeries = data.Series;
                    foreach (KeyValuePair<string, double> kvp in data.InputTotals)
                    {
                        ColumnSeries.Points.Add(kvp.Key, kvp.Value);
                    }
                    GetRegionSeriesConfiguration(ColumnSeries);
                    ColumnChart.Series.Add(ColumnSeries);
                    ColumnChart.RealMode3D = true;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.Style3D = true;
                }

                
                //Properties
                public ChartControl ColumnChart { get; set; }
                public ChartSeries ColumnSeries { get; set; }
                public Dictionary<string, double> Data { get; set; }
                public bool Percentage { get; set; }
                public ChartControl PieChart { get; set; }
                public Dictionary<string, decimal> SeriesInfo { get; set; }
                public decimal Total { get; set; }

                
                //Methods

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


                private void Get3DMode(ChartData data)
                {
                    ChartArea.Series3D = true;
                    RealMode3D = true;
                    Style3D = true;
                    Tilt = data.Dimension[0];
                    Depth = data.Dimension[1];
                    Rotation = data.Dimension[2];
                    SpacingBetweenSeries = 2;
                }

                private void Get3DMode(int[] rt)
                {
                    ColumnChart.ChartArea.Series3D = true;
                    RealMode3D = true;
                    Style3D = true;
                    Tilt = rt[0];
                    Depth = 250;
                    Rotation = rt[1];
                    SpacingBetweenSeries = 10;
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
                }

                private void GetColumnSeriesData(string title, Dictionary<string, double> data)
                {
                    ColumnSeries = new ChartSeries("Series", ChartSeriesType.Column);
                    ColumnChart.Series.Add(ColumnSeries);
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
                    Legends.Add(legend);
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

                private void GetAxisTitles(string title)
                {
                    ColumnChart.PrimaryXAxis.Title = title;
                    ColumnChart.PrimaryXAxis.TitleColor = SystemColors.Info;
                    ColumnChart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9);
                }

            }
        }
    }
}