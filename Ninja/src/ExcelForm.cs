namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;

    public partial class ExcelForm : MetroForm
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

        private void AccountTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroSetTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroSetLabel12_Click(object sender, EventArgs e)
        {

        }

        private void calculatorControl1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void tabControlAdv2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

