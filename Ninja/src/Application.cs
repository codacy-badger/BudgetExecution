// <copyright file="Application.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Data;
using Syncfusion.Windows.Forms.Chart;

namespace BudgetExecution
{
    // Delegates
    public delegate DataTable TableDelegate(DataTable table, Field column, string filter);

    /// <summary>
    /// The DataDelegate
    /// </summary>
    /// <param name="table">The table<see cref="DataTable"/></param>
    /// <param name="column">The column<see cref="Field[]"/></param>
    /// <param name="filter">The filter<see cref="string[]"/></param>
    /// <returns>The <see cref="DataTable"/></returns>
    public delegate DataTable DataDelegate(DataTable table, Field[] column, string[] filter);

    /// <summary>
    /// The Fields
    /// </summary>
    /// <param name="table">The table<see cref="DataTable"/></param>
    /// <param name="filter">The filter<see cref="string"/></param>
    /// <returns>The <see cref="string[]"/></returns>
    public delegate string[] Fields(DataTable table, string filter);

    /// <summary>
    /// The ChartDelegate
    /// </summary>
    /// <param name="chart">The chart<see cref="ChartControl"/></param>
    /// <param name="title">The title<see cref="string"/></param>
    /// <param name="data">The data<see cref="Dictionary{string, double}"/></param>
    /// <returns>The <see cref="ChartControl"/></returns>
    public delegate ChartControl ChartDelegate(ChartControl chart, string title, Dictionary<string, double> data);

    /// <summary>
    /// The InsertDelegate
    /// </summary>
    /// <param name="source">The source<see cref="Source"/></param>
    /// <param name="provider">The provider<see cref="Provider"/></param>
    /// <param name="dpr">The dpr<see cref="Dictionary{string, object}"/></param>
    public delegate void InsertDelegate(Source source, Provider provider, Dictionary<string, object> dpr);

    /// <summary>
    /// The UpdateDelegate
    /// </summary>
    /// <param name="source">The source<see cref="Source"/></param>
    /// <param name="provider">The provider<see cref="Provider"/></param>
    /// <param name="dpr">The dpr<see cref="Dictionary{string, object}"/></param>
    public delegate void UpdateDelegate(Source source, Provider provider, Dictionary<string, object> dpr);

    /// <summary>
    /// The DeleteDelegate
    /// </summary>
    /// <param name="source">The source<see cref="Source"/></param>
    /// <param name="provider">The provider<see cref="Provider"/></param>
    /// <param name="dpr">The dpr<see cref="Dictionary{string, object}"/></param>
    public delegate void DeleteDelegate(Source source, Provider provider, Dictionary<string, object> dpr);

    /// <summary>
    /// The ElementDelegate
    /// </summary>
    /// <param name="table">The table<see cref="DataTable"/></param>
    /// <param name="column">The column<see cref="Field"/></param>
    /// <returns>The <see cref="Dictionary{string, string[]}"/></returns>
    public delegate Dictionary<string, string[]> ElementDelegate(DataTable table, Field column);

    // Enum
    public enum FileExt { /// <summary>
        /// Defines the XLSX
        /// </summary>
        XLSX = 1, 
        /// <summary>
        /// Defines the CSV
        /// </summary>
        CSV = 2, 
        /// <summary>
        /// Defines the TXT
        /// </summary>
        TXT = 3, 
        /// <summary>
        /// Defines the PDF
        /// </summary>
        PDF = 4, 
        /// <summary>
        /// Defines the DOC
        /// </summary>
        DOC = 5}

    /// <summary>
    /// Defines the FundCode
    /// </summary>
    public enum FundCode { /// <summary>
        /// Defines the B
        /// </summary>
        B, 
        /// <summary>
        /// Defines the BR
        /// </summary>
        BR, 
        /// <summary>
        /// Defines the BR1
        /// </summary>
        BR1, 
        /// <summary>
        /// Defines the BR2
        /// </summary>
        BR2, 
        /// <summary>
        /// Defines the BR3
        /// </summary>
        BR3, 
        /// <summary>
        /// Defines the T
        /// </summary>
        T, 
        /// <summary>
        /// Defines the TC
        /// </summary>
        TC, 
        /// <summary>
        /// Defines the TD
        /// </summary>
        TD, 
        /// <summary>
        /// Defines the TR
        /// </summary>
        TR, 
        /// <summary>
        /// Defines the TR1
        /// </summary>
        TR1, 
        /// <summary>
        /// Defines the TR2
        /// </summary>
        TR2, 
        /// <summary>
        /// Defines the TR2A
        /// </summary>
        TR2A, 
        /// <summary>
        /// Defines the TR2B
        /// </summary>
        TR2B, 
        /// <summary>
        /// Defines the TR3
        /// </summary>
        TR3, 
        /// <summary>
        /// Defines the F
        /// </summary>
        F, 
        /// <summary>
        /// Defines the FC
        /// </summary>
        FC, 
        /// <summary>
        /// Defines the FD
        /// </summary>
        FD, 
        /// <summary>
        /// Defines the H
        /// </summary>
        H, 
        /// <summary>
        /// Defines the HC
        /// </summary>
        HC, 
        /// <summary>
        /// Defines the HD
        /// </summary>
        HD, 
        /// <summary>
        /// Defines the E1
        /// </summary>
        E1, 
        /// <summary>
        /// Defines the E1C
        /// </summary>
        E1C, 
        /// <summary>
        /// Defines the E1D
        /// </summary>
        E1D, 
        /// <summary>
        /// Defines the E2
        /// </summary>
        E2, 
        /// <summary>
        /// Defines the E2C
        /// </summary>
        E2C, 
        /// <summary>
        /// Defines the E2D
        /// </summary>
        E2D, 
        /// <summary>
        /// Defines the E3
        /// </summary>
        E3, 
        /// <summary>
        /// Defines the E3C
        /// </summary>
        E3C, 
        /// <summary>
        /// Defines the E3D
        /// </summary>
        E3D, 
        /// <summary>
        /// Defines the E4
        /// </summary>
        E4, 
        /// <summary>
        /// Defines the E4C
        /// </summary>
        E4C, 
        /// <summary>
        /// Defines the E4D
        /// </summary>
        E4D, 
        /// <summary>
        /// Defines the E5
        /// </summary>
        E5, 
        /// <summary>
        /// Defines the E5C
        /// </summary>
        E5C, 
        /// <summary>
        /// Defines the E5D
        /// </summary>
        E5D, 
        /// <summary>
        /// Defines the ZL
        /// </summary>
        ZL, 
        /// <summary>
        /// Defines the FS3
        /// </summary>
        FS3, 
        /// <summary>
        /// Defines the TS3
        /// </summary>
        TS3}

    /// <summary>
    /// Defines the Function
    /// </summary>
    public enum Function { /// <summary>
        /// Defines the SQLiteData
        /// </summary>
        SQLiteData, 
        /// <summary>
        /// Defines the BudgetTools
        /// </summary>
        BudgetTools, 
        /// <summary>
        /// Defines the DataTools
        /// </summary>
        DataTools, 
        /// <summary>
        /// Defines the DataMigration
        /// </summary>
        DataMigration, 
        /// <summary>
        /// Defines the ExcelImporter
        /// </summary>
        ExcelImporter, 
        /// <summary>
        /// Defines the PdfDataReader
        /// </summary>
        PdfDataReader}

    /// <summary>
    /// Defines the Goal
    /// </summary>
    public enum Goal { /// <summary>
        /// Defines the G1
        /// </summary>
        G1, 
        /// <summary>
        /// Defines the G2
        /// </summary>
        G2, 
        /// <summary>
        /// Defines the G3
        /// </summary>
        G3}

    /// <summary>
    /// Defines the HQ
    /// </summary>
    public enum HQ { /// <summary>
        /// Defines the A
        /// </summary>
        A, 
        /// <summary>
        /// Defines the B
        /// </summary>
        B, 
        /// <summary>
        /// Defines the C
        /// </summary>
        C, 
        /// <summary>
        /// Defines the D
        /// </summary>
        D, 
        /// <summary>
        /// Defines the E
        /// </summary>
        E, 
        /// <summary>
        /// Defines the F
        /// </summary>
        F, 
        /// <summary>
        /// Defines the G
        /// </summary>
        G, 
        /// <summary>
        /// Defines the H
        /// </summary>
        H, 
        /// <summary>
        /// Defines the J
        /// </summary>
        J, 
        /// <summary>
        /// Defines the L
        /// </summary>
        L, 
        /// <summary>
        /// Defines the M
        /// </summary>
        M}

    /// <summary>
    /// Defines the Sheet
    /// </summary>
    public enum Excel { /// <summary>
        /// Defines the Budget
        /// </summary>
        Budget, 
        /// <summary>
        /// Defines the Internal
        /// </summary>
        Internal, 
        /// <summary>
        /// Defines the External
        /// </summary>
        External, 
        /// <summary>
        /// Defines the Report
        /// </summary>
        Report}

    /// <summary>
    /// Defines the Net
    /// </summary>
    public enum Net { /// <summary>
        /// Defines the Zero
        /// </summary>
        Zero, 
        /// <summary>
        /// Defines the Increase
        /// </summary>
        Increase, 
        /// <summary>
        /// Defines the Decrease
        /// </summary>
        Decrease}

    /// <summary>
    /// Defines the Objective
    /// </summary>
    public enum Objective { /// <summary>
        /// Defines the O1
        /// </summary>
        O1, 
        /// <summary>
        /// Defines the O2
        /// </summary>
        O2, 
        /// <summary>
        /// Defines the O3
        /// </summary>
        O3, 
        /// <summary>
        /// Defines the O4
        /// </summary>
        O4, 
        /// <summary>
        /// Defines the O5
        /// </summary>
        O5}

    /// <summary>
    /// Defines the Numeric
    /// </summary>
    public enum Numeric { /// <summary>
        /// Defines the ID
        /// </summary>
        ID, 
        /// <summary>
        /// Defines the Amount
        /// </summary>
        Amount, 
        /// <summary>
        /// Defines the Obligations
        /// </summary>
        Obligations, 
        /// <summary>
        /// Defines the Commitments
        /// </summary>
        Commitments, 
        /// <summary>
        /// Defines the Authority
        /// </summary>
        Authority, 
        /// <summary>
        /// Defines the OpenCommitments
        /// </summary>
        OpenCommitments, 
        /// <summary>
        /// Defines the ULO
        /// </summary>
        ULO, 
        /// <summary>
        /// Defines the Budgeted
        /// </summary>
        Budgeted, 
        /// <summary>
        /// Defines the Posted
        /// </summary>
        Posted, 
        /// <summary>
        /// Defines the Balance
        /// </summary>
        Balance, 
        /// <summary>
        /// Defines the Hours
        /// </summary>
        Hours}

    /// <summary>
    /// Defines the Sql
    /// </summary>
    public enum Sql { /// <summary>
        /// Defines the SELECT
        /// </summary>
        SELECT, 
        /// <summary>
        /// Defines the INSERT
        /// </summary>
        INSERT, 
        /// <summary>
        /// Defines the UPDATE
        /// </summary>
        UPDATE, 
        /// <summary>
        /// Defines the DELETE
        /// </summary>
        DELETE, 
        /// <summary>
        /// Defines the CREATE
        /// </summary>
        CREATE, 
        /// <summary>
        /// Defines the DROP
        /// </summary>
        DROP}

    /// <summary>
    /// Defines the Field
    /// </summary>
    public enum Field { /// <summary>
        /// Defines the ID
        /// </summary>
        ID, 
        /// <summary>
        /// Defines the BudgetLevel
        /// </summary>
        BudgetLevel, 
        /// <summary>
        /// Defines the BFY
        /// </summary>
        BFY, 
        /// <summary>
        /// Defines the RPIO
        /// </summary>
        RPIO, 
        /// <summary>
        /// Defines the FundCode
        /// </summary>
        FundCode, 
        /// <summary>
        /// Defines the FundName
        /// </summary>
        FundName, 
        /// <summary>
        /// Defines the BOC
        /// </summary>
        BOC, 
        /// <summary>
        /// Defines the BocName
        /// </summary>
        BocName, 
        /// <summary>
        /// Defines the Org
        /// </summary>
        Org, 
        /// <summary>
        /// Defines the RC
        /// </summary>
        RC, 
        /// <summary>
        /// Defines the Code
        /// </summary>
        Code, 
        /// <summary>
        /// Defines the NPM
        /// </summary>
        NPM, 
        /// <summary>
        /// Defines the Goal
        /// </summary>
        Goal, 
        /// <summary>
        /// Defines the GoalName
        /// </summary>
        GoalName, 
        /// <summary>
        /// Defines the Objective
        /// </summary>
        Objective, 
        /// <summary>
        /// Defines the ObjectiveName
        /// </summary>
        ObjectiveName, 
        /// <summary>
        /// Defines the DivisionName
        /// </summary>
        DivisionName, 
        /// <summary>
        /// Defines the ProgramArea
        /// </summary>
        ProgramArea, 
        /// <summary>
        /// Defines the ProgramAreaName
        /// </summary>
        ProgramAreaName, 
        /// <summary>
        /// Defines the ProgramProjectCode
        /// </summary>
        ProgramProjectCode, 
        /// <summary>
        /// Defines the ProgramProjectName
        /// </summary>
        ProgramProjectName, 
        /// <summary>
        /// Defines the SiteProjectName
        /// </summary>
        SiteProjectName, 
        /// <summary>
        /// Defines the SiteProjectCode
        /// </summary>
        SiteProjectCode, 
        /// <summary>
        /// Defines the NpmName
        /// </summary>
        NpmName, 
        /// <summary>
        /// Defines the ReimbOrg
        /// </summary>
        ReimbOrg, 
        /// <summary>
        /// Defines the AH
        /// </summary>
        AH, 
        /// <summary>
        /// Defines the DCN
        /// </summary>
        DCN, 
        /// <summary>
        /// Defines the ControlNumber
        /// </summary>
        ControlNumber, 
        /// <summary>
        /// Defines the PurchaseRequest
        /// </summary>
        PurchaseRequest, 
        /// <summary>
        /// Defines the AgreementNumber
        /// </summary>
        AgreementNumber, 
        /// <summary>
        /// Defines the Type
        /// </summary>
        Type, 
        /// <summary>
        /// Defines the Division
        /// </summary>
        Division, 
        /// <summary>
        /// Defines the DocumentNumber
        /// </summary>
        DocumentNumber, 
        /// <summary>
        /// Defines the State
        /// </summary>
        State, 
        /// <summary>
        /// Defines the Organization
        /// </summary>
        Organization, 
        /// <summary>
        /// Defines the District
        /// </summary>
        District, 
        /// <summary>
        /// Defines the FocName
        /// </summary>
        FocName, 
        /// <summary>
        /// Defines the LastName
        /// </summary>
        LastName, 
        /// <summary>
        /// Defines the WorkCode
        /// </summary>
        WorkCode, 
        /// <summary>
        /// Defines the HrOrgCodeName
        /// </summary>
        HrOrgCodeName, 
        /// <summary>
        /// Defines the Name
        /// </summary>
        Name, 
        /// <summary>
        /// Defines the Section
        /// </summary>
        Section, 
        /// <summary>
        /// Defines the Email
        /// </summary>
        Email,
        Traveler
    }

    /// <summary>
    /// Defines the Provider
    /// </summary>
    public enum Provider { /// <summary>
        /// Defines the SQLite
        /// </summary>
        SQLite = 0, 
        /// <summary>
        /// Defines the Excel
        /// </summary>
        Excel = 1, 
        /// <summary>
        /// Defines the SqlServer
        /// </summary>
        SqlServer = 2, 
        /// <summary>
        /// Defines the SqlCe
        /// </summary>
        SqlCe = 3, 
        /// <summary>
        /// Defines the Access
        /// </summary>
        Access = 4, 
        /// <summary>
        /// Defines the OleDb
        /// </summary>
        OleDb = 5}

    /// <summary>
    /// Defines the Source
    /// </summary>
    public enum Source
    { /// <summary>
        /// Defines the Accounts
        /// </summary>
        Accounts,

        /// <summary>
        /// Defines the Awards
        /// </summary>
        Supplemental, 
        /// <summary>
        /// Defines the ControlNumbers
        /// </summary>
        ControlNumbers, 
        /// <summary>
        /// Defines the DivisionAccounts
        /// </summary>
        DivisionAccounts, 
        /// <summary>
        /// Defines the TravelObligations
        /// </summary>
        TravelObligations, 
        /// <summary>
        /// Defines the Divisions
        /// </summary>
        Divisions, 
        /// <summary>
        /// Defines the DWH
        /// </summary>
        DWH, 
        /// <summary>
        /// Defines the EJ
        /// </summary>
        EJ, 
        /// <summary>
        /// Defines the EN
        /// </summary>
        EN, 
        /// <summary>
        /// Defines the Personnel
        /// </summary>
        Personnel, 
        /// <summary>
        /// Defines the EPM
        /// </summary>
        EPM, 
        /// <summary>
        /// Defines the ExternalTransfers
        /// </summary>
        ExternalTransfers, 
        /// <summary>
        /// Defines the Funds
        /// </summary>
        Funds, 
        /// <summary>
        /// Defines the InternalTransfers
        /// </summary>
        InternalTransfers, 
        /// <summary>
        /// Defines the PRC
        /// </summary>
        PRC, 
        /// <summary>
        /// Defines the Programs
        /// </summary>
        Programs, 
        /// <summary>
        /// Defines the Benefits
        /// </summary>
        Benefits, 
        /// <summary>
        /// Defines the BudgetLevels
        /// </summary>
        BudgetLevels, 
        /// <summary>
        /// Defines the ProgramObligations
        /// </summary>
        ProgramObligations, 
        /// <summary>
        /// Defines the RegionalAccounts
        /// </summary>
        RegionalAccounts, 
        /// <summary>
        /// Defines the WorkCodes
        /// </summary>
        WorkCodes, 
        /// <summary>
        /// Defines the PayrollObligations
        /// </summary>
        PayrollObligations, 
        /// <summary>
        /// Defines the PayAccruals
        /// </summary>
        PayAccruals, 
        /// <summary>
        /// Defines the Sites
        /// </summary>
        Sites, 
        /// <summary>
        /// Defines the Reimbursables
        /// </summary>
        Reimbursables, 
        /// <summary>
        /// Defines the LUST
        /// </summary>
        LUST, 
        /// <summary>
        /// Defines the OIL
        /// </summary>
        OIL, 
        /// <summary>
        /// Defines the STAG
        /// </summary>
        STAG, 
        /// <summary>
        /// Defines the SF6A
        /// </summary>
        SF6A, 
        /// <summary>
        /// Defines the SUPERFUND
        /// </summary>
        SUPERFUND, 
        /// <summary>
        /// Defines the MD
        /// </summary>
        MD, 
        /// <summary>
        /// Defines the RC
        /// </summary>
        RC, 
        /// <summary>
        /// Defines the RA
        /// </summary>
        RA, 
        /// <summary>
        /// Defines the SF
        /// </summary>
        SF, 
        /// <summary>
        /// Defines the Transfers
        /// </summary>
        Transfers, 
        /// <summary>
        /// Defines the WQ
        /// </summary>
        WQ, 
        /// <summary>
        /// Defines the MM
        /// </summary>
        MM, 
        /// <summary>
        /// Defines the WSA
        /// </summary>
        WSA, 
        /// <summary>
        /// Defines the WCF
        /// </summary>
        WCF, 
        /// <summary>
        /// Defines the MDR
        /// </summary>
        MDR, 
        /// <summary>
        /// Defines the XA
        /// </summary>
        XA, 
        /// <summary>
        /// Defines the PAYROLL
        /// </summary>
        PAYROLL, 
        /// <summary>
        /// Defines the FTE
        /// </summary>
        FTE, 
        /// <summary>
        /// Defines the TRAVEL
        /// </summary>
        TRAVEL, 
        /// <summary>
        /// Defines the EXPENSES
        /// </summary>
        EXPENSES, 
        /// <summary>
        /// Defines the CONTRACTS
        /// </summary>
        CONTRACTS, 
        /// <summary>
        /// Defines the GRANTS
        /// </summary>
        GRANTS, 
        /// <summary>
        /// Defines the External
        /// </summary>
        External, 
        /// <summary>
        /// Defines the Utilization
        /// </summary>
        Utilization}

    /// <summary>
    /// Defines the Stat
    /// </summary>
    public enum Stat { /// <summary>
        /// Defines the Total
        /// </summary>
        Total = 0, 
        /// <summary>
        /// Defines the Count
        /// </summary>
        Count = 1, 
        /// <summary>
        /// Defines the Average
        /// </summary>
        Average = 2, 
        /// <summary>
        /// Defines the Ratio
        /// </summary>
        Ratio = 3}

    /// <summary>
    /// Defines the TransferType
    /// </summary>
    public enum TransferType { /// <summary>
        /// Defines the Admin
        /// </summary>
        Admin = 1, 
        /// <summary>
        /// Defines the BOC
        /// </summary>
        BOC = 2, 
        /// <summary>
        /// Defines the FromHQ
        /// </summary>
        FromHQ = 3, 
        /// <summary>
        /// Defines the ToHQ
        /// </summary>
        ToHQ = 4, 
        /// <summary>
        /// Defines the FromRpio
        /// </summary>
        FromRpio = 5, 
        /// <summary>
        /// Defines the ToRpio
        /// </summary>
        ToRpio = 6, 
        /// <summary>
        /// Defines the Recertification
        /// </summary>
        Recertification = 7, 
        /// <summary>
        /// Defines the ToDivision
        /// </summary>
        ToDivision = 8, 
        /// <summary>
        /// Defines the FromDivsion
        /// </summary>
        FromDivsion = 9, 
        /// <summary>
        /// Defines the SubAllowance
        /// </summary>
        SubAllowance = 10}

    /// <summary>
    /// Defines the <see cref="Application" />
    /// </summary>
    internal static class Application
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [ STAThread ]
        private static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}
