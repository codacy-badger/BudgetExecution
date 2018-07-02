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
            DbData = new DataBuilder(Source.RegionalAccounts, Provider.SQLite);
            Table = DbData.DbTable;
            Metric = new PrcMetric(DbData);
            ProgramElements = DbData.GetProgramElements(Table);
            BindingSource.DataSource = Table;
            Navigator.BindingSource = BindingSource;
            SQLiteGrid.DataSource = BindingSource.DataSource;
            PopulateSourceFilters();
            PopulateFilterButtons(Filter1, Info.Sources);
        }

        public SQLiteData(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.DbTable;
            Metric = new PrcMetric(DbData);
            ProgramElements = DbData.GetProgramElements(Table);
            BindingSource.DataSource = Table;
            Navigator.BindingSource = BindingSource;
            SQLiteGrid.DataSource = BindingSource.DataSource;
            PopulateSourceFilters();
            PopulateFilterButtons(Filter1, Info.Sources);
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

        public MetroSetComboBox DataFilter1 { get; set; }

        private MetroSetComboBox DataFilter2 { get; set; }

        private MetroSetComboBox DataFilter3 { get; set; }


        // METHODS

        private void PopulateSourceFilters()
        {
            DataFilter1 = Filter1;
            foreach(string s in Info.Sources)
            {
                DataFilter1.Items.Add(s);
            }
        }

        private void GetGridDataSource(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            var name = listbox.SelectedItem.ToString();
            var source = (Source)Enum.Parse(typeof(Source), name.ToString());
            BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable(source);
        }

        private void Filter3_ItemSelected(object sender, EventArgs e)
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

        private void DataMaster_Load(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DataFilter2_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                DataFilter2.Items.Clear();
                var filter = sender as MetroSetComboBox;
                DataFilter2.Tag = filter;
                var fund = filter.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{fund}'";
                var boc = ProgramElements[PrcField.BocName.ToString()];
                foreach (string b in boc)
                {
                    DataFilter2.Items.Add(b);
                }

                DataFilter3.Visible = true;
                DataFilter3.SelectionChangeCommitted += Filter3_ItemSelected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void GetFilter2Items()
        {
            try
            {
                var item = DbData.ProgramElements["FundName"];
                foreach (string i in item)
                {
                    DataFilter2.Items.Add(i);
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

        private void button5_Click(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void button8_Click(object sender, EventArgs e)
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
                            FIlter2.Items.Add(s);
                            label2.Text = "HR ORG";
                            FIlter2.SelectedIndexChanged += FilterComboBox_OnSelect;
                        }
                        break;
                    case Source.Reimbursables:
                        foreach (string s in DbData.ProgramElements["AgreementNumber"])
                        {
                            FIlter2.Items.Add(s);
                            label2.Text = "AgreementNumber";
                            FIlter2.SelectedIndexChanged += FilterComboBox_OnSelect;
                        }
                        break;
                    case Source.Sites:
                        foreach (string s in DbData.ProgramElements["State"])
                        {
                            FIlter2.Items.Add(s);
                            label2.Text = "State";
                            FIlter2.SelectedIndexChanged += FilterComboBox_OnSelect;
                        }
                        break;
                    default:
                        foreach (string s in DbData.ProgramElements["Fund"])
                        {
                            FIlter2.Items.Add(s);
                            label2.Text = "Fund";
                            FIlter2.SelectedIndexChanged += FilterComboBox_OnSelect;
                        }
                        break;

                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FilterComboBox_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var control = sender as MetroSetComboBox;
                var filter = control.SelectedItem.ToString();
                if(Filter3 == null)
                {

                    BindingSource.Filter = string.Format("Fund = '{0}'", filter.ToString());
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
                var query = table.AsEnumerable().Where(p => p.Field<string>("Fund").Equals(FIlter2.SelectedItem.ToString()))
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

        private void SplitContainerAdv1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaterialTabSelector1_Click(object sender, EventArgs e)
        {

        }

        private void LeftButton_Click_1(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void RightButton_Click_1(object sender, EventArgs e)
        {
            BindingSource.MoveNext();

        }

        private void splitContainerAdv1_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}