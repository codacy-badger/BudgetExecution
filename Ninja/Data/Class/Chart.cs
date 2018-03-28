#region Using Directives

using Syncfusion.Windows.Forms.Chart;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Chart
            {
                #region Properties

                public ChartControl ColumnChart { get; set; }
                public ChartControl PieChart { get; set; }
                public ChartSeries ColumnSeries { get; set; }
                public decimal Total { get; set; }
                public Dictionary<string, decimal> SeriesInfo { get; set; }
                public Dictionary<string, double> Data { get; set; }
                public bool Percentage { get; set; }
                public Metric Metric { get; }

                #endregion

                #region Constructors

                public Chart( )
                {
                }

                public Chart(ChartControl chart, string title, Dictionary<string, decimal> data)
                {
                    ColumnChart = chart;
                    ColumnChart.Series.Clear( );
                    ColumnChart.Legends.Clear( );
                    ColumnChart.PrimaryXAxis.Title = title;
                    ColumnChart.PrimaryXAxis.TitleColor = SystemColors.GradientInactiveCaption;
                    ColumnChart.PrimaryXAxis.TitleFont = new Font("Segoe UI", 10f);
                    ColumnSeries = new ChartSeries("Series", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, decimal> kvp in data)
                    {
                        ColumnSeries.Points.Add(kvp.Key, (double)kvp.Value);
                    }
                    GetSeriesConfiguration(ColumnSeries);
                    ColumnChart.Series.Add(ColumnSeries);
                    ColumnSeries.XAxis.Font = new Font("Segoe UI", 9F);
                    Get3DMode(ColumnChart);
                }

                public Chart(ChartControl chart, string title, DivisionAuthority P8, BindingSource bs)
                {
                    var table = (DataTable)bs.DataSource;
                    int i = bs.Position;
                    var values = table.Rows[i];
                    var value = (decimal)values["Amount"];
                    string pp = values["ProgramProjectName"].ToString( );
                    var data = P8.ProjectData;
                    ColumnChart = chart;
                    ColumnChart.Series.Clear( );
                    ColumnChart.Legends.Clear( );
                    ColumnSeries = new ChartSeries("Allocation", ChartSeriesType.Column);
                    var series = new ChartSeries("Total", ChartSeriesType.Column);
                    foreach (string key in data.Keys)
                    {
                        if (key == pp)
                        {
                            ColumnSeries.Points.Add($"{values["BocName"].ToString( )}", (double)value);
                            GetBindingSeriesConfiguration(ColumnSeries);
                            ColumnChart.Series.Add(ColumnSeries);
                            decimal total = P8.Data.Table.AsEnumerable( )
                                .Where(p => p.Field<string>("ProgramProjectName").Equals(pp))
                                .Select(p => p.Field<decimal>("Amount")).Sum( );
                            ColumnChart.PrimaryXAxis.Title = $"{ (value / total) * 100:N}% of { pp} Total Funding";
                            ColumnChart.PrimaryXAxis.TitleColor = SystemColors.Info;
                            ColumnChart.PrimaryXAxis.TitleFont = new Font("Segoe UI", 10f);
                            series.Points.Add("Total", (double)total);
                            GetBindingSeriesConfiguration(series);
                            ColumnChart.Series.Add(series);
                        }
                    }
                    Get3DBindingMode(ColumnChart);
                }

                public Chart(ChartControl chart, string title, RegionalAuthority P7, BindingSource bs)
                {
                    int i = bs.Position;
                    var table = (DataTable)bs.DataSource;
                    var values = table.Rows[i];
                    var value = (decimal)values["Amount"];
                    string pp = values["ProgramProjectName"].ToString( );
                    var data = new RegionalAuthority().ProjectData;
                    ColumnChart = chart;
                    ColumnSeries = new ChartSeries("Allocation", ChartSeriesType.Column);
                    var series = new ChartSeries("Total", ChartSeriesType.Column);
                    foreach (string key in data.Keys)
                    {
                        if (key == pp)
                        {
                            ColumnSeries.Points.Add($"{values["BocName"].ToString( )}", (double)value);
                            GetBindingSeriesConfiguration(ColumnSeries);
                            ColumnChart.Series.Add(ColumnSeries);
                            decimal total = P7.Data.Table.AsEnumerable( )
                                .Where(p => p.Field<string>("ProgramProjectName").Equals(pp))
                                .Select(p => p.Field<decimal>("Amount")).Sum( );
                            ColumnChart.PrimaryXAxis.Title = $"{ (value / total) * 100:N}% of { pp} Total Funding";
                            ColumnChart.PrimaryXAxis.TitleColor = SystemColors.Info;
                            ColumnChart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9f);
                            series.Points.Add("Total", (double)total);
                            GetBindingSeriesConfiguration(series);
                            ColumnChart.Series.Add(series);
                        }
                        ColumnSeries.XAxis.Font = new Font("Segoe UI", 10F);
                    }
                    Get3DBindingMode(ColumnChart);
                }

               

                public Chart(ChartControl chart, Dictionary<string, decimal> data)
                {
                    ColumnChart = chart;
                    ColumnChart.Series.Clear( );
                    ColumnChart.Legends.Clear( );
                    ColumnSeries = new ChartSeries("Value", ChartSeriesType.Column);
                    foreach (KeyValuePair<string, decimal> kvp in data)
                    {
                        ColumnSeries.Points.Add(kvp.Key, (double)kvp.Value);
                    }
                    GetSeriesConfiguration(ColumnSeries);
                    ColumnChart.Series.Add(ColumnSeries);
                    Get3DMode(ColumnChart);
                }

                #endregion

                #region Methods

                internal ChartControl CreateColumn( )
                {
                    return ColumnChart;
                }

                private void Get3DMode(ChartControl chart)
                {
                    ColumnChart = chart;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = 2;
                    ColumnChart.Depth = 150;
                    ColumnChart.Rotation = -10;
                    ColumnChart.SpacingBetweenSeries = 2;
                }

                private void Get3DBindingMode(ChartControl chart)
                {
                    ColumnChart = chart;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = 2;
                    ColumnChart.Depth = 150;
                    ColumnChart.Rotation = 5;
                    ColumnChart.SpacingBetweenSeries = 2;
                }

                private void Get3DMode(ChartControl chart, int[] rt)
                {
                    ColumnChart = chart;
                    ColumnChart.ChartArea.Series3D = true;
                    ColumnChart.RealMode3D = true;
                    ColumnChart.Style3D = true;
                    ColumnChart.Tilt = rt[0];
                    ColumnChart.Depth = 250;
                    ColumnChart.Rotation = rt[1];
                    ColumnChart.SpacingBetweenSeries = 10;
                }

                private void GetColumnSeriesData(ChartControl chart, string title, Dictionary<string, decimal> data)
                {
                    ColumnChart = chart;
                    ColumnSeries = new ChartSeries("Series", ChartSeriesType.Column);
                    ColumnChart.Series.Add(ColumnSeries);
                    foreach (KeyValuePair<string, decimal> kvp in data)
                    {
                        ColumnSeries.Points.Add(kvp.Key, (double)kvp.Value);
                    }
                }

                private void GetLegend(ChartControl chart, ChartSeries series)
                {
                    ColumnChart = chart;
                    ChartLegendItemsCollection items = new ChartLegendItemsCollection( );
                    ChartLegend legend = new ChartLegend(ColumnChart);
                    ChartLegendItem item = new ChartLegendItem( );
                    item.Text = series.Name;
                    legend.Text = "Legend";
                    items.Add(item);
                    legend.VisibleCheckBox = true;
                    legend.ColumnsCount = 1;
                    ColumnChart.Legends.Add(legend);
                }

                private void GetAxisTitles(ChartControl chart, string title)
                {
                    ColumnChart = chart;
                    ColumnChart.PrimaryXAxis.Title = title;
                    ColumnChart.PrimaryXAxis.TitleColor = SystemColors.Info;
                    ColumnChart.PrimaryXAxis.TitleFont = new Font("SegoeUI", 9);
                }

                private void GetMainTitle(ChartControl chart, string t)
                {
                    ColumnChart = chart;
                    ColumnChart.Titles.Clear( );
                    ChartTitle title = new ChartTitle( );
                    title.Text = t;
                    title.ForeColor = Color.White;
                    title.Font = new Font("SegoeUI", 8, FontStyle.Regular);
                    ColumnChart.Titles.Add(title);
                }

                private void GetSeriesConfiguration(ChartSeries series)
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
                

                #endregion
            }
        }
    }
}