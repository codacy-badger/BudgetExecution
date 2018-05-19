using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace BudgetExecution
{
    public class Fund
    {
        //Constructors
        public Fund(string code, string bfy)
        {
            Code = code;
            FiscalYear = bfy;
            Parameter = GetFundParameter(Code, FiscalYear);
            DataRecord = GetFundDataRecord(Source.Fund, Parameter);
            Name = DataRecord["Name"].ToString();
            Title = DataRecord["Title"].ToString();
            TreasurySymbol = DataRecord["TreasurySymbol"].ToString();
        }

        //Properties
        public string Code { get; }
        public string FiscalYear { get; }
        public Dictionary<string, object> Parameter { get; }
        public string Name { get; }
        public string Title { get; }
        public string TreasurySymbol { get; }
        public DataRow DataRecord { get; set; }

        //Methods
        Dictionary<string, object> GetFundParameter(string code, string bfy)
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
        internal Dictionary<string, object> GetFundProgramData(string code)
        {
            try
            {
                var dr = GetFundDataRecord(Source.Fund, Parameter);
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
        internal DataRow GetFundDataRecord(Source source, Dictionary<string, object> param)
        {
            try
            {
                var data = new DataBuilder(source, param).GetDataTable();
                return data.Rows[0];
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