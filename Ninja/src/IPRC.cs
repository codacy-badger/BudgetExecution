// <copyright file="IPRC.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the <see cref="IPRC" />
    /// </summary>
    public interface IPRC
    {
        // PROPERTIES
        /// <summary>
        /// Gets the Account
        /// </summary>
        Account Account { get; }

        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        decimal Amount { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        string BFY { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        BOC BOC { get; set; }

        /// <summary>
        /// Gets or sets the Fund
        /// </summary>
        Fund Fund { get; set; }

        /// <summary>
        /// Gets the Org
        /// </summary>
        Org Org { get; }

        /// <summary>
        /// Gets the RC
        /// </summary>
        RC RC { get; }

        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        string RPIO { get; set; }
    }
}
