using Acr.UserDialogs;
using SQLite;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using static IncExpTracker.App;
using static IncExpTracker.SqlTableOveralDetails;

namespace IncExpTracker
{
    public partial class MainPage : ContentPage
    {
        public SQLiteConnection conn;
        VMEntry _vmEntry = new VMEntry();
        static bool flag = false;

#if __ANDROID__
// Just use whatever directory SpecialFolder.Personal returns
string libraryPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
#else
        // we need to put in /Library/ on iOS5.1+ to meet Apple's iCloud terms
        // (they don't want non-user-generated data in Documents)
        static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
        static string libraryPath = Path.Combine(documentsPath, "Library"); // Library folder instead
#endif
        static string sqliteFilename = "MyDatabase.db3";
        static string path = Path.Combine(libraryPath, sqliteFilename);


        public MainPage()
        {

            InitializeComponent();
            
            BindingContext = _vmEntry;

            if (!flag)
            {
                SQLiteAsyncConnection database = new SQLiteAsyncConnection(path, SQLiteOpenFlags.Create);

                SqlTableIncome.CreateIncomeTable();
                SqlTableExpenses.CreateExpensesTable();
                SqlTableOveralDetails.CreateOverallDetailsTable();
                CheckForNewEntries();
                //SqlTableExpenses.createViews();
                flag = true;
            }

            //List<SqlTableIncome.IncomeTrack> check = new List<SqlTableIncome.IncomeTrack>();
            //check = SqlTableIncome.SelectIncome();
            //SqlTableExpenses.TestView();

            //AddMyTransactions.AddIncome();
            //AddMyTransactions.AddExpenses();

            //SqlTableExpenses.checkview();
        }

        async private Task<bool> IncomeAdd(object sender, EventArgs e)
        {
            try
            {
                _vmEntry.IsBusy = true;
                await Navigation.PushAsync(new TrackIncomePage("", DateTime.Now));
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _vmEntry.IsBusy = false;
            }
            return true;
            
        }
        async private Task<bool> ExpensesAdd(object sender, EventArgs e)
        {
            try
            {
                _vmEntry.IsBusy = true;
                await Navigation.PushAsync(new TrackExpensesPage("", DateTime.Now));
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _vmEntry.IsBusy = false;
            }
            return true;

        }

        async private Task<bool>MonthlyReview(object sender, EventArgs e)
        {
            try
            {
                //using (UserDialogs.Instance.Loading("Loading text here..."))
                //{
                //    await Navigation.PushAsync(new TrackMonthlyRev(DateTime.Now.Month, DateTime.Now.Year));
                //}

                _vmEntry.IsBusy = true;
                await Navigation.PushAsync(new TrackMonthlyRev(DateTime.Now.Month, DateTime.Now.Year));
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                
                _vmEntry.IsBusy = false;
            }
            return true;

        }

        async private Task<bool> OveralDetails(object sender, EventArgs e)
        {
            try
            {
                _vmEntry.IsBusy = true;
                await Navigation.PushAsync(new TrackOverallDetails());
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                _vmEntry.IsBusy = false;
            }
            return true;
            
        }
    }
}
