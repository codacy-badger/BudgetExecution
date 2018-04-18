using System.Data;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Reimbursable
            {
                //Constructors
                public Reimbursable()
                {
                }

                public Reimbursable(string fund, string bfy, string org, string code, string an, decimal auth,
                                    decimal amout, decimal avail)
                {
                    BFY = bfy;
                    Fund = new Fund(fund, bfy);
                    Org = new Org(org);
                    Account = new Account(code);
                    Code = Account.Code;
                    Agreement = an;
                    Authority = auth;
                    Amount = amout;
                    Available = avail;
                }

                public Reimbursable(DataRow dr)
                {
                    BFY = dr["BFY"].ToString();
                    Fund = new Fund(dr["Fund"].ToString(), BFY);
                    Org = new Org(dr["Fund"].ToString());
                    Account = new Account(dr["Code"].ToString());
                    Code = Account.Code;
                    Agreement = dr["Agreement"].ToString();
                    Authority = decimal.Parse(dr["Authority"].ToString());
                    Amount = decimal.Parse(dr["Amount"].ToString());
                    Available = decimal.Parse(dr["Available"].ToString());
                }

                //Properties
                public Account Account { get; }
                public string Agreement { get; }
                public decimal Amount { get; }
                public decimal Authority { get; }
                public decimal Available { get; }
                public string BFY { get; }
                public string Code { get; }
                public DataBuilder Data { get; }
                public Fund Fund { get; }
                public Org Org { get; }
            }
        }
    }
}