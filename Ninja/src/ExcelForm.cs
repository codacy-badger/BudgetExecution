// <copyright file="ExcelForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace BudgetExecution
{
    using System;

    public partial class ExcelForm : Syncfusion.Windows.Forms.MetroForm
    {
        public ExcelForm()
        {
            InitializeComponent();
        }

        private void ExcelForm_Load(object sender, EventArgs e)
        {

        }

        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            var cf = new CalculatorForm();
            cf.ShowDialog();
        }

        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            var ef = new ExcelImporter();
            ef.Show();
        }

        private void ReprogrammingButton_OnClick(object sender, EventArgs e)
        {
            var rf = new Reprogramming();
            rf.Show();
        }
    }
}
