using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using MetroSet_UI.Controls;
using Syncfusion.Windows.Forms;
using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;

namespace Budget.Ninja.Data
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
            BudgetMetric = new DataMetric(Data);
            BudgetData = Data.DataSet;
            Table = Data.QueryTable;
            BindDataGridAndNavigator(Table, dgv, bs, bn);
            BindingSource = bs;
            Navigator = bn;
            DataGrid = dgv;
        }

        //Properties
        public BindingSource BindingSource { get; set; }
        public DataSet BudgetData { get; set; }
        public DataMetric BudgetMetric { get; set; }
        public ChartControl Chart { get; set; }
        public ChartDataBindModel ChartModel { get; set; }
        public int Count { get; set; }
        public DataBuilder Data { get; set; }
        public DataGridView DataGrid { get; set; }
        public decimal[] Metrics { get; set; }
        public BindingNavigator Navigator { get; set; }
        public FlowLayoutPanel Panel { get; set; }
        public DataTable Table { get; set; }
        private bool Percent { get; set; }

        //Methods
        public DataTable FilterTable(DataTable table, string column, string filter)
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
        internal void AppropriationButton_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetButton;
                var table = GetTable(Table, "FundName", button.Tag.ToString());
                BindingSource.DataSource = table;
                PopulateBocFilterBox(table, Panel);
                Table = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void AppropriationListBoxItem_OnSelect(object sender, EventArgs e)
        {
            try
            {
                var button = sender as MetroSetListBox;
                var table = GetTable(Table, "FundName", button.SelectedItem.ToString());
                BindingSource.DataSource = table;
                Table = table;
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
                ConfigureGridColumns(dg);
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
                var table = GetTable(Table, "BocName", button.SelectedItem.ToString());
                BindingSource.DataSource = table;
                PopulateBocFilterBox(Table, Panel);
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
                var table = GetTable(Table, "BocName", button.SelectedItem.ToString());
                BindingSource.DataSource = table;
                PopulateBocFilterBox(Table, Panel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void ConfigureTabControl(MetroForm form, TabControlAdv tab, DataBuilder Ninja)
        {
            try
            {
                foreach (TabPageAdv tp in tab.TabPages)
                {
                    tp.TabForeColor = SystemColors.MenuHighlight;
                    tp.TabBackColor = Color.Black;
                }
                tab.TabPages[0].Text = "Summary";
                tab.TabPages[1].Text = "Appropriation";
                tab.TabPages[2].Text = "BOC";
                tab.TabPages[3].Text = "NPM";
                tab.TabPages[4].Text = "Goal";
                if (Ninja.DataQuery.Source == Source.P7)
                {
                    tab.TabPages[5].Text = "Objective";
                    tab.TabPages[6].Text = "Divisions";
                    tab.TabPages[7].Text = "Transfers";
                }
                if (Ninja.DataQuery.Source == Source.P8)
                {
                    tab.TabPages[5].Text = "Program Area";
                    tab.TabPages[6].Text = "Program Project";
                    tab.TabPages[7].Text = "Transfers";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateFundFilterButtonBox(DataTable table, Control filterPanel)
        {
            try
            {
                PopulateFilterButtons(filterPanel, GetCodes(table, "FundName"));
                foreach (Control c in filterPanel.Controls) c.Click += AppropriationButton_OnSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateFundFilterListBox(DataTable table, Control filterPanel)
        {
            try
            {
                var filter = filterPanel as ListBox;
                PopulateFilterListItems(filter, GetCodes(table, "FundName"));
                filter.SelectedIndexChanged += AppropriationListBoxItem_OnSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateBocFilterBox(DataTable table, FlowLayoutPanel filterPanel)
        {
            try
            {
                PopulateFilterButtons(filterPanel, GetCodes(table, "BocName"));
                foreach (Control c in filterPanel.Controls) c.Click += BocButton_OnSelect;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateFilterButtons(Control panel, string[] list)
        {
            try
            {
                panel.Controls.Clear();
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
                    panel.Controls.Add(b);
                    panel.AutoSize = true;
                    b.Tag = f;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
        internal void PopulateFilterListItems(Control panel, string[] list)
        {
            try
            {
                var box = panel as ListBox;
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
        internal void ConfigureGridColumns(DataGridView dgv)
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
        internal void ReturnButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                Table = Data.QueryTable;
                BindingSource.DataSource = Table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }
    }
}