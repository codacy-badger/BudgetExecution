namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IPRC
            {
                #region Properties

                string RPIO { get; set; }
                string BFY { get; set; }
                Fund Fund { get; }
                Org Org { get; }
                RC RC { get; }
                BOC BOC { get; }
                Account Account { get; }
                decimal Amount { get; set; }

                #endregion
            }
        }
    }
}