namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public interface IPRC
            {
                #region Properties

                Account Account { get; }
                decimal Amount { get; set; }
                string BFY { get; set; }
                BOC BOC { get; }
                Fund Fund { get; }
                Org Org { get; }
                RC RC { get; }
                string RPIO { get; set; }

                #endregion
            }
        }
    }
}