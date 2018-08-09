
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

    public partial class Reprogramming : MetroForm
    {
        // CONSTRUCTORS
        public Reprogramming()
        {
            InitializeComponent();
        }

        public Reprogramming(Source source, Provider provider)
        {
            InitializeComponent();
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
        private Source Source { get; }

        private Provider Provider { get; }

        internal DataFilter TableFilter { get; set; }

        internal DataBuilder DbData { get; set; }

        public Query DbQuery { get; }

        public DataTable DbTable { get; }

        public Dictionary<string, string[]> ProgramElements { get; }

        public string[] Columns { get; }

        public DataRow[] DbRow { get; }

        public BindingSource BindingSource { get; set; }

        // METHODS
        private void CalculatorButton_OnClick(object sender, EventArgs e)
        {
            var c = new CalculatorForm();
            c.Show();
        }

        private void Tab2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
