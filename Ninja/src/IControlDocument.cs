namespace BudgetExecution
{
    internal interface IControlDocument : ISupplementalAllocation
    {
        string ControlNumber { get; set; }

        string DateIssued { get; set; }

        string DivisionID { get; set; }

        string Name { get; set; }

        string Purpose { get; set; }

        string GetDocumentControlNumber();

        int GetNewDocNumber();
    }
}
