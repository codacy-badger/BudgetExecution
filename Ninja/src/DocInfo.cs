// <copyright file="DocInfo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;

namespace BudgetExecution
{
    public class DocInfo
    {
        // CONSTRUCTORS
        public DocInfo() { }

        public DocInfo(DivisionAuthority budget)
        {
            Data = budget;
            ControlNumber = GetControlNumber();
            DocumentHeader = GetDocumentHeader();
            AccountingInfo = GetAccountingInfo();
            SignatureBlock = GetSignatureInfo();
        }

        // PROPERTIES
        public List<string> AccountingInfo { get; set; }

        public decimal Awards { get; set; }

        public List<string> ControlInfo { get; set; }

        public ControlNumber ControlNumber { get; set; }

        public List<string> ControlNumbers { get; set; }

        public string DateIssued { get; set; }

        public string DcnPrefix { get; set; }

        public DivisionAuthority Data { get; set; }

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

        internal ControlNumber GetControlNumber()
        {
            try
            {
                return new ControlNumber();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal Dictionary<string, string> GetDocmumentInfo()
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("ControlNumber", ControlNumber.ToString());
                param.Add("Org", Organization.Code);
                param.Add("Division", Organization.Name);
                param.Add("Id", Organization.ID);
                param.Add("FiscalYear", DivisionAuthority.FiscalYear);
                param.Add("Purpose", Purpose);
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        internal List<string> GetDocumentHeader()
        {
            List<string> division = new List<string>();
            division.Add("US EPA REGION 6");
            division.Add($"{Organization.Name}");
            division.Add($"ID : {Organization.ID}");
            division.Add($"Org Code: {Organization.Code}");
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
                return new DataBuilder(Source.InternalTransfers, Provider.SQLite).Table.Rows.Count + 1;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return-1;
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
