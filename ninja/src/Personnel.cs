using System;
using System.Collections.Generic;
using System.Data;

namespace BudgetExecution
{
    public class Personnel
    {
        // CONSTRUCTORS
        public Personnel(DataRow dbRow)
        {
            DbRow = dbRow;
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source);
            DbTable = DbData.Table;
        }

        public Personnel(int id, string eid, string hoc, string hon, string wc, string f, string l, string lvt, double leave, DataRow dbRow)
        {
            Source = Source.Personnel;
            Provider = Provider.SQLite;
            DbData = new DataBuilder(Source);
            DbTable = DbData.Table;
            ID = id;
            Email = eid;
            MailCode = hoc;
            Office = hon;
            WorkCode = wc;
            FirstName = f;
            LastName = l;
            Cell = lvt;
            Phone = leave;
            DbRow = dbRow;
        }

        public Personnel(DataRow dr, DataRow dbRow)
        {
            DbRow = dbRow;
            ID = int.Parse(dr["ID"].ToString());
            Email = dr["EmployId"].ToString();
            MailCode = dr["HrOrgCode"].ToString();
            Office = dr["HrOrgName"].ToString();
            WorkCode = dr["WorkCode"].ToString();
            FirstName = dr["First"].ToString();
            LastName = dr["Last"].ToString();
            Cell = dr["LeaveType"].ToString();
            Phone = double.Parse(dr["LeaveHours"].ToString());
        }

        // PROPERTIES
        public Source Source { get; }

        public Provider Provider { get; }

        public DataBuilder DbData { get; }

        public SQLiteQuery DbQuery { get; set; }

        public DataTable DbTable { get; set; }

        public DataRow DbRow { get; set; }

        public int ID { get; }

        public string Email { get; set; }

        public string FirstName { get; set; }

        public string MailCode { get; set; }

        public string Office { get; set; }

        public string LastName { get; set; }

        public double Phone { get; set; }

        public string Cell { get; set; }

        public string WorkCode { get; set; }

        public string Contractor { get; set; }

        public static void Insert(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.InsertCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Update(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.UpdateCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }

        public static void Delete(Source source, Provider provider, Dictionary<string, object> p)
        {
            try
            {
                var query = new Query(source, provider, Sql.INSERT, p);
                var conn = query.DataConnection;
                var command = query.DeleteCommand;
                conn.Open();
                command.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
            }
        }
    }
}
