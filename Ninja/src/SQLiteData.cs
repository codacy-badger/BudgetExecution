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
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms;

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
            Table = DbData.DbTable;
            BindingSource = DbData.BindingSource;
            Grid.DataSource = DbData.BindingSource;
            Navigator.BindingSource = DbData.BindingSource;
            ProgramElements = DbData.GetProgramElements(DbData.DbTable);
            Text = $"{Source.ToString()} Database";
            FunctionTab.TabVisible = false;
            TableFilter = new DataFilter(Info.FilterTableRows);
        }
        // PROPERTIES
        private Source Source { get; }

        private Provider Provider { get; }

        private DataFilter TableFilter { get; set; }

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

        public Field C1 { get; set; }

        public Field C2 { get; set; }

        public Field C3 { get; set; }

        // METHODS

        private void PopulateSourceFilters()
        {
            FilterControl1 = Filter1;
            foreach(string s in Info.Sources)
            {
                FilterControl1.Items.Add(s);
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterItems(Field colname, DataBuilder DbData, MetroSetComboBox control, Label label)
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
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
                var am = new RecordManager(Source, Provider);
                am.Show();
            }
            catch (Exception ex)
            {

                var  _ = new Error(ex).ShowDialog();
            }
        }

        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                var am = new RecordManager(Source, Provider);
                am.Show();
            }
            catch (Exception ex)
            {

                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
            }
        }

        private void GetDataBase(Source source)
        {
            switch (source)
            {
                case Source.Accounts:
                    label1.Text = "Fund Code";
                    PopulateFilterItems(Field.Fund, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.ProgramProjectCode, DbData, Filter2, label2);
                    label2.Text = "Program Project";
                    break;
                case Source.Awards:

                    label1.Text = "Division";
                    PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    label2.Text = "Fund Name";
                    break;
                case Source.Reimbursables:
                    label1.Text = "Agreement Number";
                    PopulateFilterItems("AgreementNumber", DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Reimbursable Org Code";
                    PopulateFilterItems("ReimbOrg", DbData, Filter3, label3);
                    break;
                case Source.ControlNumbers:
                    label1.Text = "Division";
                    PopulateFilterItems("DivisionID", DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.Fund, DbData, Filter2, label2);
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
                    PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Budget Object Class";
                    PopulateFilterItems(Field.BocName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Finance Object Class";
                    PopulateFilterItems("FocName", DbData, Filter4, label4);
                    break;
                case Source.DivisionObligations:
                    label1.Text = "Division";
                    PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Budget Object Class";
                    PopulateFilterItems(Field.BocName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Finance Object Class";
                    PopulateFilterItems("FocName", DbData, Filter4, label4);
                    break;
                case Source.PayrollObligations:
                    label1.Text = "Division";
                    PopulateFilterItems(Field.DivisionName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Work Code Name";
                    PopulateFilterItems("WorkCodeName", DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Finance Object Class";
                    PopulateFilterItems("FocName", DbData, Filter4, label4);
                    break;
                case Source.PRC:
                    label1.Text = "Budget Level";
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Division";
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Budget Object Class";
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.Transfers:
                    label1.Text = "Budget Level";
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.Fund, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Division";
                    PopulateFilterItems(Field.RC, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Reprogramming Number";
                    PopulateFilterItems("DocumentNumber", DbData, Filter4, label4);
                    break;
                case Source.FTE:
                    label1.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Program Project";
                    PopulateFilterItems(Field.ProgramProjectName, DbData, Filter2, label2);
                    break;
                case Source.PAYROLL:
                    label1.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Program Project";
                    PopulateFilterItems(Field.ProgramProjectName, DbData, Filter2, label2);
                    break;
                case Source.EPM:
                    label1.Text = "Budget Level";
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    label2.Text = "Fund";
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    label3.Text = "Division";
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    label4.Text = "Budget Object Class";
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.OIL:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.SUPERFUND:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.STAG:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    break;
                case Source.LUST:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.DWH:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.TRAVEL:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    break;
                case Source.EXPENSES:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.CONTRACTS:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.GRANTS:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;
                case Source.WCF:
                    PopulateFilterItems(Field.BudgetLevel, DbData, Filter1, label1);
                    Filter2.Visible = true;
                    PopulateFilterItems(Field.FundName, DbData, Filter2, label2);
                    Filter3.Visible = true;
                    PopulateFilterItems(Field.DivisionName, DbData, Filter3, label3);
                    Filter4.Visible = true;
                    PopulateFilterItems(Field.BocName, DbData, Filter4, label4);
                    break;


            }
        }

        private void Filter1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                F1 = filter.SelectedItem.ToString();
                C1 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                var tbl = TableFilter(Table, C1, F1);
                BindingSource.DataSource = tbl;
                label6.Text = DbData.GetTotal(tbl).ToString("c");
                label12.Text = DbData.GetCount(tbl).ToString();
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
                var filter = sender as MetroSetComboBox;
                F2 = filter.SelectedItem.ToString();
                C2 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                var tbl = TableFilter(Table, C1, F1);
                var tbl2 = TableFilter(tbl, C2, F2);
                BindingSource.DataSource = tbl2;
                label6.Text = DbData.GetTotal(tbl2).ToString("c");
                label12.Text = DbData.GetCount(tbl2).ToString();
            }
            catch (Exception ex)
            {
                var errorMessage = new Error(ex);
                errorMessage.ShowDialog();
            }
        }

        private void Filter3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var filter = sender as MetroSetComboBox;
                F3 = filter.SelectedItem.ToString();
                C3 = (Field)Enum.Parse(typeof(Field), filter.Tag.ToString());
                var tbl = TableFilter(Table, C1, F1);
                var tbl2 = TableFilter(tbl, C2, F2);
                var tbl3 = TableFilter(tbl2, C3, F3);
                BindingSource.DataSource = tbl3;
                label6.Text = DbData.GetTotal(tbl3).ToString("c");
                label12.Text = DbData.GetCount(tbl3).ToString();
            }
            catch (Exception ex)
            {
                var errorMessage = new Error(ex);
                errorMessage.ShowDialog();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            try
            {
                BindingSource.Filter = null;
                BindingSource.DataSource = Table;
                Navigator.BindingSource = BindingSource;
                Grid.DataSource = BindingSource;
                Filter2.Items.Clear();
                Filter3.Items.Clear();
                label2.Visible = false;
                Filter2.Visible = false;
                label3.Visible = false;
                Filter3.Visible = false;
                label4.Visible = false;
                Filter4.Visible = false;
            }
            catch (System.Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
            }      
        }
    }
}