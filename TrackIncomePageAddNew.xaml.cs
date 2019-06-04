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
        int flag = 0;
        double amount = 0;
        double hours = 0;
        double overtime = 0;
        public TrackIncomePageAddNew (int entryId, string reason)
		{
			InitializeComponent ();
            if (reason == "PayDay")
            {
                _vmEntry.IsPayDay = true;
            }
            else
            {
                _vmEntry.IsPayDay = false;
            }
            if (entryId >= 0)
            {
                VMEntry s = SqlTableIncome.SelectEntry(entryId);
                _vmEntry.Id = s.Id;
                _vmEntry.Date = s.Date;
                _vmEntry.Descr = s.Descr;
                _vmEntry.StrAmount = s.Amount.ToString();
                _vmEntry.HoursToString = s.HoursToString;
                _vmEntry.OverTimeToString = s.OverTimeToString;
                
                flag = 1;
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
            
            try
            {
                CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

                _vmEntry.StrAmount = _vmEntry.StrAmount.Replace(",", ".");
                amount = Double.Parse(_vmEntry.StrAmount, culture);

                if (_vmEntry.Descr == "PayDay")
                {
                    _vmEntry.HoursToString = _vmEntry.HoursToString.Replace(",", ".");
                    hours = Double.Parse(_vmEntry.HoursToString, culture);
                    if (_vmEntry.OverTimeToString == null)
                    {
                        _vmEntry.OverTimeToString = "0";
                    }
                    _vmEntry.OverTimeToString = _vmEntry.OverTimeToString.Replace(",", ".");
                    overtime = Double.Parse(_vmEntry.OverTimeToString, culture);
                }
                
            }
            catch (Exception)
            {
                await DisplayAlert("Wrong Input", "Please check the decimal point(if any)", "ok");
                return;
            }
            
            if (flag == 1)
            {
                IncomeTrack updIncTrack = new IncomeTrack();
                updIncTrack.Amount = amount;
                updIncTrack.Descr = _vmEntry.Descr;
                updIncTrack.Date = _vmEntry.Date;
                updIncTrack.Id = _vmEntry.Id;
                if (_vmEntry.Descr == "PayDay")
                {
                    updIncTrack.Hours = hours;
                    updIncTrack.OverTime = overtime;
                }
                SqlTableIncome.UpdateData(updIncTrack);

                await DisplayAlert("Done", "Income Updated!", "Great!");
            }
            else
            {
                int incomeId = -1;
                IncomeTrack newItem = new IncomeTrack();
                newItem.Amount = amount;
                newItem.Descr = _vmEntry.Descr;
                newItem.Date = DateTime.Now;
                newItem.Hours = hours;
                newItem.OverTime = overtime;
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