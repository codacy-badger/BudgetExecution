// <copyright file="Parameter.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    public class PrcParameter : IPrcParameter
    {
        public PrcParameter(int id, string bl, string rpio, string bfy, string fund, string org, string rc, string boc, string code)
        {
            ID = id;
            BudgetLevel = bl ?? "7";
            RPIO = rpio ?? "06";
            BFY = bfy;
            Fund = fund;
            Org = org ?? RPIO;
            RC = rc;
            BOC = boc;
            Code = code;
            Data = new Dictionary<string, object>()
            {
                ["ID"] = ID,
                ["BudgetLevel"] = bl,
                ["RPIO"] = RPIO,
                ["BFY"] = BFY,
                ["Fund"] = Fund,
                ["Org"] = Org,
                ["RC"] = RC,
                ["BOC"] = BOC,
                ["Code"] = Code
            };
        }

        public int ID { get; }

        public string BFY { get; }

        public string BOC { get; }

        public string BudgetLevel { get; }

        public string Code { get; }

        public string Fund { get; }

        public string Org { get; }

        public Dictionary<string, object> Data { get; set; }

        public string RC { get; }

        public string RPIO { get; }
    }
}
