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
	public partial class TrackExpensesPageAddNew : ContentPage
	{
        VMEntry _vmEntry = new VMEntry();
        int flag = 0;
        
        public TrackExpensesPageAddNew(int entryId, string itemDescr)
		{
			InitializeComponent ();
            BindingContext = _vmEntry;
                        
            if (entryId > 0)
            {
                VMEntry s =  SqlTableExpenses.SelectEntry(entryId);
                _vmEntry.Id = s.Id;
                _vmEntry.Date = s.Date;
                _vmEntry.Descr = s.Descr;
                _vmEntry.StrAmount = s.Amount.ToString();
                flag = 1;
            }
            else
            {
                _vmEntry.Descr = itemDescr;
            }
        }
        
        async void AddExpense(object sender, EventArgs e)
        {
            double amount = 0;
            try
            {
                _vmEntry.StrAmount = _vmEntry.StrAmount.Replace(",", ".");
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");
                amount = Double.Parse(_vmEntry.StrAmount, culture);
            }
            catch (Exception)
            {

                await DisplayAlert("Wrong Input", "Please enter the amount", "ok");
                return;
            }

            if (flag == 1)
            {
                ExpensesTrack updExpTrack = new ExpensesTrack();
                updExpTrack.Amount = amount;
                updExpTrack.Descr = _vmEntry.Descr;
                updExpTrack.Date = _vmEntry.Date;
                updExpTrack.Id = _vmEntry.Id;
                SqlTableExpenses.UpdateData(updExpTrack);
                await DisplayAlert("Done", "Expense Updated!", "Okay");
            }
            else
            {
                ExpensesTrack newItem = new ExpensesTrack();
                newItem.Amount = amount;
                newItem.Descr = _vmEntry.Descr;
                newItem.Date = DateTime.Now;
                SqlTableExpenses.InsertData(newItem);
                await DisplayAlert("Done", "Expense Added!", "Okay");
            }
            await Navigation.PushAsync(new MainPage());
        }

        async void CancelBtnIncomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}