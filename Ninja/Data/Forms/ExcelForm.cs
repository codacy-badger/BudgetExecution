using System;
using Syncfusion.Windows.Forms.Spreadsheet;



namespace BudgetExecution
{
    public partial class ExcelForm : Syncfusion.Windows.Forms.MetroForm
    {
        public ExcelForm()
        {
            InitializeComponent();
            GetReport();
        }

        public DivisionAuthority Budget { get; set; }
        public Spreadsheet Report { get; set; }

        internal void GetReport()
        {
            Report = new Spreadsheet();
            Report.Open(@"D:\dev\database\BudgetControlTemplate.xlsx");
        }

        internal void GetReport(object sender, EventArgs e)
        {
            Report = new Spreadsheet();
            Report.Open(@"D:\dev\database\BudgetControlTemplate.xlsx");
        }

        private void splitContainerAdv1_Click(object sender, EventArgs e)
        {

        }

        private void spreadsheet1_Click(object sender, EventArgs e)
        {

        }
    }
}

