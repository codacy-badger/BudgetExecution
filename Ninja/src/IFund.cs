// <copyright file="IFund.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    public interface IFund
    {
        // PROPERTIES
        string Code { get; }

        DataTable Table { get; set; }

        string FiscalYear { get; }

        string Name { get; }

        Dictionary<string, object> Parameter { get; }

        string Title { get; }

        string TreasurySymbol { get; }

        // METHODS
        DataTable GetData(Source source, Provider provider, Dictionary<string, object> param);

        Dictionary<string, object> GetParamData(string code, string bfy);

        Dictionary<string, object> GetFundData(string code);

        string ToString();
    }
}