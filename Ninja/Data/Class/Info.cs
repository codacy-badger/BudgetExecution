using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public static class Info
            {
                public static string[] AgencyActivityCodes = {
                "1", "2", "3", "P1", "P3", "P8", "PS", "Q1", "Q3", "R1",
                "R2", "R5", "Regional", "W1", "W2", "53", "54", "55", "56", "4", "5", "6", "8", "9", "10", "11",
                "12", "50", "51", "52", "57", "61", "PY", "AT", "DG", "DH", "DN", "DS", "PM", "P4", "Q4",
                "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27",
                "28", "29", "30", "31", "33", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44",
                "45", "46", "47", "F1", "F2", "F3", "F4", "F5", "LA", "PT", "PQ", "UW", "AP", "DJ", "LD",
                "RL", "58", "B4", "B5", "BP", "PA", "PB", "PC", "PV", "PW", "R3", "R4"
                };

                public static string[] AgencyITCodes = {
                "EK", "FH", "FJ", "GB", "SL", "SM", "AA", "AB", "AC", "AD", "AE",
                "AF", "AG", "AH", "AJ", "AL", "AM", "AQ", "AR", "AT", "BB", "BC", "BG", "BH", "BJ", "BK",
                "BL", "BP", "CB", "CC", "CD", "CE", "CH", "CJ", "CK", "CL", "CP", "CQ", "CR", "CS", "CT",
                "CW", "DB", "DC", "DE", "DF", "DG", "DH", "DK", "DM", "DW", "EB", "EC", "ED", "EF", "EG",
                "EH", "EJ", "EL", "EM", "EN", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ", "FA",
                "FB", "FC", "FD", "FE", "FF", "FG", "FM", "FR", "FS", "FT", "FU", "FV", "FW", "GA", "GC",
                "GD", "GE", "GF", "GG", "GH", "GR", "GS", "GT", "HA", "HB", "HC", "HE", "IB", "IG", "IM",
                "IS", "JC", "JD", "JE", "JF", "JG", "JH", "JK", "JL", "JM", "JN", "JP", "KA", "KB", "LD",
                "LP", "MF", "MG", "MH", "MJ", "MT", "NC", "ND", "NE", "NF", "NG", "NH", "NJ", "PE", "PF",
                "PG", "PK", "PM", "PN", "PS", "PU", "QD", "QE", "RA", "RB", "RC", "RJ", "RK", "RS", "SB",
                "SC", "SD", "SE", "SG", "SH", "SK", "SN", "SP", "ST", "SX", "SY", "SZ", "TA", "TB", "TE",
                "TF", "TG", "TH", "TJ", "TK", "TM", "TN", "UA", "VR", "WB", "WC", "WD", "WE", "WI", "WM",
                "WS", "WT"
                };

                public static string[] AgencyOrgCodes = {
                "01", "02", "03", "04", "0400BMT", "05", "0500BMT", "06", "07", "08", "09", "10", "11", "13",
                "16", "17", "20", "23", "27", "28", "30", "31", "3100EEN", "32", "3200EEN", "3200P", "3200P1",
                "33", "36", "3600BMT", "39", "3900EEN", "40", "4000EEN", "50", "51", "52", "53", "5300EEN", "54",
                "56", "58", "69", "6900EEN", "72", "74", "75", "76", "77", "7700EEN", "85", "87", "8700BMT", "88",
                "9HF", "9R", "B1", "B2", "B3", "B4", "B5", "B9", "BE00EEN", "BX", "C2", "D1", "D3", "P8", "E1", "E100EEN",
                "E2", "E200EEN", "E4", "E5", "E8", "HA", "HB", "HD", "HE", "HM", "HM00EEN", "HP", "HS", "HT", "T1", "26",
                "5600EEN", "1000ALV", "9R00AG7", "D100AG7", "D100BG7", "35", "0A00C", "0A00E", "0A00F", "0A00P", "0A00R",
                "0A00S", "1A00C", "1A00E", "1A00F", "1A00P", "1A00R", "1A00S", "2A00C", "2A00E", "2A00F", "2A00P", "2A00R",
                "2A00S", "3A00C", "3A00E", "3A00F", "3A00P", "3A00R", "3A00S", "4A00C", "4A00E", "4A00F", "4A00P", "4A00R",
                "4A00S", "5A00C", "5A00E", "5A00F", "5A00P", "5A00R", "5A00S", "6A00C", "6A00E", "6A00F", "6A00P", "6A00R",
                "6A00S", "7A00C", "7A00E", "7A00P", "7A00R", "7A00S", "8A00C", "8A00E", "8A00F", "8A00P", "8A00R", "8A00S",
                "9A00C", "9A00E", "9A00F", "9A00P", "9A00R", "9A00S", "D4", "B7", "H1"
                };

                public static string[] AgencyPrcCodes = {
                "101A46", "101A46XP3", "101A46XP4", "101A46XQ3", "101A58", "101A59", "102A45", "102A58", "102A59","102A76", "102AH5", "102J59", "103AC4", "103AC5", "104A97", "104A98", "201B42", "201B53", "201B71",
                "201BL2", "202B63", "202B65", "202B66", "202B67", "202B68X33", "202B68XP8", "202B68XQC", "202B88",
                "202B89", "202BD4", "202BE2", "202BJ7", "202BK2", "202BK4", "202BK5", "202BL2", "202E63", "202G63X01",
                "202G65X01", "202G68X01", "202GJ7", "202GJ7X01", "202GK2X01", "202GK4X01", "202GK5X01", "202H63", "202JJ7",
                "202N63", "301D43", "301DC3", "301E43", "301E57", "301LE1", "301M43", "301MA4", "301ME9", "302D86",
                "302D86X58", "302DA1", "302DA2", "302JA1", "303D99", "304LD9", "401C54", "401CC2", "401CP8", "401CD7",
                "401CD8", "401CJ1", "401CJ2", "401CJ3", "401HD8", "401JJ1", "401LJ4", "401LJ5", "401MH3", "401MJ1",
                "402C95", "402E90", "402MG9", "501E44", "501E50", "501E52", "501J50", "501J52", "ZZZBE5", "ZZZEF2",
                "ZZZG73", "ZZZGE3", "ZZZGF2", "ZZZGF2X01", "ZZZGF2X02", "ZZZGF2X03", "ZZZGF2X10", "ZZZGF3", "ZZZGF5",
                "ZZZGF5X05", "ZZZGF5X06", "ZZZGF5X52", "ZZZGG7", "ZZZH70", "ZZZHF1", "ZZZHF2", "ZZZHF6", "ZZZHF8",
                "ZZZJE5", "ZZZJF1", "ZZZJF2", "ZZZM70", "ZZZME5", "ZZZME7", "ZZZME8", "ZZZMF5", "ZZZMG4", "ZZZMG5",
                "ZZZMG6", "ZZZMG7", "ZZZMH9", "ZZZNE4", "ZZZNF2", "ZZZNF9", "ZZZNG1", "101A61", "101FK6", "101FK6XR1",
                "102A59XTM", "102A61", "102AL2", "102FK6", "102FK6XR2", "104A72", "104A72XPC", "201B71XPB", "201FK7",
                "201FL2", "202FK7", "301FK8", "301FK8XPV", "301FK8XPW", "301FL2", "301GK8", "301JK8", "401F72", "401F72XPC",
                "401F84", "401FK9", "401FK9XRegional", "401FK9XRegional", "501E62", "ZZZA73", "102A04", "102A04XAT", "102A04XPM", "102A05",
                "102A17", "102A20", "201B03", "201B08", "201B23", "202B01", "202B06", "202B06XP1", "202B07", "202B20", "301D24",
                "302D11", "302D16", "303D11", "304L15", "401C09", "401C10", "402C13", "501E12", "501E14", "ZZZH21", "202B80",
                "201B81", "102AH4", "102AJ9", "202B51", "201B51", "202B78", "202B82", "301D79", "301D79XBP", "302DJ6", "303D86", "303D87",
                "303D91","ZZZPG2", "303D72", "303D72XPA", "303D72XPC", "303DC6", "303DC8", "303DC9", "303DD2", "501EC7", "501EH2", "501JC7",
                "ZZZD73"
                };

                public static string[] AgencyRpioCode = {
                "11", "13", "16", "17", "18", "20", "26", "27", "30", "35", "39", "75", "77", "01","02", "03", "04", "05", "06", "07", "08",
                "09", "10"
                };

                public static string[] Division = { "6WQ", "6WCF", "6MD", "6MDR", "WSA", "6MM", "6WSA", "6EN", "6RA", "6RC", "6SF", "6XA", "6EJ", "R06" };

                public static string[] DivisionIdTitleOrg = {
                "6MD | MANAGEMENT DIVISION | 06C", "6MM | MULTIMEDIA DIVISION | 06J", "6EN | COMPLIANCE & ENFORCEMENT DIVISION | 06M",
                "6RC | OFFICE OF REGIONAL COUNSEL | 06D", "6SF | SUPERFUND DIVISION | 06L", "6RA | OFFICE OF THE REGIONAL ADMINISTRATOR | 06A",
                "6EJ | ENVIRONMENTAL JUSTICE & TRIBAL AFFAIRS DIVISION | 06F", "6XA | THE OFFICE OF EXTERNAL AFFAIRS | 06X",
                "6WQ | WATER QUALITY DIVISION | 06K", "6WSA | WORKFORCE SUPPORT ACCOUNT | 06N",
                "6WCF | WORKING CAPITAL FUND | 06G"
                };

                public static string[] Divisions = { "6MD", "6MM", "6RA", "6SF", "6EJ", "6XA", "6WQ", "6EN", "6RC", "R06", "6WSA", "6WCF" };

                public static string[] DivisionTitle = {
                "6MD Management Division", "6MM MultiMedia Division", "6EN Compliance && Enforcement Division",
                "6RC Office of Regional Counsel", "6SF Superfund Division", "6RA The Office of the Regional Administrator",
                "6EJ Environmental Justice && Tribal Affairs Division", "6XA The Office of External Affairs",
                "6WQ Water Quality Protection Division", "EPA Region 6 Dallas,TX"
                };

                public static string[] MultiYears = {
                "2015", "2015 2016", "2016 2017", "2016", "2017 2018", "2017","2018 2019", "2018", "2019 2020","2019", "2020 2021","2020", "2021 2022", "2021",
                "2022", "2022 2023",
                };

                public static string[] NpmCodes = { "M", "L", "G", "J", "H", "C", "F", "A", "B", "P", "N", "D", "E" };

                public static string[] RcCodes = { "06C", "06A", "06L", "06F", "06X", "06K", "06J", "06M", "06D", "06N", "06G" };

                public static string[] Year = { "2017", "2018", "2019", "2020", "2021", "2021", "2022", "2024", "2025", "2026", "2027" };

                public static SortedList<string, object> DivisionLookUp()
                {
                    SortedList<string, object> d = new SortedList<string, object>();
                    d.Add("MD", "Management Division");
                    d.Add("MM", "MultiMedia Division");
                    d.Add("EN", "Enforcement Division");
                    d.Add("RC", "Regional Counsel");
                    d.Add("SF", "Superfund Division");
                    d.Add("RA", "Regional Administrator");
                    d.Add("EJ", "Tribal Affairs");
                    d.Add("XA", "External Affairs");
                    d.Add("WQ", "Water Quality");
                    d.Add("WSA", "Workforce Support");
                    d.Add("WCF", "Working Capital");
                    return d;
                }

                public static string DivisionName(string rc)
                {
                    switch (rc)
                    {
                        case "06K":
                            return "WATER DIVISION";

                        case "06C":
                            return "MANAGEMENT DIVISION";

                        case "06N":
                            return "WORKFORCE SUPPORT";

                        case "06G":
                            return "WORKING CAPITAL";

                        case "06J":
                            return "MULTIMEDIA DIVISION";

                        case "06R":
                            return "REGIONAL RESERVE";

                        case "06M":
                            return "ENFORCEMENT DIVISION";

                        case "06D":
                            return "REGIONAL COUNSEL";

                        case "06A":
                            return "REGIONAL ADMINISTRATOR";

                        case "06L":
                            return "SUPERFUND DIVISION";

                        case "6A":
                            return "SUPERFUND DIVISION";

                        case "06X":
                            return "EXTERNAL AFFAIRS";

                        case "06":
                            return "R06";

                        case "06F":
                            return "ENVIRONMENTAL JUSTICE";

                        case "":
                            return "R06";

                        default: return "R06";
                    }
                }

                public static string GetAppropriationName(string fundcode)
                {
                    switch (fundcode)
                    {
                        case "B":
                            return "EPM";

                        case "BR":
                            return "EPM REIMB.";

                        case "BR1":
                            return "EPM BR1";

                        case "BR3":
                            return "EPM BR3";

                        case "T":
                            return "SUPERFUND";

                        case "TD":
                            return "SUPERFUND RECOVERIES";

                        case "TR":
                            return "SUPERFUND REIMB.";

                        case "TR1":
                            return "SF STATE CONTRACT";

                        case "TR2":
                            return "SF SP ACCT NON-FED";

                        case "TR2A":
                            return "SF FED SPECIAL ACCT";

                        case "TR2B":
                            return "SF NONFED SPECIAL ACCT";

                        case "F":
                            return "LUST";

                        case "FC":
                            return "LUST CARRYOVER";

                        case "FD":
                            return "LUST RECOVERIES";

                        case "H":
                            return "OIL";

                        case "HC":
                            return "OIL CARRYOVER";

                        case "HD":
                            return "OIL RECOVERIES";

                        case "HR":
                            return "OIL REIMB";

                        case "E1":
                            return "CATEGORICAL GRANTS";

                        case "E1C":
                            return "CATEGORICAL GRANTS CARRYOVER";

                        case "E1D":
                            return "CATEGORICAL GRANTS RECOVERIES";

                        case "E2":
                            return "CLEAN WATER SRF";

                        case "E2C":
                            return "CWSRF CARRYOVERY";

                        case "E2D":
                            return "CWSRF RECOVERIES";

                        case "E3":
                            return "DRINKING WATER SRF";

                        case "E3C":
                            return "DWSRF CARRYOVER";

                        case "E3D":
                            return "DWSRF RECOVERIES";

                        case "E4":
                            return "SPECIAL PROJECTS";

                        case "E4C":
                            return "SPECIAL PROJECTS CARRYOVER";

                        case "E4D":
                            return "SPECIAL PROJECTS RECOVERIES";

                        case "E5":
                            return "STAG EARMARKS";

                        case "E5C":
                            return "STAG EARMARKS CARRYOVER";

                        case "E5D":
                            return "STAG EARMARKS RECOVERIES";

                        case "ZL":
                            return "DEEP WATER HORIZON";
                    }
                    return null;
                }

                public static string GetAppropriationTitle(string fundcode)
                {
                    switch (fundcode)
                    {
                        case "B":
                            return "ENVIRONMENTAL PROGRAMS AND MANAGEMENT";

                        case "BR":
                            return "EPM REIMB MULTIYEAR";

                        case "BR1":
                            return "EPM REIMB";

                        case "BR3":
                            return "EPM REIMB IPA NONFED";

                        case "T":
                            return "SUPERFUND APPROPRIATION";

                        case "TD":
                            return "SUPERFUND RECOVERIES";

                        case "TR":
                            return "SUPERFUND REIMB";

                        case "TR1":
                            return "SF STATE CONTRACT";

                        case "TR2":
                            return "SF SP ACCT NON-FED";

                        case "TR2A":
                            return "SF FED SPECIAL ACCT";

                        case "TR2B":
                            return "SF NONFED SPECIAL ACCT";

                        case "F":
                            return "UNDERGROUND STORAGE TANKS";

                        case "FC":
                            return "UNDERGROUND STORAGE TANKS CARRYOVER";

                        case "FD":
                            return "UNDERGROUND STORAGE TANKS RECOVERIES";

                        case "H":
                            return "OIL SPILL TRUSTFUND";

                        case "HC":
                            return "OIL SPILL TRUSTFUND CARRYOVER";

                        case "HD":
                            return "OIL SPILL TRUSTFUND RECOVERIES";

                        case "HR":
                            return "OIL SPILL TRUSTFUND REIMB";

                        case "E1":
                            return "STAG CATEGORICAL GRANTS";

                        case "E1C":
                            return "STAG CATEGORICAL GRANTS CARRYOVER";

                        case "E1D":
                            return "STAG CATEGORICAL GRANTS RECOVERIES";

                        case "E2":
                            return "STAG CLEAN WATER SRF";

                        case "E2C":
                            return "STAG CLEAN WATER SRF CARRYOVER";

                        case "E2D":
                            return "STAG CLEAN WATER SRF RECOVERIES";

                        case "E3":
                            return "STAG DRINKING WATER SRF";

                        case "E3C":
                            return "STAG DRINKING WATER SRF CARRYOVER";

                        case "E3D":
                            return "STAG DRINKING WATER SRF RECOVERIES";

                        case "E4":
                            return "STAG SPECIAL PROJECTS AND BROWNFIELDS";

                        case "E4C":
                            return "STAG SPECIAL PROJECTS AND BROWNFIELDS CARRYOVER";

                        case "E4D":
                            return "STAG SPECIAL PROJECTS AND BROWNFIELDS RECOVERIES";

                        case "E5":
                            return "OLD EARMARKS";

                        case "E5C":
                            return "OLD EARMARKS CARRYOVER";

                        case "E5D":
                            return "OLD EARMARKS RECOVERIES";
                    }
                    return null;
                }

                public static string GetBocName(string boc)
                {
                    try
                    {
                        switch (boc)
                        {
                            case "10":
                                return "PAYROLL";

                            case "17":
                                return "FTE";

                            case "21":
                                return "TRAVEL";

                            case "28":
                                return "SITE TRAVEL";

                            case "36":
                                return "EXPENSES";

                            case "37":
                                return "CONTRACTS";

                            case "38":
                                return "WCF";

                            case "41":
                                return "GRANTS";

                            default: return "NONE";
                        }
                    }
                    catch (System.Exception e)
                    {
                        MessageBox.Show(e.TargetSite + e.StackTrace);
                        return null;
                    }
                }

                public static string GetDivisionMailCode(string Org)
                {
                    try
                    {
                        switch (Org)
                        {
                            case "06K":
                                return "6WQ";

                            case "06G":
                                return "6WCF";

                            case "06C":
                                return "6MD";

                            case "06R":
                                return "6MDR";

                            case "06N":
                                return "6WSA";

                            case "06J":
                                return "6MM";

                            case "06M":
                                return "6EN";

                            case "06D":
                                return "6RC";

                            case "06A":
                                return "6RA";

                            case "06L":
                                return "6SF";

                            case "6A":
                                return "6SF";

                            case "06X":
                                return "6XA";

                            case "06F":
                                return "6EJ";

                            case "06":
                                return "R06";

                            default: return "R06";
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }

                public static string[] GetFields(this DataTable table)
                {
                    try
                    {
                        var columns = table.Columns;
                        string[] fields = new string[columns.Count];
                        for (int i = 0; i < columns.Count; i++)
                        {
                            foreach (DataColumn dc in columns)
                            {
                                fields[i] = dc.ColumnName;
                            }
                        }
                        return fields;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }

                public static string GetGoalName(string goal)
                {
                    try
                    {
                        switch (goal)
                        {
                            case "01":
                                return "CORE MISSION";

                            case "1":
                                return "CORE MISSION";

                            case "2":
                                return "COOPERATIVE FEDERALISM";

                            case "02":
                                return "COOPERATIVE FEDERALISM";

                            case "3":
                                return "RULE OF LAW AND PROCESS";

                            case "03":
                                return "RULE OF LAW AND PROCESS";

                            default:
                                return goal;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }

                public static string GetObjectiveName(string obj)
                {
                    try
                    {
                        switch (obj)
                        {
                            case "1":
                                return "COMPLIANCE WITH THE LAW";

                            case "01":
                                return "COMPLIANCE WITH THE LAW";

                            case "2":
                                return "CREATE CONSISTENCY AND CERTAINTY";

                            case "02":
                                return "CREATE CONSISTENCY AND CERTAINTY";

                            case "3":
                                return "PRIORITIZE ROBUST SCIENCE";

                            case "03":
                                return "PRIORITIZE ROBUST SCIENCE";

                            case "4":
                                return "STREAMLINE AND MODERNIZE";

                            case "04":
                                return "STREAMLINE AND MODERNIZE";

                            case "5":
                                return "IMPROVE EFFICIENCY AND EFFECTIVENESS";

                            case "05":
                                return "IMPROVE EFFICIENCY AND EFFECTIVENESS";

                            default:
                                return obj;
                        }
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }

                public static string GetTreasurySymbol(string fundcode)
                {
                    try
                    {
                        switch (fundcode)
                        {
                            case "B":
                                return "068/0108";

                            case "BR":
                                return "068/0108";

                            case "BR1":
                                return "068/0108";

                            case "BR3":
                                return "068/0108";

                            case "T":
                                return "68-68X8145";

                            case "TD":
                                return "68-68X8145";

                            case "TR":
                                return "68-68X8145";

                            case "TR1":
                                return "68-68X8145";

                            case "TR2":
                                return "68-68X8145";

                            case "TR2A":
                                return "68-68X8145";

                            case "TR2B":
                                return "68-68X8145";

                            case "F":
                                return "068-68X8153";

                            case "FC":
                                return "068-68X8153";

                            case "FD":
                                return "068-68X8153";

                            case "H":
                                return "068X8221";

                            case "HC":
                                return "068X8221";

                            case "HD":
                                return "068X8221";

                            case "HR":
                                return "068X8221";

                            case "E1":
                                return "068X0103";

                            case "E1C":
                                return "068X0103";

                            case "E1D":
                                return "068X0103";

                            case "E2":
                                return "068X0103";

                            case "E2C":
                                return "068X0103";

                            case "E2D":
                                return "068X0103";

                            case "E3":
                                return "068X0103";

                            case "E3C":
                                return "068X0103";

                            case "E3D":
                                return "068X0103";

                            case "E4":
                                return "068X0103";

                            case "E4C":
                                return "068X0103";

                            case "E4D":
                                return "068X0103";

                            case "E5":
                                return "068X0103";

                            case "E5C":
                                return "068X0103";

                            case "E5D":
                                return "068X0103";

                            case "ZL":
                                return "68 - 68X8145";
                        }
                        return null;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }

                public static bool IsChildOf(this DataRow child, DataRow parent)
                {
                    try
                    {
                        if (child["BudgetLevel"].ToString().Equals("8") &&
                    child["BFY"].ToString().Equals(parent["BFY"].ToString()) &&
                    child["Fund"].ToString().Equals(parent["Fund"].ToString()) &&
                    child["Code"].ToString().Equals(parent["Code"].ToString()) &&
                    child["BOC"].ToString().Equals(parent["BOC"].ToString()))
                            return true;
                        else
                            return false;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return false;
                    }
                }

                public static bool IsParentOf(this DataRow parent, DataRow child)
                {
                    try
                    {
                        if (parent["BudgetLevel"].ToString().Equals("7") &&
                            parent["BFY"].ToString().Equals(child["BFY"].ToString()) &&
                            parent["Fund"].ToString().Equals(child["Fund"].ToString()) &&
                            parent["Code"].ToString().Equals(child["Code"].ToString()) &&
                            parent["BOC"].ToString().Equals(child["BOC"].ToString()))
                            return true;
                        else
                            return false;
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return false;
                    }
                }

                public static PRC ToPrc(this DataRow row)
                {
                    try
                    {
                        return new PRC(row);
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.Message + ex.StackTrace);
                        return null;
                    }
                }
            }
        }
    }
}