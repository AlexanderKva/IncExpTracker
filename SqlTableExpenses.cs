using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

namespace IncExpTracker
{
    class SqlTableExpenses
    {
        public static string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "MyDatabase.db3");

        [Table("Expenses")]
        public class ExpensesTrack
        {
            [PrimaryKey, AutoIncrement, Column("id")]
            public int Id { get; set; }
            [MaxLength(20),Column("date")]
            public DateTime Date { get; set; }
            [Column("amount")]
            public double Amount { get; set; }
            [MaxLength(20),Column("descr")]
            public string Descr { get; set; }
        }

        // Creates Table if it doesnt exist already
        public static void CreateExpensesTable()
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<ExpensesTrack>();
        }

        // Select * 
        public static List<ExpensesTrack> SelectExpenses()
        {
            List<ExpensesTrack> returnTable = new List<ExpensesTrack>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();
            foreach (var s in table)
            {
                returnTable.Add(s);
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return returnTable;
        }

        // Select * where #Month == month && #Year == year
        public static List<ExpensesTrack> SelectedMonthExpenses(int month, int year)
        {
            List<ExpensesTrack> selectedMonth = new List<ExpensesTrack>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();
            foreach (var s in table)
            {
                if (s.Date.Month == month && s.Date.Year == year)
                {
                    selectedMonth.Add(s);
                }
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return selectedMonth;
        }

        // Select * where #id == id
        public static VMEntry SelectEntry(int id)
        {
            VMEntry returnEntry = new VMEntry();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();
            foreach (var s in table)
            {
                if (s.Id == id)
                {
                    returnEntry.Id = s.Id;
                    returnEntry.Date = s.Date;
                    returnEntry.Amount = s.Amount;
                    returnEntry.Descr = s.Descr;
                }
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return returnEntry;
        }

        /* Insert Into Expenses (..)
         * SqlTableOveralDetails has to be up-to-date as well
         */
        public static void InsertData(ExpensesTrack newEntry)
        {
            var db = new SQLiteConnection(dbPath);
            SqlTableOveralDetails.InsertEntry(newEntry.Descr, 0, newEntry.Amount, newEntry.Date);
            db.Insert(newEntry);
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        /* Update Expenses where #id == id 
         * SqlTableOveralDetails has to be up-to-date as well (via UpdateEntries)
         */
        public static void UpdateData(ExpensesTrack entryToUpdate)
        {
            double lastExpValue = 0;
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();
            foreach (var s in table)
            {
                if (entryToUpdate.Id == s.Id)
                {
                    lastExpValue = s.Amount;
                }
            }
            SqlTableOveralDetails.UpdateEntries(entryToUpdate.Descr, entryToUpdate.Date.Month, entryToUpdate.Date.Year, 0, 0, lastExpValue, entryToUpdate.Amount);
            db.Update(entryToUpdate);
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        /* Delete where #id == id
         * SqlTableOveralDetails has to be up-to-date as well (via UpdateEntries)
         *      (just does the Math and adds or subtracts amounts)
         */
        public static void DeleteRow(int id)
        {
            VMEntry local = new VMEntry();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();
            foreach (var s in table)
            {
                if (s.Id == id)
                {
                    local.Id = s.Id;
                    local.Date = s.Date;
                    local.Amount = s.Amount;
                    local.Descr = s.Descr;
                }
            }
            SqlTableOveralDetails.UpdateEntries(local.Descr,local.Date.Month, local.Date.Year, 0, 0, local.Amount, 0);
            var delete = db.Query<ExpensesTrack>("Delete from Expenses where Id = " + id);
            db.Dispose();
            GC.Collect();
            db.Close();
        }
       
        /* Query that returns expenses 
         * of a specific month
         * groupped by Description
         */
        public static List<VMMonthlyDetails> SelectMonthlyExpenses(int month, int year)
        {
            List<VMMonthlyDetails> retList = new List<VMMonthlyDetails>();
            var db = new SQLiteConnection(dbPath);
           

            var a = db.Query<VMMonthlyDetails>("select descr, sum(amount) as amount,date " +
                                               "from Expenses " +
                                               "where date > ? AND date < ? " +
                                               "group by descr", new DateTime(year, month, 01).Ticks,
                                                new DateTime(year, month, 01).AddMonths(1).AddMinutes(-1).Ticks);
            foreach (var s in a)
            {
                    retList.Add(s);
            }
            
            db.Dispose();
            GC.Collect();
            db.Close();
            return retList;
        }
        /* Query that returns expenses
         * from the beginning of time
         * grouped by Description
         */ 
        public static List<VMMonthlyDetails> ExpensesAllTime()
        {
            List<VMMonthlyDetails> result = new List<VMMonthlyDetails>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();

            ExpensesTrack getFirstEntrysDate = table.FirstOrDefault();

            var a = db.Query<VMMonthlyDetails>("select descr, sum(amount) as amount " +
                                               "from Expenses " +
                                               "group by descr ");

            foreach (var s in a)
            {
                result.Add(s);
            }

            result.FirstOrDefault().Date = getFirstEntrysDate.Date;

            db.Dispose();
            GC.Collect();
            db.Close();
            return result;
        }
        /* Query that returns a specific Expense
         * from <Expenses Track> table
         * from the beginning of time
         * grouped by Month
         */
        public static List<VMMonthlyDetails> SpecificExpenseAllTime(string descr)
        {
            List<VMMonthlyDetails> result = new List<VMMonthlyDetails>();
            List<VMMonthlyDetails> zz = new List<VMMonthlyDetails>();
            
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<ExpensesTrack>();

            foreach (var s in table)
            {
                if (s.Descr == descr)
                {
                    zz.Add(new VMMonthlyDetails
                    {
                        Descr = s.Date.ToString("MMMM yyyy", CultureInfo.InvariantCulture),
                        Amount = s.Amount,
                        Date = s.Date
                    });
                }
            }

            var firstOne = zz.FirstOrDefault();
            var lastOne = zz.LastOrDefault();

            DateTime viewDate = new DateTime(firstOne.Date.Year, firstOne.Date.Month, 1);

            int lenght = (lastOne.Date.Year - firstOne.Date.Year) * 12 + (lastOne.Date.Month - firstOne.Date.Month);

            result.Add(new VMMonthlyDetails
            {
                Descr = firstOne.Date.ToString("MMMM yyyy", CultureInfo.InvariantCulture),
                Date = firstOne.Date
            });
            
            for (int i = 0; i < lenght; i++)
            {
                viewDate = viewDate.AddMonths(1);
                result.Add(new VMMonthlyDetails
                {
                    Descr = viewDate.ToString("MMMM yyyy", CultureInfo.InvariantCulture),
                    Date = viewDate.Date
                });
            }

            foreach (var s in zz)
            {
                foreach (var x in result)
                {
                    if (s.Descr == x.Descr )
                    {
                        x.Amount += s.Amount;
                    }
                }
            }

            db.Dispose();
            GC.Collect();
            db.Close();

            return result;
        }
    }
}
