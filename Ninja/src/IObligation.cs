// <copyright file="IObligation.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the <see cref="IObligation" />
    /// </summary>
    public interface IObligation
    {
        /// <summary>
        /// Gets or sets the Obligations
        /// </summary>
        decimal Obligations { get; set; }

        /// <summary>
        /// Gets or sets the BFY
        /// </summary>
        string BFY { get; set; }

        /// <summary>
        /// Gets or sets the BOC
        /// </summary>
        BOC BOC { get; set; }

        /// <summary>
        /// Gets or sets the DocumentControlNumber
        /// </summary>
        string DocumentControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the FOC
        /// </summary>
        string FOC { get; set; }

        /// <summary>
        /// Gets or sets the FocName
        /// </summary>
        string FocName { get; set; }

        /// <summary>
        /// Gets or sets the Fund
        /// </summary>
        Fund Fund { get; set; }

        /// <summary>
        /// Gets or sets the ID
        /// </summary>
        int ID { get; set; }

        /// <summary>
        /// Gets or sets the Org
        /// </summary>
        Org Org { get; set; }

        /// <summary>
        /// Gets or sets the PRC
        /// </summary>
        PRC[] PRC { get; set; }

        /// <summary>
        /// Gets or sets the ProgramProjectCode
        /// </summary>
        string ProgramProjectCode { get; set; }

        /// <summary>
        /// Gets or sets the RC
        /// </summary>
        RC RC { get; set; }

        /// <summary>
        /// Gets or sets the RPIO
        /// </summary>
        string RPIO { get; set; }
    }
}
