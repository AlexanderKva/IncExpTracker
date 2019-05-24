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
            List<IncomeTrack> addincome = new List<IncomeTrack>
            {
                new IncomeTrack
                {
                    Descr = "PayDay",
                    Amount = 38.25,
                    Date = DateTime.ParseExact("04/05/2019 02:03:00", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("04/05/2019 13:51:04", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("05/05/2019 02:12:35", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("05/05/2019 23:52:44", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("07/05/2019 01:52:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("10/05/2019 22:44:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("11/05/2019 14:00:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("11/05/2019 22:22:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("12/05/2019 16:34:21", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("13/05/2019 18:50:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("17/05/2019 20:35:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("18/05/2019 17:33:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("19/05/2019 16:37:46", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Date = DateTime.ParseExact("20/05/2019 18:15:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
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
                    Amount = 24.75,
                    Date = DateTime.ParseExact("20/04/2019 18:15:50", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new IncomeTrack
                {
                    Descr = "Tips",
                    Amount = 5.45,
                    Date = DateTime.ParseExact("20/04/2019 18:15:57", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                }
            };
            foreach (var s in addincome)
            {
                InsertData(s);
            }

        }

        public static void AddExpenses()
        {
            List<ExpensesTrack> addexpense = new List<ExpensesTrack>
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
                    Date = DateTime.ParseExact("19/05/2019 01:47:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ciggies",
                    Amount = 7.7,
                    Date = DateTime.ParseExact("19/05/2019 16:37:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Ψιλικά",
                    Amount = 2.2,
                    Date = DateTime.ParseExact("19/05/2019 19:48:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                },
                new ExpensesTrack
                {
                    Descr = "Μπύρα",
                    Amount = 8.3,
                    Date = DateTime.ParseExact("20/05/2019 20:29:12", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture)
                }
            };

            foreach (var s in addexpense)
            {
                SqlTableExpenses.InsertData(s);
            }
        }

        
    }
}
