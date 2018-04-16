using Budget.Ninja.Data;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Syncfusion.Windows.Forms.Grid;
using MetroSet_UI.Controls;
using System.Data.SQLite;

namespace Ninja.Data
{
    public partial class DataMaster : Syncfusion.Windows.Forms.MetroForm
    {
        //Constructors
        public DataMaster()
        {
            InitializeComponent();
            Data = new DataBuilder(Source.P7);
            Table = Data.BudgetTable;
            Metric = new DataMetric(Data);
            ProgramElements = Data.GetElements(Table);
            BindingSource.DataSource = Table;
            Grid.DataSource = BindingSource;
            GridNavigator.BindingSource = BindingSource;
            GetGridColumns(Grid);
            GetFundFilterItems();
        }


        //Properties
        Query Query { get; }
        SQLiteDataAdapter Adapter { get; }
        DataBuilder Data { get; }
        DataMetric Metric { get; }
        DataTable Table { get; set; }
        Dictionary<string, string[]> ProgramElements { get; set; }
        Dictionary<string, object> Parameter { get; set; }

        //Methods
        private void DataMaster_Load(object sender, EventArgs e)
        {
            FundFilter.SelectionChangeCommitted += FundFilter_ItemSelected;
            BocFilter.Visible = false;
        }
        private void gridRecordNavigationControl1_Click(object sender, EventArgs e)
        {

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

        void GetFundFilterItems()
        {
            var item = Data.ProgramElements["FundName"];
            foreach (string i in item)
                FundFilter.Items.Add(i);
        }

        void FundFilter_ItemSelected(object sender, EventArgs e)
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

        void BocFilter_ItemSelected(object sender, EventArgs e)
        {
            var boc = sender as MetroSetComboBox;
            var bocfilter = boc.SelectedItem.ToString();
            BindingSource.Filter = $"FundName = '{FundFilter.SelectedItem.ToString()}' AND BocName = '{bocfilter}'";

        }
    }
}
