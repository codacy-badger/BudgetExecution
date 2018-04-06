using Syncfusion.Windows.Forms.Chart;
using System.Windows.Forms;

namespace Ninja.Data
{
    public partial class BudgetDataGrid : UserControl
    {
        public BudgetDataGrid()
        {
            InitializeComponent();
        }

        public ChartDataBindModel ChartData { get; set; }

        private void GridListBox_SelectedIndexChanged(object sender)
        {
        }
    }
}