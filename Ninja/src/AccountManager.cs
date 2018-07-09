// <copyright file="PrcAccountManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
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
            PopulateComboBoxes();
        }

        public AccountManager(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            DbTable = DbData.DbTable;
            DbRow = DbTable.AsEnumerable().Select(prc => prc).First();
            AccountBinding = DbData.BindingSource;
            AccountNavigator.BindingSource = AccountBinding;
            AddNewTab.TabVisible = false;
            ConfigureTextBoxBindings();
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

        private void AccountManager_Load(object sender, EventArgs e)
        {
            if (AddNewTab.TabVisible == true)
                AddButton.Visible = false;
            AddButton.Click += AddButton_OnClick;
            PreviousButton.Click += PreviousButton_Click;
            NextButton.Click += NextButton_Click;
        }

        private void ConfigureTextBoxBindings()
        {
            try
            {
                ID.DataBindings.Add(new Binding("Text", DbTable, "ID"));
                BudgetLevel.DataBindings.Add(new Binding("Text", DbTable, "BudgetLevel"));
                BFY.DataBindings.Add(new Binding("Text", DbTable, "BFY"));
                Fund.DataBindings.Add(new Binding("Text", DbTable, "Fund"));
                Org.DataBindings.Add(new Binding("Text", DbTable, "Org"));
                RC.DataBindings.Add(new Binding("Text", DbTable, "RC"));
                Code.DataBindings.Add(new Binding("Text", DbTable, "Code"));
                SubProject.DataBindings.Add(new Binding("Text", DbTable, "SubProject"));
                BOC.DataBindings.Add(new Binding("Text", DbTable, "BOC"));
                ProgramProject.DataBindings.Add(new Binding("Text", DbTable, "ProgramProjectName"));
                ProgramArea.DataBindings.Add(new Binding("Text", DbTable, "ProgramAreaName"));
                Amount1.DataBindings.Add(new Binding("Text", DbTable, "Amount"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void PopulateComboBoxes()
        {
            var data = new DataBuilder(Source, Provider);
            foreach (string p in data.ProgramElements["SubProject"])
                SubProjectComboBox.Items.Add(p);
            foreach (string p in data.ProgramElements["Code"])
                CodeComboBox.Items.Add(p);
            foreach (string p in data.ProgramElements["Fund"])
                FundComboBox.Items.Add(p);
            foreach (string p in data.ProgramElements["RC"])
                RcComboBox.Items.Add(p);
            foreach (string p in data.ProgramElements["Org"])
                OrgComboBox.Items.Add(p);
            foreach (string p in data.ProgramElements["BOC"])
                BocComboBox.Items.Add(p);
        }

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

        private void AddButton_OnClick(object sender, EventArgs e)
        {

        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            DbData.BindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            DbData.BindingSource.MoveNext();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var addmanager = new AccountManager(this.Source, this.Provider);
            addmanager.Show();
            this.Close();

        }

    }
}