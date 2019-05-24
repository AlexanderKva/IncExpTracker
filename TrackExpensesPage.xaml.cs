using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static IncExpTracker.SqlTableExpenses;


namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackExpensesPage : ContentPage
	{
        VMEntry _vmEntry = new VMEntry();
        VMEntryList _vmEntryList = null;
        double total = 0;
        public TrackExpensesPage (string descr,DateTime date)
		{
            InitializeComponent();
            _vmEntryList = new VMEntryList();
            
            if (descr == "" )
            {
                titleLbl.Text = "Expenses Details - " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " " + date.Year;
                FillTheGrid();
                
            }
            else
            {
                titleLbl.Text = "Expenses Details - " + descr + " - " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " " + date.Year; ;
                ShowSpecificCat(descr,date);
            }
            BindingContext = _vmEntryList;
            DateTime now = DateTime.Now;
            int currentMonth = now.Month;
        }

        async void FillTheGrid()
        {
            List<ExpensesTrack> incomeEntries = SelectedMonthExpenses(DateTime.Now.Month, DateTime.Now.Year);
            foreach (var s in incomeEntries)
            {
                _vmEntryList.EntryList.Add(new VMEntry
                {
                    Id = s.Id,
                    Descr = s.Descr,
                    Amount = s.Amount,
                    Date = s.Date,
                    DateToString = s.Date.DayOfWeek + " " + s.Date.ToString("dd MMM HH:mm")
                });
                total += s.Amount;
            }
            _vmEntryList.Summary = total;
            
        }
        async void ShowSpecificCat(string descr, DateTime date)
        {
            List<ExpensesTrack> expenseEntries = SelectedMonthExpenses(DateTime.Now.Month,DateTime.Now.Year);
            if (date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year)
            {
                expenseEntries = SelectedMonthExpenses(DateTime.Now.Month, DateTime.Now.Year);
            }
            else
            {
                expenseEntries = SelectedMonthExpenses(date.Month, date.Year);
            }

            VMEntryList listToShow = new VMEntryList();
            foreach (var s in expenseEntries)
            {
                if (s.Descr == descr)
                {
                    listToShow.EntryList.Add(new VMEntry
                    {
                        Id = s.Id,
                        Descr = s.Descr,
                        Amount = s.Amount,
                        Date = s.Date,
                        DateToString = s.Date.DayOfWeek + " " + s.Date.ToString("dd MMM HH:mm")
                    });
                    listToShow.Summary += s.Amount;
                }
                
            }
            _vmEntryList = listToShow;
            if (date.Month == DateTime.Now.Month)
            {
                secTitle.Text = "This month you spent " + _vmEntryList.Summary + " on " + listToShow.EntryList[0].Descr;
            }
            else
            {
                secTitle.Text = "On " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " you spent " + _vmEntryList.Summary + " on " + listToShow.EntryList[0].Descr;
            }
            
            
        }

        async void AddExpenses(object sender, EventArgs e)
        {
            string returnAnswer = "";
            
            var answer = await DisplayActionSheet("New Item", null, null,"Food","Gasoline","Ciggies","Other");
            if (answer == "Food")
            {
                returnAnswer = "Food";
            }
            else if (answer == "Gasoline")
            {
                returnAnswer = "Gasoline";
            }
            else if (answer == "Ciggies")
            {
                returnAnswer = "Ciggies";
            }
            else if (answer == "Other")
            {
                returnAnswer = "";
            }
            else 
            {
                return;
            }
            
            await Navigation.PushAsync(new TrackExpensesPageAddNew(-1, returnAnswer));
        }

        async void TappedItem(object sender, EventArgs e)
        {
            var getId = insideGrid.SelectedItem as VMEntry;
            var answer = await DisplayActionSheet("What to do?", null, null, "Edit", "Delete");
            if (answer == "Delete")
            {
                bool x = await DisplayAlert("Delete", "Are you sure you want to delete that entry?", "Yes!", "Naah!");
                if (x)
                {
                    DeleteRow(getId.Id);
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    return;
                }
                
            }
            else if(answer == "Edit")
            {
                await Navigation.PushAsync(new TrackExpensesPageAddNew(getId.Id,""));
            }
            else
            {
                return;
            }
        }

        async void CancelBtnExpensesPage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

    }
}