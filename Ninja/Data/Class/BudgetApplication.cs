using System;
using System.Collections.Generic;
using System.Data;
using Ninja.Forms;
using Syncfusion.Windows.Forms.Chart;

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

            public enum PrcField
            {
                ID, BFY, RPIO, Fund, FundName, BOC, BocName, Org, RC, NPM, Goal, GoalName, Objective, ObjectiveName, Division, ProgramArea, ProgramAreaName, ProgramProjectCode, ProgramProjectName
            }

            public enum Provider
            {
                Sqlite = 1, Excel = 2, SqlServer = 3, Access = 4
            }

            public enum Source
            {
                T6, T7, B6, E1, D6, P6, P7, P8, A6, O6, O7, O8, F6, S6, EPM, LUST, OIL, STAG, SUPERFUND, SF6A, EJ, EN, MD, RC, RA, SF, WQ, MM, WSA, WCF, MDR, XA,
                BOC10, BOC17, BOC21, BOC28, BOC36, BOC37, BOC41, C8, C7,
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
            
            //Delegates
            public delegate double[] Calculator(DataTable table);

            public delegate DataTable TableFilter(DataTable table, PrcField prcfilter, string filter);

            public delegate ChartControl GetChart(ChartControl chart, string title, Dictionary<string, double> data);
        }
    }
}