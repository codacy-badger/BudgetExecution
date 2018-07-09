
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class PdfDataReader : Syncfusion.Windows.Forms.MetroForm
    {
        public PdfDataReader()
        {
            InitializeComponent();
            DataFilterTab.TabVisible = false;
        }
    }
}
