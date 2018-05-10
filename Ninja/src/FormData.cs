using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;

namespace BudgetExecution
{
    public class FormData
    {
        //Constructors
        public FormData()
        {
        }

        public FormData(DataBuilder data, BindingSource bs, DataGridView dgv, BindingNavigator bn)
        {
            Data = data;
            DataMetric = new PrcMetric(Data);
            DataSet = Data.DataSet;
            DataTable = Data.QueryTable;
            BindDataGridAndNavigator(DataTable, dgv, bs, bn);
            BindingSource = bs;
            Navigator = bn;
            DataGrid = dgv;
        }

        //Properties
        public Stat Measure { get; set; }
        public ChartSeriesType ChartType { get; set; }
        public BindingSource BindingSource { get; set; }
        public DataSet DataSet { get; set; }
        public PrcMetric DataMetric { get; set; }
        public ChartControl Chart { get; set; }
        public ChartDataBindModel ChartModel { get; set; }
        public Control PrimaryFilterControl { get; set; }
        public Control SecondaryFilterControl { get; set; }
        public Control TertiaryFilterControl { get; set; }
        public int Count { get; set; }
        public DataBuilder Data { get; set; }
        public DataGridView DataGrid { get; set; }
        public decimal[] Metrics { get; set; }
        public BindingNavigator Navigator { get; set; }
        public FlowLayoutPanel Panel { get; set; }
        public DataTable DataTable { get; set; }
        public Dictionary<string, object> SearchParameter { get; set; }
        Func<DataTable, PrcField, string> TableFilter;

        //Methods
        public decimal GetAverage(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }
        public string[] GetCodes(DataTable table, string column)
        {
            try
            {
                return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, decimal> GetDataTotals(DataTable table, string column, string filter)
        {
            try
            {
                var list = GetCodes(table, column);
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach (string ftr in list)
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                        .Sum(p => p.Field<decimal>("Amount"));
                    if (query > 0)
                        info.Add(filter, query);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public PRC[] GetPrcArray(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Select(p => new PRC()).ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public Dictionary<string, string[]> GetProgramElements(DataTable table)
        {
            try
            {
                var data = new Dictionary<string, string[]>();
                foreach (DataColumn dc in table.Columns)
                {
                    if (dc.ColumnName.Equals("Id") || dc.ColumnName.Equals("Amount"))
                        continue;
                    data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
                }
                if (data.ContainsKey("Id")) data.Remove("Id");
                if (data.ContainsKey("Amount")) data.Remove("Amount");
                if (data.ContainsKey("P6_Id")) data.Remove("P6_Id");
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public DataTable GetTable(DataTable table, string column, string filter)
        {
            try
            {
                return table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter)).Select(p => p).CopyToDataTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        public decimal GetTotal(DataTable table)
        {
            try
            {
                return table.AsEnumerable().Sum(p => p.Field<decimal>("Amount"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return -1M;
            }
        }
        public Dictionary<string, decimal> GetTotals(DataTable table, string[] filters, string column)
        {
            try
            {
                Dictionary<string, decimal> info = new Dictionary<string, decimal>();
                foreach (string filter in filters)
                {
                    var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                        .Select(p => p).Sum(p => p.Field<decimal>("Amount"));
                    if (query > 0)
                        info.Add(filter, query);
                }
                return info;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
                return null;
            }
        }
        internal void PrimaryFilterControlButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetButton;
                var table = GetTable(DataTable, "FundName", button.Tag.ToString());
                BindingSource.DataSource = table;
                PopulateBocFilterBox(table, Panel);
                DataTable = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PrimaryFilterControlListBox_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetListBox;
                var table = GetTable(DataTable, "FundName", button.SelectedItem.ToString());
                BindingSource.DataSource = table;
                DataTable = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void BindDataGridAndNavigator(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
        {
            try
            {
                bs.DataSource = table;
                dg.DataSource = bs;
                bn.BindingSource = bs;
                ConfigureDataGridViewVisibleColumns(dg);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void BindTextBox(BindingSource bs, TextBox tb, string field)
        {
            try
            {
                var table = (DataTable)bs.DataSource;
                var row = table.Rows[bs.Position];
                var binding = new Binding("Text", row, field);
                tb.DataBindings.Add(binding);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void BocButton_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetListBox;
                var table = GetTable(DataTable, "BocName", button.SelectedItem.ToString());
                BindingSource.DataSource = table;
                PopulateBocFilterBox(DataTable, Panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void BocListBoxItem_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetListBox;
                var table = GetTable(DataTable, "BocName", button.SelectedItem.ToString());
                BindingSource.DataSource = table;
                PopulateBocFilterBox(DataTable, Panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void ConfigurePrimaryFilterControlButton(DataTable table, Control fitlerControl, PrcField prc)
        {
            try
            {
                PopulateFilterButtons(fitlerControl, GetCodes(table, prc.ToString()));
                foreach (Control c in fitlerControl.Controls) c.Click += PrimaryFilterControlButton_OnClick;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void ConfigurePrimaryFilterControlBox(DataTable table, Control filterControl, PrcField prc)
        {
            try
            {
                var filter = filterControl as ListBox;
                PopulateFilterListItems(filter, GetCodes(table, prc.ToString()));
                filter.SelectedIndexChanged += PrimaryFilterControlListBox_OnSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateBocFilterBox(DataTable table, FlowLayoutPanel fitlerControl)
        {
            try
            {
                PopulateFilterButtons(fitlerControl, GetCodes(table, "BocName"));
                foreach (Control c in fitlerControl.Controls) c.Click += BocButton_OnSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateFilterButtons(Control control, string[] list)
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
                    b.HoverTextColor = Color.AntiqueWhite;
                    b.Size = new Size(175, 30);
                    b.Margin = new Padding(3);
                    b.Padding = new Padding(1);
                    control.Controls.Add(b);
                    control.AutoSize = true;
                    b.Tag = f;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateFilterListItems(Control control, string[] list)
        {
            try
            {
                var box = control as ListBox;
                box.Controls.Clear();
                foreach (string f in list)
                {
                    box.Items.Add(f);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void ConfigureFormSettings(MetroForm form)
        {
            try
            {
                form.Size = new Size(1200, 700);
                form.BackColor = Color.Black;
                form.BorderColor = SystemColors.MenuHighlight;
                form.ForeColor = SystemColors.MenuHighlight;
                form.MetroColor = Color.Black;
                form.ShowIcon = false;
                form.ShowInTaskbar = true;
                form.CaptionBarColor = Color.Black;
                form.CaptionFont = new Font("Segoe UI", 10f, FontStyle.Regular);
                form.CaptionForeColor = SystemColors.MenuHighlight;
                form.BorderThickness = 1;
                form.Padding = new Padding(1);
                form.CaptionAlign = HorizontalAlignment.Left;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void ConfigureDataGridViewVisibleColumns(DataGridView dgv)
        {
            try
            {
                foreach (DataGridViewColumn dc in dgv.Columns)
                    dc.Visible = false;
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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void ReturnNavigateButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                DataTable = Data.QueryTable;
                BindingSource.DataSource = DataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal Dictionary<string, object> GetCurrentRowPrcParameter(DataGridView dgv)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    var dgvRow = dgv.CurrentRow;
                    var data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(dgvRow.Cells["ID"].Value.ToString()));
                    data.Add("Fund", dgvRow.Cells["Fund"].Value.ToString());
                    data.Add("Org", dgvRow.Cells["Org"].Value.ToString());
                    data.Add("RC", dgvRow.Cells["RC"].ToString());
                    data.Add("Code", dgvRow.Cells["Code"].ToString());
                    data.Add("BOC", dgvRow.Cells["BOC"].ToString());
                    return data;
                }
                return null;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        internal void DataGridViewAccountUpdate(DataGridView dgv, Source source)
        {
            var param = new Dictionary<string, object>();
            if(dgv.Rows.Count > 0)
                param = GetCurrentRowPrcParameter(dgv);
            var query = new Query(source, param);
            using (SQLiteConnection conn = query.Connection)
            {
                var cmd = query.GetUpdateCommand();
                cmd.ExecuteNonQuery();
                var adp = new SQLiteDataAdapter();

            }
        }
    }
}