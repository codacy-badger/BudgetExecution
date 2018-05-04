using System.Collections.Generic;



namespace BudgetExecution
{
    public class Parameter : IParameter
    {
        #region Properties

        public string BFY { get; }
        public string BOC { get; }
        public string BudgetLevel { get; }
        public string Code { get; }
        public string Fund { get; }
        public string Org { get; }
        public Dictionary<string, string> PRC { get; set; }
        public string RC { get; }
        public string RPIO { get; }

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
            PRC = new Dictionary<string, string>()
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
    
