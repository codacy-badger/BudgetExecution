using Ninja.Forms;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.Data;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public enum Command
            {
                Select, Insert, Update, Delete, Create, Drop, Alter
            }

            public enum Connection
            {
                Sqlite = 1, Excel = 2, SqlServer = 3, Access = 4
            }

            public enum FileExt
            {
                xlsx = 1, csv = 2, txt = 3, pdf = 4, doc = 5
            }

            public enum FundCode
            {
                B, BR, BR2, BR3, T, TC, TD, TR, TR1, TR2, TR2A, TR2B, TR3, F, FC, FD, H, HC, HD, E1, E1C, E1D, E2, E2C, E2D, E3,
                E3C, E3D, E4, E4C, E4D, E5, E5C, E5D, ZL
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

            public enum Provider
            {
                Sqlite = 1, Excel = 2, SqlServer = 3, Access = 4
            }

            public enum Source
            {
                T6, T7, B6, E1, P6, P7, P8, A6, O6, O7, O8, F6, EPM, LUST, OIL, STAG, SUPERFUND, SF6A, EJ, EN, MD, RC, RA, SF, WQ, MM, WSA, WCF, MDR, XA
            }


            public enum PrcFilter
            {
                ID, BFY, RPIO, Fund, FundName, BOC, BocName, NPM, Goal, GoalName, Objective, ObjectiveName, Division, ProgramArea, ProgramAreaName, ProgramProjectCode, ProgramProjectName
            }

            public enum ChartFilter
            {
                Fund, FundName, BOC, BocName, NPM, Goal, GoalName, Objective, ObjectiveName, RC, DivisionName, ProgramArea, ProgramAreaName, ProgramProjectCode, ProgramProjectName
            }

          
            public enum Metric
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

            #region Delegates

            public delegate ChartControl GetChart(ChartControl chart, string title, Dictionary<string, double> data);

            public delegate string GetName(string code);

            public delegate void NinjaForm();

            public delegate Tuple<DataSet, decimal[]> QueryData(Source source, Dictionary<string, object> param);

            public delegate bool Verify(DataTable table, Dictionary<string, object> param);

            #endregion Delegates
        }
    }
}