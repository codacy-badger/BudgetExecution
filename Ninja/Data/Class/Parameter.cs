﻿using System.Collections.Generic;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Parameter : IParameter
            {
                #region Properties

                public string BudgetLevel { get; }
                public string RPIO { get; }
                public string BFY { get; }
                public string Fund { get; }
                public string Org { get; }
                public string RC { get; }
                public string BOC { get; }
                public string Code { get; }
                public Dictionary<string, string> PRC { get; set; }

                #endregion Properties

                #region Constructors

                public Parameter(string bl, string rpio, string bfy, string fund, string org, string rc, string boc, string code)
                {
                    BudgetLevel = bl ?? "7";
                    RPIO = rpio ?? "06";
                    BFY = bfy;
                    Fund = fund;
                    Org = org ?? RPIO;
                    RC = rc;
                    BOC = boc;
                    Code = code;
                    PRC = new Dictionary<string, string>( )
                    {
                        ["BudgetLevel"] = bl,
                        ["RPIO"] = RPIO,
                        ["BFY"] = BFY,
                        [Fund] = Fund,
                        ["Org"] = Org,
                        ["RC"] = RC,
                        ["BOC"] = BOC,
                        ["Code"] = Code
                    };
                }

                #endregion Constructors
            }
        }
    }
}