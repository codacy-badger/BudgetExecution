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
            BindingSource = new BindingSource();
            BindingSource.DataSource = new DataBuilder(data.Source, Provider.SQLite);
            AccountNavigator.BindingSource = BindingSource;
        }

        public AccountManager(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(this.Source, this.Provider);
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbData.DbTable;
            AccountNavigator.BindingSource = BindingSource;
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
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            AccountNavigator.BindingSource = BindingSource;
            AddNewTab.TabVisible = false;
        }


        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; set; }

        public DataRow DbRow { get; }

        List<Label> Labels { get; set; }

        List<MetroSetTextBox> TextBoxes { get; set; }

        List<MetroSetComboBox> ComboBoxes { get; set; }

        FormData Ninja { get; set; }

        // METHODS

        private void AccountManager_Load(object sender, EventArgs e)
        {
            if (AddNewTab.TabVisible == true)
                AddButton.Visible = false;
            ConfigureTextBoxBindings();
        }

        private void ConfigureTextBoxBindings()
        {
            try
            {
                ID.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "ID"));
                BudgetLevel.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "BudgetLevel"));
                BFY.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "BFY"));
                Fund.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Fund"));
                Org.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Org"));
                RC.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "RC"));
                Code.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Code"));
                SubProject.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "SubProject"));
                BOC.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "BOC"));
                ProgramProject.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "ProgramProjectName"));
                ProgramArea.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "ProgramAreaName"));
                Amount1.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Amount"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }


        private void PopulateComboBoxes()
        {
            var data = new DataBuilder(Source, Provider);
            if(data.DbTable.Columns.Contains("SubProject"))
            {
                foreach (string p in data.ProgramElements["SubProject"])
                    ComboBox5.Items.Add(p);
            }
            foreach (string p in data.ProgramElements["Code"])
                ComboBox6.Items.Add(p);
            foreach (string p in data.ProgramElements["Fund"])
                ComboBox3.Items.Add(p);
            foreach (string p in data.ProgramElements["RC"])
                ComboBox8.Items.Add(p);
            foreach (string p in data.ProgramElements["Org"])
                ComboBox4.Items.Add(p);
            foreach (string p in data.ProgramElements["BOC"])
                ComboBox7.Items.Add(p);
        }

        private void PopuluateFundCodes()
        {
            try
            {
                var codes = Info.AgencyFundCodes;
                foreach (string c in codes)
                    ComboBox3.Items.Add(c);
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
            var addmanager = new AccountManager(Source.PRC, this.Provider);
            addmanager.AccountNavigator.Visible = false;
            addmanager.UpdateTab.TabVisible = false;
            addmanager.Show();
            this.Close();
        }

        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            this.BindingSource.MovePrevious();
        }

        private void NextButton_OnClick(object sender, EventArgs e)
        {
            this.BindingSource.MoveNext();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var addmanager = new AccountManager(this.Source, this.Provider);
            addmanager.AccountNavigator.Visible = false;
            addmanager.AddNewTab.TabVisible = false;
            addmanager.Show();
            this.Close();

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void CalculatorButton_Click(object sender, EventArgs e)
        {
            var cf = new CalculatorForm();
            cf.Show();
        }

    }
}