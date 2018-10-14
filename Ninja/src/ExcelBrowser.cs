using System;
using Syncfusion.Windows.Forms;

namespace BudgetExecution
{
    public partial class ExcelBrowser : MetroForm
    {
        public ExcelBrowser()
        {
            InitializeComponent();
        }

        public ExcelBrowser(string message)
        {
            InitializeComponent();
            MessageText = message;
            Info.Text = "\n  " + MessageText;
        }

        // PROPERTIES
        public string MessageText { get; set; }

        // METHODS
        private void OkButton_OnClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
