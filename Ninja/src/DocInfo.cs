using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;




namespace BudgetExecution
{
    public class DocInfo
    {
        // CONSTRUCTORS
        public DocInfo()
        {
        }

        public DocInfo(DivisionAuthority budget)
        {
            DivisionBudget = budget;
            ControlNumber = GetControlNumber();
            DocumentHeader = GetDocumentHeader();
            AccountingInfo = GetAccountingInfo();
            SignatureBlock = GetSignatureInfo();
        }

        // PROPERTIES
        public List<string> AccountingInfo { get; set; }

        public decimal Awards { get; set; }
        public List<string> ControlInfo { get; set; }
        public string ControlNumber { get; set; }
        public List<string> ControlNumbers { get; set; }
        public string DateIssued { get; set; }
        public string DcnPrefix { get; set; }
        public DivisionAuthority DivisionBudget { get; set; }
        public List<string> DocumentHeader { get; set; }
        public Org Organization { get; }
        public decimal OverTime { get; set; }
        public string Purpose { get; set; }
        public List<Transfer> Reprogrammings { get; set; }
        public List<string> SignatureBlock { get; set; }
        public Dictionary<string, object> Suppplemental { get; set; }
        public int TimeOffAwards { get; set; }
        public PRC Training { get; set; }

        // METHODS
        internal List<string> GetAccountingInfo()
        {
            List<string> footer = new List<string>();
            footer.Add("FUNDING INFORMATION");
            footer.Add("DCN:  * AT DIVISION'S DISCRETION - MUST BE ALPHA");
            footer.Add("BUDGET ORG:  ALLOWANCE HOLDER AND RESPONSIBILITY CENTER");
            footer.Add("PRC:  7 CHARACTERS - GOAL/OBJECTIVE/NPM/PROGRAM PROJECT/ACTIVITY");
            footer.Add("OBJECT CLASS: 2 or 4 DIGIT");
            footer.Add("SITE/PROJECT:  OPTIONAL FIELD");
            footer.Add("SEE REFERENCES:");
            footer.Add("            EPA RESOURCES MANAGEMENT DIRECTIVE 2590A - OBJECT CLASS MANUAL");
            footer.Add("            EPA RESOURCES MANAGEMENT DIRECTIVE 2550 - ADMINISTRATIVE CONTROL OF APPROPRIATED FUNDS");
            footer.Add("            REGION 6 MANAGEMENT OF EXPIRING FUNDS MEMORANDUM DATED 10/4/2016");
            return footer;
        }

        internal string GetControlNumber()
        {
            try
            {
                StringBuilder controlNumber = new StringBuilder();
                string month = DateTime.Now.Month.ToString();
                string day = DateTime.Now.Day.ToString();
                controlNumber.Append(DivisionAuthority.FiscalYear);
                controlNumber.Append(month);
                controlNumber.Append(day);
                controlNumber.Append("-");
                controlNumber.Append((DivisionAuthority.FiscalYear[2].ToString()));
                controlNumber.Append((DivisionAuthority.FiscalYear[3].ToString()));
                controlNumber.Append("-");
                controlNumber.Append(Organization.ID);
                controlNumber.Append("-01");
                return controlNumber.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        internal Dictionary<string, string> GetDocmumentDictionary()
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("ControlNumber", ControlNumber);
                param.Add("Org", Organization.Code);
                param.Add("Division", Organization.Name);
                param.Add("Id", Organization.ID);
                param.Add("FiscalYear", DivisionAuthority.FiscalYear);
                param.Add("Purpose", Purpose);
                return param;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return null;
            }
        }

        internal List<string> GetDocumentHeader()
        {
            List<string> division = new List<string>();
            division.Add("US EPA REGION 6");
            division.Add($"{ Organization.Name }");
            division.Add($"ID : { Organization.ID }");
            division.Add($"Org Code: { Organization.Code }");
            division.Add($"Budget Authority for Fiscal Year {DivisionAuthority.FiscalYear}");
            return division;
        }

        internal List<string> GetManagementHeader()
        {
            List<string> header = new List<string>();
            header.Add("US EPA REGION 6");
            header.Add("Management Division 6MD");
            header.Add("Office of the Regional Comptroller 6MD-C");
            header.Add("Budget and Accounting Section 6MD-CB");
            return header;
        }

        internal int GetNewDocNumber()
        {
            try
            {
                return (new DataBuilder(Source.Reprogramming, Provider.SQLite).Table.Rows.Count) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR!: \n" + ex.TargetSite + ex.StackTrace);
                return -1;
            }
        }

        internal List<string> GetSignatureInfo()
        {
            List<string> signature = new List<string>();
            signature.Add("Terry D. Eppler");
            signature.Add("Budget Analyst | 6MD-CB");
            signature.Add("US EPA Region 6");
            return signature;
        }
    }
}
    
