﻿using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Budget
{
    namespace Ninja
    {
        namespace Data
        {
            public class Metric : IChartSeriesIndexedModel
            {
                public Metric()
                {
                }

                public Metric(Source source)
                {
                    Data = new DataBuilder(source);
                    Table = Data.Table;
                    E6 = Data.E6;
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Metrics = GetMetrics(Table);
                    FundTotals = GetTotals(Table, "FundName");
                    FundMetrics = GetMetrics(Table, "FundName");
                    BocTotals = GetTotals(Table, "BocName");
                    BocMetrics = GetMetrics(Table, "BocName");
                    NpmTotals = GetTotals(Table, "NPM");
                    NpmMetrics = GetMetrics(Table, "NPM");
                    ProgramProjectTotals = GetTotals(Table, "ProgramProjectCode");
                    ProgramProjectMetrics = GetMetrics(Table, "ProgramProjectCode");
                    ProgramAreaTotals = GetTotals(Table, "ProgramAreaCode");
                    ProgramAreaMetrics = GetMetrics(Table, "ProgramAreaCode");
                    GoalTotals = GetTotals(Table, "GoalName");
                    GoalMetrics = GetMetrics(Table, "GoalName");
                    ObjectiveTotals = GetTotals(Table, "ObjectiveName");
                    ObjectiveMetrics = GetMetrics(Table, "ObjectiveName");
                }

                public Metric(DataBuilder data)
                {
                    Table = data.Table;
                    E6 = Table.DataSet;
                    Total = GetTotal(Table);
                    Count = Table.Rows.Count;
                    Average = GetAverage(Table);
                    Metrics = GetMetrics(Table);
                    FundTotals = GetTotals(Table, "FundName");
                    FundMetrics = GetMetrics(Table, "FundName");
                    BocTotals = GetTotals(Table, "BocName");
                    BocMetrics = GetMetrics(Table, "BocName");
                    NpmTotals = GetTotals(Table, "NPM");
                    NpmMetrics = GetMetrics(Table, "NPM");
                    ProgramProjectTotals = GetTotals(Table, "ProgramProjectCode");
                    ProgramProjectMetrics = GetMetrics(Table, "ProgramProjectCode");
                    ProgramAreaTotals = GetTotals(Table, "ProgramAreaCode");
                    ProgramAreaMetrics = GetMetrics(Table, "ProgramAreaCode");
                    GoalTotals = GetTotals(Table, "GoalName");
                    GoalMetrics = GetMetrics(Table, "GoalName");
                    ObjectiveTotals = GetTotals(Table, "ObjectiveName");
                    ObjectiveMetrics = GetMetrics(Table, "ObjectiveName");
                }

                public decimal Average { get; }
                public Dictionary<string, decimal[]> BocMetrics { get; set; }
                public Dictionary<string, decimal> BocTotals { get; set; }
                public double[] ChartData { get; set; }
                public int Count { get; }
                public DataBuilder Data { get; }
                public Dictionary<string, string[]> DataElement { get; }
                public DataSet E6 { get; }
                public Dictionary<string, decimal[]> FundMetrics { get; }
                public Dictionary<string, decimal> FundTotals { get; }
                public Dictionary<string, decimal[]> GoalMetrics { get; set; }
                public Dictionary<string, decimal> GoalTotals { get; set; }
                public decimal[] Metrics { get; }
                public Dictionary<string, decimal[]> NpmMetrics { get; set; }
                public Dictionary<string, decimal> NpmTotals { get; set; }
                public Dictionary<string, decimal[]> ObjectiveMetrics { get; set; }
                public Dictionary<string, decimal> ObjectiveTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramAreaMetrics { get; set; }
                public Dictionary<string, decimal> ProgramAreaTotals { get; set; }
                public Dictionary<string, decimal[]> ProgramProjectMetrics { get; set; }
                public Dictionary<string, decimal> ProgramProjectTotals { get; set; }
                public DataTable Table { get; set; }
                public decimal Total { get; }

                public event ListChangedEventHandler Changed;

                public decimal GetAverage(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<decimal>("Amount")).Average();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return -1M;
                    }
                }

                public string[] GetCodes(DataTable table, string column)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => p.Field<string>(column)).Distinct().ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

                public int GetCount(DataTable table)
                {
                    try
                    {
                        return table.Rows.Count;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return -1;
                    }
                }

                public Dictionary<string, string[]> GetDataElements(DataTable table)
                {
                    var data = new Dictionary<string, string[]>();
                    foreach (DataColumn dc in table.Columns)
                    {
                        if (dc.ColumnName.Equals("Id") || dc.ColumnName.Equals("Amount"))
                            continue;
                        data.Add(dc.ColumnName, GetCodes(table, dc.ColumnName));
                    }
                    if (data.ContainsKey("Id")) data.Remove("Id");
                    if (data.ContainsKey("Amount")) data.Remove("Amount");
                    if (data.ContainsKey("P6_Id")) data.Remove("P6_Id");
                    return data;
                }

                public bool GetEmpty(int index)
                {
                    return false;
                }

                public decimal[] GetMetrics(DataTable table)
                {
                    var count = GetCount(table);
                    return new decimal[] { GetTotal(table), (decimal)count, GetAverage(table) };
                }

                public PRC[] GetPrcArray(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Select(p => new PRC()).ToArray();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

                public decimal GetTotal(DataTable table)
                {
                    try
                    {
                        return table.AsEnumerable().Sum(p => p.Field<decimal>("Amount"));
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return -1M;
                    }
                }

                public double[] GetY(int index)
                {
                    return new double[] { ChartData[index] };
                }

                private Tuple<DataTable, PRC[], decimal, int> GetAllocation(DataTable table)
                {
                    return new Tuple<DataTable, PRC[], decimal, int>(table, GetPrcArray(table), GetTotal(table), GetCount(table));
                }

                private double[] GetChartData(Dictionary<string, decimal> data)
                {
                    try
                    {
                        var val = new double[data.Values.Count];
                        for (int i = 0; i < data.Values.Count; i++)
                        {
                            foreach (KeyValuePair<string, decimal> kvp in data)
                            {
                                val[i] = (double)kvp.Value;
                            }
                        }
                        return val;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message);
                        return null;
                    }
                }

                private Dictionary<string, decimal>[] GetChartInput()
                {
                    return new Dictionary<string, decimal>[] {FundTotals, BocTotals, NpmTotals, GoalTotals,
                        ObjectiveTotals, ProgramAreaTotals, ProgramProjectTotals};
                }

                private Dictionary<string, decimal[]> GetMetrics(DataTable table, string column)
                {
                    try
                    {
                        Dictionary<string, decimal[]> info = new Dictionary<string, decimal[]>();
                        if (table.GetFields().Contains(column))
                        {
                            foreach (string filter in DataElement[column])
                            {
                                decimal[] stat = new decimal[4];
                                stat[0] = GetTotal(table);
                                stat[1] = (decimal)GetCount(table);
                                stat[2] = stat[0] / stat[1];
                                stat[3] = (stat[0] / Total) * 100;
                                info.Add(filter, stat);
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

                private Dictionary<string, decimal> GetTotals(DataTable table, string column)
                {
                    try
                    {
                        var info = new Dictionary<string, decimal>();
                        if (table.GetFields().Contains(column))
                        {
                            foreach (string filter in DataElement[column])
                            {
                                var query = table.AsEnumerable().Where(p => p.Field<string>(column).Equals(filter))
                                    .Select(p => p.Field<decimal>("Amount")).Sum();
                                if (query > 0)
                                    info.Add(filter, query);
                            }
                        }
                        return info;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                        return null;
                    }
                }

            }
        }
    }
}