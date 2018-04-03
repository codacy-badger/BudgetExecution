#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public partial class AccountManager : MetroForm
            {
                #region Properties

                public DivisionAuthority Division { get; set; }
                public RegionalAuthority R6 { get; set; }
                private object Current { get; }
                private int Index { get; }
                private Dictionary<string, object> Parameter { get; set; }
                public Query P8Query { get; set; }
                public Query P7Query { get; set; }
                private DataTable Data { get; set; }

                #endregion Properties

                public AccountManager( )
                {
                    InitializeComponent( );
                }
            }
        }
    }
}