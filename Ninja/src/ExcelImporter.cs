


namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Text;
    using System.Windows.Forms;

    public partial class ExcelImporter : Syncfusion.Windows.Forms.MetroForm
    {
        public ExcelImporter()
        {
            InitializeComponent();
            DataFilterTab.TabVisible = false;
        }

        private void ExcelImporter_Load(object sender, EventArgs e)
        {

        }
    }
}
