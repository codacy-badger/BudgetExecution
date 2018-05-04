

namespace BudgetExecution
{
    public interface IObligation : IPRC
    {
        //Properties
        decimal CommitmentAmount { get; set; }

        string DCNprefix { get; set; }
        string DocType { get; set; }
        string DocumentControlNumber { get; set; }
        string FOC { get; set; }
        string FocName { get; set; }
        string GrantNumber { get; set; }
        decimal ObligationAmount { get; set; }
        string PurchaseRequestNumber { get; set; }
        string SiteProjectCode { get; set; }
        string SiteProjectName { get; set; }
        string System { get; set; }
    }
}