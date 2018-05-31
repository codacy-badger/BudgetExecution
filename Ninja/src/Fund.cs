using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class Fund : IFund
    {
        //Constructors
        public Fund()
        {

        }
        public Fund(string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetFundParameter(Code, FiscalYear);
            Data = GetFundDataRecord(Source.Fund, Provider.SQLite, Parameter);
            DataRecord = Data.Rows[0];
            ID = int.Parse(DataRecord["ID"].ToString());
            Name = DataRecord["Name"].ToString();
            Title = DataRecord["Title"].ToString();
            TreasurySymbol = DataRecord["TreasurySymbol"].ToString();
        }
        public Fund(Source source, Provider provider, string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetFundParameter(Code, FiscalYear);
            Data = GetFundDataRecord(Source.Fund, Provider.SQLite, Parameter);
            DataRecord = Data.AsEnumerable().First();
            ID = int.Parse(DataRecord["ID"].ToString());
            Name = DataRecord["Name"].ToString();
            Title = DataRecord["Title"].ToString();
            TreasurySymbol = DataRecord["TreasurySymbol"].ToString();
        }

        //Properties
        public int ID { get; set; }
        public string Code { get; }
        public string FiscalYear { get; }
        public Dictionary<string, object> Parameter { get; }
        public string Name { get; }
        public string Title { get; }
        public string TreasurySymbol { get; }
        public DataTable Data { get; set; }
        public DataRow DataRecord { get; set; }

        //Methods
        public Dictionary<string, object> GetFundParameter(string code, string bfy)
        {
            try
            {
                return new Dictionary<string, object>() { ["Code"] = code, ["FiscalYear"] = bfy };
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        public Dictionary<string, object> GetFundProgramData(string code)
        {
            try
            {
                var dr = GetFundDataRecord(Source.Fund, Provider.SQLite, Parameter);
                Parameter.Add("Name", Name);
                Parameter.Add("Title", Title);
                Parameter.Add("TreasurySymbol", TreasurySymbol);
                return Parameter;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        public DataTable GetFundDataRecord(Source source, Provider provider, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, provider, param);
                return data.Table;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return null;
            }
        }
        public override string ToString()
        {
            return Code;
        }
    }
}