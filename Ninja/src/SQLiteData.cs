// <copyright file="SQLiteData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
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
            Grid.DataSource = BindingSource;
            GetPrcGridVisibleColumns(Grid);
            GridNavigator.BindingSource = BindingSource;
            PopulateSourceFilters();
            Filter1.SelectedValueChanged += GetGridDataSource;
        }

        // PROPERTIES
        private SQLiteDataAdapter Adapter { get; }

        private DataBuilder DbData { get; }

        private PrcMetric Metric { get; }

        private Dictionary<string, object> Parameter { get; set; }

        private Dictionary<string, string[]> ProgramElements { get; set; }

        private Query Query { get; }

        private DataTable Table { get; set; }


        // METHODS

        private void PopulateSourceFilters()
        {
            foreach(string s in Info.Sources)
            {
                Filter1.Items.Add(s);
            }
        }

        private void GetGridDataSource(object sender, EventArgs e)
        {
            var cbox = sender as MetroSetComboBox;
            var name = cbox.SelectedItem.ToString();
            var source = (Source)Enum.Parse(typeof(Source), name.ToString());
            BindingSource.DataSource = new DataBuilder(source, Provider.SQLite).GetDataTable();
            GridNavigator.BindingSource = BindingSource;
        }

        private void BocFilter_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var boc = sender as MetroSetComboBox;
                var bocfilter = boc.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{Filter1.SelectedItem.ToString()}' AND BocName = '{bocfilter}'";
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

        private void FundFilter_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                FIlter2.Items.Clear();
                var filter = sender as MetroSetComboBox;
                Filter1.Tag = filter;
                var fund = filter.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{fund}'";
                var boc = ProgramElements[PrcField.BocName.ToString()];
                foreach (string b in boc)
                {
                    FIlter2.Items.Add(b);
                }

                FIlter2.Visible = true;
                FIlter2.SelectionChangeCommitted += BocFilter_ItemSelected;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void GetFundFilterItems()
        {
            try
            {
                var item = DbData.ProgramElements["FundName"];
                foreach (string i in item)
                {
                    Filter1.Items.Add(i);
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

                dgv.Columns[0].Visible = true;
                dgv.Columns[4].Visible = true;
                dgv.Columns[5].Visible = true;
                dgv.Columns[6].Visible = true;
                dgv.Columns[8].Visible = true;
                dgv.Columns[8].HeaderText = "BOC";
                dgv.Columns[9].Visible = true;
                dgv.Columns[11].Visible = true;
                dgv.Columns[12].Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}