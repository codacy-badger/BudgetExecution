using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using MetroSet_UI.Controls;
using System.Data.SQLite;

namespace Ninja.Data
{
    public partial class BudgetDataGrid : UserControl
    {
        public ChartDataBindModel ChartData { get; set; }

        public BudgetDataGrid()
        {
            InitializeComponent();
        }

        private void GridListBox_SelectedIndexChanged(object sender)
        {

        }
    }
}
