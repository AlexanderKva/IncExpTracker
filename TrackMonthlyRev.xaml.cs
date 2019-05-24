using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static IncExpTracker.SqlTableExpenses;
using static IncExpTracker.SqlTableIncome;
using static IncExpTracker.SqlTableOveralDetails;

namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackMonthlyRev : ContentPage
	{
        VMEntry _vmEntry = new VMEntry();
        VMMonthlyDetails _vmMonthlyDetails = new VMMonthlyDetails();
        public int m = 0;
        public int y = 0;
        public TrackMonthlyRev (int month,int year)
		{
			InitializeComponent ();
            BindingContext = _vmEntry;
            m = month;
            y = year;
            pageTitle.Text = "Monthly Review - " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month) + " " + year;
            Test();
           
            

            if (month == DateTime.Now.Month && year == DateTime.Now.Year)
            {
                incTotalLbl.Text = "Your income this month is: " + _vmEntry.IncomeTotal;
                expTotalLbl.Text = "Expenses this month are: " + _vmEntry.ExpTotal;
            }
            else
            {
                incTotalLbl.Text = "Your income for " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month) + " was: " + _vmEntry.IncomeTotal;
                expTotalLbl.Text = "Your expenses for " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(month) + " was: " + _vmEntry.ExpTotal;
            }
        }

        async void Test()
        {
            _vmEntry.IsBusy = true;
            if (await FillThePage(m, y) == true)               // Activity Indicator On/Off
            {
                _vmEntry.IsBusy = false;
            }
            else _vmEntry.IsBusy = true;
            
        }
        async private Task<bool> FillThePage(int month,int year)
        {
            try
            {
                OverallDetails a = SqlTableOveralDetails.SelectEntry(month, year);

                _vmEntry.IncomeTotal = a.IncThisMonth;
                _vmEntry.ExpTotal = a.ExpThisMonth;
                _vmEntry.Total = a.Summary;
                if (_vmEntry.Total > 0)
                {
                    sumTextLbl.BackgroundColor = Color.FromHex("#267f00");
                }
                else
                {
                    sumTextLbl.BackgroundColor = Color.IndianRed;
                }
                if (month > 9)
                {
                    string test = "01/" + month + "/" + year + " 00:01:00";
                    _vmEntry.Date = Convert.ToDateTime(test);
                }
                else
                {
                    string test = "01/0" + month + "/" + year + " 00:01:00";
                    _vmEntry.Date = Convert.ToDateTime(test);
                }


                List<VMMonthlyDetails> incList = SqlTableIncome.checkview(month, year);
                List<VMMonthlyDetails> expList = SqlTableExpenses.checkview(month, year);


                incomeGrid.ItemsSource = incList;
                expensesGrid.ItemsSource = expList;
                return true;
            }
            catch (Exception)
            {
                return false;
                
            }
            
        }

        
        async void ShowIncome(object sender, EventArgs e)
        {
            var getDescr = incomeGrid.SelectedItem as VMMonthlyDetails;
            string a = getDescr.Descr;
            await Navigation.PushAsync(new TrackIncomePage(a,new DateTime(y,m,01)));
        }

        async void ShowExpenses(object sender, EventArgs e)
        {
            var getDescr = expensesGrid.SelectedItem as VMMonthlyDetails;
            string a = getDescr.Descr;
            await Navigation.PushAsync(new TrackExpensesPage(a,new DateTime(y,m,01)));
        }

        //async void CancelBtn(object sender, EventArgs e)
        //{
        //    await Navigation.PushAsync(new MainPage());
        //}

    }
}