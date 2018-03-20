#region Using Directives

using Syncfusion.Windows.Forms.Spreadsheet;
using System;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class ExcelForm : Syncfusion.Windows.Forms.MetroForm
            {
                public Spreadsheet Report { get; set; }
                public DivisionAuthority Budget { get; set; }

                public ExcelForm( )
                {
                    InitializeComponent( );
                    GetReport( );
                }

                internal void GetReport( )
                {
                    Report = new Spreadsheet( );
                    Report.Open(@"D:\dev\database\BudgetControlTemplate.xlsx");
                }

                internal void GetReport(object sender, EventArgs e)
                {
                    Report = new Spreadsheet( );
                    Report.Open(@"D:\dev\database\BudgetControlTemplate.xlsx");
                }
            }
        }
    }
}