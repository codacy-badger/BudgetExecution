// <copyright file="DocInfo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="DocInfo" />
    /// </summary>
    public class DocInfo
    {
        // CONSTRUCTORS
        /// <summary>
        /// Initializes a new instance of the <see cref="DocInfo"/> class.
        /// </summary>
        public DocInfo()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DocInfo"/> class.
        /// </summary>
        /// <param name="budget">The budget<see cref="DivisionAuthority"/></param>
        public DocInfo(DivisionAuthority budget)
        {
            Data = budget;
            ControlNumber = GetControlNumber();
            DocumentHeader = GetDocumentHeader();
            AccountingInfo = GetAccountingInfo();
            SignatureBlock = GetSignatureInfo();
        }

        // PROPERTIES
        /// <summary>
        /// Gets or sets the AccountingInfo
        /// </summary>
        public List<string> AccountingInfo { get; set; }

        /// <summary>
        /// Gets or sets the Awards
        /// </summary>
        public decimal Awards { get; set; }

        /// <summary>
        /// Gets or sets the ControlInfo
        /// </summary>
        public List<string> ControlInfo { get; set; }

        /// <summary>
        /// Gets or sets the ControlNumber
        /// </summary>
        public ControlNumber ControlNumber { get; set; }

        /// <summary>
        /// Gets or sets the ControlNumbers
        /// </summary>
        public List<string> ControlNumbers { get; set; }

        /// <summary>
        /// Gets or sets the DateIssued
        /// </summary>
        public string DateIssued { get; set; }

        /// <summary>
        /// Gets or sets the DcnPrefix
        /// </summary>
        public string DcnPrefix { get; set; }

        /// <summary>
        /// Gets or sets the Data
        /// </summary>
        public DivisionAuthority Data { get; set; }

        /// <summary>
        /// Gets or sets the DocumentHeader
        /// </summary>
        public List<string> DocumentHeader { get; set; }

        /// <summary>
        /// Gets the Organization
        /// </summary>
        public Org Organization { get; }

        /// <summary>
        /// Gets or sets the OverTime
        /// </summary>
        public decimal OverTime { get; set; }

        /// <summary>
        /// Gets or sets the Purpose
        /// </summary>
        public string Purpose { get; set; }

        /// <summary>
        /// Gets or sets the Reprogrammings
        /// </summary>
        public List<Transfer> Reprogrammings { get; set; }

        /// <summary>
        /// Gets or sets the SignatureBlock
        /// </summary>
        public List<string> SignatureBlock { get; set; }

        /// <summary>
        /// Gets or sets the Suppplemental
        /// </summary>
        public Dictionary<string, object> Suppplemental { get; set; }

        /// <summary>
        /// Gets or sets the TimeOffAwards
        /// </summary>
        public int TimeOffAwards { get; set; }

        /// <summary>
        /// Gets or sets the Training
        /// </summary>
        public PRC Training { get; set; }

        // METHODS
        /// <summary>
        /// The GetAccountingInfo
        /// </summary>
        /// <returns>The <see cref="List{string}"/></returns>
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

        /// <summary>
        /// The GetControlNumber
        /// </summary>
        /// <returns>The <see cref="ControlNumber"/></returns>
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

        /// <summary>
        /// The GetDocmumentInfo
        /// </summary>
        /// <returns>The <see cref="Dictionary{string, string}"/></returns>
        internal Dictionary<string, string> GetDocmumentInfo()
        {
            try
            {
                Dictionary<string, string> param = new Dictionary<string, string>();
                param.Add("ControlNumber", ControlNumber.ToString());
                param.Add("Org", Organization.Code);
                param.Add("Division", Organization.Name);
                param.Add("Id", Organization.ID);
                param.Add("Purpose", Purpose);
                return param;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        /// <summary>
        /// The GetDocumentHeader
        /// </summary>
        /// <returns>The <see cref="List{string}"/></returns>
        internal List<string> GetDocumentHeader()
        {
            List<string> division = new List<string>();
            division.Add("US EPA REGION 6");
            division.Add($"{Organization.Name}");
            division.Add($"ID : {Organization.ID}");
            division.Add($"Org Code: {Organization.Code}");
            return division;
        }

        /// <summary>
        /// The GetManagementHeader
        /// </summary>
        /// <returns>The <see cref="List{string}"/></returns>
        internal List<string> GetManagementHeader()
        {
            List<string> header = new List<string>();
            header.Add("US EPA REGION 6");
            header.Add("Management Division 6MD");
            header.Add("Office of the Regional Comptroller 6MD-C");
            header.Add("Budget and Accounting Section 6MD-CB");
            return header;
        }

        /// <summary>
        /// The GetNewDocNumber
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        internal int GetNewDocNumber()
        {
            try
            {
                return new DataBuilder(Source.InternalTransfers, Provider.SQLite).Table.Rows.Count + 1;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return -1;
            }
        }

        /// <summary>
        /// The GetSignatureInfo
        /// </summary>
        /// <returns>The <see cref="List{string}"/></returns>
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
