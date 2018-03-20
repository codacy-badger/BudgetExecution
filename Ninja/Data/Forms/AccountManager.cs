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
                public RegionalAuthority Region { get; set; }
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
                    Region = new RegionalAuthority( );
                    Division = new DivisionAuthority( );
                    GetRCValues( );
                    GetFundValues( );
                    GetOrgValues( );
                    GetCodeValues( );
                }

                private void Next(object sender, EventArgs e)
                {
                }

                private void Previous(object sender, EventArgs e)
                {
                }

                private void AccountManager_Load(object sender, EventArgs e)
                {
                }

                private void GetRCValues( )
                {
                    var rc = Division.DataElement["RC"];
                    foreach (string r in rc)
                        RcBox.Items.Add(r);
                }

                private void GetFundValues( )
                {
                    var fund = Region.DataElement["Fund"];
                    foreach (string f in fund)
                        FundBox.Items.Add(f);
                }

                private void GetOrgValues( )
                {
                    var org = Region.DataElement["Org"];
                    foreach (string oc in org)
                        OrgBox.Items.Add(oc);
                }

                private void GetCodeValues( )
                {
                    var prc = Region.DataElement["Code"];
                    foreach (string p in prc)
                        CodeBox.Items.Add(p);
                }
            }
        }
    }
}