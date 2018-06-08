// <copyright file="ControlData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    public class ControlData
    {
        public ControlData()
        {
        }

        public ControlData(PRC account)
        {
            FiscalYear = account.BFY;
            Search = new Dictionary<string, object>
            {
                ["BudgetLevel"] = budgetLevel,
                ["Fund"] = account.Fund.Code,
                ["BFY"] = FiscalYear,
                ["BOC"] = account.BOC.Code,
                ["Code"] = account.Code
            };
            Allocation = new DataBuilder(Source.RegionAccount, Provider.SQLite, Search).DataRecords;
            PrcAccount = Allocation[0].ToPrc();
            Limit = PrcAccount.Amount;
        }

        private static string budgetLevel = "7";

        public DataRow[] Allocation { get; }

        public Query CtrlQuery { get; }

        public string FiscalYear { get; }

        public decimal Limit { get; }

        public PRC PrcAccount { get; }

        public string RC { get; }

        public Dictionary<string, object> Search { get; }
    }
}
