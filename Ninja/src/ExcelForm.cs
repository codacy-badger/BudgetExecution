// <copyright file="ExcelForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    using Syncfusion.Windows.Forms;
    using Syncfusion.WinForms.DataGrid.Events;

    public partial class ExcelForm : MetroForm
    {
        // CONSTRUCTORS
        public ExcelForm()
        {
            InitializeComponent();
            Source = Source.DivisionAccounts;
            Provider = Provider.SQLite;
        }

        public ExcelForm(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
        }

        // PROPERTIES
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        internal DataFilter TableFilter { get; set; }

        internal FieldFilter FieldFilter { get; set; }

        internal BindingSource BindingSource { get; set; }

        internal DataBuilder DbData { get; set; }

        internal Dictionary<string, object> Parameter { get; set; }

        internal Dictionary<string, string[]> ProgramElements { get; set; }

        internal DataTable Table { get; set; }

        // METHODS
        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelImporter ef = new ExcelImporter();
            ef.Show();
        }

        private void ReprogrammingButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rf = new Reprogramming();
            rf.Show();
        }     
        
        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        private void AddButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                RecordManager am = new RecordManager(Source, Provider);
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
        }

        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                RecordManager am = new RecordManager(Source, Provider);
                am.Show();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
