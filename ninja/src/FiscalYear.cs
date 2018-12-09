/// <summary>
/// <copyright file="FiscalYear.cs" company="PlaceholderCompany">
/// Copyright (c) PlaceholderCompany. All rights reserved.
/// </copyright>
/// </summary>
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;

    public struct FiscalYear
    {
        // CONTRUCTORS

        public FiscalYear(string bfy)
        {
            InputArgs = int.Parse(bfy);
            Date = DateTime.Parse($"10/01/{InputArgs}");
            CalendarDate = DateTime.Today;
            CalendarYear = CalendarDate.Year;
            CalendarMonth = CalendarDate.Month;
            CalendarDay = CalendarDate.Day;
            StartDate = GetStartDate(Date);
            EndDate = GetEndDate(Date);
            IsCurrent = DateTime.Today.Year < Date.Year;
            IsCarryover = !IsCurrent;
        }

        // PROPERTIES

        public DateTime CalendarDate { get; set; }

        public DateTime Date { get; }

        public int InputArgs { get; }

        public int CalendarYear { get; }

        public int CalendarMonth { get; }

        public int CalendarDay { get; }

        public bool IsCurrent { get; set; }

        public bool IsCarryover { get; set; }

        public DateTime StartDate { get; }

        public DateTime EndDate { get; }

        // METHODS

        public static DateTime GetStartDate(DateTime input)
        {
            try
            {
                if(input.Year > DateTime.Today.Year)
                {
                    return new DateTime(DateTime.Today.Year, 10, 1);
                }

                if(input.Year == DateTime.Today.Year)
                {
                    return new DateTime(DateTime.Today.Year - 1, 10, 1);
                }

                return default(DateTime);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return default(DateTime);
            }
        }

        public static DateTime GetEndDate(DateTime input)
        {
            try
            {
                if(input.Year == DateTime.Today.Year)
                {
                    return new DateTime(DateTime.Today.Year + 1, 9, 30);
                }

                if(input.Year > DateTime.Today.Year)
                {
                    return new DateTime(DateTime.Today.Year + 2, 9, 30);
                }

                return default(DateTime);
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return default(DateTime);
            }
        }

        public Dictionary<string, DateTime> GetFederalHolidays(Dictionary<string, string> d)
        {
            try
            {
                Dictionary<string, DateTime> holiday = new Dictionary<string, DateTime>();
                foreach(KeyValuePair<string, string> kvp in d)
                {
                    holiday.Add(kvp.Key, DateTime.Parse(kvp.Value));
                }

                return holiday;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public Dictionary<string, DateTime> GetNationalHolidays(Dictionary<string, string> d)
        {
            try
            {
                Dictionary<string, DateTime> holiday = new Dictionary<string, DateTime>();
                foreach(KeyValuePair<string, string> kvp in d)
                {
                    holiday.Add(kvp.Key, DateTime.Parse(kvp.Value));
                }

                return holiday;
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }

        public override string ToString()
        {
            try
            {
                return InputArgs.ToString();
            }
            catch(Exception ex)
            {
                new Error(ex).ShowDialog();
                return null;
            }
        }
    }
}