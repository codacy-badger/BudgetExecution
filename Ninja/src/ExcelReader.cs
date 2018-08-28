


namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    public partial class ExcelReader : Syncfusion.Windows.Forms.MetroForm
    {
        public ExcelReader()
        {
            InitializeComponent();
            FilterTab.TabVisible = false;
        }

        public ExcelReader(Source source)
        {
            InitializeComponent();
            FilterTab.TabVisible = false;
            Source = source;
            Provider = Provider.OleDb;
        }

        public ExcelReader(Source source, Provider provider)
        {
            InitializeComponent();
            FilterTab.TabVisible = false;
            Source = source;
            Provider = provider;
        }

        // PROPERTIES 
        public Source Source { get; set; }

        public Provider Provider { get; set; }

        public DataBuilder DbData { get; set; }

        public DataTable Table { get; set; }

        // METHODS
        private void ExcelImporter_Load(object sender, EventArgs e)
        {
        }

        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            CalculatorForm cf = new CalculatorForm();
            cf.ShowDialog();
        }

        private void ExcelButton_OnClick(object sender, EventArgs e)
        {
            ExcelReader ef = new ExcelReader();
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

        private void FilterButton_OnClick(object sender, EventArgs e)
        {
            try
            {
                FilterTab.TabVisible = true;
                FunctionTab.TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        private void FunctionButton_OnClick(object sender, EventArgs e)
        {
            try
            {               
                FunctionTab.TabVisible = true;
                FilterTab.TabVisible = false;
            }
            catch (Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
