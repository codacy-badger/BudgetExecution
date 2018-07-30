// <copyright file="FormData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    public class FormData
    {
        // CONSTRUCTORS
        public FormData()
        {
        }

        public FormData(DataBuilder DbData, BindingSource bs, DataGridView dgv, BindingNavigator bn)
        {
            this.DbData = DbData;
            DbTable = this.DbData.DbTable;
            BindGridAndNavigator(DbTable, dgv, bs, bn);
            BindingSource = bs;
            this.Grid = dgv;
            BindingSource.DataSource = DbTable;
            BindingSource = DbData.BindingSource;
            BindingSource.DataSource = DbTable;
            this.Grid.DataSource = BindingSource.DataSource;
        }

        public FormData(Source source, Provider provider, Dictionary<string, object> param)
        {
            DbData = new DataBuilder(source, provider, param);
            DbTable = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
        }


        public FormData(Source source, Provider provider, Dictionary<string, object> param, BindingSource bs, DataGridView dgv, BindingNavigator bn)
        {
            DbData = new DataBuilder(source, provider, param);
            DbTable = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            BindGridAndNavigator(DbTable, dgv, bs, bn);
            BindingSource = bs;
            BindingSource.DataSource = DbTable;
            this.Grid = dgv;
            this.Grid.DataSource = BindingSource.DataSource;
        }

        // PROPERTIES
        public Stat Measure { get; set; }

        public ChartSeriesType ChartType { get; set; }

        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; set; }

        public BindingSource BindingSource { get; set; }

        public DataSet DataSet { get; set; }

        public DataTable DbTable { get; set; }

        public int Count { get; set; }

        public DataGridView Grid { get; set; }

        internal Func<DataTable, PrcField, string> TableFilter { get; set; }

        // METHODS

        private Dictionary<string, object> GetDataFields(DataTable table)
        {
            try
            {
                var cct = table.Columns.Count;
                var rct = table.Rows.Count;
                var row = table.Rows[0];
                var col = table.GetFields();
                var val = row.ItemArray;
                var param = new Dictionary<string, object>();
                for (int i = 0; i < cct; i++)
                    param.Add(col[i], val[i]);
                return param;
            }
            catch (Exception e)
            {
                var error = new Error(e).ShowDialog();
                return null;
            }
        }

        private void CreateTextBoxBindings(DataGridView dgv, MetroSetTextBox[] tbx)
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
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
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
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void CreateTextBoxDataBinding(BindingSource bs, TextBox tb, string field)
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
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void CreateTextBoxDataBinding(BindingSource bs, List<TextBox> tb)
        {
            try
            {
                var table = (DataTable)bs.DataSource;
                var field = table.GetFields();
                var row = table.Rows[bs.Position];
                Binding binding;
                for(int i = 0; i < tb.Count; i++)
                {
                    binding = new Binding("Text", row, field[i]);
                    tb[i].DataBindings.Add(binding);
                }
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void BocButton_OnSelect(object sender, EventArgs e)
        {
            var listbox = sender as Button;
            try
            {
                BindingSource.Filter = $"{listbox.Tag.ToString()} = '{listbox.Text}'";
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void ListBoxItem_OnSelect(object sender, EventArgs e)
        {
            var listbox = sender as ListBox;
            try
            {
                BindingSource.Filter = $"{listbox.Tag.ToString()} = '{listbox.SelectedItem.ToString()}'";
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterControlItems(DataTable table, Control filterControl, PrcField prc)
        {
            try
            {
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void PopulateFilterPanel(FlowLayoutPanel fitlerControl, string[] filter)
        {
            try
            {
                InitializeFilterButtons(fitlerControl, filter);
                foreach (Control c in fitlerControl.Controls)
                {
                    c.Click += BocButton_OnSelect;
                }
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void InitializeFilterButtons(Control control, string[] list)
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
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void PopulateListBoxItems(Control control, string[] list)
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
                var error = new Error(ex).ShowDialog();
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
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void ConfigureDataGridViewVisibleColumns(DataGridView dgv)
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
                var error = new Error(ex).ShowDialog();
            }
        }

        internal void ReturnButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                DbTable = DbData.DbTable;
                BindingSource.DataSource = DbTable;
            }
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
            }
        }

        internal Dictionary<string, object> GetCurrentRowDictionary(DataGridView dgv)
        {
            try
            {
                if (dgv.CurrentRow != null)
                {
                    var row = dgv.CurrentRow;
                    var data = new Dictionary<string, object>();
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
            catch (Exception ex)
            {
                var error = new Error(ex).ShowDialog();
                return null;
            }
        }

        internal decimal GetCount(DataTable table, PrcField column, string filter)
        {
            if(table.Columns.Contains("Amount"))
            {
                try
                {
                    return table.AsEnumerable().Where(p => p.Field<string>(column.ToString()).
                        Equals(filter)).Select(p => p.Field<decimal>("Amount") > 0).Count();
                }
                catch (Exception ex)
                {
                    var error = new Error(ex).ShowDialog();
                    return -1;
                }
            }
            return -1;
        }
    }
}