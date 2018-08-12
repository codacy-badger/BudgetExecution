
namespace BudgetExecution
{
    using Syncfusion.Windows;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.SQLite;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// class Reprogramming
    /// </summary>
    public partial class Reprogramming : MetroForm
    {
        // CONSTRUCTORS
        public Reprogramming()
        {
           this.InitializeComponent();
        }

        public Reprogramming(Source source, Provider provider)
        {
            this.InitializeComponent();
            Source = source;
            Provider = provider;
            DbQuery = new Query(Source, Provider);
            DbData = new DataBuilder(DbQuery);
            DbTable = DbData.DbTable;
            DbRow = DbData.DbRow;
            ProgramElements = DbData.GetProgramElements(DbTable);
            Columns = DbData.Columns;
            BindingSource = new BindingSource();
            TableFilter = Info.FilterRows;
        }


        // PROPERTIES

        public Query DbQuery { get; }

        public DataTable DbTable { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public string[] Columns { get; }

        public DataRow[] DbRow { get; }

        public BindingSource BindingSource { get; set; }

        internal DataFilter TableFilter { get; set; }

        internal DataBuilder DbData { get; set; }

        private Source Source { get; }

        private Provider Provider { get; }

        // METHODS        
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
