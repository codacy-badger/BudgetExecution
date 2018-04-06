using Syncfusion.Windows.Forms.Spreadsheet;
using System;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
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
            }
        }
    }
}