using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static IncExpTracker.SqlTableExpenses;

namespace IncExpTracker
{
    class SqlTableFixedCosts
    {
        public static string dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Personal),
                "MyDatabase.db3");

        [Table("FixedCosts")]
        public class FixedExpenses
        {
            [PrimaryKey,AutoIncrement,Column("id")]
            public int Id { get; set; }

            [MaxLength(20), Column("lastUpdateDate")]
            public DateTime LastUpdateDate { get; set; }

            [MaxLength(20), Column("nextUpdateDate")]
            public DateTime NextUpdateDate { get; set; }

            [Column("UpdateEvery")]
            public int UpdateEvery { get; set; }

            [Column("amount")]
            public double Amount { get; set; }

            [MaxLength(20), Column("descr")]
            public string Descr { get; set; }

            [Column("isEnabled")]
            public bool IsEnabled { get; set; }
            
        }

        // Creates Table if it doesnt exist already
        public static void CreateFixedCostsTable()
        {
            Console.WriteLine("Creating database, if it doesn't already exist");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<FixedExpenses>();
            GC.Collect();
            db.Close();
        }

        // Add Entry
        public static void AddFixedCosts(FixedExpenses entry)
        {
            var db = new SQLiteConnection(dbPath);
            db.Insert(entry);
            db.Dispose();
            GC.Collect();
            db.Close();
        }
        // Delete Entry
        public static void DeleteRow(int id)
        {
            FixedExpenses local = new FixedExpenses();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<FixedExpenses>();
            var delete = db.Query<FixedExpenses>("Delete from FixedCosts where Id = " + id);
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        // Select * 
        public static List<FixedExpenses> SelectFixedExpenses()
        {
            List<FixedExpenses> returnTable = new List<FixedExpenses>();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<FixedExpenses>();
            foreach (var s in table)
            {
                returnTable.Add(s);
            }
            db.Dispose();
            GC.Collect();
            db.Close();
            return returnTable;
        }

        // Select * where id = #id
        public static VMFixedCosts SelectId(int id)
        {
            VMFixedCosts s = new VMFixedCosts();
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<FixedExpenses>();

            foreach (var z in table)
            {
                if (z.Id == id)
                {
                    s.Id = z.Id;
                    if (z.IsEnabled)
                    {
                        s.IsEnabled = "Yes";
                    }
                    else
                    {
                        s.IsEnabled = "No";
                    }
                    s.LastUpd = z.LastUpdateDate;
                    s.LastUpdToString = z.LastUpdateDate.ToString("ddd dd MMM");
                    s.NextUpd = z.NextUpdateDate;
                    s.NextUpdToString = z.NextUpdateDate.ToString("ddd dd MMM");
                    s.Descr = z.Descr;
                    s.UpdEvery = z.UpdateEvery;
                    s.Amount = z.Amount;
                    s.AmountToString = z.Amount.ToString();

                }
            }


            return s;
        }


        // Update Entry
        public static void UpdateFixedCosts(FixedExpenses itemToUpdate)
        {
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<FixedExpenses>();

            db.Update(itemToUpdate);
            db.Dispose();
            GC.Collect();
            db.Close();
        }

        /*
         *  This guy gets the job done 
         */
        public static void UpdateFixedCostsTable()
        {
            List<ExpensesTrack> checkExp = SelectedMonthExpenses(DateTime.Now.Month, DateTime.Now.Year);
            List<FixedExpenses> fixedExp = SelectFixedExpenses();
            List<FixedExpenses> UnpaidList = SelectFixedExpenses();
            List<ExpensesTrack> addThisIfNeeded = new List<ExpensesTrack>();
            fixedExp.Add(new FixedExpenses
            {
                Id = -1,
                Descr = "",
                Amount = 0,
                IsEnabled = false,
                LastUpdateDate = DateTime.Now,
                NextUpdateDate = DateTime.Now,
                UpdateEvery = 0
            });
            var db = new SQLiteConnection(dbPath);
            var table = db.Table<FixedExpenses>();

            foreach (var s in fixedExp)
            {
                foreach (var d in checkExp)
                {
                    if (s.Descr != d.Descr)
                    {
                        UnpaidList.Remove(s);
                    }
                }
            }

            if (UnpaidList != null)
            {
                foreach (var s in UnpaidList)
                {
                    if (s.IsEnabled == false && DateTime.Now > s.NextUpdateDate)
                    {
                        FixedExpenses itemToUpdate = new FixedExpenses();

                        itemToUpdate.Id = s.Id;
                        itemToUpdate.IsEnabled = s.IsEnabled;
                        itemToUpdate.LastUpdateDate = s.NextUpdateDate;

                        DateTime date = s.NextUpdateDate.AddMonths(1);
                        try
                        {
                            date = new DateTime(date.Year, date.Month, s.UpdateEvery);
                        }
                        catch (Exception)
                        {
                            date = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
                        }
                        itemToUpdate.NextUpdateDate = date;
                        itemToUpdate.UpdateEvery = s.UpdateEvery;
                        itemToUpdate.Descr = s.Descr;
                        itemToUpdate.Amount = s.Amount;

                        UpdateFixedCosts(itemToUpdate);
                    }
                    else if (DateTime.Now > s.NextUpdateDate && s.IsEnabled == true)
                    {
                        // Add fix cost on Expenses Table
                        ExpensesTrack addThis = new ExpensesTrack();
                        addThis.Id = s.Id;
                        addThis.Amount = s.Amount;
                        addThis.Descr = s.Descr;
                        addThis.Date = s.NextUpdateDate;

                        InsertData(addThis);

                        // Update Fix cost table (dates)

                        FixedExpenses itemToUpdate = new FixedExpenses();

                        itemToUpdate.Id = s.Id;
                        itemToUpdate.IsEnabled = s.IsEnabled;
                        itemToUpdate.LastUpdateDate = s.NextUpdateDate;

                        DateTime date = s.NextUpdateDate.AddMonths(1);
                        try
                        {
                            date = new DateTime(date.Year, date.Month, s.UpdateEvery);
                        }
                        catch (Exception)
                        {
                            date = new DateTime(date.Year, date.Month, 1).AddMonths(1).AddDays(-1);
                        }
                        itemToUpdate.NextUpdateDate = date;
                        itemToUpdate.UpdateEvery = s.UpdateEvery;
                        itemToUpdate.Descr = s.Descr;
                        itemToUpdate.Amount = s.Amount;

                        UpdateFixedCosts(itemToUpdate);


                    }
                }
            }
           
            db.Dispose();
            GC.Collect();
            db.Close();

        }

    }
}
