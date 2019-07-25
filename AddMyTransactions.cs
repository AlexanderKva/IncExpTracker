using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using static IncExpTracker.SqlTableExpenses;
using static IncExpTracker.SqlTableIncome;


namespace IncExpTracker
{
    class AddMyTransactions
    {
        public static void AddIncome()
        {
            // May
            List<IncomeTrack> addIncomeMay = new List<IncomeTrack>
            {
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 38.25,
                    Date = DateTime.ParseExact("04/05/2019 02:03:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 7.75,
                    Date = DateTime.ParseExact("04/05/2019 02:06:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 18,
                    Date = DateTime.ParseExact("04/05/2019 13:51:04", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 4,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 5,
                    Date = DateTime.ParseExact("04/05/2019 13:51:11", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 38.25,
                    Date = DateTime.ParseExact("05/05/2019 02:12:35", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 18.25,
                    Date = DateTime.ParseExact("05/05/2019 02:53:16", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 36,
                    Date = DateTime.ParseExact("05/05/2019 23:52:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 9.4,
                    Date = DateTime.ParseExact("05/05/2019 23:52:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 36,
                    Date = DateTime.ParseExact("07/05/2019 01:52:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 10.1,
                    Date = DateTime.ParseExact("07/05/2019 01:53:02", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 27,
                    Date = DateTime.ParseExact("10/05/2019 22:44:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 6,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 3.5,
                    Date = DateTime.ParseExact("10/05/2019 23:00:02", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 18,
                    Date = DateTime.ParseExact("11/05/2019 14:00:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 4,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 7,
                    Date = DateTime.ParseExact("11/05/2019 14:03:02", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("11/05/2019 22:22:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 5.5,
                    Date = DateTime.ParseExact("11/05/2019 22:24:02", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("12/05/2019 16:34:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 10.4,
                    Date = DateTime.ParseExact("12/05/2019 16:35:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 36,
                    Date = DateTime.ParseExact("13/05/2019 18:50:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 10.7,
                    Date = DateTime.ParseExact("13/05/2019 18:50:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 27,
                    Date = DateTime.ParseExact("17/05/2019 20:35:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 6,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 6.6,
                    Date = DateTime.ParseExact("17/05/2019 20:50:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("18/05/2019 17:33:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 11.2,
                    Date = DateTime.ParseExact("18/05/2019 17:33:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("19/05/2019 16:37:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 18.1,
                    Date = DateTime.ParseExact("19/05/2019 16:37:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 24.75,
                    Date = DateTime.ParseExact("20/05/2019 18:15:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 5,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 5.45,
                    Date = DateTime.ParseExact("20/05/2019 18:15:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 42.75,
                    Date = DateTime.ParseExact("24/05/2019 18:15:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 10.05,
                    Date = DateTime.ParseExact("24/05/2019 18:15:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                 new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("25/05/2019 18:15:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 13.4,
                    Date = DateTime.ParseExact("25/05/2019 18:15:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                 new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("26/05/2019 18:15:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 14.55,
                    Date = DateTime.ParseExact("26/05/2019 18:15:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("28/05/2019 18:44:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 9.2,
                    Date = DateTime.ParseExact("28/05/2019 18:45:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 36,
                    Date = DateTime.ParseExact("31/05/2019 18:55:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 11,
                    Date = DateTime.ParseExact("31/05/2019 18:56:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                }


            };
            // June
            List<IncomeTrack> addIncomeJune = new List<IncomeTrack>
            {
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 42.75,
                    Date = DateTime.ParseExact("01/06/2019 17:06:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 13.6,
                    Date = DateTime.ParseExact("01/06/2019 17:06:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("02/06/2019 17:29:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 14.9,
                    Date = DateTime.ParseExact("02/06/2019 17:29:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 42.75,
                    Date = DateTime.ParseExact("03/06/2019 17:31:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 13.1,
                    Date = DateTime.ParseExact("03/06/2019 17:31:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 38.25,
                    Date = DateTime.ParseExact("07/06/2019 17:31:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 11.75,
                    Date = DateTime.ParseExact("07/06/2019 17:31:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("08/06/2019 17:31:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 14.2,
                    Date = DateTime.ParseExact("08/06/2019 17:31:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("09/06/2019 16:38:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 16.15,
                    Date = DateTime.ParseExact("09/06/2019 16:38:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("10/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 6.4,
                    Date = DateTime.ParseExact("10/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("11/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 9.55,
                    Date = DateTime.ParseExact("11/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 38.25,
                    Date = DateTime.ParseExact("14/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 11.8,
                    Date = DateTime.ParseExact("14/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 47.25,
                    Date = DateTime.ParseExact("15/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 1.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 15.55,
                    Date = DateTime.ParseExact("15/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("15/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 15.5,
                    Date = DateTime.ParseExact("15/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("17/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 12.2,
                    Date = DateTime.ParseExact("17/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 40.5,
                    Date = DateTime.ParseExact("18/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 9.2,
                    Date = DateTime.ParseExact("18/06/2019 17:41:15", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 36,
                    Date = DateTime.ParseExact("21/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 8,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 10,
                    Date = DateTime.ParseExact("21/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("22/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 10.6,
                    Date = DateTime.ParseExact("22/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("23/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 9.9,
                    Date = DateTime.ParseExact("23/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 42.75,
                    Date = DateTime.ParseExact("28/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 9.25,
                    Date = DateTime.ParseExact("28/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 33.75,
                    Date = DateTime.ParseExact("29/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 7,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 6.75,
                    Date = DateTime.ParseExact("29/06/2019 17:41:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                }
            };
            // July
            List<IncomeTrack> addIncomeJuly = new List<IncomeTrack>
            {
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 42.75,
                    Date = DateTime.ParseExact("05/07/2019 18:08:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 9,
                    OverTime = 0.5
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 7.45,
                    Date = DateTime.ParseExact("25/07/2019 18:08:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 0,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 45,
                    Date = DateTime.ParseExact("06/07/2019 18:07:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 10,
                    OverTime = 0
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 5.3,
                    Date = DateTime.ParseExact("06/07/2019 18:08:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture),
                    Hours = 0,
                    OverTime = 0
                },
            };


            foreach (var s in addIncomeMay)
            {
                SqlTableIncome.InsertData(s);
            }
            foreach (var s in addIncomeJune)
            {
                SqlTableIncome.InsertData(s);
            }
            foreach (var s in addIncomeJuly)
            {
                SqlTableIncome.InsertData(s);
            }
        }

        public static void AddExpenses()
        {
            // May
            List<ExpensesTrack> addExpensesMay = new List<ExpensesTrack>
            {
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 4,
                    Date = DateTime.ParseExact("04/05/2019 02:06:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3,
                    Date = DateTime.ParseExact("04/05/2019 12:44:16", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.3,
                    Date = DateTime.ParseExact("04/05/2019 23:26:32", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 1,
                    Date = DateTime.ParseExact("05/05/2019 01:06:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("05/05/2019 02:08:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 1.2,
                    Date = DateTime.ParseExact("05/05/2019 02:46:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.3,
                    Date = DateTime.ParseExact("05/05/2019 22:42:43", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("05/05/2019 23:26:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coca-Cola",
                    Amount = 0.9,
                    Date = DateTime.ParseExact("05/05/2019 23:27:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.8,
                    Date = DateTime.ParseExact("06/05/2019 10:01:31", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 4.9,
                    Date = DateTime.ParseExact("06/05/2019 10:01:42", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 1,
                    Date = DateTime.ParseExact("06/05/2019 12:50:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "OASTH",
                    Amount = 1,
                    Date = DateTime.ParseExact("06/05/2019 12:51:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee Island",
                    Amount = 1.7,
                    Date = DateTime.ParseExact("06/05/2019 12:52:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Άλλο",
                    Amount = 8,
                    Date = DateTime.ParseExact("06/05/2019 15:06:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Service Nexus",
                    Amount = 50,
                    Date = DateTime.ParseExact("06/05/2019 19:31:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 3,
                    Date = DateTime.ParseExact("07/05/2019 12:15:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("07/05/2019 12:15:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Super Market",
                    Amount = 8,
                    Date = DateTime.ParseExact("07/05/2019 18:48:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Super Market",
                    Amount = 20.2,
                    Date = DateTime.ParseExact("09/05/2019 19:21:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("10/05/2019 15:36:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("10/05/2019 19:44:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 4,
                    Date = DateTime.ParseExact("10/05/2019 23:15:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 2,
                    Date = DateTime.ParseExact("11/05/2019 00:23:10", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρες",
                    Amount = 5.2,
                    Date = DateTime.ParseExact("11/05/2019 00:18:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 4.3,
                    Date = DateTime.ParseExact("11/05/2019 00:23:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Νερό",
                    Amount = 0.3,
                    Date = DateTime.ParseExact("11/05/2019 17:06:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3.5,
                    Date = DateTime.ParseExact("11/05/2019 21:33:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 1.7,
                    Date = DateTime.ParseExact("11/05/2019 21:33:38", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 5,
                    Date = DateTime.ParseExact("12/05/2019 02:00:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 2,
                    Date = DateTime.ParseExact("12/05/2019 02:54:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("12/05/2019 15:59:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Φαρμακείο",
                    Amount = 10,
                    Date = DateTime.ParseExact("12/05/2019 16:01:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 3.3,
                    Date = DateTime.ParseExact("12/05/2019 23:11:08", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 2,
                    Date = DateTime.ParseExact("13/05/2019 02:38:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("13/05/2019 02:38:26", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4.4,
                    Date = DateTime.ParseExact("13/05/2019 18:49:06", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Νερό",
                    Amount = 0.3,
                    Date = DateTime.ParseExact("14/05/2019 13:46:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Χυμός",
                    Amount = 1.3,
                    Date = DateTime.ParseExact("14/05/2019 13:46:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 3.7,
                    Date = DateTime.ParseExact("14/05/2019 18:46:53", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Λοιπά έξοδα",
                    Amount = 14.5,
                    Date = DateTime.ParseExact("15/05/2019 11:14:29", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 8.65,
                    Date = DateTime.ParseExact("15/05/2019 17:47:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("15/05/2019 17:47:54", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 3.25,
                    Date = DateTime.ParseExact("16/05/2019 14:02:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },

                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 9.7,
                    Date = DateTime.ParseExact("17/05/2019 00:42:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Άλλο",
                    Amount = 8.5,
                    Date = DateTime.ParseExact("17/05/2019 20:37:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 1,
                    Date = DateTime.ParseExact("17/05/2019 22:24:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.2,
                    Date = DateTime.ParseExact("18/05/2019 15:57:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3.3,
                    Date = DateTime.ParseExact("18/05/2019 17:33:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Φαρμακείο",
                    Amount = 13,
                    Date = DateTime.ParseExact("19/05/2019 01:47:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 5.4,
                    Date = DateTime.ParseExact("19/05/2019 16:37:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4.5,
                    Date = DateTime.ParseExact("19/05/2019 19:48:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.9,
                    Date = DateTime.ParseExact("20/05/2019 20:29:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 5.9,
                    Date = DateTime.ParseExact("20/05/2019 23:55:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 1.8,
                    Date = DateTime.ParseExact("21/05/2019 13:24:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 5.4,
                    Date = DateTime.ParseExact("19/05/2019 01:47:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 19.2,
                    Date = DateTime.ParseExact("19/05/2019 16:37:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψώνια",
                    Amount = 195.8,
                    Date = DateTime.ParseExact("19/05/2019 19:48:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 15,
                    Date = DateTime.ParseExact("20/05/2019 20:29:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("20/05/2019 23:55:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Σκυλοτροφή",
                    Amount = 10,
                    Date = DateTime.ParseExact("21/05/2019 13:24:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 19.2,
                    Date = DateTime.ParseExact("22/05/2019 01:47:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("23/05/2019 22:37:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 2.2,
                    Date = DateTime.ParseExact("23/05/2019 22:48:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 8.3,
                    Date = DateTime.ParseExact("23/05/2019 23:29:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                 new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("24/05/2019 20:54:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 1.1,
                    Date = DateTime.ParseExact("24/05/2019 23:25:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 1,
                    Date = DateTime.ParseExact("26/05/2019 01:54:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("26/05/2019 01:55:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("26/05/2019 16:12:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 2,
                    Date = DateTime.ParseExact("26/05/2019 16:12:24", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("26/05/2019 17:08:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 4,
                    Date = DateTime.ParseExact("28/05/2019 09:50:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 3.3,
                    Date = DateTime.ParseExact("28/05/2019 09:51:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 9.7,
                    Date = DateTime.ParseExact("28/05/2019 09:52:24", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 2.6,
                    Date = DateTime.ParseExact("28/05/2019 09:53:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψώνια",
                    Amount = 133.8,
                    Date = DateTime.ParseExact("28/05/2019 09:54:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Τάσος",
                    Amount = 350,
                    Date = DateTime.ParseExact("28/05/2019 09:55:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 2.3,
                    Date = DateTime.ParseExact("28/05/2019 13:50:24", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 5,
                    Date = DateTime.ParseExact("28/05/2019 17:37:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("29/05/2019 02:02:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 7.25,
                    Date = DateTime.ParseExact("29/05/2019 10:59:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 1.8,
                    Date = DateTime.ParseExact("29/05/2019 12:02:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 9.7,
                    Date = DateTime.ParseExact("30/05/2019 10:59:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                }
            };
            // June
            List<ExpensesTrack> addExpensesJune = new List<ExpensesTrack>
            {
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 2.6,
                    Date = DateTime.ParseExact("01/06/2019 15:39:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.6,
                    Date = DateTime.ParseExact("01/06/2019 15:39:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4.5,
                    Date = DateTime.ParseExact("02/06/2019 02:37:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 1.6,
                    Date = DateTime.ParseExact("02/06/2019 02:37:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Πουρμπουάρ",
                    Amount = 1,
                    Date = DateTime.ParseExact("02/06/2019 02:38:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.1,
                    Date = DateTime.ParseExact("02/06/2019 17:53:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 5.5,
                    Date = DateTime.ParseExact("03/06/2019 00:28:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3,
                    Date = DateTime.ParseExact("03/06/2019 02:34:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 3.3,
                    Date = DateTime.ParseExact("03/06/2019 02:35:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ασφάλεια Nexus",
                    Amount = 55,
                    Date = DateTime.ParseExact("03/06/2019 12:45:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 19,
                    Date = DateTime.ParseExact("03/06/2019 12:45:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("03/06/2019 19:32:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 7.5,
                    Date = DateTime.ParseExact("03/06/2019 19:30:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 2.5,
                    Date = DateTime.ParseExact("04/06/2019 13:02:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 12.8,
                    Date = DateTime.ParseExact("04/06/2019 17:30:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 13.9,
                    Date = DateTime.ParseExact("04/06/2019 22:09:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 20,
                    Date = DateTime.ParseExact("06/06/2019 15:28:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 6.5,
                    Date = DateTime.ParseExact("06/06/2019 15:28:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 13.9,
                    Date = DateTime.ParseExact("06/06/2019 15:29:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Πουρμπουάρ",
                    Amount = 4,
                    Date = DateTime.ParseExact("06/06/2019 22:21:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 2,
                    Date = DateTime.ParseExact("06/06/2019 22:39:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4.5,
                    Date = DateTime.ParseExact("07/06/2019 18:34:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.2,
                    Date = DateTime.ParseExact("07/06/2019 21:38:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 3,
                    Date = DateTime.ParseExact("08/06/2019 00:23:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 2.4,
                    Date = DateTime.ParseExact("08/06/2019 02:53:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("08/06/2019 02:55:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("08/06/2019 17:10:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("08/06/2019 19:31:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 1.2,
                    Date = DateTime.ParseExact("09/06/2019 02:50:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("09/06/2019 19:04:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 1,
                    Date = DateTime.ParseExact("10/06/2019 03:44:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 3.2,
                    Date = DateTime.ParseExact("10/06/2019 03:44:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Λαλί",
                    Amount = 10,
                    Date = DateTime.ParseExact("10/06/2019 13:24:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 1.8,
                    Date = DateTime.ParseExact("10/06/2019 13:52:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ρεύμα",
                    Amount = 60,
                    Date = DateTime.ParseExact("11/06/2019 12:21:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3,
                    Date = DateTime.ParseExact("12/06/2019 01:54:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 43.8,
                    Date = DateTime.ParseExact("13/06/2019 01:06:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 14,
                    Date = DateTime.ParseExact("14/06/2019 14:44:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψώνια",
                    Amount = 17.9,
                    Date = DateTime.ParseExact("14/06/2019 18:13:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 14,
                    Date = DateTime.ParseExact("14/06/2019 18:14:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("15/06/2019 02:53:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 1.6,
                    Date = DateTime.ParseExact("15/06/2019 02:53:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 50,
                    Date = DateTime.ParseExact("15/06/2019 02:54:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("15/06/2019 19:26:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("16/06/2019 19:12:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 6.6,
                    Date = DateTime.ParseExact("16/06/2019 20:52:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 2.8,
                    Date = DateTime.ParseExact("16/06/2019 23:31:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 10,
                    Date = DateTime.ParseExact("17/06/2019 14:18:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 1.5,
                    Date = DateTime.ParseExact("17/06/2019 18:59:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("17/06/2019 21:03:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.6,
                    Date = DateTime.ParseExact("17/06/2019 21:04:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3,
                    Date = DateTime.ParseExact("18/06/2019 22:23:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 3.6,
                    Date = DateTime.ParseExact("19/06/2019 12:39:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("19/06/2019 21:04:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 5.2,
                    Date = DateTime.ParseExact("20/06/2019 12:13:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 11.4,
                    Date = DateTime.ParseExact("21/06/2019 12:00:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 13.2,
                    Date = DateTime.ParseExact("21/06/2019 12:00:35", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 7,
                    Date = DateTime.ParseExact("21/06/2019 12:01:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 2.5,
                    Date = DateTime.ParseExact("21/06/2019 17:00:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.6,
                    Date = DateTime.ParseExact("21/06/2019 23:54:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.6,
                    Date = DateTime.ParseExact("22/06/2019 02:33:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 2,
                    Date = DateTime.ParseExact("22/06/2019 14:14:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("22/06/2019 21:08:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 0.5,
                    Date = DateTime.ParseExact("23/06/2019 18:09:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("23/06/2019 18:56:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.2,
                    Date = DateTime.ParseExact("24/06/2019 00:52:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Λαλί",
                    Amount = 10,
                    Date = DateTime.ParseExact("24/06/2019 12:35:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 2.9,
                    Date = DateTime.ParseExact("24/06/2019 12:35:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 16,
                    Date = DateTime.ParseExact("25/06/2019 10:13:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 26.7,
                    Date = DateTime.ParseExact("25/06/2019 18:41:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ρεύμα",
                    Amount = 100,
                    Date = DateTime.ParseExact("25/06/2019 18:43:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Food",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("26/06/2019 01:20:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee Island",
                    Amount = 2.2,
                    Date = DateTime.ParseExact("26/06/2019 14:31:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Λοιπά έξοδα",
                    Amount = 22.3,
                    Date = DateTime.ParseExact("27/06/2019 22:22:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 9.2,
                    Date = DateTime.ParseExact("28/06/2019 16:59:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Λοιπά έξοδα",
                    Amount = 5.2,
                    Date = DateTime.ParseExact("28/06/2019 17:00:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 4,
                    Date = DateTime.ParseExact("28/06/2019 20:29:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 10,
                    Date = DateTime.ParseExact("30/06/2019 10:29:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("30/06/2019 10:30:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Tolls",
                    Amount = 1.7,
                    Date = DateTime.ParseExact("30/06/2019 10:31:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπιτσόμπαρο",
                    Amount = 11,
                    Date = DateTime.ParseExact("30/06/2019 23:42:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 7.8,
                    Date = DateTime.ParseExact("30/06/2019 23:43:03", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                }
            };
            // July
            List<ExpensesTrack> addExpensesJuly = new List<ExpensesTrack>
            {
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 10,
                    Date = DateTime.ParseExact("02/07/2019 07:26:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπουγάτσα",
                    Amount = 3.6,
                    Date = DateTime.ParseExact("02/07/2019 07:27:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 11.6,
                    Date = DateTime.ParseExact("03/07/2019 06:54:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("03/07/2019 07:16:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "SuperMarket",
                    Amount = 16,
                    Date = DateTime.ParseExact("03/07/2019 20:35:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 7.5,
                    Date = DateTime.ParseExact("04/07/2019 22:32:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπουγάτσα",
                    Amount = 1.8,
                    Date = DateTime.ParseExact("05/07/2019 10:38:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },

                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 0.4,
                    Date = DateTime.ParseExact("05/07/2019 20:22:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.8,
                    Date = DateTime.ParseExact("06/07/2019 01:40:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("06/07/2019 16:17:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Λάστιχο",
                    Amount = 13,
                    Date = DateTime.ParseExact("06/07/2019 16:18:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gasoline",
                    Amount = 3,
                    Date = DateTime.ParseExact("06/07/2019 18:06:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },                
                new ExpensesTrack
                {
                    Descr = "Xarisma",
                    Amount = 0.1,
                    Date = DateTime.ParseExact("06/07/2019 19:17:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 9.6,
                    Date = DateTime.ParseExact("07/07/2019 10:51:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 28,
                    Date = DateTime.ParseExact("08/07/2019 12:28:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 13,
                    Date = DateTime.ParseExact("08/07/2019 20:35:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Νερό",
                    Amount = 1,
                    Date = DateTime.ParseExact("08/07/2019 19:05:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.7,
                    Date = DateTime.ParseExact("08/07/2019 19:05:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Βόλτα",
                    Amount = 10,
                    Date = DateTime.ParseExact("09/07/2019 23:37:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 10,
                    Date = DateTime.ParseExact("09/07/2019 23:37:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 1.5,
                    Date = DateTime.ParseExact("09/07/2019 23:37:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Coffee",
                    Amount = 3.4,
                    Date = DateTime.ParseExact("11/07/2019 08:45:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 8.2,
                    Date = DateTime.ParseExact("11/07/2019 22:46:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Gas Nexus",
                    Amount = 5,
                    Date = DateTime.ParseExact("11/07/2019 22:46:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Service Nexus",
                    Amount = 14,
                    Date = DateTime.ParseExact("11/07/2019 22:47:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπουγάτσα",
                    Amount = 1.8,
                    Date = DateTime.ParseExact("12/07/2019 08:16:52", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
            };


            foreach (var s in addExpensesMay)
            {
                SqlTableExpenses.InsertData(s);
            }
            foreach (var s in addExpensesJune)
            {
                SqlTableExpenses.InsertData(s);
            }
            foreach (var s in addExpensesJuly)
            {
                SqlTableExpenses.InsertData(s);
            }
        }

    }
}
