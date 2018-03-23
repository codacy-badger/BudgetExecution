#region Using Directives

using System.Collections.Generic;

#endregion Using Directives

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class ControlData
            {
                #region Properties

                public static string BudgetLevel = "7";
                public PRC[] Allocation { get; }
                public Query CtrlQuery { get; }
                public string FiscalYear { get; }
                public decimal Limit { get; }
                public PRC PrcAccount { get; }
                public string RC { get; }
                public Dictionary<string, object> Search { get; }

                #endregion

                #region Contructors

                public ControlData( )
                {
                }

                public ControlData(PRC account)
                {
                    FiscalYear = account.BFY;
                    Search = new Dictionary<string, object>
                    {
                        ["BudgetLevel"] = BudgetLevel,
                        ["Fund"] = account.Fund.Code,
                        ["BFY"] = FiscalYear,
                        ["BOC"] = account.BOC.Code,
                        ["Code"] = account.Code
                    };
                    Allocation = new DataBuilder(Source.P7, Search).Accounts;
                    PrcAccount = Allocation[0];
                    Limit = PrcAccount.Amount;
                }

                #endregion
            }
        }
    }
}