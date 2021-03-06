﻿// <copyright file="AccountManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="AccountManager" />
    /// </summary>
    public partial class AccountManager : MetroForm
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        public AccountManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="data">The data<see cref="DataBuilder"/></param>
        public AccountManager(DataBuilder data)
        {
            InitializeComponent();
            if(DbData == null)
            {
                DbData = data;
            }

            BindingSource = new BindingSource();
            BindingSource.DataSource = new DataBuilder(data.Source, Provider.SQLite);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        public AccountManager(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            ProgramElements = DbData.ProgramElements;
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbData.Table;
            BindComboBoex();
            Update.TabVisible = false;
            BFY = ProgramElements["BFY"];
            BudgetLevel = ProgramElements["BudgetLevel"];
            Org = ProgramElements["Org"];
            AH = ProgramElements["AH"];
            RC = ProgramElements["RC"];
            BOC = ProgramElements["BOC"];
            Code = ProgramElements["Code"];
            SubProject = ProgramElements["SubProject"];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AccountManager"/> class.
        /// </summary>
        /// <param name="source">The source<see cref="Source"/></param>
        /// <param name="provider">The provider<see cref="Provider"/></param>
        /// <param name="p">The p<see cref="Dictionary{string, object}"/></param>
        public AccountManager(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            ProgramElements = DbData.ProgramElements;
            Table = DbData.Table;
            DbRow = Table.Rows[0];
            BindingSource.DataSource = Table;
            Insert.TabVisible = false;
            BFY = ProgramElements["BFY"];
            BudgetLevel = ProgramElements["BudgetLevel"];
            Org = ProgramElements["Org"];
            AH = ProgramElements["AH"];
            RC = ProgramElements["RC"];
            BOC = ProgramElements["BOC"];
            Code = ProgramElements["Code"];
            SubProject = ProgramElements["SubProject"];
            PopulateComboBoxes();
        }

        // PROPERTIES
        /// <summary>
        /// Gets or sets the Source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the Provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the DbData
        /// </summary>
        public DataBuilder DbData { get; set; }

        /// <summary>
        /// Gets or sets the ProgramElements
        /// </summary>
        public Dictionary<string, string[]> ProgramElements { get; set; }

        /// <summary>
        /// Gets or sets the Table
        /// </summary>
        public DataTable Table { get; set; }

        /// <summary>
        /// Gets the DbRow
        /// </summary>
        public DataRow DbRow { get; }

        /// <summary>
        /// Gets or sets the Labels
        /// </summary>
        public List<Label> Labels { get; set; }

        /// <summary>
        /// Gets or sets the TextBoxes
        /// </summary>
        public List<MetroSetTextBox> TextBoxes { get; set; }

        /// <summary>
        /// Gets or sets the ComboBoxes
        /// </summary>
        public List<MetroSetComboBox> ComboBoxes { get; set; }

        /// <summary>
        /// Gets or sets the Ninja
        /// </summary>
        public FormData Ninja { get; set; }

        /// <summary>
        /// Gets or sets the BudgetLevel
        /// </summary>
        public string[] BudgetLevel { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        public string[] BFY { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        public string[] Org { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        public string[] RC { get; set; }

        /// <summary>
        /// Gets or sets the AH
        /// </summary>
        public string[] AH { get; set; }

        /// <summary>
        /// Gets or sets the Code
        /// </summary>
        public string[] Code { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        public string[] BOC { get; set; }

        /// <summary>
        /// Gets or sets the Fund
        /// </summary>
        public string[] Fund { get; set; }

        /// <summary>
        /// Gets or sets the SubProject
        /// </summary>
        public string[] SubProject { get; set; }

        // METHODS
        /// <summary>
        /// The ConfigureGridVisibleColumns
        /// </summary>
        /// <param name="dgv">The dgv<see cref="DataGridView"/></param>
        internal void ConfigureGridVisibleColumns(DataGridView dgv)
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

        /// <summary>
        /// The BindGridAndNavigator
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <param name="dg">The dg<see cref="DataGridView"/></param>
        /// <param name="bs">The bs<see cref="BindingSource"/></param>
        /// <param name="bn">The bn<see cref="BindingNavigator"/></param>
        internal void BindGridAndNavigator(DataTable table, DataGridView dg, BindingSource bs, BindingNavigator bn)
        {
            try
            {
                bs.DataSource = table;
                dg.DataSource = bs;
                bn.BindingSource = bs;
                ConfigureGridVisibleColumns(dg);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The GetCurrentRowDictionary
        /// </summary>
        /// <param name="bs">The bs<see cref="BindingSource"/></param>
        /// <returns>The <see cref="Dictionary{string, object}"/></returns>
        internal Dictionary<string, object> GetCurrentRowDictionary(BindingSource bs)
        {
            if(bs.DataSource != null)
            {
                try
                {
                    DataRow row = (DataRow) bs.Current;
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(row["ID"].ToString()));
                    data.Add("AH", row["AH"].ToString());
                    data.Add("Org", row["Org"].ToString());
                    data.Add("RC", row["RC"].ToString());
                    data.Add("Code", row["Code"].ToString());
                    data.Add("BOC", row["BOC"].ToString());
                    return data;
                }
                catch(Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        /// <summary>
        /// The AccountManager_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void AccountManager_Load(object sender, EventArgs e)
        {
            ConfigureTextBoxBindings();
        }

        /// <summary>
        /// The ConfigureTextBoxBindings
        /// </summary>
        private void ConfigureTextBoxBindings()
        {
            try
            {
                UpdateID.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "PrcID"));
                UpdateLevel.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "BudgetLevel"));
                UpdateYear.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "BFY"));
                UpdateFund.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Fund"));
                UpdateAh.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Org"));
                UpdateRc.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "RC"));
                UpdateCode.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Code"));
                UpdateSubProject.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "SubProject"));
                UpdateBoc.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "BOC"));
                UpdateProgramProject.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "ProgramProjectName"));
                UpdateProgramArea.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "ProgramAreaName"));
                UpdateAmount.DataBindings.Add(new Binding("Text", BindingSource.DataSource, "Amount"));
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The BindComboBoex
        /// </summary>
        internal void BindComboBoex()
        {
            try
            {
                AddSubProject.DataSource = BindingSource;
                AddSubProject.DisplayMember = "SubProject";
                AddLevel.DataSource = BindingSource;
                AddLevel.DisplayMember = "BudgetLevel";
                AddBoc.DataSource = BindingSource;
                AddBoc.DisplayMember = "BOC";
                AddRc.DataSource = BindingSource;
                AddRc.DisplayMember = "RC";
                AddAh.DataSource = BindingSource;
                AddAh.DisplayMember = "AH";
                AddCode.DataSource = BindingSource;
                AddCode.DisplayMember = "Code";
                AddOrg.DataSource = BindingSource;
                AddOrg.DisplayMember = "Org";
                AddYear.DataSource = BindingSource;
                AddYear.DisplayMember = "BFY";
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        /// <summary>
        /// The PopulateComboBoxes
        /// </summary>
        internal void PopulateComboBoxes()
        {
            foreach(string s in SubProject)
            {
                AddSubProject.Items.Add(s);
            }

            foreach(string c in Code)
            {
                AddCode.Items.Add(c);
            }

            foreach(string f in Fund)
            {
                AddFund.Items.Add(f);
            }

            foreach(string r in RC)
            {
                AddRc.Items.Add(r);
            }

            foreach(string o in Org)
            {
                AddOrg.Items.Add(o);
            }

            foreach(string a in AH)
            {
                AddAh.Items.Add(a);
            }

            foreach(string b in BOC)
            {
                AddBoc.Items.Add(b);
            }
        }

        /// <summary>
        /// The PopuluateFundCodes
        /// </summary>
        private void PopuluateFundCodes()
        {
            try
            {
                string[] codes = Info.AgencyFundCodes;
                foreach(string c in codes)
                {
                    AddFund.Items.Add(c);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        /// <summary>
        /// The GetLabels
        /// </summary>
        /// <param name="gbo">The gbo<see cref="GroupBox"/></param>
        /// <returns>The <see cref="List{Label}"/></returns>
        private List<Label> GetLabels(GroupBox gbo)
        {
            try
            {
                List<Label> lblList = null;
                foreach(Label lbl in gbo.Controls)
                {
                    lblList.Add(lbl);
                }

                return lblList;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetComboBoxes
        /// </summary>
        /// <param name="gbo">The gbo<see cref="GroupBox"/></param>
        /// <returns>The <see cref="List{MetroSetComboBox}"/></returns>
        private List<MetroSetComboBox> GetComboBoxes(GroupBox gbo)
        {
            try
            {
                List<MetroSetComboBox> cboList = new List<MetroSetComboBox>();
                foreach(MetroSetComboBox cbo in gbo.Controls)
                {
                    cboList.Add(cbo);
                }

                return cboList;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetLabels
        /// </summary>
        /// <returns>The <see cref="List{Label}"/></returns>
        private List<Label> GetLabels()
        {
            try
            {
                List<Label> labels = new List<Label>();
                foreach(Label lbl in RecorDataGroupBox.Controls)
                {
                    labels.Add(lbl);
                }

                return labels;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetComboBoxes
        /// </summary>
        /// <returns>The <see cref="List{MetroSetComboBox}"/></returns>
        private List<MetroSetComboBox> GetComboBoxes()
        {
            try
            {
                List<MetroSetComboBox> labels = null;
                foreach(MetroSetComboBox lbl in RecorDataGroupBox.Controls)
                {
                    labels.Add(lbl);
                }

                return labels;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetDataFields
        /// </summary>
        /// <param name="table">The table<see cref="DataTable"/></param>
        /// <returns>The <see cref="Dictionary{string, object}"/></returns>
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

        /// <summary>
        /// The CalculatorButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        /// <summary>
        /// The ExcelButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelData ef = new ExcelData();
            ef.Show();
        }

        /// <summary>
        /// The ReprogrammingButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void ReprogrammingButton_OnClick(object sender, EventArgs e)
        {
            Reprogramming rf = new Reprogramming();
            rf.Show();
        }

        /// <summary>
        /// The PreviousButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void PreviousButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        /// <summary>
        /// The NextButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void NextButton_OnClick(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        /// <summary>
        /// The AddButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
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

        /// <summary>
        /// The RefreshButton_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void RefreshButton_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The CopyButton_OnClick
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
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

        /// <summary>
        /// The AccountTabControl_SelectedIndexChanged
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void AccountTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// The PopulateComboBox
        /// </summary>
        /// <param name="comboBox">The comboBox<see cref="ComboBox"/></param>
        /// <param name="list">The list<see cref="string[]"/></param>
        internal void PopulateComboBox(ComboBox comboBox, string[] list)
        {
            try
            {
                foreach(string s in list)
                {
                    comboBox.Items.Add(s);
                }
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
