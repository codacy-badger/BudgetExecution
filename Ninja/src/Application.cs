﻿// <copyright file="Application.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using Syncfusion.Windows.Forms.Chart;

    // Delegates
    public delegate double[] Calculator(DataTable table);

    public delegate DataTable DataFilter(DataTable table, Field prcfilter, string filter);

    public delegate string[] ColumnFilter(DataTable table, string filter);

    public delegate ChartControl GetChart(ChartControl chart, string title, Dictionary<string, double> data);

    // Enum
    public enum FileExt
    {
        XLSX = 1, CSV = 2, TXT = 3, PDF = 4, DOC = 5
    }

    public enum FundCode
    {
        B, BR, BR2, BR3, T, TC, TD, TR, TR1, TR2, TR2A, TR2B, TR3, F, FC, FD, H, HC, HD, E1, E1C, E1D, E2, E2C, E2D, E3,
        E3C, E3D, E4, E4C, E4D, E5, E5C, E5D, ZL, FS3, TS3
    }

    public enum Function
    {
        SQLiteData, BudgetTools, DataTools, DataMigration, ExcelImporter, PdfDataReader
    }

    public enum Goal
    {
        G1, G2, G3
    }

    public enum HQ
    {
        A, B, C, D, E, F, G, H, J, L, M,
    }

    public enum Net
    {
        Zero, Increase, Decrease
    }

    public enum Objective
    {
        O1, O2, O3, O4, O5
    }

    public enum Field
    {
        ID, BudgetLevel, BFY, RPIO, Fund, FundName, BOC, BocName, Org, RC, Code, NPM, Goal, GoalName, Objective,
        ObjectiveName, DivisionName, ProgramArea, ProgramAreaName, ProgramProjectCode, ProgramProjectName,
        SiteProjectName, SiteProjectCode, NpmName, ReimbOrg, AH, DCN, ControlNumber, PurchaseRequest, AgreementNumber, Type,
        DivisionID, DocumentNumber, State, Organization, District, FocName, LastName, WorkCode, HrOrgCodeName
    }

    public enum Provider
    {
        SQLite = 1, OleDb = 2, SqlServer = 3, SqlCe = 4
    }

    public enum Source
    {
        Accounts, Awards, ControlNumbers, DivisionAccounts, DivisionObligations, Divisions, DWH, EJ, EN, Employees, EPM, ExternalTransfers, Funds, InternalTransfers, PRC, RegionalAccounts,
        Obligations, PayrollObligations, Sites, Reimbursables, LUST, OIL, STAG, SUPERFUND, MD, RC, RA, SF, Transfers, WQ,MM, WSA, WCF, MDR, XA, PAYROLL, FTE, TRAVEL, EXPENSES, CONTRACTS, GRANTS

    }

    public enum Stat
    {
        Total, Count, Average, Ratio
    }

    public enum TransferType
    {
        Admin = 1, BOC = 2, FromHQ = 3, ToHQ = 4, FromRpio = 5,
        ToRpio = 6, Recertification = 7, ToDivision = 8, FromDivsion = 9, SubAllowance = 10
    }

    internal static class Application
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(new MainForm());
        }
    }
}