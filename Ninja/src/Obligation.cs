namespace BudgetExecution
{
    using System.Data;

    public class Obligation
    {
        #region Properties

        public Account Account { get; set; }

        public string BFY { get; set; }

        public BOC BOC { get; set; }

        public string Code { get; set; }

        public decimal CommitmentAmount { get; set; }

        public DataBuilder Data { get; set; }

        public string DCNprefix { get; set; }

        public string DocType { get; set; }

        public string DocumentControlNumber { get; set; }

        public string FOC { get; set; }

        public string FocName { get; set; }

        public Fund Fund { get; set; }

        public string GrantNumber { get; set; }

        public string NpmCode { get; set; }

        public decimal ObligationAmount { get; set; }

        public Org Org { get; set; }

        public string PurchaseRequestNumber { get; set; }

        public RC RC { get; set; }

        public string RPIO { get; set; }

        public string SiteProjectCode { get; set; }

        public string SiteProjectName { get; set; }

        public string System { get; set; }

        #endregion Properties

        #region Constructors

        public Obligation()
        {
        }

        public Obligation(string rpio, string fy, string fund, string org, string rc, string code, string boc, string foc, string focname,
                            string doctype, string system, string prn, string dcnprefix, string grantnumber,
                            string siteprojcode, string siteprojname, string dcn, decimal c, decimal o)
        {
            RPIO = rpio;
            BFY = fy;
            Fund = new Fund(fund, fy);
            Org = new Org(org);
            RC = new RC(rc);
            Account = new Account(code);
            Code = Account.Code;
            NpmCode = Account.NPM;
            BOC = new BOC(boc);
            FOC = foc;
            FocName = focname;
            DocType = doctype;
            System = system;
            PurchaseRequestNumber = prn;
            DCNprefix = dcnprefix;
            GrantNumber = grantnumber;
            SiteProjectCode = siteprojcode;
            SiteProjectName = siteprojname;
            DocumentControlNumber = dcn;
            CommitmentAmount = c;
            ObligationAmount = o;
        }

        public Obligation(DataRow dr)
        {
            RPIO = dr["RPIO "].ToString();
            BFY = dr["BFY"].ToString();
            Fund = new Fund(dr["Fund"].ToString(), BFY);
            Org = new Org(dr["Org"].ToString());
            RC = new RC(dr["RC"].ToString());
            Code = dr["Code"].ToString();
            Account = new Account(Code);
            NpmCode = Account.NPM;
            BOC = new BOC(dr["BOC"].ToString());
            FOC = dr["FOC"].ToString();
            FocName = dr["FocName"].ToString();
            DocType = dr["DocType"].ToString();
            System = dr["System"].ToString();
            PurchaseRequestNumber = dr["PurchaseRequestNumber"].ToString();
            DCNprefix = dr["DCNprefix "].ToString();
            GrantNumber = dr["GrantNumber"].ToString();
            SiteProjectCode = dr["SiteProjectCode"].ToString();
            SiteProjectName = dr["SiteProjectName"].ToString();
            DocumentControlNumber = dr["DocumentControlNumber"].ToString();
            CommitmentAmount = decimal.Parse(dr["CommitmentAmount"].ToString());
            ObligationAmount = decimal.Parse(dr["ObligationAmount"].ToString());
        }

        #endregion Constructors
    }
}
