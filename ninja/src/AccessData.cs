﻿// <copyright file="AccessData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Interactivity;

    /// <summary>
    /// UI for the SQLiteData class.
    /// </summary>
    public sealed partial class AccessData : MetroForm
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessData"/> class.
        /// </summary>
        public AccessData()
        {
            InitializeComponent();
            Source = Source.PRC;
            Provider = Provider.Access;
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

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessData"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public AccessData(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            BindingSource = DbData.BindingSource;
            Grid.DataSource = DbData.BindingSource;
            ProgramElements = DbData.ProgramElements;
            Text = $@"{Source.ToString()} Database";
            TableFilter = Info.FilterRows;
            Fields = Info.GetColumnValues;
            label12.Text = Table.Rows.Count.ToString();
        }

        // PROPERTIES
        /// <summary>
        /// Gets the Source
        /// </summary>
        private Source Source { get; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        private Provider Provider { get; }

        /// <summary>
        /// Gets or sets the TableFilter
        /// </summary>
        internal TableDelegate TableFilter { get; set; }

        /// <summary>
        /// Gets or sets the Fields
        /// </summary>
        internal Fields Fields { get; set; }

        /// <summary>
        /// Gets the DbData
        /// </summary>
        internal DataBuilder DbData { get; }

        /// <summary>
        /// Gets or sets the Parameter
        /// </summary>
        internal Dictionary<string, object> Parameter { get; set; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        internal Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        internal DataTable Table { get; set; }

        /// <summary>
        /// Gets or sets the F1
        /// </summary>
        private string F1 { get; set; }

        /// <summary>
        /// Gets or sets the F2
        /// </summary>
        private string F2 { get; set; }

        /// <summary>
        /// Gets or sets the F3
        /// </summary>
        private string F3 { get; set; }

        /// <summary>
        /// Gets or sets the F4
        /// </summary>
        private string F4 { get; set; }

        /// <summary>
        /// Gets or sets the C1
        /// </summary>
        private Field C1 { get; set; }

        /// <summary>
        /// Gets or sets the C2
        /// </summary>
        private Field C2 { get; set; }

        /// <summary>
        /// Gets or sets the C3
        /// </summary>
        private Field C3 { get; set; }

        /// <summary>
        /// Gets or sets the C4
        /// </summary>
        private Field C4 { get; set; }

        /// <summary>
        /// Handles the Load event of the SQLiteData control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SQLiteData_Load(object sender, EventArgs e)
        {
            try
            {
                HideTopGridLabels();
                if(Source == Source.PRC)
                {
                    Filter1.Text = @"BFY";
                    Filter1.Items.Add("2018");
                    Filter2.Text = @"Fund";
                    label5.Visible = true;
                    label5.Text = @"Total: ";
                    label6.Visible = true;
                    foreach(string f in ProgramElements["Fund"])
                    {
                        Filter2.Items.Add(f);
                    }

                    Filter3.Text = @"RC";
                    foreach(string rc in ProgramElements["RC"])
                    {
                        Filter3.Items.Add(rc);
                    }
                }

                FunctionTab.TabVisible = false;
                GetDataBase(Source);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Populates the filter items.
        /// </summary>
        /// <param name="colname">The colname.</param>
        /// <param name="data">The data.</param>
        /// <param name="control">The control.</param>
        /// <param name="label">The label.</param>
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

        /// <summary>
        /// Populates the filter items.
        /// </summary>
        /// <param name="colname">The colname.</param>
        /// <param name="table">The table.</param>
        /// <param name="control">The control.</param>
        /// <param name="label">The label.</param>
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

                string[] filters = Fields(table, colname);
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

        /// <summary>
        /// Populates the filter items.
        /// </summary>
        /// <param name="colname">The colname.</param>
        /// <param name="data">The data.</param>
        /// <param name="control">The control.</param>
        /// <param name="label">The label.</param>
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

        /// <summary>
        /// Populates the filter items.
        /// </summary>
        /// <param name="colname">The colname.</param>
        /// <param name="table">The table.</param>
        /// <param name="control">The control.</param>
        /// <param name="label">The label.</param>
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

                string[] item = Fields(table, colname.ToString());
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

        /// <summary>
        /// Populates the filter buttons.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="list">The list.</param>
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

        /// <summary>
        /// Handles the OnClick event of the FilterControlButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Hides the top grid labels.
        /// </summary>
        private void HideTopGridLabels()
        {
            try
            {
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                Filter2.Visible = false;
                Filter3.Visible = false;
                Filter4.Visible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Filter1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Filter2 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(sender is VisualComboBox filter)
                {
                    F2 = filter.SelectedItem.ToString();
                    C2 = (Field) Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable tbl = TableFilter(Table, C1, F1);
                DataTable tbl2 = TableFilter(tbl, C2, F2);
                BindingSource.DataSource = tbl2;
                label6.Text = DbData.GetTotal(Source, tbl2).ToString("c");
                label12.Text = tbl2.Rows.ToString();
                PopulateFilterItems(Filter3.Tag.ToString(), tbl2, Filter3, label3);
                Filter4.Visible = false;
                label4.Visible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Filter3 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Filter3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                F3 = filter?.SelectedItem.ToString();
                if(filter != null)
                {
                    C3 = (Field) Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable tbl = TableFilter(Table, C1, F1);
                DataTable tbl2 = TableFilter(tbl, C2, F2);
                DataTable tbl3 = TableFilter(tbl2, C3, F3);
                BindingSource.DataSource = tbl3;
                label6.Text = DbData.GetTotal(Source, tbl3).ToString("c");
                label12.Text = tbl3.Rows.Count.ToString();
                if(Filter4.Tag != null)
                {
                    PopulateFilterItems(Filter4.Tag.ToString(), tbl3, Filter4, label4);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the Filter4 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void Filter4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                F4 = filter?.SelectedItem.ToString();
                if(filter != null)
                {
                    C4 = (Field) Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable tbl = TableFilter(Table, C1, F1);
                DataTable tbl2 = TableFilter(tbl, C2, F2);
                DataTable tbl3 = TableFilter(tbl2, C3, F3);
                DataTable tbl4 = TableFilter(tbl3, C4, F4);
                BindingSource.DataSource = tbl4;
                label6.Text = DbData.GetTotal(Source, tbl4).ToString("c");
                label12.Text = tbl4.Rows.Count.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Gets the data base.
        /// </summary>
        /// <param name="source">The source.</param>
        private void GetDataBase(Source source)
        {
            try
            {
                switch(source)
                {
                    case Source.Accounts:
                        label1.Text = @"Fund";
                        PopulateFilterItems(Field.FundCode, Table, Filter1, label1);
                        Filter2.Tag = "GoalName";
                        Filter3.Tag = "ProgramProjectName";
                        break;

                    case Source.Supplemental:
                        label1.Text = @"DivisionName";
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "Type";
                        break;

                    case Source.Reimbursables:
                        label1.Text = @"AgreementNumber";
                        PopulateFilterItems(Field.AgreementNumber, Table, Filter1, label1);
                        Filter2.Tag = "ReimbOrg";
                        Filter3.Tag = "FundName";
                        break;

                    case Source.ControlNumbers:
                        label1.Text = @"DivisionID";
                        PopulateFilterItems(Field.Division, Table, Filter1, label1);
                        Filter2.Tag = "Fund";
                        break;

                    case Source.Divisions:
                        label1.Text = @"DivisionName";
                        PopulateFilterItems(Field.Name, Table, Filter1, label1);
                        Filter2.Tag = "Title";
                        Filter3.Tag = "RC";
                        Filter4.Tag = "Code";
                        break;

                    case Source.Personnel:
                        label1.Text = "HrOrgCodeName";
                        PopulateFilterItems(Field.HrOrgCodeName, Table, Filter1, label1);
                        Filter2.Tag = "WorkCode";
                        Filter3.Tag = "LastName";
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
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "BocName";
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
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "RC";
                        break;

                    case Source.FTE:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BudgetLevel";
                        Filter3.Tag = "DivisionName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.PAYROLL:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "ProgramAreaName";
                        Filter3.Tag = "NpmCode";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.EPM:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.OIL:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.SUPERFUND:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.STAG:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.LUST:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.DWH:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.TRAVEL:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.EXPENSES:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.CONTRACTS:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.GRANTS:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.WCF:
                        label1.Text = "BudgetLevel";
                        PopulateFilterItems(Field.BudgetLevel, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.DivisionAccounts:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.EJ:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.EN:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
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
                        PopulateFilterItems(Field.DivisionName, Table, Filter1, label1);
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "BOC";
                        break;

                    case Source.RegionalAccounts:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.Sites:
                        label1.Text = "State";
                        PopulateFilterItems(Field.State, Table, Filter1, label1);
                        Filter2.Tag = "District";
                        Filter3.Tag = "FocName";
                        break;

                    case Source.MD:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.RC:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.RA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.SF:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.WQ:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.MM:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.WSA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.MDR:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.XA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, Table, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;
                    case Source.Programs:
                        break;
                    case Source.BudgetLevels:
                        break;
                    case Source.WorkCodes:
                        break;
                    case Source.PayrollObligations:
                        break;
                    case Source.PayAccruals:
                        break;
                    case Source.SF6A:
                        break;
                    case Source.External:
                        break;
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Handles the OnClick event of the CalculatorButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        /// <summary>
        /// Handles the OnClick event of the ExcelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelData ef = new ExcelData();
            ef.Show();
        }

        /// <summary>
        /// Handles the OnClick event of the ReprogrammingButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ReprogrammingButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rf = new Reprogramming();
            rf.Show();
        }

        /// <summary>
        /// Handles the OnClick event of the PreviousButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        /// <summary>
        /// Handles the OnClick event of the NextButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        /// <summary>
        /// Handles the OnClick event of the AddButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void AddButton_OnClick(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the RefreshButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the OnClick event of the CopyButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CopyButton_OnClick(object sender, EventArgs e)
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

        /// <summary>
        /// Handles the OnClick event of the FilterButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FilterButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                FilterTab.TabVisible = true;
                FunctionTab.TabVisible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Handles the OnClick event of the FunctionButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void FunctionButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                FunctionTab.TabVisible = true;
                FilterTab.TabVisible = false;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// Handles the Enter event of the VisualGroupBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void VisualGroupBox1_Enter(object sender, EventArgs e)
        {
        }
    }
}
