// <copyright file="ExcelForm.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;

    using MetroSet_UI.Controls;

    using Syncfusion.Styles;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.WinForms.DataGrid.Events;

    public partial class ExcelForm : MetroForm
    {
        // CONSTRUCTORS
        public ExcelForm()
        {
            InitializeComponent();
            Source = Source.DivisionAccounts;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            BindingSource = new BindingSource();
            Table = DbData.DbTable;
            BindingSource.DataSource = Table;
            ProgramElements = DbData.ProgramElements;
            Ninja = new FormData(Source, Provider);
            BudgetTemplate = GetInternalFilePath();
        }

        public ExcelForm(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(source, provider);
            BindingSource = new BindingSource();
            Table = DbData.DbTable;
            BindingSource.DataSource = Table;
            ProgramElements = DbData.ProgramElements;
            Ninja = new FormData(Source, Provider);
            BudgetTemplate = GetInternalFilePath();
        }

        public ExcelForm(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            BindingSource = new BindingSource();
            Table = DbData.DbTable;
            BindingSource.DataSource = Table;
            ProgramElements = DbData.ProgramElements;
            Ninja = new FormData(Source, Provider, p);
            BudgetTemplate = GetInternalFilePath();
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

        internal FormData Ninja { get; set; }

        internal string BudgetTemplate { get; set; }

        // METHODS
        public string GetInternalFilePath()
        {
            try
            {
                var setting = new AppSettingsReader();
                return (string)setting.GetValue("BudgetReport", typeof(string));
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal void GetBinary()
        {
            try
            {
                var setting = new AppSettingsReader();
                string report = (string)setting.GetValue("BudgetReport", typeof(string));
                BudgetReport.Open(report);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void InitializeFilterButtons(Control control, string[] list)
        {
            try
            {
                control.Controls.Clear();
                foreach (string f in list)
                {
                    MetroSetButton b = new MetroSetButton();
                    b.Text = f;
                    b.Font = new Font("Segoe UI", 8f);
                    b.NormalColor = Color.Black;
                    b.NormalTextColor = SystemColors.MenuHighlight;
                    b.NormalBorderColor = Color.Black;
                    b.HoverBorderColor = Color.Blue;
                    b.HoverColor = Color.SteelBlue;
                    b.HoverTextColor = Color.AntiqueWhite;
                    b.Size = new Size(175, 30);
                    b.Margin = new Padding(3);
                    b.Padding = new Padding(1);
                    control.Controls.Add(b);
                    control.AutoSize = true;
                    b.Tag = f;
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterPanel(FlowLayoutPanel fitlerControl, string[] filter)
        {
            try
            {
                InitializeFilterButtons(fitlerControl, filter);
                foreach (MetroSetComboBox c in fitlerControl.Controls)
                {
                    var msb = new MetroSetButton();
                    InitializeFilterButtons(msb, filter);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

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

        private void ExcelForm_Load(object sender, EventArgs e)
        {

        }
    }
}