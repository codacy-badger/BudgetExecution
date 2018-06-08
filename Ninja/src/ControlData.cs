namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    public class ControlData
    {
        #region Properties

        public static string BudgetLevel = "7";

        public DataRow[] Allocation { get; }

        public Query CtrlQuery { get; }

        public string FiscalYear { get; }

        public decimal Limit { get; }

        public PRC PrcAccount { get; }

        public string RC { get; }

        public Dictionary<string, object> Search { get; }

        #endregion

        public ControlData()
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
            Allocation = new DataBuilder(Source.RegionAccount, Provider.SQLite, Search).DataRecords;
            PrcAccount = Allocation[0].ToPrc();
            Limit = PrcAccount.Amount;
        }
    }
}

