namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class NPM
            {
                #region Properties

                public string Code { get; }
                public string Name { get; set; }
                public string RPIO { get; set; }
                public string Title { get; set; }

                #endregion Properties

                #region Constructors

                public NPM(HQ code)
                {
                    Code = code.ToString();
                }

                public NPM(string code)
                {
                    Code = code;
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