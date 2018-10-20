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

namespace BudgetExecution
{
    public class FormData
    {
        // CONSTRUCTORS
        public FormData()
        {
        }

        public FormData(DataBuilder data, BindingSource bs, DataGridView dgv, BindingNavigator bn)
        {
            DbData = data;
            Table = DbData.Table;
            BindGridAndNavigator(Table, dgv, bs, bn);
            BindingSource = bs;
            Grid = dgv;
            BindingSource.DataSource = Table;
            Grid.DataSource = BindingSource.DataSource;
        }

        public FormData(Source source, Provider provider)
        {
            DbData = new DataBuilder(source, provider);
            Table = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
        }

        public FormData(Source source, Provider provider, Dictionary<string, object> param)
        {
            DbData = new DataBuilder(source, provider, param);
            Table = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
        }

        public FormData(Source source, Provider provider, Dictionary<string, object> param, BindingSource bs, DataGridView dgv, BindingNavigator bn)
        {
            DbData = new DataBuilder(source, provider, param);
            Table = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = Table;
            BindGridAndNavigator(Table, dgv, bs, bn);
            BindingSource = bs;
            BindingSource.DataSource = Table;
            Grid = dgv;
            Grid.DataSource = BindingSource.DataSource;
        }

        // PROPERTIES
        public Stat Measure { get; set; }

        public ChartSeriesType ChartType { get; set; }

        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; set; }

        public BindingSource BindingSource { get; set; }

        public DataSet DataSet { get; set; }

        public DataTable Table { get; set; }

        public int Count { get; set; }

        public DataGridView Grid { get; set; }

        internal DataFilter TableFilter { get; set; }

        // METHODS
        public List<SQLiteParameter[]> GetParamList(DataTable table)
        {
            try
            {
                List<SQLiteParameter[]> paramlist = new List<SQLiteParameter[]>();
                foreach(DataRow row in table.Rows)
                {
                    paramlist.Add(GetParamArray(row));
                }

                return paramlist;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal void BindGridAndNavigator(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
        {
            try
            {
                bs.DataSource = table;
                dg.DataSource = bs;
                bn.BindingSource = bs;
                ConfigureDataGridViewVisibleColumns(dg);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void CreateTextBoxDataBinding(BindingSource bs, TextBox tb, string field)
        {
            try
            {
                DataTable table = (DataTable) bs.DataSource;
                DataRow row = table.Rows[bs.Position];
                Binding binding = new Binding("Text", row, field);
                tb.DataBindings.Add(binding);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void CreateTextBoxDataBinding(BindingSource bs, List<TextBox> tb)
        {
            try
            {
                DataTable table = (DataTable) bs.DataSource;
                string[] field = table.GetColumnNames();
                DataRow row = table.Rows[bs.Position];
                for(int i = 0; i < tb.Count; i++)
                {
                    tb[i].DataBindings.Add(new Binding("Text", row, field[i]));
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void BocButton_OnSelect(MetroSetComboBox mscb)
        {
            try
            {
                BindingSource.Filter = $"{mscb.Tag} = '{mscb.SelectedItem}'";
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void ListBoxItem_OnSelect(object sender, EventArgs e)
        {
            ListBox listbox = sender as ListBox;
            try
            {
                if(listbox != null)
                {
                    BindingSource.Filter = $"{listbox.Tag} = '{listbox.SelectedItem}'";
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterControlItems(DataTable table, Control filterControl, Field prc)
        {
            try
            {
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterPanel(FlowLayoutPanel fitlerControl, string[] filter)
        {
            try
            {
                InitializeFilterButtons(fitlerControl, filter);
                foreach(MetroSetComboBox c in fitlerControl.Controls)
                {
                    MetroSetButton msb = new MetroSetButton();
                    InitializeFilterButtons(msb, filter);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void InitializeFilterButtons(Control control, string[] list)
        {
            try
            {
                control.Controls.Clear();
                foreach(string f in list)
                {
                    MetroSetButton b = new MetroSetButton();
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void PopulateListBoxItems(Control control, string[] list)
        {
            try
            {
                ListBox box = control as ListBox;
                box.Controls.Clear();
                foreach(string f in list)
                {
                    box.Items.Add(f);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void ConfigureDataGridViewVisibleColumns(DataGridView dgv)
        {
            try
            {
                foreach(DataGridViewColumn dc in dgv.Columns)
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal void ReturnButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                Table = DbData.Table;
                BindingSource.DataSource = Table;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        internal Dictionary<string, object> GetCurrentRowDictionary(DataGridView dgv)
        {
            try
            {
                if(dgv.CurrentRow != null)
                {
                    DataGridViewRow row = dgv.CurrentRow;
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(row.Cells["ID"].Value.ToString()));
                    data.Add("BudgetLevel", row.Cells["BudgetLevel"].Value.ToString());
                    data.Add("Org", row.Cells["Org"].Value.ToString());
                    data.Add("RC", row.Cells["RC"].ToString());
                    data.Add("Code", row.Cells["Code"].ToString());
                    data.Add("BOC", row.Cells["BOC"].ToString());
                    return data;
                }

                return null;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal decimal GetCount(DataTable table, Field column, string filter)
        {
            if(table.Columns.Contains("Amount"))
            {
                try
                {
                    return table.AsEnumerable().Where(p => p.Field<string>(column.ToString()).Equals(filter)).Select(p => p.Field<decimal>("Amount") > 0).Count();
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return-1;
                }
            }

            return-1;
        }

        private Dictionary<string, object> GetDataFields(DataTable table)
        {
            try
            {
                int cct = table.Columns.Count;
                int rct = table.Rows.Count;
                DataRow row = table.Rows[0];
                string[] col = table.GetColumnNames();
                object[] val = row.ItemArray;
                Dictionary<string, object> param = new Dictionary<string, object>();
                for(int i = 0; i < cct; i++)
                {
                    param.Add(col[i], val[i]);
                }

                return param;
            }
            catch(Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        private SQLiteParameter[] GetParamArray(DataRow row)
        {
            try
            {
                DataColumnCollection cols = row.Table.Columns;
                object[] item = row.ItemArray;
                SQLiteParameter[] param = new SQLiteParameter[row.ItemArray.Length];
                for(int i = 0; i < row.ItemArray.Length; i++)
                {
                    param[i] = new SQLiteParameter(cols[i].ColumnName, item[i]);
                }

                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private void CreateTextBoxPrcBindings(DataGridView dgv, TextBox[] tbx)
        {
            try
            {
                tbx[0].DataBindings.Add(new Binding("Text", dgv.DataSource, "ID"));
                tbx[1].DataBindings.Add(new Binding("Text", dgv.DataSource, "BudgetLevel"));
                tbx[2].DataBindings.Add(new Binding("Text", dgv.DataSource, "BFY"));
                tbx[3].DataBindings.Add(new Binding("Text", dgv.DataSource, "Fund"));
                tbx[4].DataBindings.Add(new Binding("Text", dgv.DataSource, "Org"));
                tbx[5].DataBindings.Add(new Binding("Text", dgv.DataSource, "RC"));
                tbx[6].DataBindings.Add(new Binding("Text", dgv.DataSource, "Code"));
                tbx[7].DataBindings.Add(new Binding("Text", dgv.DataSource, "BOC"));
                tbx[8].DataBindings.Add(new Binding("Text", dgv.DataSource, "Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelData ef = new ExcelData();
            ef.Show();
        }

        private void ReprogrammingButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rf = new Reprogramming();
            rf.Show();
        }

        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        private void AddButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                RecordManager am = new RecordManager(Source, Provider);
                am.Show();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
        }

        private void CopyButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                RecordManager am = new RecordManager(Source, Provider);
                am.Show();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
