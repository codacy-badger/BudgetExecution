// <copyright file="PrcAccountManager.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;

    public partial class NewPrcAccountManager : Syncfusion.Windows.Forms.MetroForm
    {
        // CONSTRUCTORS
        public NewPrcAccountManager()
        {
            InitializeComponent();
        }


        public NewPrcAccountManager(DataBuilder data)
        {
            InitializeComponent();
            if (DbData == null)
                DbData = data;
            AccountBinding = DbData.BindingSource;
            Labels = GetLabels();
            ComboBoxes = GetComboBoxes();
        }

        // PROPERTIES
        DataBuilder DbData { get; set; }
        BindingSource AccountBinding { get; set; }
        List<Label> Labels { get; set; }
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

        private void PopuluateBocCodes()
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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}