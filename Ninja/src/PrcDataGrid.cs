// <copyright file="PrcDataGrid.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;

namespace Ninja.Data
{
    public partial class BudgetDataGrid : UserControl
    {
        public BudgetDataGrid()
        {
            InitializeComponent();
        }

        public ChartDataBindModel ChartData { get; set; }

        private void GridListBox_SelectedIndexChanged(object sender) { }
    }
}
