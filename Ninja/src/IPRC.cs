﻿// <copyright file="IPRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>



namespace BudgetExecution
{
    public interface IPRC
    {
        // PROPERTIES
        Account Account { get; }

        decimal Amount { get; set; }

        string BFY { get; set; }

        BOC BOC { get; }

        Fund Fund { get; }

        Org Org { get; }

        RC RC { get; }

        string RPIO { get; set; }
    }
}
