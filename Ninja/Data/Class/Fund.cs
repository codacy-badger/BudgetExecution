namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Fund
            {
                #region Properties

                public string Code { get; }
                public string FiscalYear { get; }
                public string Name { get; }
                public string Title { get; }
                public string TreasurySymbol { get; }

                #endregion Properties

                #region Constructors

                public Fund(string code, string bfy)
                {
                    Code = code;
                    FiscalYear = bfy;
                    Name = Info.GetAppropriationName(code);
                    Title = Info.GetAppropriationTitle(code);
                    TreasurySymbol = Info.GetTreasurySymbol(code);
                }

                #endregion Constructors

                #region Methods

                public override string ToString()
                {
                    return Code;
                }

                #endregion Methods
            }
        }
    }
}