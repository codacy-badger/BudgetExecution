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
                public string ID { get; }
                public string Name { get; }

                #endregion

                public RC(string code)
                {
                    Code = code;
                    Name = Info.DivisionName(code);
                    ID = Info.GetDivisionMailCode(code);
                }

                #region Methods

                public override string ToString()
                {
                    return Code;
                }

                #endregion
            }
        }
    }
}