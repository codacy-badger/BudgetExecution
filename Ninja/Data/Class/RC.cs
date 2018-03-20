namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class RC
            {
                #region Properties

                public string Code { get; }
                public string Name { get; }
                public string ID { get; }

                #endregion

                #region Constructor

                public RC(string code)
                {
                    Code = code;
                    Name = Info.DivisionName(code);
                    ID = Info.GetDivisionMailCode(code);
                }

                #endregion

                #region Methods

                public override string ToString( )
                {
                    return Code;
                }

                #endregion
            }
        }
    }
}