namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    using MetroSet_UI.Controls;

    using Syncfusion.Windows.Forms;

    public partial class AccountManager : MetroForm
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
            {
                DbData = data;
            }

            BindingSource = new BindingSource();
            BindingSource.DataSource = new DataBuilder(data.Source, Provider.SQLite);
            AccountNavigator.BindingSource = BindingSource;
        }

        public AccountManager(Source source, Provider provider)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider);
            BindingSource = new BindingSource();
            BindingSource.DataSource = DbData.DbTable;
            AccountNavigator.BindingSource = BindingSource;
            Update.TabVisible = false;
            PopulateComboBoxes();
        }

        public AccountManager(Source source, Provider provider, Dictionary<string, object> p)
        {
            InitializeComponent();
            Source = source;
            Provider = provider;
            DbData = new DataBuilder(Source, Provider, p);
            Table = DbData.DbTable;
            DbRow = Table.Rows[0];
            BindingSource.DataSource = Table;
            AccountNavigator.Visible = false;
            Insert.TabVisible = false;
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable Table { get; set; }

        public DataRow DbRow { get; }

        public List<Label> Labels { get; set; }

        public List<MetroSetTextBox> TextBoxes { get; set; }

        public List<MetroSetComboBox> ComboBoxes { get; set; }

        public FormData Ninja { get; set; }

        // METHODS
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
                new Error(ex).ShowDialog();
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
                new Error(ex).ShowDialog();
            }
        }

        internal Dictionary<string, object> GetCurrentRowDictionary(BindingSource bs)
        {
            if (bs.DataSource != null)
            {
                try
                {
                    DataRow row = (DataRow)bs.Current;
                    Dictionary<string, object> data = new Dictionary<string, object>();
                    data.Add("ID", int.Parse(row["ID"].ToString()));
                    data.Add("AH", row["AH"].ToString());
                    data.Add("Org", row["Org"].ToString());
                    data.Add("RC", row["RC"].ToString());
                    data.Add("Code", row["Code"].ToString());
                    data.Add("BOC", row["BOC"].ToString());
                    return data;
                }
                catch (Exception ex)
                {
                    new Error(ex).ShowDialog();
                    return null;
                }
            }

            return null;
        }

        private void AccountManager_Load(object sender, EventArgs e)
        {
            if (Insert.TabVisible)
            {
                AddButton.Visible = false;
            }

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
                new Error(ex).ShowDialog();
            }
        }

        private void PopulateComboBoxes()
        {
            DataBuilder data = new DataBuilder(Source, Provider);
            if (data.DbTable.Columns.Contains("SubProject"))
            {
                foreach (string p in data.ProgramElements["SubProject"])
                {
                    ComboBox5.Items.Add(p);
                }
            }

            foreach (string p in data.ProgramElements["Code"])
            {
                ComboBox6.Items.Add(p);
            }

            foreach (string p in data.ProgramElements["Fund"])
            {
                ComboBox3.Items.Add(p);
            }

            foreach (string p in data.ProgramElements["RC"])
            {
                ComboBox8.Items.Add(p);
            }

            foreach (string p in data.ProgramElements["Org"])
            {
                ComboBox4.Items.Add(p);
            }

            foreach (string p in data.ProgramElements["BOC"])
            {
                ComboBox7.Items.Add(p);
            }
        }

        private void PopuluateFundCodes()
        {
            try
            {
                string[] codes = Info.AgencyFundCodes;
                foreach (string c in codes)
                {
                    ComboBox3.Items.Add(c);
                }
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private List<Label> GetLabels(GroupBox gbo)
        {
            try
            {
                List<Label> lblList = null;
                foreach (Label lbl in gbo.Controls)
                {
                    lblList.Add(lbl);
                }

                return lblList;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private List<MetroSetComboBox> GetComboBoxes(GroupBox gbo)
        {
            try
            {
                List<MetroSetComboBox> cboList = new List<MetroSetComboBox>();
                foreach (MetroSetComboBox cbo in gbo.Controls)
                {
                    cboList.Add(cbo);
                }

                return cboList;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private List<Label> GetLabels()
        {
            try
            {
                List<Label> labels = new List<Label>();
                foreach (Label lbl in RecorDataGroupBox.Controls)
                {
                    labels.Add(lbl);
                }

                return labels;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private List<MetroSetComboBox> GetComboBoxes()
        {
            try
            {
                List<MetroSetComboBox> labels = null;
                foreach (MetroSetComboBox lbl in RecorDataGroupBox.Controls)
                {
                    labels.Add(lbl);
                }

                return labels;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        private Dictionary<string, object> GetDataFields(DataTable table)
        {
            try
            {
                int cct = table.Columns.Count;
                int rct = table.Rows.Count;
                DataRow row = table.Rows[0];
                string[] col = table.GetFields();
                object[] val = row.ItemArray;
                Dictionary<string, object> param = new Dictionary<string, object>();
                for (int i = 0; i < cct; i++)
                {
                    param.Add(col[i], val[i]);
                }

                return param;
            }
            catch (Exception e)
            {
                new Error(e).ShowDialog();
                return null;
            }
        }

        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelImporter ef = new ExcelImporter();
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
            catch (Exception ex)
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
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}