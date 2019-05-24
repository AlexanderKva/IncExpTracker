using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace IncExpTracker
{
    class SqlTableIncome
    {
        public static string dbPath = Path.Combine(
                 Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                 "MyDatabase.db3");


        [Table("Income")]
        public class IncomeTrack
        {
            [PrimaryKey, AutoIncrement, Column("id")]
            public int Id { get; set; }
            [MaxLength(20), Column("date")]
            public DateTime Date { get; set; }
            [Column("amount")]
            public double Amount { get; set; }
            [MaxLength(20),Column("descr")]
            public string Descr { get; set; }

        }

        // Creates Database if it doesnt exist already
        public static void DatabaseCreate()
        {
            string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.Personal),
            "database.db3");
            // dbPath contains a valid file path for the database file to be stored    

        }

        // Creates Table if it doesnt exist already
        public static void CreateIncomeTable()
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<IncomeTrack>();
            GC.Collect();
            db.Close();
        }

        // Select *
        public static List<IncomeTrack> SelectIncome()
        {
            List<IncomeTrack> returnTable = new List<IncomeTrack>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<IncomeTrack>();
            foreach (var s in table)
            {
                returnTable.Add(s);
                //Console.WriteLine("--" + s.Date + "--");
            }
            GC.Collect();
            db.Close();
            return returnTable;
        }

        // Select * where #Month == month && #Year == year
        public static List<IncomeTrack> SelectedMonthIncome(int month, int year)
        {
            List<IncomeTrack> selectedMonth = new List<IncomeTrack>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<IncomeTrack>();
            
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
            var table = db.Table<IncomeTrack>();
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

        /*  Insert Into Income
         *  SqlTableOveralDetails has to be up to date as well (via UpdateEntries)
         */
        public static void InsertData(IncomeTrack newIncome)
        {
            var db = new SQLiteConnection(dbPath);
            //*********************************
            SqlTableOveralDetails.InsertEntry(newIncome.Descr, newIncome.Amount, 0, newIncome.Date);
            //*********************************
            db.Insert(newIncome);
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        /*  Update Income where #id == id
         *  SqlTableOveralDetails has to be up to date as well (via UpdateEntries)
         */
        public static void UpdateData(IncomeTrack entryToUpdate)
        {
            double lastIncomeValue = 0;
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<IncomeTrack>();
            foreach (var s in table)
            {
                if (entryToUpdate.Id == s.Id)
                {
                    lastIncomeValue = s.Amount;
                }
            }
            SqlTableOveralDetails.UpdateEntries(entryToUpdate.Descr, entryToUpdate.Date.Month, entryToUpdate.Date.Year, lastIncomeValue, entryToUpdate.Amount, 0, 0);
            db.Update(entryToUpdate);
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        /* Delete where #id == id
         * SqlTableOveralDetails has to be up to date as well (via UpdateEntries)
         *      (just does the Math and adds or subtracts amounts)
         */
        public static void DeleteRow(int id)
        {
            VMEntry local = new VMEntry();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<IncomeTrack>();
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
            SqlTableOveralDetails.UpdateEntries(local.Descr, local.Date.Month, local.Date.Year, local.Amount, 0, 0, 0);
            var delete = db.Query<IncomeTrack>("Delete from Income where Id = " + id);
            db.Dispose();
            GC.Collect();
            db.Close();
        }


        /* Groups Categories and returns a list of SUM(PayDay),SUM(Tips),SUM(Other)
         * for a selected month
         */
        public static List<VMEntry> SelectSpecificItems(int month, int year)
        {
            List<VMEntry> list2ret = new List<VMEntry>();
            VMEntry salaryItems = new VMEntry();
            VMEntry tipItems = new VMEntry();
            VMEntry others = new VMEntry();

            salaryItems.Descr = "PayDay";
            tipItems.Descr = "Tips";
            others.Descr = "Other Income";

            var db = new SQLiteConnection(dbPath);
            var table = db.Table<IncomeTrack>();
            foreach (var s in table)
            {
                if (month == s.Date.Month)
                {
                    if (s.Descr == "PayDay")
                    {
                        salaryItems.Total = salaryItems.Total + s.Amount;
                    }
                    else if (s.Descr == "Tips")
                    {
                        tipItems.Total = tipItems.Total + s.Amount;
                    }
                    else
                    {
                        others.Total = others.Total + s.Amount;
                    }
                }
            }
            list2ret.Add(salaryItems);
            list2ret.Add(tipItems);
            list2ret.Add(others);
            db.Dispose();
            GC.Collect();
            db.Close();
            return list2ret;
        }

        //Query that returns income groupped by Description
        public static List<VMMonthlyDetails> checkview(int month, int year)
        {
            List<VMMonthlyDetails> retList = new List<VMMonthlyDetails>();
            var db = new SQLiteConnection(dbPath);

            var a = db.Query<VMMonthlyDetails>("select descr, sum(amount) as amount,date " +
                                                "from Income " +
                                                "where date > ? AND date < ? " +
                                                "group by descr", new DateTime(year, month, 01).Ticks,
                                                 new DateTime(year, month, 01).AddMonths(1).AddDays(-1).Ticks);

            foreach (var s in a)
            {
                //if (s.Date.Month == month)
                //{
                    retList.Add(s);
                //}
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return retList;
        }

        public void checksmth()
        {
            var db = new SQLiteConnection(dbPath);

        }

    }
}
