// <copyright file="IObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IObligation
    {
        decimal Amount { get; set; }

        string BFY { get; set; }

        BOC BOC { get; set; }

        string DocumentControlNumber { get; set; }

        string FOC { get; set; }

        string FocName { get; set; }

        Fund Fund { get; set; }

        int ID { get; set; }

        Org Org { get; set; }

        PRC[] PRC { get; set; }

        string ProgramProjectCode { get; set; }

        RC RC { get; set; }

        string RPIO { get; set; }
    }
}
