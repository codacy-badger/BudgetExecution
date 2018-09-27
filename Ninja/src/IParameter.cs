﻿// <copyright file="IParameter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IParameter
    {
        // PROPERTIES
        int ID { get; }

        string BFY { get; }

        string BOC { get; }

        string Code { get; }

        string Fund { get; }

        string Org { get; }

        string RC { get; }

        string RPIO { get; }
    }
}
