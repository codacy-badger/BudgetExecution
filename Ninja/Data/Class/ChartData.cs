using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class ChartData
            {

                //Constructors
                public ChartData()
                {
                }

                public ChartData(Source source)
                {
                    Data = new DataBuilder(source);
                    Metric = new DataMetric(Data);
                    BindingSource = new BindingSource();

                }


                //Properties
                public string[] Axes { get; set; }
                public BindingSource BindingSource { get; set; }
                public DataBuilder Data { get; }
                public DataMetric Metric { get; }
                public int[] Dimension { get; set; }
                public ChartDataBindModel Model { get; }
                public ChartSeries Series { get; set; }
                public string[] Titles { get; set; }
                public ChartSeriesType Type { get; set; }


                //Methods
                internal ChartSeries GetSeriesData(Dictionary<string, decimal> data)
                {
                    var model = new ChartSeries();
                    foreach(KeyValuePair<string, decimal> kvp in data)
                    {
                        model.Points.Add(kvp.Key, (double)kvp.Value);
                    }
                    return model;
                }

                internal Dictionary<string, double> GetDoubleTotals(DataTable table, string column)
                {
                    try
                    {
                        Dictionary<string, double> info = new Dictionary<string, double>();
                        foreach (string filter in Metric.ProgramElements[column])
                        {
                            var query = Metric.FilterTable(table, column, filter);
                            info.Add(filter, (double)Data.GetTotal(query));
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                internal Dictionary<string, double[]> GetDoubleMetrics(DataTable table, string column)
                {
                    try
                    {
                        Dictionary<string, double[]> info = new Dictionary<string, double[]>();
                        foreach (string filter in Metric.ProgramElements[column])
                        {
                            var query = Metric.FilterTable(table, column, filter);
                            double[] stat = new double[4];
                            stat[0] = (double)Data.GetTotal(query);
                            stat[1] = (double)Data.GetCount(query);
                            stat[2] = stat[0] / stat[1];
                            stat[3] = (stat[0] / (double)Metric.Total) * 100;
                            info.Add(filter, stat);
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                        return null;
                    }
                }

                internal ChartDataBindModel GetDataBinding(Dictionary<string, double> data)
                {
                    try
                    {
                        var chartdata = new ArrayList();
                        foreach (KeyValuePair<string, double> kvp in data)
                        {
                            chartdata.Add(new { kvp.Key, kvp.Value });
                        }
                        var model = new ChartDataBindModel(chartdata);
                        model.YNames = new string[] { "Amount" };
                        return model;                       
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }

                internal ChartDataBindModel GetDataBinding(BindingSource bs, DataTable table)
                {
                    try
                    {
                        if (BindingSource == null)
                            BindingSource = new BindingSource();
                        BindingSource = bs;
                        BindingSource.DataSource = table;
                        var model = new ChartDataBindModel(bs);
                        return model;
                    }
                    catch (Exception e)
                    {

                        MessageBox.Show(e.Message + e.StackTrace);
                        return null;
                    }
                }


            }


        }
    }
}