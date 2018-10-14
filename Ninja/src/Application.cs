// <copyright file="Application.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using Syncfusion.Windows.Forms.Chart;

    // Delegates
    public delegate double[] Calculator(DataTable table);

    public delegate DbParameter[] Param(Dictionary<string, object> param);

    public delegate DataTable DataFilter(DataTable table, Field column, string filter);

    public delegate DataTable DataFiltr(DataTable table, Field[] column, string[] filter);

    public delegate string[] Fields(DataTable table, string filter);

    public delegate ChartControl GetChart(ChartControl chart, string title, Dictionary<string, double> data);

    public delegate void Insert(Source source, Provider provider, Dictionary<string, object> dpr);

    public delegate void Update(Source source, Provider provider, Dictionary<string, object> dpr);

    public delegate void Delete(Source source, Provider provider, Dictionary<string, object> dpr);

    public delegate Dictionary<string, string[]> ProgramElement(DataTable table, Field column);

    // Enum
    public enum FileExt { XLSX = 1, CSV = 2, TXT = 3, PDF = 4, DOC = 5 }

    public enum FundCode { B, BR, BR2, BR3, T, TC, TD, TR, TR1, TR2, TR2A, TR2B, TR3, F, FC, FD, H, HC, HD, E1, E1C, E1D, E2, E2C, E2D, E3, E3C, E3D, E4, E4C, E4D, E5, E5C, E5D, ZL, FS3, TS3 }

    public enum Function { SQLiteData, BudgetTools, DataTools, DataMigration, ExcelImporter, PdfDataReader }

    public enum Goal { G1, G2, G3 }

    public enum HQ { A, B, C, D, E, F, G, H, J, L, M }

    public enum Net { Zero, Increase, Decrease }

    public enum Objective { O1, O2, O3, O4, O5 }

    public enum Numeric { ID, Amount, Obligations, Commitments, LeaveHours, WorkHours }

    public enum Sql { SELECT, INSERT, UPDATE, DELETE, CREATE, DROP }

    public enum Field { ID, BudgetLevel, BFY, RPIO, Fund, FundName, BOC, BocName, Org, RC, Code, NPM, Goal, GoalName, Objective, ObjectiveName, DivisionName, ProgramArea, ProgramAreaName, ProgramProjectCode, ProgramProjectName, SiteProjectName, SiteProjectCode, NpmName, ReimbOrg, AH, DCN, ControlNumber, PurchaseRequest, AgreementNumber, Type, Division, DocumentNumber, State, Organization, District, FocName, LastName, WorkCode, HrOrgCodeName, Name }

    public enum Provider { SQLite = 0, Excel = 1, SqlServer = 2, SqlCe = 3, Access = 4, OleDb = 5 }

    public enum Source { Accounts, Awards, ControlNumbers, DivisionAccounts, DivisionObligations, TravelObligations, Divisions, DWH, EJ, EN, Employees, EPM, ExternalTransfers, Funds, InternalTransfers, PRC, Programs, Benefits, ProgramObligations, RegionalAccounts, Obligations, PayrollObligations, Sites, Reimbursables, LUST, OIL, STAG, SF6A, SUPERFUND, MD, RC, RA, SF, Transfers, WQ, MM, WSA, WCF, MDR, XA, PAYROLL, FTE, TRAVEL, EXPENSES, CONTRACTS, GRANTS }

    public enum Stat { Total = 0, Count = 1, Average = 2, Ratio = 3 }

    public enum TransferType { Admin = 1, BOC = 2, FromHQ = 3, ToHQ = 4, FromRpio = 5, ToRpio = 6, Recertification = 7, ToDivision = 8, FromDivsion = 9, SubAllowance = 10 }

    static internal class Application
    {
        /// <summary>
        ///     The main entry point for the application.
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
