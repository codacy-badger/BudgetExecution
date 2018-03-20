namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class FTE : IPRC
            {
                #region Properties

                public decimal Allocation { get; set; }
                public string RPIO { get; set; }
                public string BFY { get; set; }
                public Fund Fund { get; set; }
                public Org Org { get; set; }
                public RC RC { get; set; }
                public BOC BOC { get; set; }
                public Account Account { get; }
                public string Code { get; }
                public decimal Amount { get; set; }

                #endregion Properties

                #region Constructors

                public FTE( )
                {
                }

                public FTE(string code)
                {
                    Account = new Account(code);
                    Code = Account.Code;
                }

                #endregion Constructors
            }
        }
    }
}