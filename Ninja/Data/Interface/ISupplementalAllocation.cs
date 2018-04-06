namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            internal interface ISupplementalAllocation
            {
                decimal Awards { get; set; }
                decimal OverTime { get; set; }
                int TimeOffAwards { get; set; }
                PRC Training { get; set; }
            }
        }
    }
}