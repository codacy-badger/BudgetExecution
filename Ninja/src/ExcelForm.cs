// <copyright file="ExcelForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;

    public partial class ExcelForm : MetroForm
    {
        public ExcelForm()
        {
            InitializeComponent();
            GetReport();
        }

        public DivisionAuthority Budget { get; set; }

        public Spreadsheet Report { get; set; }

        internal void GetReport()
        {
            Report = new Spreadsheet();
            Report.Open(@"D:\dev\database\BudgetControlTemplate.xlsx");
        }

        internal void GetReport(object sender, EventArgs e)
        {
            Report = new Spreadsheet();
            Report.Open(@"D:\dev\database\BudgetControlTemplate.xlsx");
        }

        private void SplitContainerAdv1_Click(object sender, EventArgs e)
        {
        }

        private void Spreadsheet1_Click(object sender, EventArgs e)
        {
        }

        private void AccountTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void MetroSetTextBox1_Click(object sender, EventArgs e)
        {
        }

        private void MetroSetLabel12_Click(object sender, EventArgs e)
        {
        }

        private void CalculatorControl1_Click(object sender, EventArgs e)
        {
        }

        private void Button7_Click(object sender, EventArgs e)
        {
        }

        private void Button10_Click(object sender, EventArgs e)
        {
        }

        private void TabControlAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
