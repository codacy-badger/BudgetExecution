// <copyright file="IControlDocument.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    /// <summary>
    /// Defines the <see cref="IControlDocument" />
    /// </summary>
    internal interface IControlDocument : ISupplementalAllocation
    {
        /// <summary>
        /// Gets or sets the ControlNumber
        /// </summary>
        string ControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the DateIssued
        /// </summary>
        string DateIssued { get; set; }

        /// <summary>
        /// Gets or sets the DivisionID
        /// </summary>
        string DivisionID { get; set; }

        /// <summary>
        /// Gets or sets the Name
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Gets or sets the Purpose
        /// </summary>
        string Purpose { get; set; }

        /// <summary>
        /// The GetDocumentControlNumber
        /// </summary>
        /// <returns>The <see cref="string"/></returns>
        string GetDocumentControlNumber();

        /// <summary>
        /// The GetNewDocNumber
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        int GetNewDocNumber();
    }
}
