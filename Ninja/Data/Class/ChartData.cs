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
                public ChartSeriesType Type { get; set; }
                public ChartControl Chart { get; set; }
                public ChartSeries Series { get; set; }
                public ChartDataBindModel Model { get; set; }
                public bool Percentage { get; set; }
                public ChartControl PieChart { get; set; }
                public Dictionary<string, decimal> Values { get; set; }
                public decimal Total { get; set; }
                public decimal Ratio { get; set; }
                public decimal Average { get; set; }
                public string[] PrimaryTitle { get; set; }
                public string[] AxisTitle { get; set; }
                private IAuthority Data { get; set; }
                public BindingSource BindingSource { get; set; }
                public int Tilt { get; set; }
                public int Depth { get; set; }
                public int Rotation { get; set; }

                public ChartData()
                {

                }
            }


        }
    }
}