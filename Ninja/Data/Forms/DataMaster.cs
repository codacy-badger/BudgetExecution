using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Budget.Ninja.Data;
using MetroSet_UI.Controls;

namespace Ninja.Data
{
    public partial class DataMaster : Syncfusion.Windows.Forms.MetroForm
    {
        //Constructors
        public DataMaster()
        {
            InitializeComponent();
            Data = new DataBuilder(Source.P7);
            Table = Data.QueryTable;
            Metric = new DataMetric(Data);
            ProgramElements = Data.GetElements(Table);
            BindingSource.DataSource = Table;
            Grid.DataSource = BindingSource;
            GridNavigator.BindingSource = BindingSource;
            GetGridColumns(Grid);
            GetFundFilterItems();
        }

        private SQLiteDataAdapter Adapter { get; }

        private DataBuilder Data { get; }

        private DataMetric Metric { get; }

        private Dictionary<string, object> Parameter { get; set; }

        private Dictionary<string, string[]> ProgramElements { get; set; }

        //Properties
        private Query Query { get; }

        private DataTable Table { get; set; }

        private void BocFilter_ItemSelected(object sender, EventArgs e)
        {
            var boc = sender as MetroSetComboBox;
            var bocfilter = boc.SelectedItem.ToString();
            BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}' AND BocName = '{bocfilter}'";
        }

        //Methods
        private void DataMaster_Load(object sender, EventArgs e)
        {
            FundFilter.SelectionChangeCommitted += FundFilter_ItemSelected;
            BocFilter.Visible = false;
        }

        private void FundFilter_ItemSelected(object sender, EventArgs e)
        {
            BocFilter.Items.Clear();
            var filter = sender as MetroSetComboBox;
            FundFilter.Tag = filter;
            var fund = filter.SelectedItem.ToString();
            BindingSource.Filter = $"FundName = '{fund}'";
            var boc = ProgramElements[PrcFilter.BocName.ToString()];
            foreach (string b in boc)
                BocFilter.Items.Add(b);
            BocFilter.Visible = true;
            BocFilter.SelectionChangeCommitted += BocFilter_ItemSelected;
        }

        private void GetFundFilterItems()
        {
            var item = Data.ProgramElements["FundName"];
            foreach (string i in item)
                FundFilter.Items.Add(i);
        }

        private void GetGridColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn dc in dgv.Columns)
                dc.Visible = false;
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

        private void gridRecordNavigationControl1_Click(object sender, EventArgs e)
        {
        }
    }
}