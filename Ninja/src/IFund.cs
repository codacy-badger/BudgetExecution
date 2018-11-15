// <copyright file="IFund.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System.Collections.Generic;
using System.Data;

namespace BudgetExecution
{
    public interface IFund
    {
        // PROPERTIES
        string Code { get; }

        DataTable Table { get; set; }

        string BFY { get; }

        string Name { get; }

        Dictionary<string, object> Parameter { get; }

        string Title { get; }

        string TreasurySymbol { get; }

        // METHODS
        DataTable GetData(Source source, Provider provider, Dictionary<string, object> param);

        Dictionary<string, object> GetDataFields(string code, string bfy);

        Dictionary<string, object> GetFundData(string code);

        string ToString();
    }
}
