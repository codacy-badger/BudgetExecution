// <copyright file="PrcAccountManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;

    public partial class AccountManager : Syncfusion.Windows.Forms.MetroForm
    {
        // CONSTRUCTORS
        public AccountManager()
        {
            InitializeComponent();
        }


        public AccountManager(DataBuilder data)
        {
            InitializeComponent();
            if (DbData == null)
                DbData = data;
            AccountBinding = DbData.BindingSource;
            AccountNavigator.BindingSource = AccountBinding;
        }

        public AccountManager(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            AccountBinding = DbData.BindingSource;
            AccountNavigator.BindingSource = AccountBinding;
            UpdateTab.TabVisible = false;
        }

        public AccountManager(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            AccountBinding = DbData.BindingSource;
            AccountNavigator.BindingSource = AccountBinding;
            AddNewTab.TabVisible = false;
        }


        // PROPERTIES
        Source Source { get; }

        Provider Provider { get; }

        DataBuilder DbData { get; }

        DataTable DbTable { get; set; }

        DataRow DbRow { get; }

        BindingSource AccountBinding { get; set; }

        List<Label> Labels { get; set; }

        List<MetroSetTextBox> TextBoxes { get; set; }

        List<MetroSetComboBox> ComboBoxes { get; set; }

        FormData Ninja { get; set; }

        // METHODS

        private void PopuluateFundCodes()
        {
            try
            {
                var codes = Info.AgencyFundCodes;
                foreach (string c in codes)
                    FundComboBox.Items.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PopuluateBocCodes(MetroSetComboBox BocBox)
        {
            try
            {
                var codes = new string[] { "10", "17", "21", "28", "36", "37", "38", "41" };
                foreach (string c in codes)
                    BocBox.Items.Add(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private List<Label> GetLabels(GroupBox gbo)
        {
            try
            {
                List<Label> lblList = null;
                foreach (Label lbl in gbo.Controls)
                    lblList.Add(lbl);
                return lblList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        private List<MetroSetComboBox> GetComboBoxes(GroupBox gbo)
        {
            try
            {
                List<MetroSetComboBox> cboList = null;
                foreach (MetroSetComboBox cbo in gbo.Controls)
                    cboList.Add(cbo);
                return cboList;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        private List<Label> GetLabels()
        {
            try
            {
                List<Label> labels = null;
                foreach (Label lbl in RecorDataGroupBox.Controls)
                    labels.Add(lbl);
                return labels;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

        private List<MetroSetComboBox> GetComboBoxes()
        {
            try
            {
                List<MetroSetComboBox> labels = null;
                foreach (MetroSetComboBox lbl in RecorDataGroupBox.Controls)
                    labels.Add(lbl);
                return labels;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }

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
                MessageBox.Show(e.Message + e.StackTrace);
                return null;
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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
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
                MessageBox.Show(ex.Message.ToString() + ex.StackTrace.ToString());
            }
        }

        internal Dictionary<string, object> GetCurrentRowDictionary(BindingSource bs)
        {
            if (bs.DataSource != null)
            {
                try
                {
                    var row = (DataRow)bs.Current;
                    var data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(row["ID"].ToString()));
                    data.Add("BudgetLevel", row["BudgetLevel"].ToString());
                    data.Add("Org", row["Org"].ToString());
                    data.Add("RC", row["RC"].ToString());
                    data.Add("Code", row["Code"].ToString());
                    data.Add("BOC", row["BOC"].ToString());
                    return data;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                    return null;
                }
            }
            return null;
        }

    }
}