#region Using Directives

using Syncfusion.Windows.Forms.Chart;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class FunctionalityForm : Syncfusion.Windows.Forms.MetroForm
            {
                public FunctionalityForm( )
                {
                    InitializeComponent( );
                }

                private void GetD6DataManager(object sender, System.EventArgs e)
                {
                    var datamanager = new DataManager(Source.P8);
                    datamanager.Show( );
                    this.Close( );
                }

                private void GetR6DataManager(object sender, System.EventArgs e)
                {
                    var datamanager = new DataManager(Source.P7);
                    datamanager.Show( );
                    this.Close( );
                }

            }
        }
    }
}