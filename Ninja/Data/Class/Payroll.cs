using System.Data;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Payroll
            {
                #region Properties

                public decimal Amount { get; }
                public string BFY { get; }
                public string Code { get; }
                public Fund Fund { get; }
                public double Hours { get; }
                public string HrOrgCode { get; }
                public Org Org { get; }
                public string ProgramProjectCode { get; }
                public string ProgramProjectName { get; }
                public RC RC { get; }
                public string RPIO { get; }
                public string WorkCode { get; }
                public string WorkCodeName { get; }
                public double YearBaseHours { get; }
                public decimal YearBasePay { get; }
                public double YearOverTimeHours { get; }
                public decimal YearOverTimePay { get; }

                #endregion

                #region Constructors

                public Payroll()
                {
                }

                public Payroll(string rpio, string bfy, string fund, string org, string rc, string code, string progproj, string progprojname,
                                string hoc, string wc, string wcn, decimal amount, decimal ybp, double ybh, decimal yotp, double yoth)
                {
                    RPIO = rpio;
                    BFY = bfy;
                    Fund = new Fund(fund, bfy);
                    Org = new Org(org);
                    RC = new RC(rc);
                    Code = code;
                    ProgramProjectCode = progproj;
                    ProgramProjectName = progprojname;
                    HrOrgCode = hoc;
                    WorkCode = wc;
                    WorkCodeName = wcn;
                    Amount = amount;
                    Hours = ybh;
                    YearBasePay = ybp;
                    YearBaseHours = ybh;
                    YearOverTimePay = yotp;
                    YearOverTimeHours = yoth;
                }

                public Payroll(DataRow dr)
                {
                    RPIO = dr["RPIO"].ToString();
                    BFY = dr["BFY "].ToString();
                    Fund = new Fund(dr["Fund"].ToString(), BFY);
                    Org = new Org(dr["Org"].ToString());
                    RC = new RC(dr["RC"].ToString());
                    Code = dr["Code"].ToString();
                    ProgramProjectCode = dr["ProgramProjectCode"].ToString();
                    ProgramProjectName = dr["ProgramProjectName"].ToString();
                    HrOrgCode = dr["HrOrgCode"].ToString();
                    WorkCode = dr["WorkCode"].ToString();
                    WorkCodeName = dr["WorkCodeName"].ToString();
                    Amount = decimal.Parse(dr["Amount"].ToString());
                    Hours = double.Parse(dr["Hours"].ToString());
                    YearBasePay = decimal.Parse(dr["YearBasePay"].ToString());
                    YearBaseHours = double.Parse(dr["YearBaseHours"].ToString());
                    YearOverTimePay = decimal.Parse(dr["YearOverTimePay"].ToString());
                    YearOverTimeHours = double.Parse(dr["YearOverTimeHours"].ToString());
                }

                #endregion
            }
        }
    }
}