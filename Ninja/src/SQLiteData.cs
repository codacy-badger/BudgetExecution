// <copyright file="SQLiteData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    using MetroSet_UI.Controls;
    using VisualPlus.Toolkit.Controls.Interactivity;

    using Syncfusion.Windows.Forms;

    /// <summary>
    /// UI for the SQLiteData class.
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.MetroForm" />
    public partial class SQLiteData : MetroForm
    {
        // CONSTRUCTORS
        public SQLiteData()
        {
            InitializeComponent();
            Source = Source.RegionalAccounts;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            BindingSource = DbData.BindingSource;
            Grid.DataSource = BindingSource;
            ProgramElements = DbData.GetProgramElements(Table);
            Grid.DataSource = BindingSource.DataSource;
            PopulateFilterButtons(Filter1, Info.Sources);
            Text = $"{Source.ToString()} Database";
            TableFilter = Info.FilterRows;
            FieldFilter = Info.GetColumnValues;
            label12.Text = Table.Rows.Count.ToString();
        }

        public SQLiteData(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            BindingSource = DbData.BindingSource;
            Grid.DataSource = DbData.BindingSource;
            ProgramElements = DbData.GetProgramElements(Table);
            Text = $"{Source.ToString()} Database";
            TableFilter = Info.FilterRows;
            FieldFilter = Info.GetColumnValues;
            label12.Text = Table.Rows.Count.ToString();
        }

        // PROPERTIES
        private Source Source { get; }

        private Provider Provider { get; }

        internal DataFilter TableFilter { get; set; }

        internal FieldFilter FieldFilter { get; set; }

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
                if (Source == Source.PRC)
                {
                    Filter1.Text = "BFY";
                    Filter1.Items.Add("2018");
                    Filter2.Text = "Fund";
                    label5.Visible = true;
                    label5.Text = "Total: ";
                    label6.Visible = true;
                    foreach (string f in DbData.ProgramElements["Fund"])
                        Filter2.Items.Add(f);
                    Filter3.Text = "RC";
                    foreach (string rc in DbData.ProgramElements["RC"])
                        Filter3.Items.Add(rc);
                }

                GetDataBase(Source);
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(string colname, DataBuilder data, VisualComboBox control, Label label)
        {
            try
            {
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if (label.Visible == false)
                {
                    label.Visible = true;
                }

                string[] filters = data.ProgramElements[colname];
                control.Tag = colname;
                foreach (string i in filters)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(string colname, DataTable table, VisualComboBox control, Label label)
        {
            try
            {
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if (label.Visible == false)
                {
                    label.Visible = true;
                    label.Text = control.Tag.ToString();
                }

                string[] filters = FieldFilter(table, colname);
                foreach (string i in filters)
                {
                    control.Items.Add(i);
                }

                if (control.Visible == false)
                    control.Visible = true;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(Field colname, DataBuilder data, VisualComboBox control, Label label)
        {
            try
            {
                control.Tag = colname.ToString();
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if (label.Visible == false)
                {
                    label.Visible = true;
                    label.Text = control.Tag.ToString();
                }

                string[] item = FieldFilter(data.DbTable, colname.ToString());
                //string[] items = ProgramElements[colname.ToString()];
                foreach (string i in item)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(Field colname, DataTable table, VisualComboBox control, Label label)
        {
            try
            {
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                if (label.Visible == false)
                {
                    label.Visible = true;
                }

                string[] item = FieldFilter(table, colname.ToString());
                control.Tag = colname.ToString();
                foreach (string i in item)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterButtons(VisualComboBox control, string[] list)
        {
            try
            {
                control.Items.Clear();
                foreach (string f in list)
                {
                    control.Items.Add(f);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void FilterControlButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                MetroSetButton button = sender as MetroSetButton;
                string name = button.Tag.ToString();
                Source source = (Source)Enum.Parse(typeof(Source), name.ToString());
                BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetPrcGridVisibleColumns(DataGridView dgv)
        {
            try
            {
                foreach (DataGridViewColumn dc in dgv.Columns)
                {
                    dc.Visible = false;
                }

                dgv.Columns[3].Visible = true;
                dgv.Columns[4].Visible = true;
                dgv.Columns[6].Visible = true;
                dgv.Columns[8].Visible = true;
                dgv.Columns[9].Visible = true;
                dgv.Columns[11].Visible = true;
                dgv.Columns[12].Visible = true;
                dgv.Columns[12].DefaultCellStyle.Format = "c";
            }
            catch (Exception ex)
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
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                F1 = filter.SelectedItem.ToString();
                C1 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                DataTable tbl = TableFilter(Table, C1, F1);
                BindingSource.DataSource = tbl;
                label6.Text = DbData.GetTotal(tbl).ToString("c");
                label12.Text = tbl.Rows.Count.ToString();
                PopulateFilterItems(Filter2.Tag.ToString(), tbl, Filter2, label2);
                Filter3.Visible = false;
                label3.Visible = false;
                Filter4.Visible = false;
                label4.Visible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (sender is VisualComboBox filter)
                {
                    F2 = filter.SelectedItem.ToString();
                    C2 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                }

                DataTable tbl = TableFilter(Table, C1, F1);
                DataTable tbl2 = TableFilter(tbl, C2, F2);
                BindingSource.DataSource = tbl2;
                label6.Text = DbData.GetTotal(tbl2).ToString("c");
                label12.Text = tbl2.Rows.ToString();
                PopulateFilterItems(Filter3.Tag.ToString(), tbl2, Filter3, label3);
                Filter4.Visible = false;
                label4.Visible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                F3 = filter?.SelectedItem.ToString();
                if (filter != null)
                    C3 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                DataTable tbl = TableFilter(Table, C1, F1);
                DataTable tbl2 = TableFilter(tbl, C2, F2);
                DataTable tbl3 = TableFilter(tbl2, C3, F3);
                BindingSource.DataSource = tbl3;
                label6.Text = DbData.GetTotal(tbl3).ToString("c");
                label12.Text = tbl3.Rows.Count.ToString();
                if (Filter4.Tag != null)
                {
                    PopulateFilterItems(Filter4.Tag.ToString(), tbl3, Filter4, label4);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void Filter4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                VisualComboBox filter = sender as VisualComboBox;
                F4 = filter?.SelectedItem.ToString();
                if (filter != null)
                    C4 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                DataTable tbl = TableFilter(Table, C1, F1);
                DataTable tbl2 = TableFilter(tbl, C2, F2);
                DataTable tbl3 = TableFilter(tbl2, C3, F3);
                DataTable tbl4 = TableFilter(tbl3, C4, F4);
                BindingSource.DataSource = tbl4;
                label6.Text = DbData.GetTotal(tbl4).ToString("c");
                label12.Text = tbl4.Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void GetDataBase(Source source)
        {
            try
            {
                switch (source)
                {
                    case Source.Accounts:
                        label1.Text = "Fund";
                        PopulateFilterItems(Field.Fund, DbData, Filter1, label1);
                        Filter2.Tag = "GoalName";
                        Filter3.Tag = "ProgramProjectName";
                        break;

                    case Source.Awards:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "Type";
                        break;

                    case Source.Reimbursables:
                        label1.Text = "AgreementNumber";
                        PopulateFilterItems("AgreementNumber", DbData, Filter1, label1);
                        Filter2.Tag = "ReimbOrg";
                        Filter3.Tag = "FundName";
                        break;

                    case Source.ControlNumbers:
                        label1.Text = "DivisionID";
                        PopulateFilterItems("DivisionID", DbData, Filter1, label1);
                        Filter2.Tag = "Fund";
                        break;

                    case Source.Divisions:
                        label1.Text = "DivisionName";
                        PopulateFilterItems("Name", DbData, Filter1, label1);
                        Filter2.Tag = "Title";
                        Filter3.Tag = "RC";
                        Filter4.Tag = "Code";
                        break;

                    case Source.Employees:
                        label1.Text = "HrOrgCodeName";
                        PopulateFilterItems(Field.HrOrgCodeName, DbData, Filter1, label1);
                        Filter2.Tag = "WorkCode";
                        Filter3.Tag = "LastName";
                        break;

                    case Source.Funds:
                        label1.Text = "Name";
                        PopulateFilterItems("Name", DbData, Filter1, label1);
                        Filter2.Tag = "Title";
                        Filter3.Tag = "Code";
                        Filter4.Tag = "FiscalYear";
                        break;

                    case Source.Obligations:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramArea";
                        Filter4.Tag = "DCN";
                        break;

                    case Source.DivisionObligations:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "DCN";
                        break;

                    case Source.PayrollObligations:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "FocName";
                        break;

                    case Source.PRC:
                        label1.Text = "BudgetLevel";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.Transfers:
                        label1.Text = "BudgetLevel";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "RC";
                        break;

                    case Source.FTE:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BudgetLevel";
                        Filter3.Tag = "DivisionName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.PAYROLL:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "ProgramAreaName";
                        Filter3.Tag = "NpmCode";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.EPM:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.OIL:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.SUPERFUND:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.STAG:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.LUST:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.DWH:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.TRAVEL:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.EXPENSES:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.CONTRACTS:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.GRANTS:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "DivisionName";
                        Filter3.Tag = "ProgramAreaName";
                        Filter4.Tag = "ProgramProjectName";
                        break;

                    case Source.WCF:
                        label1.Text = "BudgetLevel";
                        PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.DivisionAccounts:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                        Filter2.Tag = "FundName";
                        Filter3.Tag = "BocName";
                        Filter4.Tag = "ProgramAreaName";
                        break;

                    case Source.EJ:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.EN:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.ExternalTransfers:
                        label1.Text = "DocumentNumber";
                        PopulateFilterItems(Field.DocumentNumber, DbData, Filter1, label1);
                        Filter2.Tag = "Type";
                        Filter3.Tag = "Fund";
                        Filter4.Tag = "BOC";
                        break;

                    case Source.InternalTransfers:
                        label1.Text = "DivisionName";
                        PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                        Filter2.Tag = "Fund";
                        Filter3.Tag = "BOC";
                        break;

                    case Source.RegionalAccounts:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.Sites:
                        label1.Text = "State";
                        PopulateFilterItems(Field.State, DbData, Filter1, label1);
                        Filter2.Tag = "District";
                        Filter3.Tag = "FocName";
                        break;

                    case Source.MD:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.RC:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.RA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.SF:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.WQ:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.MM:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.WSA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.MDR:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;

                    case Source.XA:
                        label1.Text = "FundName";
                        PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                        Filter2.Tag = "BocName";
                        Filter3.Tag = "ProgramAreaName";
                        break;
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

        private void FilterButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                FilterTab.TabVisible = true;
                FunctionTab.TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FunctionButton_OnClick(object sender, EventArgs e)
        {
            try
            {               
                FunctionTab.TabVisible = true;
                FilterTab.TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void visualGroupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}