


namespace BudgetExecution
{
    using System;
    using System.Data;

    public partial class ExcelImporter : Syncfusion.Windows.Forms.MetroForm
    {
        public ExcelImporter()
        {
            InitializeComponent();
            DataFilterTab.TabVisible = false;
        }

        public ExcelImporter(Source source)
        {
            InitializeComponent();
            DataFilterTab.TabVisible = false;
            Source = source;
            Provider = Provider.OleDb;
        }

        public ExcelImporter(Source source, Provider provider)
        {
            InitializeComponent();
            DataFilterTab.TabVisible = false;
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
    }
}
