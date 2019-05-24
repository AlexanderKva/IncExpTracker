using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static IncExpTracker.SqlTableIncome;

namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackIncomePageAddNew : ContentPage
	{
        VMEntry _vmEntry = new VMEntry();
        int id = 0;
		public TrackIncomePageAddNew (int entryId, string reason)
		{
			InitializeComponent ();
            
            if (entryId >= 0)
            {
                VMEntry s = SqlTableIncome.SelectEntry(entryId);
                _vmEntry.Id = s.Id;
                _vmEntry.Date = s.Date;
                _vmEntry.Descr = s.Descr;
                _vmEntry.StrAmount = s.Amount.ToString();
                id = 1;
            }
            else
            {
                _vmEntry.Descr = reason;
            }
            BindingContext = _vmEntry;
            addIncomeDescr.ReturnCommand = new Command(() => addIncomeAmount.Focus());
        }

        async void AddIncome(object sender, EventArgs e)
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
            
            if (id == 1)
            {
                IncomeTrack updIncTrack = new IncomeTrack();
                updIncTrack.Amount = amount;
                updIncTrack.Descr = _vmEntry.Descr;
                updIncTrack.Date = _vmEntry.Date;
                updIncTrack.Id = _vmEntry.Id;
                SqlTableIncome.UpdateData(updIncTrack);
                await DisplayAlert("Done", "Income Updated!", "Great!");
            }
            else
            {
                IncomeTrack newItem = new IncomeTrack();
                newItem.Amount = amount;
                newItem.Descr = _vmEntry.Descr;
                newItem.Date = DateTime.Now;
                SqlTableIncome.InsertData(newItem);
                await DisplayAlert("Done", "Income Added!", "Great!");
            }
            
            await Navigation.PushAsync(new MainPage());
        }

        async void CancelBtnIncomePage(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}