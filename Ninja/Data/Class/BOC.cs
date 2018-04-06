namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class BOC
            {
                #region Properties

                public string Code { get; }
                public string Name { get; }
                public decimal Value { get; }

                #endregion Properties

                #region Constructors

                public BOC(string code)
                {
                    Code = code;
                    Name = Info.GetBocName(code);
                    Value = 0m;
                }

                public BOC(string code, decimal amount)
                {
                    Code = code;
                    Name = Info.GetBocName(code);
                    Value = amount;
                }

                #endregion Constructors

                #region Methods

                public decimal GetValue(PRC prc)
                {
                    return prc.Amount;
                }

                public override string ToString()
                {
                    return Code;
                }

                #endregion Methods
            }
        }
    }
}