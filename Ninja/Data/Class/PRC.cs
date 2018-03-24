#region Using Directives

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

#endregion

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class PRC : IAccount
            {
                #region Properties
                public string BudgetLevel { get; set; }
                public int Id { get; set; }
                public string RPIO { get; set; }
                public string BFY { get; set; }
                public Fund Fund { get; }
                public RC RC { get; }
                public string Org { get; }
                public BOC BOC { get; }
                public Account Account { get; }
                public string Goal { get; }
                public string GoalName { get; }
                public string Objective { get; }
                public string ObjectiveName { get; }
                public string Code { get; set; }
                public decimal Amount { get; set; }
                public string NPM { get; set; }
                public string NpmCode { get; }
                public string NpmName { get; set; }
                public string ProgramProjectCode { get; }
                public string ProgramProjectName { get; set; }
                public PRC[] AllocationData { get; set; }
                public FTE FTE { get; set; }
                public string ProgramArea { get; set; }
                public Parameter Parameter { get; }
                private Dictionary<string, object> Data { get; set; }
                #endregion Properties

                #region Constructors

                public PRC()
                {
                }

                public PRC(string bl, string rpio, string bfy, string fund, string org, string rc, string code, string boc, decimal amount)
                {
                    BudgetLevel = bl;
                    RPIO = rpio;
                    BFY = bfy;
                    Fund = new Fund(fund, bfy);
                    RC = new RC(rc);
                    Org = org;
                    Account = new Account(code);
                    Code = Account.Code;
                    BOC = new BOC(boc, amount);
                    Amount = amount;
                    NpmCode = Account.NpmCode;
                    ProgramProjectCode = Account.ProgramProjectCode;
                    Goal = Account.Goal;
                    GoalName = Account.GoalName;
                    Objective = Account.Objective;
                    ObjectiveName = Account.ObjectiveName;
                    Parameter = GetParameter();
                }

                public PRC(DataRow datarow)
                {
                    Id = int.Parse(datarow["Id"].ToString());
                    BudgetLevel = datarow["BudgetLevel"].ToString();
                    RPIO = datarow["RPIO"].ToString();
                    BFY = datarow["BFY"].ToString();
                    Fund = new Fund(datarow["Fund"].ToString(), datarow["BFY"].ToString());
                    RC = new RC(datarow["RC"].ToString());
                    Org = datarow["Org"].ToString();
                    Account = new Account(datarow["Code"].ToString());
                    Code = Account.Code;
                    BOC = new BOC(datarow["BOC"].ToString());
                    Amount = decimal.Parse(datarow["Amount"].ToString());
                    NpmCode = Account.NpmCode;
                    ProgramProjectCode = Account.ProgramProjectCode;
                    Goal = Account.Goal;
                    GoalName = Account.GoalName;
                    Objective = Account.Objective;
                    ObjectiveName = Account.ObjectiveName;
                    Parameter = GetParameter();
                }

                #endregion Constructors

                #region Methods

                internal Dictionary<string, object> GetData()
                {
                    try
                    {
                        Dictionary<string, object> param = new Dictionary<string, object>()
                        {
                            ["Id"] = Id,
                            ["BudgetLevel"] = BudgetLevel,
                            ["RPIO"] = RPIO,
                            ["BFY"] = BFY,
                            ["Fund"] = Fund.Code,
                            ["RC"] = RC,
                            ["BOC"] = BOC.Code,
                            ["Code"] = Account.Code,
                            ["Amount"] = Amount.ToString("c")
                        };
                        return param;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR! : \n" + ex.StackTrace);
                        return null;
                    }
                }

                internal Parameter GetParameter()
                {
                    return new Parameter(BudgetLevel, RPIO, BFY, Fund.Code, Org, RC.Code, BOC.Code, Account.Code);
                }

                public string GetGoal()
                {
                    var goal = Code.Substring(0, 1).ToCharArray();
                    return goal.ToString();
                }

                public string GetGoalName(string code)
                {
                    return Info.GetGoalName(code);
                }

                public string GetObjective()
                {
                    return Code.Substring(1, 2);
                }

                public string GetObjectiveName(string code)
                {
                    return Info.GetObjectiveName(code);
                }

                public string GetNpmCode()
                {
                    var npm = Code.Substring(2, 1).ToCharArray();
                    return npm.ToString();
                }

                public string GetCode()
                {
                    return Code;
                }

                public string GetProgramProjectCode()
                {
                    return Code.Substring(5, 2);
                }

                public string[] GetProgramData()
                {
                    var pp = GetProgramProjectCode();
                    var sql = new Dictionary<string, object>();
                    sql.Add("ProgramProjectCode", pp);
                    string[] p = new DataBuilder(Source.A6, sql).A6Query();
                    return p;
                }

                internal decimal GetFteAllocation()
                {
                    if (BOC.Code == "17")
                    {
                        try
                        {
                            return Amount;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                            return -1m;
                        }
                    }
                    else
                        return 0.0m;
                }

                internal decimal Reprogram(decimal amount)
                {
                    try
                    {
                        this.Amount += amount;
                        return Amount;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString() + $"Target Method:\n{ex.TargetSite}\n" + $"Stack:\n{ex.StackTrace}");
                        return -1;
                    }
                }

                internal PRC[] GetAllocation(DataTable table)
                {
                    PRC[] allocation = new PRC[table.Rows.Count];
                    for(int i = 0; i<table.Rows.Count; i++)
                    {
                        foreach (DataRow row in table.Rows)
                            allocation[i] = new PRC(row);
                    }
                    return allocation;
                }

                public override string ToString( )
                {
                    return Account.Code;
                }

                #endregion Methods
            }
        }
    }
}