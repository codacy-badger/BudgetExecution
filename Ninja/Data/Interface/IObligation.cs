namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IObligation : IPRC
            {
                #region Properties

                string FOC { get; set; }
                string FocName { get; set; }
                string DocType { get; set; }
                string DocumentControlNumber { get; set; }
                string DCNprefix { get; set; }
                string System { get; set; }
                string PurchaseRequestNumber { get; set; }
                string SiteProjectCode { get; set; }
                string SiteProjectName { get; set; }
                string GrantNumber { get; set; }
                decimal CommitmentAmount { get; set; }
                decimal ObligationAmount { get; set; }

                #endregion
            }
        }
    }
}