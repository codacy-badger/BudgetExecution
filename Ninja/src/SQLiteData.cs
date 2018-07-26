// <copyright file="SQLiteData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using MetroFramework.Controls;
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms;
    using VisualPlus.Toolkit.Controls;
    using VisualPlus.Toolkit.Controls.DataManagement;

    public partial class SQLiteData : MetroForm
    {
        // CONSTRUCTORS
        public SQLiteData()
        {
            InitializeComponent();
            Source = Source.RegionalAccounts;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source, Provider);
            BindingSource = DbData.BindingSource;
            Grid.DataSource = BindingSource;
            Navigator.BindingSource = BindingSource;
            ProgramElements = DbData.GetProgramElements(DbData.DbTable);
            Navigator.BindingSource = BindingSource;
            Grid.DataSource = BindingSource.DataSource;
            PopulateSourceFilters();
            PopulateFilterButtons(Filter1, Info.Sources);
            Text = $"{Source.ToString()} Database";
            FunctionTab.TabVisible = false;
        }

        public SQLiteData(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            BindingSource = DbData.BindingSource;
            Grid.DataSource = DbData.BindingSource;
            Navigator.BindingSource = DbData.BindingSource;
            ProgramElements = DbData.GetProgramElements(DbData.DbTable);
            Text = $"{Source.ToString()} Database";
            FunctionTab.TabVisible = false;
        }
        // PROPERTIES
        private Source Source { get; }

        private Provider Provider { get; }

        private SQLiteDataAdapter Adapter { get; }

        private DataBuilder DbData { get; }
        
        private PrcMetric Metric { get; }

        private Dictionary<string, object> Parameter { get; set; }

        private Dictionary<string, string[]> ProgramElements { get; set; }

        private Query Query { get; }

        private DataTable Table { get; set; }

        public DataGridView SqlGrid { get; set; }

        public MetroSetComboBox FilterControl1 { get; set; }

        private MetroSetComboBox FilterControl2 { get; set; }

        private MetroSetComboBox FilterControl3 { get; set; }

        public string F1 { get; set; }

        public string F2 { get; set; }

        public string F3 { get; set; }

        public string C1 { get; set; }

        public string C2 { get; set; }

        public string C3 { get; set; }

        // METHODS

        private void PopulateSourceFilters()
        {
            FilterControl1 = Filter1;
            foreach(string s in Info.Sources)
            {
                FilterControl1.Items.Add(s);
            }
        }

        private void GetGridDataSource(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            var name = listbox.SelectedItem.ToString();
            var source = (Source)Enum.Parse(typeof(Source), name.ToString());
            BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable(source);
        }

        private void Filter1_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                F1 = filter.SelectedItem.ToString();
                BindingSource.Filter = string.Format("{0} = '{1}'", filter.Tag.ToString(), filter.SelectedItem.ToString());
                if (Filter2.Visible == false)
                    Filter2.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Filter2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                var fund = filter.SelectedItem.ToString();
                F1 = Filter1.SelectedItem.ToString();
                var f1col = Filter1.Tag.ToString();
                BindingSource.Filter = string.Format("{0} = '{1}' AND {2} = '{3}'", f1col, F1, filter.Tag.ToString(), fund);
                if (Filter3.Visible == false)
                    Filter3.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Filter3_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                F1 = Filter1.SelectedItem.ToString();
                var f1col = Filter1.Tag.ToString();
                F2 = Filter2.SelectedItem.ToString();
                var f2col = Filter2.Tag.ToString();
                F3 = Filter3.SelectedItem.ToString();
                var f3col = Filter3.Tag.ToString();
                BindingSource.Filter = string.Format("{0} = '{1}' AND {3} = '{4}' AND {5} = '{6}'", f1col, F1, f2col, F2, f3col, F3);
                if (Filter4.Visible == false)
                    Filter4.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Filter4_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var boc = sender as MetroSetComboBox;
                var bocfilter = boc.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{Filter3.SelectedItem.ToString()}' AND BocName = '{bocfilter}'";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void SQLiteData_Load(object sender, EventArgs e)
        {
            try
            {
                HideTopGridLabels();
                Text = Source.ToString();
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
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        internal void PopulateFilterItems(string colname, DataBuilder DbData, MetroSetComboBox control)
        {
            try
            {
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }

                var filters = DbData.ProgramElements[colname];
                control.Tag = colname;
                foreach (string i in filters)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        internal void PopulateFilterItems(string colname, DataBuilder DbData, MetroSetComboBox control, Label label)
        {
            try
            {
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }
                
                if(label.Visible == false)
                {
                    label.Visible = true;
                }

                var filters = DbData.ProgramElements[colname];
                control.Tag = colname;
                foreach (string i in filters)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        internal void PopulateFilterItems(PrcField colname, DataBuilder DbData, MetroSetComboBox control)
        {
            try
            {
                if (control.Items.Count > 0)
                {
                    control.Items.Clear();
                }
                var item = DbData.ProgramElements[colname.ToString()];
                control.Tag = colname;
                foreach (string i in item)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        internal void PopulateFilterItems(PrcField colname, DataBuilder DbData, MetroSetComboBox control, Label label)
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

                var item = DbData.ProgramElements[colname.ToString()];
                control.Tag = colname.ToString();
                foreach (string i in item)
                {
                    control.Items.Add(i);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
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
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        private void TabControlTabPage_Click(object sender, EventArgs e)
        {

        }

        internal void PopulateFilterButtons(FlowLayoutPanel control, string[] list)
        {
            try
            {
                control.Controls.Clear();
                foreach (string f in list)
                {
                    var b = new MetroSetButton();
                    b.Text = f;
                    b.Font = new Font("Segoe UI", 8f);
                    b.NormalColor = Color.Black;
                    b.NormalTextColor = SystemColors.MenuHighlight;
                    b.NormalBorderColor = Color.Black;
                    b.HoverBorderColor = Color.Blue;
                    b.HoverColor = Color.SteelBlue;
                    b.HoverTextColor = SystemColors.Info;
                    b.Size = new Size(160, 30);
                    b.Margin = new Padding(3);
                    b.Padding = new Padding(1);
                    control.AutoSize = true;
                    control.Controls.Add(b);
                    b.Tag = f;
                    b.Click += FilterControlButton_OnClick;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }

        internal void PopulateFilterButtons(MetroSetComboBox control, string[] list)
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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }

        internal void FilterControlButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetButton;
                var name = button.Tag.ToString();
                var source = (Source)Enum.Parse(typeof(Source), name.ToString());
                BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }

        private void GetFilters(Source source)
        {
            try
            {
                switch(source)
                {
                    case Source.Employees:
                        foreach(string s in DbData.ProgramElements["HrOrgCodeName"])
                        {
                            Filter2.Items.Add(s);
                            Filter2.Text = "HR ORG";
                            Filter2.SelectedIndexChanged += Filter1ComboBox_OnSelect;
                        }
                        break;
                    case Source.Reimbursables:
                        foreach (string s in DbData.ProgramElements["AgreementNumber"])
                        {
                            Filter2.Items.Add(s);
                            Filter2.Text = "AgreementNumber";
                            Filter2.SelectedIndexChanged += Filter1ComboBox_OnSelect;
                        }
                        break;
                    case Source.Sites:
                        foreach (string s in DbData.ProgramElements["State"])
                        {
                            Filter2.Items.Add(s);
                            Filter2.Text = "State";
                            Filter2.SelectedIndexChanged += Filter1ComboBox_OnSelect;
                        }
                        break;
                    default:
                        foreach (string s in DbData.ProgramElements["Fund"])
                        {
                            Filter2.Items.Add(s);
                            Filter2.Text = "Fund";
                            Filter2.SelectedIndexChanged += Filter1ComboBox_OnSelect;
                        }
                        break;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void Filter1ComboBox_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var control = sender as MetroSetComboBox;
                var filter = control.SelectedItem.ToString();
                if(Filter3 == null)
                {

                    BindingSource.Filter = string.Format("Fund = '{0}'", control.SelectedItem.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PopulateFilter2Items()
        {
            try
            {
                Filter3.Items.Clear();
                Filter3.Visible = true;
                var table = (DataTable)BindingSource.DataSource;
                var query = table.AsEnumerable().Where(p => p.Field<string>("Fund").Equals(Filter2.SelectedItem.ToString()))
                        .Select(p => p).Distinct().CopyToDataTable();
                foreach (var row in query.AsEnumerable().Select(p => p.Field<string>("BocName")).Distinct().ToArray())
                {
                    Filter3.Items.Add(row);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        
        private void LeftButton_Click_1(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void RightButton_Click_1(object sender, EventArgs e)
        {
            BindingSource.MoveNext();

        }

        private void AddButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                var am = new RecordManager(this.Source, this.Provider);
                am.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                var am = new RecordManager(this.Source, this.Provider);
                am.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void RefreshButton_OnClick(object sender, EventArgs e)
        {
            if (DbData != null)
            {
                try
                {
                    BindingSource.Filter = null;
                    Navigator.BindingSource = BindingSource;
                    Grid.DataSource = BindingSource;
                    label6.Text = DbData.GetTotal(DbData.DbTable).ToString("c");
                    label12.Text = DbData.GetCount(DbData.DbTable).ToString();
                    Filter2.Items.Clear();
                    Filter3.Items.Clear();
                    PopulateFilterItems(Filter1.SelectedItem.ToString(), DbData, Filter2, label2);
                    label2.Visible = false;
                    Filter2.Visible = false;
                    label3.Visible = false;
                    Filter3.Visible = false;
                    label4.Visible = false;
                    Filter4.Visible = false;
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
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
                MessageBox.Show(ex.Message + ex.TargetSite);
            }
        }

        private void GetDataBase(Source source)
        {
            switch (source)
            {
                case Source.Accounts:
                    label1.Text = "Fund Code";
                    PopulateFilterItems(PrcField.Fund, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.ProgramProjectCode, DbData, Filter2, label2);
                    label2.Text = "Program Project";
                    break;
                case Source.Awards:

                    label1.Text = "Division";
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    label2.Text = "Fund Name";
                    break;
                case Source.Reimbursables:
                    label1.Text = "Agreement Number";
                    PopulateFilterItems("AgreementNumber", DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Reimbursable Org Code";
                    PopulateFilterItems("ReimbOrg", DbData, Filter3, label3);
                    break;
                case Source.ControlNumbers:
                    label1.Text = "Division";
                    PopulateFilterItems("DivisionID", DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.Fund, DbData, Filter2, label2);
                    break;
                case Source.Divisions:
                    label1.Text = "Division Name";
                    PopulateFilterItems("Name", DbData, Filter1, label1);
                    break;
                case Source.Employees:
                    label1.Text = "HR Org Code Name";
                    PopulateFilterItems("HrOrgCodeName", DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Work Code";
                    PopulateFilterItems("WorkCode", DbData, Filter2, label2);
                    break;
                case Source.Funds:
                    label1.Text = "Fund";
                    PopulateFilterItems("FundName", DbData, Filter1, label1);
                    break;
                case Source.Obligations:
                    label1.Text = "Division";
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Budget Object Class";
                    PopulateFilterItems(PrcField.BocName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Finance Object Class";
                    PopulateFilterItems("FocName", DbData, Filter4, label4);
                    break;
                case Source.DivisionObligations:
                    label1.Text = "Division";
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Budget Object Class";
                    PopulateFilterItems(PrcField.BocName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Finance Object Class";
                    PopulateFilterItems("FocName", DbData, Filter4, label4);
                    break;
                case Source.PayrollObligations:
                    label1.Text = "Division";
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Work Code Name";
                    PopulateFilterItems("WorkCodeName", DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Finance Object Class";
                    PopulateFilterItems("FocName", DbData, Filter4, label4);
                    break;
                case Source.PRC:
                    label1.Text = "Budget Level";
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Division";
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Budget Object Class";
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.Transfers:
                    label1.Text = "Budget Level";
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.Fund, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Division";
                    PopulateFilterItems(PrcField.RC, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Reprogramming Number";
                    PopulateFilterItems("ControlNumber", DbData, Filter4, label4);
                    break;
                case Source.FTE:
                    label1.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Program Project";
                    PopulateFilterItems(PrcField.ProgramProjectName, DbData, Filter2, label2);
                    break;
                case Source.PAYROLL:
                    label1.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Program Project";
                    PopulateFilterItems(PrcField.ProgramProjectName, DbData, Filter2, label2);
                    break;
                case Source.EPM:
                    label1.Text = "Budget Level";
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Division";
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Budget Object Class";
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.OIL:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.SUPERFUND:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.STAG:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    break;
                case Source.LUST:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.DWH:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.TRAVEL:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    break;
                case Source.EXPENSES:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.CONTRACTS:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.GRANTS:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;
                case Source.WCF:
                    PopulateFilterItems(PrcField.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(PrcField.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(PrcField.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(PrcField.BocName, DbData, Filter4, label4);
                    break;


            }
        }

        private void Filter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var control = sender as MetroSetComboBox;
                F1 = control.SelectedItem.ToString();
                C1 = control.Tag.ToString();
                BindingSource.Filter = $"{C1} = '{F1}'";
                Table = DbData.DbTable.AsEnumerable()
                    .Where(p => p.Field<string>(C1).Equals(F1))
                    .Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
            }

        }

        private void Filter2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var control = sender as MetroSetComboBox;
                F2 = control.SelectedItem.ToString();
                C2 = control.Tag.ToString();
                BindingSource.Filter = $"{C1} = '{F1}' AND {C2} = '{F2}'";
                Table = DbData.DbTable.AsEnumerable()
                    .Where(p => p.Field<string>(C1).Equals(F1))
                    .Where(p => p.Field<string>(C2).Equals(F2))
                    .Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.TargetSite);
            }

        }
    }
}