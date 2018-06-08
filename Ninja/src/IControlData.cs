// <copyright file="IControlData.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    internal interface IControlDocument : ISupplementalAllocation
    {
        #region Properties

        string ControlNumber { get; set; }

        string DateIssued { get; set; }

        string DivisionID { get; set; }

        string Name { get; set; }

        string Purpose { get; set; }

        #endregion

        #region Methods

        string GetDocumentControlNumber();

        int GetNewDocNumber();

        #endregion
    }
}