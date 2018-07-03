﻿// <copyright file="Employee.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data;

    public class Employee
    {
        // CONSTRUCTORS
        public Employee()
        {
        }

        public Employee(string eid, string hoc, string hon, string wc, string f, string l, string lvt, double wk, double leave, double proj, double uselose)
        {
            EmployId = eid;
            HrOrgCode = hoc;
            HrOrgName = hon;
            WorkCode = wc;
            First = f;
            Last = l;
            LeaveType = lvt;
            Work = wk;
            Leave = leave;
            Projected = proj;
            UseLose = uselose;
        }

        public Employee(DataRow dr)
        {
            EmployId = dr["EmployId "].ToString();
            HrOrgCode = dr["HrOrgCode"].ToString();
            HrOrgName = dr["HrOrgName"].ToString();
            WorkCode = dr["WorkCode"].ToString();
            First = dr["First"].ToString();
            Last = dr["Last"].ToString();
            LeaveType = dr["LeaveType"].ToString();
            Work = double.Parse(dr["Work"].ToString());
            Leave = double.Parse(dr["Leave"].ToString());
            Projected = double.Parse(dr["Projected"].ToString());
            UseLose = double.Parse(dr["UseLose"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

        public string EmployId { get; }

        public string First { get; }

        public string HrOrgCode { get; }

        public string HrOrgName { get; }

        public string Last { get; }

        public double Leave { get; }

        public string LeaveType { get; }

        public double Projected { get; }

        public double UseLose { get; }

        public double Work { get; }

        public string WorkCode { get; }
    }
}