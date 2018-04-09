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

                public ChartData(DataBuilder data, ChartFilter filter)
                {
                    Data = data;
                    Metric = new DataMetric(Data);
                    InputTotals = Metric.GetChartTotals(Data.BudgetTable, filter.ToString());
                    Series = GetSeriesData(InputTotals);
                    Dimension = GetDimensions();

                }

                public ChartData(DataBuilder data, ChartSeriesType type)
                {
                    Data = data;
                    Metric = new DataMetric(Data);
                    BindingSource = new BindingSource();
                    BindingSource.DataSource = Data.BudgetTable;
                    Model = new ChartDataBindModel(BindingSource);
                    Model.YNames = new string[] { "Amount" };
                    Series = new ChartSeries();
                    Series.Type = type;
                    Series.SeriesModel = Model;

                }

                //Properties
                public DataBuilder Data { get; }
                public DataMetric Metric { get; }
                public Dictionary<string, double> InputTotals { get; set; }
                public Dictionary<string, double[]> InputMetrics { get; set; }
                public BindingSource BindingSource { get; set; }
                public ChartDataBindModel Model { get; }
                public int[] Dimension { get; set; }
                public ChartSeries Series { get; set; }
                public string[] MainTitle { get; set; }
                public string[] AxisTitle { get; set; }
                public ChartFilter Filter { get; set; }
                public ChartSeriesType SeriesType { get; set; }


                //Methods
                internal ChartSeries GetSeriesData(Dictionary<string, double> data)
                {
                    var series = new ChartSeries();
                    foreach(KeyValuePair<string, double> kvp in data)
                    {
                        series.Points.Add(kvp.Key, kvp.Value);
                    }
                    return series;
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

                internal int[] GetDimensions(params int[] a)
                {
                    return new int[] { 2, 250, -10 };
                }

            }


        }
    }
}