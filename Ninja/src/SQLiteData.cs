﻿// <copyright file="SQLiteData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms;
using VisualPlus.Toolkit.Controls.Interactivity;

namespace BudgetExecution
{
    /// <summary>
    ///     UI for the SQLiteData class.
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    public sealed partial class SQLiteData : MetroForm
    {
        // CONSTRUCTORS
        public SQLiteData()
        {
            InitializeComponent();
            Source = Source.RegionalAccounts;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            BindingSource = DbData.BindingSource;
            Grid.DataSource = BindingSource;
            ProgramElements = DbData.ProgramElements;
            Grid.DataSource = BindingSource.DataSource;
            PopulateFilterButtons(Filter1, Info.Sources);
            Text = $@"{Source.ToString()} Database";
            TableFilter = Info.FilterRows;
            Fields = Info.GetColumnValues;
            label12.Text = Table.Rows.Count.ToString();
        }

        public SQLiteData(Source source, Provider provider = Provider.SQLite)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            BindingSource = DbData.BindingSource;
            Grid.DataSource = DbData.BindingSource;
            ProgramElements = DbData.ProgramElements;
            Text = $@"{Source.ToString()} - Database";
            TableFilter = Info.FilterRows;
            Fields = Info.GetColumnValues;
            label12.Text = Table.Rows.Count.ToString();
        }

        // PROPERTIES
        private Source Source { get; }

        private Provider Provider { get; }

        internal TableDelegate TableFilter { get; set; }

        internal Fields Fields { get; set; }

        internal DataBuilder DbData { get; }

        internal Dictionary<string, object> Parameter { get; set; }

        internal Dictionary<string, string[]> ProgramElements { get; set; }

        internal DataTable Table { get; set; }

        private string F1 { get; set; }

        private string F2 { get; set; }

        private string F3 { get; set; }

        private string F4 { get; set; }

        private Field C1 { get; set; }

        private Field C2 { get; set; }

        private Field C3 { get; set; }

        private Field C4 { get; set; }

        // METHODS
        private void SQLiteData_Load(object sender, EventArgs e)
        {
            try
            {
                HideTopGridLabels();
                if(Source == Source.PRC)
                {
                    Filter1.Text = @"BFY";
                    Filter1.Items.Add("2018");
                    Filter2.Text = @"FundName";
                    label11.Visible = true;
                    label11.Text = @"Records: ";
                    label6.Visible = true;
                    foreach(string f in ProgramElements["FundName"])
                    {
                        Filter2.Items.Add(f);
                    }

                    Filter3.Text = @"RC";
                    foreach(string rc in ProgramElements["RC"])
                    {
                        Filter3.Items.Add(rc);
                    }
                }

                Filter5.Visible = false;
                label5.Visible = false;
                GetDataBase(Source);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(string colname, DataBuilder data, VisualComboBox control, Label label)
        {
            try
            {
                if(control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if(label.Visible == false)
                {
                    label.Visible = true;
                }

                string[] filters = data.ProgramElements[colname];
                control.Tag = colname;
                foreach(string i in filters)
                {
                    control.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(string colname, DataTable table, VisualComboBox control, Label label)
        {
            try
            {
                if(control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if(label.Visible == false)
                {
                    label.Visible = true;
                    label.Text = control.Tag?.ToString() ?? colname;
                }

                string[] filters = table.AsEnumerable().Select(p => p.Field<string>(colname)).Distinct().ToArray();
                foreach(string i in filters)
                {
                    control.Items.Add(i);
                }

                if(control.Visible == false)
                {
                    control.Visible = true;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(Field colname, DataBuilder data, VisualComboBox control, Label label)
        {
            try
            {
                control.Tag = colname.ToString();
                if(control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if(label.Visible == false)
                {
                    label.Visible = true;
                    label.Text = control.Tag.ToString();
                }

                string[] items = ProgramElements[colname.ToString()];
                foreach(string i in items)
                {
                    control.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(Field colname, DataTable table, VisualComboBox control, Label label)
        {
            try
            {
                if(control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if(label.Visible == false)
                {
                    label.Visible = true;
                }

                string[] item = table.AsEnumerable().Select(p => p.Field<string>(colname.ToString())).Distinct().ToArray();
                control.Tag = colname.ToString();
                foreach(string i in item)
                {
                    control.Items.Add(i);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterButtons(VisualComboBox control, string[] list)
        {
            try
            {
                control.Items.Clear();
                foreach(string f in list)
                {
                    control.Items.Add(f);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void FilterControlButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                MetroSetButton button = sender as MetroSetButton;
                string name = button?.Tag.ToString();
                Source source = (Source) Enum.Parse(typeof(Source), name ?? throw new InvalidOperationException());
                BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void HideTopGridLabels()
        {
            try
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label15.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                Filter2.Visible = false;
                Filter3.Visible = false;
                Filter4.Visible = false;
                Filter5.Visible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                F1 = filter?.SelectedItem.ToString();
                C1 = (Field) Enum.Parse(typeof(Field), filter?.Tag.ToString());
                DataTable tbl = TableFilter(Table, C1, F1);
                BindingSource.DataSource = tbl;
                label6.Text = DbData.GetTotal(Source, tbl).ToString("c");
                label12.Text = tbl.Rows.Count.ToString();
                PopulateFilterItems(Filter2.Tag.ToString(), tbl, Filter2, label2);
                Filter3.Visible = false;
                label3.Visible = false;
                Filter4.Visible = false;
                label4.Visible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(sender is VisualComboBox filter)
                {
                    F2 = filter.SelectedItem.ToString();
                    C2 = (Field) Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable table = Table.AsEnumerable().Where(p => p.Field<string>(C1.ToString()).Equals(F1)).Where(p => p.Field<string>(C2.ToString()).Equals(F2)).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                label6.Text = DbData.GetTotal(Source, table).ToString("c");
                label12.Text = table.Rows.Count.ToString();
                if(Filter3.Tag != null)
                {
                    PopulateFilterItems(Filter3.Tag.ToString(), table, Filter3, label3);
                }

                Filter4.Visible = false;
                label4.Visible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                if(filter?.SelectedItem != null)
                {
                    F3 = filter.SelectedItem.ToString();
                    C3 = (Field) Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable table = Table.AsEnumerable().Where(p => p.Field<string>(C1.ToString()).Equals(F1)).Where(p => p.Field<string>(C2.ToString()).Equals(F2)).Where(p => p.Field<string>(C3.ToString()).Equals(F3)).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                label6.Text = DbData.GetTotal(Source, table).ToString("c") ?? "0";
                label12.Text = table.Rows.Count.ToString() ?? "0";
                if(Filter4.Tag != null)
                {
                    PopulateFilterItems(Filter4.Tag.ToString(), table, Filter4, label4);
                }               
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                if(filter.SelectedItem != null)
                {
                    F4 = filter.SelectedItem.ToString();
                    C4 = (Field) Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable table = Table.AsEnumerable().Where(p => p.Field<string>(C1.ToString()).Equals(F1)).Where(p => p.Field<string>(C2.ToString()).Equals(F2)).Where(p => p.Field<string>(C3.ToString()).Equals(F3)).Where(p => p.Field<string>(C4.ToString()).Equals(F4)).Select(p => p).CopyToDataTable();
                BindingSource.DataSource = table;
                if(table.Columns.Contains("Amount"))
                {
                    label6.Text = DbData.GetTotal(Source, table).ToString("c");
                }

                label12.Text = table.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetDataBase(Source source)
        {
            try
            {
                switch(source)
                {
                    case Source.Accounts:
                        label1.Text = "FundCode";
                        PopulateFilterItems(Field.FundCode, Table, Filter1, label1);
                        Filter2.Tag = "GoalName";
                        Filter3.Tag = "ProgramProjectName";
                        Filter4.Visible = false;
                        break;

                    case Source.Supplemental:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "Type";
                        Filter4.Visible = false;
                        break;

                    case Source.Reimbursables:
                        label1.Text = "AgreementNumber";
                        PopulateFilterItems(Field.AgreementNumber, Table, Filter1, label1);
                        Filter2.Tag = "ReimbOrg";
                        Filter3.Tag = "FundName";
                        Filter4.Visible = false;
                        break;

                    case Source.ControlNumbers:
                        label1.Text = "Division";
                        PopulateFilterItems(Field.Division, Table, Filter1, label1);
                        Filter2.Tag = "FundCode";
                        Filter3.Visible = false;
                        Filter4.Visible = false;
                        break;

                    case Source.Divisions:
                        label1.Text = "Name";
                        PopulateFilterItems(Field.Name, Table, Filter1, label1);
                        Filter2.Tag = "Title";
                        Filter3.Tag = "RC";
                        Filter4.Tag = "Code";
                        break;

                    case Source.Personnel:
                        label1.Text = "Division";
                        PopulateFilterItems(Field.Division, Table, Filter1, label1);
                        Filter2.Tag = "Section";
                        Filter3.Tag = "LastName";
                        Filter4.Tag = "Email";
                        break;

                    case Source.Funds:
                        label1.Text = "Name";
                        PopulateFilterItems(Field.Name, Table, Filter1, label1);
                        Filter2.Tag = "Title";
                        Filter3.Tag = "Code";
                        Filter4.Tag = "FiscalYear";
                        break;

                    case Source.Benefits:
                        label1.Text = "HROrgCodeName";
                        PopulateFilterItems(Field.HrOrgCodeName, Table, Filter1, label1);
                        Filter2.Tag = "OccupationalSeries";
                        Filter3.Tag = "HROrgCode";
                        Filter4.Tag = "LastName";
                        break;

                    case Source.PayrollObligations:
                    case Source.ProgramObligations:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "FocName";
                        break;

                    case Source.TravelObligations:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "Traveler";
                        Filter4.Tag = "FocName";
                        break;

                    case Source.PRC:
                        label1.Text = "BudgetLevel";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.Transfers:
                        label1.Text = "BudgetLevel";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "RC";
                        Filter4.Tag = "BocName";
                        break;

                    case Source.FTE:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BudgetLevel";
                        Filter3.Tag = "DivisionName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.PAYROLL:
                    case Source.CONTRACTS:
                    case Source.EXPENSES:
                    case Source.TRAVEL:
                    case Source.WCF:
                    case Source.GRANTS:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "ProgramAreaName";
                        Filter3.Tag = "NPM";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.SUPERFUND:
                    case Source.STAG:
                    case Source.LUST:
                    case Source.DWH:
                    case Source.OIL:
                    case Source.EPM:
                    case Source.SF6A:
                        label1.Text = "BocName";
                        PopulateFilterItems(Field.BocName, Table, Filter1, label1);
                        Filter2.Tag = "NPM";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.EJ:
                    case Source.EN:
                    case Source.RA:
                    case Source.RC:
                    case Source.SF:
                    case Source.MD:
                    case Source.MDR:
                    case Source.WQ:
                    case Source.WSA:
                    case Source.XA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "NPM";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.DivisionAccounts:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.ExternalTransfers:
                        label1.Text = "DocumentNumber";
                        PopulateFilterItems(Field.DocumentNumber, Table, Filter1, label1);
                        Filter2.Tag = "Type";
                        Filter3.Tag = "Fund";
                        Filter4.Tag = "BOC";
                        break;

                    case Source.InternalTransfers:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.Division, Table, Filter1, label1);
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "BOC";
                        Filter4.Visible = false;
                        break;

                    case Source.RegionalAccounts:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "NPM";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.Sites:
                        label1.Text = "State";
                        PopulateFilterItems(Field.State, Table, Filter1, label1);
                        Filter2.Tag = "District";
                        Filter3.Tag = "FocName";
                        break;
                }
            }
            catch(Exception ex)
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
            ExcelData ef = new ExcelData();
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
            catch(Exception ex)
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
                DataGridViewRow dgvRow = Grid.CurrentRow;
                Dictionary<string, object> data = new Dictionary<string, object>();
                data.Add("ID", int.Parse(dgvRow.Cells["ID"].Value.ToString()));
                RecordManager am = new RecordManager(Source, Provider, data);
                am.Show();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void VisualGroupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void TabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
