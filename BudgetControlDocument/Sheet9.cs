﻿using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualStudio.Tools.Applications.Runtime;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;

namespace BudgetControlDocument
{
    public partial class Sheet9
    {
        private void Sheet9_Startup(object sender, System.EventArgs e)
        {
        }

        private void Sheet9_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(Sheet9_Startup);
            this.Shutdown += new System.EventHandler(Sheet9_Shutdown);
        }

        #endregion

    }
}
