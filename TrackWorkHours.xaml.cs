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
	public partial class TrackWorkHours : ContentPage
	{
        VMEntry _vmEntry = new VMEntry();
        VMEntryList _vmEntryList = new VMEntryList();
        double total = 0;
        double hoursTotal = 0;
        double overTimeTotal = 0;
        DateTime date = new DateTime();
		public TrackWorkHours (DateTime zz)
		{
			InitializeComponent ();
            date = zz;
            FillTheGrid();
            _vmEntryList.MonthToString = zz.ToString("MMMM", CultureInfo.InvariantCulture);
            BindingContext = _vmEntryList;
		}

        async void FillTheGrid()
        {
            
            List<IncomeTrack> incomeEntries = SelectedMonthIncome(date.Month, date.Year);
            foreach (var s in incomeEntries)
            {
                if (s.Descr == "PayDay")
                {
                    _vmEntryList.EntryList.Add(new VMEntry
                    {
                        Id = s.Id,
                        Descr = s.Descr,
                        Amount = s.Amount,
                        Date = s.Date,
                        DateToString = s.Date.ToString("ddd dd MMM HH:mm"),
                        HoursToString = s.Hours.ToString(),
                        OverTimeToString = s.OverTime.ToString()

                    });
                    _vmEntryList.HoursSum += s.Hours + s.OverTime;
                    _vmEntryList.ScheduledSum += s.Hours;
                    _vmEntryList.ExtraSum += s.OverTime;
                    
                }
            }
            titleLbl.Text = "Work hours - " + date.ToString("MMMM", CultureInfo.InvariantCulture);
            titleLbl.TextColor = Color.Black;
            downLbl.Text = "Your work-hours for " + date.ToString("MMMM", CultureInfo.InvariantCulture) + " are: " + _vmEntryList.HoursSum;
            downLbl.TextColor = Color.Black;


        }
    }
}