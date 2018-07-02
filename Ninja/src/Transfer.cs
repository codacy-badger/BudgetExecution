// <copyright file="Reprogramming.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Transfer
    {
        private DataBuilder DbData;
        private DataRow Data;
        private Source Source;
        private Provider Provider;

        // CONSTRUCTORS
        public Transfer()
        {
        }

        public Transfer(string bl, string docType, string rpio, string org, string rc, string bfy, string fund, string tcn, string qtr, string date, string code, string progproj, string ppn, string npmcode, string fromto, string boc, decimal amount)
        {
            BudgetLevel = bl;
            DocType = docType;
            RPIO = rpio;
            Org = new Org(org);
            RC = new RC(rc);
            BFY = bfy;
            Fund = new Fund(fund, BFY);
            TCN = tcn;
            Qtr = qtr;
            Date = date;
            Code = code;
            Account = new Account(fund, code);
            NpmCode = Account.NPM;
            FromTo = fromto;
            BOC = new BOC(boc);
            Amount = amount;
        }

        public Transfer(DataRow dr)
        {
            BudgetLevel = dr["BudgetLevel"].ToString();
            DocType = dr["DocType"].ToString();
            RPIO = dr["RPIO"].ToString();
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            TCN = dr["TCN"].ToString();
            Qtr = dr["Qtr"].ToString();
            Date = dr["Date"].ToString();
            Code = dr["Code"].ToString();
            Account = new Account(dr["Code"].ToString(), Code);
            NpmCode = Account.NPM;
            FromTo = dr["FromTo"].ToString();
            BOC = new BOC(dr["BOC"].ToString());
            Amount = decimal.Parse(dr["Amount"].ToString());
        }

        // PROPERTIES
        public Account Account { get; }

        public decimal Amount { get; }

        public string BFY { get; }

        public BOC BOC { get; }

        public string BudgetLevel { get; }

        public string Code { get; }

        public string Date { get; }

        public string DocType { get; }

        public string FromTo { get; }

        public Fund Fund { get; }

        public string NpmCode { get; }

        public Org Org { get; }

        public string Qtr { get; }

        public RC RC { get; }

        public string RPIO { get; }

        public string TCN { get; }
    }
}