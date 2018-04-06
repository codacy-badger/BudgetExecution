using System.Collections.Generic;
using System.Data;
using MetroForm = Syncfusion.Windows.Forms.MetroForm;

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
                public Query P7Query { get; set; }
                public Query P8Query { get; set; }
                public RegionalAuthority R6 { get; set; }
                private object Current { get; }
                private DataTable Data { get; set; }
                private int Index { get; }
                private Dictionary<string, object> Parameter { get; set; }

                #endregion Properties

                public AccountManager()
                {
                    InitializeComponent();
                }
            }
        }
    }
}