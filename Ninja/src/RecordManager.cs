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
            DbData = data;
            DbTable = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            BindTextBoxes(BindingSource, DbTable);
            RecordNavigator1.BindingSource = BindingSource;
            RecordNavigator1.BindingSource = BindingSource;
            RecordNavigator2.BindingSource = BindingSource;
            AddNewTab.TabVisible = false;
        }

        public RecordManager(Source source, Provider provider)
        {

            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            DbTable = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            BindTextBoxes(BindingSource, DbTable);
            RecordNavigator1.BindingSource = BindingSource;
            RecordNavigator2.BindingSource = BindingSource;
            AddNewTab.TabVisible = false;
        }

        public RecordManager(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            DbTable = DbData.GetDataTable();
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbTable;
            BindTextBoxes(BindingSource, DbTable);
            RecordNavigator1.BindingSource = BindingSource;
            RecordNavigator2.BindingSource = BindingSource;
            AddNewTab.TabVisible = false;
        }

        // PROPERTIES
        Source Source { get; set;}

        Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable DbTable { get; set; }

        public DataRow DbRow { get; set; }

        public Label[] Label { get; set; }

        public List<MetroSetComboBox> ComboBoxes { get; set; }

        public MetroSetTextBox[] Box { get; set; }


        // METHODS
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
                var  _ = new Error(ex).ShowDialog();
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
                var  _ = new Error(ex).ShowDialog();
            }

        }

        private Label[] GetLabels()
        {
            try
            {
                var label = new Label[]
                {
                    lbl0, lbl1, lbl2, lbl3, lbl4, lbl5, lbl6, lbl7, lbl8, lbl9, lbl10,
                    lbl11, lbl12, lbl13, lbl14, lbl15, lbl16, lbl17, lbl18, lbl19, lbl20,
                    lbl21, lbl22, lbl23, lbl24, lbl25, lbl26, lbl27, lbl28, lbl29
                };
                return label;
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        private MetroSetTextBox[] GetTextBoxes()
        {
            try
            {
                var box = new MetroSetTextBox[]
                {
                    box0, box1, box2, box3, box4, box5, box6, box7, box8, box9, box10,
                    box11, box12, box13, box14, box15, box16, box17, box18, box19, box20,
                    box21, box22, box23, box24, box25, box26, box27, box28, box29
                };
                return box;
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        private void BindTextBoxes(BindingSource bs, DataTable dt)
        {
            try
            {
                var lbl = GetLabels();
                foreach (Label l in lbl)
                    l.Visible = false;

                MetroSetTextBox[] tbx = GetTextBoxes();
                foreach (MetroSetTextBox tb in tbx)
                    tb.Visible = false;

                List<string> cn = new List<string>();
                foreach (DataColumn dc in dt.Columns)
                    cn.Add(dc.ColumnName);

                int current = bs.Position;
                for (int i = 0; i < cn.Count; i++)
                {
                    tbx[i].Visible = true;
                    tbx[i].DataBindings.Add(new Binding("Text", BindingSource.DataSource, dt.Columns[i].ColumnName));
                    lbl[i].Visible = true;
                    lbl[i].Text = dt.Columns[i].ColumnName;
                }

            }
            catch (Exception ex)
            {

                var  _ = new Error(ex).ShowDialog();
            }

        }

        private void BindTextBoxes(object sender, EventArgs e)
        {
            try
            {
                Label[] lbl = GetLabels();
                foreach (Label l in lbl)
                    l.Visible = false;

                MetroSetTextBox[] tbx = GetTextBoxes();
                foreach (MetroSetTextBox tb in tbx)
                    tb.Visible = false;

                List<string> cn = new List<string>();                    
                foreach (DataColumn dc in DbTable.Columns)
                    cn.Add(dc.ColumnName);

                var current = BindingSource.Position;
                for (int i = 0; i < cn.Count; i++)
                {
                    tbx[i].Visible = true;
                    tbx[i].DataBindings.Add(new Binding("Text", BindingSource.DataSource, cn[i]));
                    lbl[i].Visible = true;
                    lbl[i].Text = cn[i];
                }

            }
            catch (Exception ex)
            {

                var  _ = new Error(ex).ShowDialog();
            }
            
        }

        private List<MetroSetComboBox> GetComboBoxes()
        {
            try
            {
                List<MetroSetComboBox> labels = null;
                foreach (MetroSetComboBox lbl in RecordTabelPanel.Controls)
                    labels.Add(lbl);
                return labels;
            }
            catch (Exception ex)
            {
                var  _ = new Error(ex).ShowDialog();
                return null;
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
           
            BindingSource.MoveNext();
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            BindingSource.MovePrevious();
        }
    }
}