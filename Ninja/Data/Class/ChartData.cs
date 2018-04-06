using Syncfusion.Windows.Forms.Chart;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class ChartData
            {
                public ChartData()
                {
                }

                public ChartData(Source source)
                {
                    Data = new DataBuilder(source);
                    BindingSource.DataSource = Data.Table;
                    DataMetric = new Metric(Data);
                }

                public string[] AxesTitle { get; set; }
                public BindingSource BindingSource { get; }
                public ChartControl Chart { get; set; }
                public DataBuilder Data { get; }
                public Metric DataMetric { get; }
                public int[] Dimension { get; set; }
                public ChartDataBindModel Model { get; }
                public ChartSeries Series { get; set; }
                public string[] Titles { get; set; }
                public ChartSeriesType Type { get; set; }
            }
        }
    }
}