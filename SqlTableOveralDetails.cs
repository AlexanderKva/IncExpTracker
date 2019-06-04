using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using static IncExpTracker.SqlTableExpenses;
using static IncExpTracker.SqlTableIncome;

namespace IncExpTracker
{
    class SqlTableOveralDetails
    {
        public static string dbPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                    "MyDatabase.db3");
        [Table("OverallDetails")]
        public class OverallDetails
        {
            [PrimaryKey, AutoIncrement, Column("id")]
            public int id { get; set; }

            [MaxLength(12),Column("month")]
            public string Month { get; set; }

            [Column("MonthToInt")]
            public int MonthToInt { get; set; }

            [Column("IncThisMonth")]
            public double IncThisMonth { get; set; }

            [Column("ExpThisMonth")]
            public double ExpThisMonth { get; set; }

            [Column("Summary")]
            public double Summary { get; set; }

            [Column("Year")]
            public int Year { get; set; }
            
            [Column("IncPayDay")]
            public double incPayDay { get; set; }

            [Column("IncTips")]
            public double incTips { get; set; }

            [Column("IncOther")]
            public double incOther { get; set; }

            [Column("ExpFood")]
            public double expFood { get; set; }

            [Column("ExpCiggies")]
            public double expCiggies { get; set; }

            [Column("ExpGas")]
            public double expGas { get; set; }

            [Column("ExpOther")]
            public double expOther { get; set; }
        }

        // Creates Table if it doesnt exist already
        public static void CreateOverallDetailsTable()
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<OverallDetails>();
        }

        // Select * (to fill the grid)
        public static List<OverallDetails> SelectOverallDetails()
        {
            List<OverallDetails> returnDetails = new List<OverallDetails>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<OverallDetails>();
            foreach (var s in table)
            {
                returnDetails.Add(s);
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return returnDetails;
        }

        // Select * where #Month == month && #Year == year 
        public static OverallDetails SelectEntry(int month, int year)
        {
            OverallDetails a = new OverallDetails();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<OverallDetails>();
            foreach (var s in table)
            {
                if (s.MonthToInt == month && s.Year == year)
                {
                    a.id = s.id;
                    a.IncThisMonth = s.IncThisMonth;
                    a.ExpThisMonth = s.ExpThisMonth;
                    a.Month = s.Month;
                    a.MonthToInt = s.MonthToInt;
                    a.Summary = s.Summary;
                    a.expCiggies = s.expCiggies;
                    a.expFood = s.expFood;
                    a.expGas = s.expGas;
                    a.expOther = s.expOther;
                    a.incOther = s.incOther;
                    a.incPayDay = s.incPayDay;
                    a.incTips = s.incTips;
                }
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return a;
        }

        // Select * where #Month == month && #Year == year
        public static OverallDetails SelectSpecificMonth(int month,int year)
        {
            OverallDetails returnEntry = null;
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<OverallDetails>();

            foreach (var s in table)
            {
                if (month == s.MonthToInt && year == s.Year)
                {
                    returnEntry = s;
                }
            }
            db.Dispose();
            GC.Collect();
            db.Close();

            return returnEntry;
        }

        // Inserts an entry in DB, if exists, updates it
        public static void InsertEntry(string descr,double inc, double exp, DateTime date)
        {
            OverallDetails item = new OverallDetails();
            var db = new SQLiteConnection(dbPath);
            OverallDetails checkIfExists = SelectSpecificMonth(date.Month, date.Year);
            
            // If != null, update entry!
            if (checkIfExists != null)
            {
                item = checkIfExists;
                item.id = checkIfExists.id;

                item.IncThisMonth += inc;
                item.ExpThisMonth += exp;
                item.Summary = item.IncThisMonth - item.ExpThisMonth;

                item.MonthToInt = date.Month;
                item.Month = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month);
                item.Year = date.Year;

                if (descr == "PayDay") { item.incPayDay += inc; }
                else if (descr == "Tips") { item.incTips += inc; }
                else { item.incOther += inc; }

                if (descr == "Food") { item.expFood += exp; }
                else if (descr == "Gasoline") { item.expGas += exp; }
                else if (descr == "Ciggies") { item.expCiggies += exp; }
                else { item.expOther += exp; }

                db.Update(item);
            }
            // Else, entry doesnt exist, create a new one!
            else
            {
                item.IncThisMonth = inc;
                item.ExpThisMonth = exp;
                item.Summary = item.IncThisMonth - item.ExpThisMonth;

                item.MonthToInt = date.Month;
                item.Month = DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month);
                item.Year = date.Year;

                if (descr == "PayDay") { item.incPayDay = inc; }
                else if (descr == "Tips") { item.incTips = inc; }
                else { item.incOther = inc; }

                if (descr == "Food") { item.expFood = exp; }
                else if (descr == "Gasoline") { item.expGas = exp; }
                else if (descr == "Ciggies") { item.expCiggies = exp; }
                else { item.expOther = exp; }
                db.Insert(item);
            }
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        // For "Edit entry" option only!
        // Requires: month - year - income instance - new income instance - expense instance - new expense instance
        public static void UpdateEntries(string descr, int month, int year, double incomeInstance, double newIncomeInstance, double expensesInstance, double newExpenseInstance)
        {
            OverallDetails item = new OverallDetails();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<OverallDetails>();

            foreach (var s in table)
            {
                if (s.MonthToInt == month && s.Year == year)
                {
                    item = s;
                    item.id = s.id;

                    item.IncThisMonth += newIncomeInstance - incomeInstance;
                    item.ExpThisMonth += newExpenseInstance - expensesInstance;
                    item.Summary = item.IncThisMonth - item.ExpThisMonth;

                    item.Month = s.Month;
                    item.MonthToInt = s.MonthToInt;
                    item.Year = s.Year;

                    // Change Income category for Monthly Review
                    if (descr == "PayDay")
                    {
                        item.incPayDay += newIncomeInstance - incomeInstance;
                    }
                    else if (descr == "Tips")
                    {
                        item.incTips += newIncomeInstance - incomeInstance;
                    }
                    else
                    {
                        item.incOther += newIncomeInstance - incomeInstance;
                    }

                    // Change Expenses category for Monthly Review
                    if (descr == "Food")
                    {
                        item.expFood += newExpenseInstance - expensesInstance;
                    }
                    else if (descr == "Gasoline")
                    {
                        item.expGas += newExpenseInstance - expensesInstance;
                    }
                    else if (descr == "Ciggies")
                    {
                        item.expCiggies += newExpenseInstance - expensesInstance;
                    }
                    else
                    {
                        item.expOther += newExpenseInstance - expensesInstance;
                    }

                    
                }
            }

            // if MonthToInt == 0 => There are no entries on selected month, Hence we have the first entry of the month
            if (item == null)
            {
                InsertEntry(descr, newIncomeInstance, newExpenseInstance, DateTime.Now);
            }
            //else
            //// There is already an Entry for the current month
            //// Update Inc/Exp - Summ. 
            //{
            //    if (newIncomeInstance == 0 && incomeInstance == 0)
            //    {
            //        item.ExpThisMonth = item.ExpThisMonth - expensesInstance + newExpenseInstance;
            //    }
            //    else
            //    {
            //        item.IncThisMonth = item.IncThisMonth - incomeInstance + newIncomeInstance;
            //    }

            //    item.Summary = item.IncThisMonth - item.ExpThisMonth;
            //    
            //}
            db.Update(item);
            db.Dispose();
            GC.Collect();
            db.Close();
        

    }

        // Checks if there is already a last month entry -if not- creates one
        public static void CheckForNewEntries()
        {
            OverallDetails returnEntry = null;

            var db = new SQLiteConnection(dbPath);
            var table = db.Table<OverallDetails>();
            int prevMonth = DateTime.Now.AddMonths(-1).Month;
            int prevMonthyear = DateTime.Now.AddMonths(-1).Year;
            foreach (var s in table)
            {
                if (prevMonth == s.MonthToInt && s.Year == prevMonthyear)
                {
                    returnEntry = s;
                }
            }

            // No entry found?! Create one!
            if (returnEntry == null)
            {
                InsertEntry("",0,0,DateTime.Now.AddMonths(-1));
            }
            db.Dispose();
            GC.Collect();
            db.Close();
        }
    }
}
