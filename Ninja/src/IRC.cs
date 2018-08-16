// <copyright file="IRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    public interface IRC
    {
        // PROPERTIES
        string Code { get; }

        string ID { get; }

        string Name { get; }

        // METHODS
        string ToString();
    }
}