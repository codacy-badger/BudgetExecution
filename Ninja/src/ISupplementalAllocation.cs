namespace BudgetExecution
{
    internal interface ISupplementalAllocation
    {
        // PROPERTIES
        decimal Awards { get; set; }

        decimal OverTime { get; set; }

        int TimeOffAwards { get; set; }

        PRC Training { get; set; }
    }
}
