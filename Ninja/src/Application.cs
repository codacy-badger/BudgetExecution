﻿// <copyright file="Application.cs" company="PlaceholderCompany">
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

    public delegate DataTable DataDelegate(DataTable table, Field[] column, string[] filter);

    public delegate string[] Fields(DataTable table, string filter);

    public delegate ChartControl ChartDelegate(ChartControl chart, string title, Dictionary<string, double> data);

    public delegate void InsertDelegate(Source source, Provider provider, Dictionary<string, object> dpr);

    public delegate void UpdateDelegate(Source source, Provider provider, Dictionary<string, object> dpr);

    public delegate void DeleteDelegate(Source source, Provider provider, Dictionary<string, object> dpr);

    public delegate Dictionary<string, string[]> ElementDelegate(DataTable table, Field column);

    // Enum
    public enum FileExt { XLSX = 1, CSV = 2, TXT = 3, PDF = 4, DOC = 5 }

    public enum FundCode { B, BR, BR1, BR2, BR3, T, TC, TD, TR, TR1, TR2, TR2A, TR2B, TR3, F, FC, FD, H, HC, HD, E1, E1C, E1D, E2, E2C, E2D, E3, E3C, E3D, E4, E4C, E4D, E5, E5C, E5D, ZL, FS3, TS3 }

    public enum Function { SQLiteData, BudgetTools, DataTools, DataMigration, ExcelImporter, PdfDataReader }

    public enum Goal { G1, G2, G3 }

    public enum HQ { A, B, C, D, E, F, G, H, J, L, M }

    public enum Sheet { Budget, Internal, External, Report }

    public enum Net { Zero, Increase, Decrease }

    public enum Objective { O1, O2, O3, O4, O5 }

    public enum Numeric { ID, Amount, Obligations, Commitments, Authority, OpenCommitments, ULO, Budgeted, Posted, Balance, Hours }

    public enum Sql { SELECT, INSERT, UPDATE, DELETE, CREATE, DROP }

    public enum Field { ID, BudgetLevel, BFY, RPIO, FundCode, FundName, BOC, BocName, Org, RC, Code, NPM, Goal, GoalName, Objective, ObjectiveName, DivisionName, ProgramArea, ProgramAreaName, ProgramProjectCode, ProgramProjectName, SiteProjectName, SiteProjectCode, NpmName, ReimbOrg, AH, DCN, ControlNumber, PurchaseRequest, AgreementNumber, Type, Division, DocumentNumber, State, Organization, District, FocName, LastName, WorkCode, HrOrgCodeName, Name }

    public enum Provider { SQLite = 0, Excel = 1, SqlServer = 2, SqlCe = 3, Access = 4, OleDb = 5 }

    public enum Source { Accounts, Awards, ControlNumbers, DivisionAccounts, TravelObligations, Divisions, DWH, EJ, EN, Personnel, EPM, ExternalTransfers, Funds, InternalTransfers, PRC, Programs, Benefits, BudgetLevels, ProgramObligations, RegionalAccounts, WorkCodes, PayrollObligations, PayAccruals, Sites, Reimbursables, LUST, OIL, STAG, SF6A, SUPERFUND, MD, RC, RA, SF, Transfers, WQ, MM, WSA, WCF, MDR, XA, PAYROLL, FTE, TRAVEL, EXPENSES, CONTRACTS, GRANTS, External }

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
