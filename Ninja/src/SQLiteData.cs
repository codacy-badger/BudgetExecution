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
            DbData = new DataBuilder(Source.RegionAccount, Provider.SQLite);
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            ProgramElements = DbData.GetProgramElements(Table);
            BindingSource.DataSource = Table;
            AccountGrid.DataSource = BindingSource;
            GetPrcGridVisibleColumns(AccountGrid);
            AccountNavigator.BindingSource = BindingSource;
            PopulateSourceFilters();
            PopulateFilterButtons(Filter1, Info.Sources);
        }

        public SQLiteData(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            ProgramElements = DbData.GetProgramElements(Table);
            BindingSource.DataSource = Table;
            AccountGrid.DataSource = BindingSource;
            GetPrcGridVisibleColumns(AccountGrid);
            AccountNavigator.BindingSource = BindingSource;
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

        public DataGridView Grid { get; set; }

        public FlowLayoutPanel DataFilter1 { get; set; }

        private MetroSetComboBox DataFilter2 { get; set; }

        private MetroSetComboBox DataFilter3 { get; set; }


        // METHODS

        private void PopulateSourceFilters()
        {
            DataFilter1 = Filter1;
            foreach(string s in Info.Sources)
            {
            }
        }

        private void GetGridDataSource(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            var name = listbox.SelectedItem.ToString();
            var source = (Source)Enum.Parse(typeof(Source), name.ToString());
            BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable();
            AccountNavigator.BindingSource = BindingSource;
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


        internal void FilterControlButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetButton;
                var name = button.Tag.ToString();
                var source = (Source)Enum.Parse(typeof(Source), name.ToString());
                BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable();
                AccountNavigator.BindingSource = BindingSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }

        private void splitContainerAdv1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTabSelector1_Click(object sender, EventArgs e)
        {

        }
    }
}