using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using Budget.Ninja.Data;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms;


namespace BudgetExecution
{
    public partial class AccessDataMaster : MetroForm
    {
        // CONSTRUCTORS
        public AccessDataMaster()
        {
            InitializeComponent();
            DbData = new DataBuilder(Source.PRC, Provider.OleDb);
            Table = DbData.Table;
            Metric = new PrcMetric(DbData);
            ProgramElements = DbData.GetProgramElements(Table);
            BindingSource.DataSource = Table;
            Grid.DataSource = BindingSource;
            GridNavigator.BindingSource = BindingSource;
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
        private void BocFilter_ItemSelected(object sender, EventArgs e)
        {
            try
            {
                var boc = sender as MetroSetComboBox;
                var bocfilter = boc.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{MasterFilter1.SelectedItem.ToString()}' AND BocName = '{bocfilter}'";
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
                MasterFIlter2.Items.Clear();
                var filter = sender as MetroSetComboBox;
                MasterFilter1.Tag = filter;
                var fund = filter.SelectedItem.ToString();
                BindingSource.Filter = $"FundName = '{fund}'";
                var boc = ProgramElements[PrcField.BocName.ToString()];
                foreach (string b in boc)
                    MasterFIlter2.Items.Add(b);
                MasterFIlter2.Visible = true;
                MasterFIlter2.SelectionChangeCommitted += BocFilter_ItemSelected;
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
                    MasterFilter1.Items.Add(i);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void GetGridColumns(DataGridView dgv)
        {
            try
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void AccessDataMaster_Load(object sender, EventArgs e)
        {
        }
    }
}