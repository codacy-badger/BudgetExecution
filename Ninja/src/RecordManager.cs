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

    public partial class RecordManager : Syncfusion.Windows.Forms.MetroForm
    {
        // CONSTRUCTORS
        public RecordManager()
        {
            InitializeComponent();
        }


        public RecordManager(DataBuilder data)
        {
            InitializeComponent();
            if (DbData == null)
                DbData = data;
            AccountBinding = DbData.BindingSource;
            Labels = GetLabels();
            ComboBoxes = GetComboBoxes();
        }

        public RecordManager(Source source, Provider provider)
        {

            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            DbTable = DbData.DbTable;
            DbRow = DbTable.AsEnumerable().Select(prc => prc).First();
            BindingSource = DbData.BindingSource;
            BindingSource.DataSource = DbTable;
            RecordNavigator.BindingSource = BindingSource;
            AddNewTab.TabVisible = false;
        }

        public RecordManager(Source source, Provider provider, Dictionary<string, object> p)
        {

            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            DbTable = DbData.DbTable;
            DbRow = DbTable.AsEnumerable().Select(prc => prc).First();
            BindingSource = DbData.BindingSource;
            BindingSource.DataSource = DbTable;
            RecordNavigator.BindingSource = BindingSource;
            AddNewTab.TabVisible = false;
        }

        // PROPERTIES
        Source Source { get; set;}
        Provider Provider { get; set; }
        DataBuilder DbData { get; set; }
        DataTable DbTable { get; set; }
        DataRow DbRow { get; set; }
        BindingSource AccountBinding { get; set; }
        Label[] Labels { get; set; }
        List<MetroSetComboBox> ComboBoxes { get; set; }

        private void PopuluateFundCodes(MetroSetComboBox FundComboBox)
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

        private void Button5_Click(object sender, EventArgs e)
        {
        }

        private Label[] GetLabels()
        {
            try
            {
                var label = new Label[]
                {
                    lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10,
                    lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20,
                    lbl21, lbl22, lbl23, lbl24
                };
                return label;
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

        private void lbl14_Click(object sender, EventArgs e)
        {

        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            BindingSource.MoveNext();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}