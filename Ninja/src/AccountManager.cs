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
            if(DbData == null)
            {
                DbData = data;
            }

            BindingSource = new BindingSource();
            BindingSource.DataSource = new DataBuilder(data.Source, Provider.SQLite);
        }

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
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public Dictionary<string, string[]> ProgramElements { get; set; }

        public DataTable Table { get; set; }

        public DataRow DbRow { get; }

        public List<Label> Labels { get; set; }

        public List<MetroSetTextBox> TextBoxes { get; set; }

        public List<MetroSetComboBox> ComboBoxes { get; set; }

        public FormData Ninja { get; set; }

        public string[] BudgetLevel { get; set; }

        public string[] BFY { get; set; }

        public string[] Org { get; set; }

        public string[] RC { get; set; }

        public string[] AH { get; set; }

        public string[] Code { get; set; }

        public string[] BOC { get; set; }

        public string[] Fund { get; set; }

        public string[] SubProject { get; set; }

        // METHODS
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

        private void AccountManager_Load(object sender, EventArgs e)
        {
            ConfigureTextBoxBindings();
        }

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

        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelDataReader ef = new ExcelDataReader();
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
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e) { }

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

        private void AccountTabControl_SelectedIndexChanged(object sender, EventArgs e) { }

        internal void PopulateComboBox(ComboBox comboBox, string[] list)
        {
            try
            {
                foreach(var s in list)
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
