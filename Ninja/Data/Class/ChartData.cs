using Syncfusion.Windows.Forms.Chart;
using System.Collections.Generic;
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

                }


                //Properties
                public string[] Axes { get; set; }
                public BindingSource BindingSource { get; }
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
            }


        }
    }
}