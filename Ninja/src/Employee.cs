// <copyright file="Employee.cs" company="PlaceholderCompany">
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

        public Employee(int id, string eid, string hoc, string hon, string wc, string f, string l, string lvt, double leave)
        {
            ID = id;
            EmployId = eid;
            HrOrgCode = hoc;
            HrOrgName = hon;
            WorkCode = wc;
            First = f;
            Last = l;
            LeaveType = lvt;
            LeaveHours = leave;
        }

        public Employee(DataRow dr)
        {
            ID =  int.Parse(dr["ID"].ToString());
            EmployId = dr["EmployId"].ToString();
            HrOrgCode = dr["HrOrgCode"].ToString();
            HrOrgName = dr["HrOrgName"].ToString();
            WorkCode = dr["WorkCode"].ToString();
            First = dr["First"].ToString();
            Last = dr["Last"].ToString();
            LeaveType = dr["LeaveType"].ToString();
            LeaveHours = double.Parse(dr["LeaveHours"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public DataTable DbTable { get; }

        public DataRow DbRow { get; }

        public int ID { get; }

        public string EmployId { get; }

        public string First { get; }

        public string HrOrgCode { get; }

        public string HrOrgName { get; }

        public string Last { get; }

        public double LeaveHours { get; }

        public string LeaveType { get; }

        public string WorkCode { get; }
    }
}