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
            Labels = GetLabels();
            ComboBoxes = GetComboBoxes();
        }

        public AccountManager(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            AccountBinding = DbData.BindingSource;
            AccountNavigator.BindingSource = AccountBinding;
            Labels = GetLabels();
            ComboBoxes = GetComboBoxes();
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

        // METHODS
        private void TabControlAdv1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

        private void Button5_Click(object sender, EventArgs e)
        {
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

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}