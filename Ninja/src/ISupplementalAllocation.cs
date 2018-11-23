// <copyright file="ISupplementalAllocation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the <see cref="ISupplementalAllocation" />
    /// </summary>
    internal interface ISupplementalAllocation
    {
        // PROPERTIES
        /// <summary>
        /// Gets or sets the Awards
        /// </summary>
        decimal Awards { get; set; }

        /// <summary>
        /// Gets or sets the OverTime
        /// </summary>
        decimal OverTime { get; set; }

        /// <summary>
        /// Gets or sets the TimeOffAwards
        /// </summary>
        int TimeOffAwards { get; set; }

        /// <summary>
        /// Gets or sets the Training
        /// </summary>
        PRC Training { get; set; }
    }
}
