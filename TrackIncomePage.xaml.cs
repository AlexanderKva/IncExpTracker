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
    public partial class TrackIncomePage : ContentPage
    {
        VMEntry _vmEntry = new VMEntry();
        VMEntryList _vmEntryList = null;
        double total = 0;
        public TrackIncomePage(string descr,DateTime date)
        {
            InitializeComponent();
            _vmEntryList = new VMEntryList();

            if (descr == "")
            {
                titleLbl.Text = "Income Details - " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " " + date.Year;
                FillTheGrid();
            }
            else
            {
                titleLbl.Text = "Income Details - " + descr + " - " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " " + date.Year;
                ShowSpecificCat(descr, date);
            }
            BindingContext = _vmEntryList;

            DateTime now = DateTime.Now;
            int currentMonth = now.Month;
        }

        async void FillTheGrid()
        {
            _vmEntryList.IsBusy = true;
            List<IncomeTrack> incomeEntries = SelectedMonthIncome(DateTime.Now.Month, DateTime.Now.Year);
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

        async void ShowSpecificCat(string descr,DateTime date)
        {
           
            _vmEntryList.IsBusy = true;
            List<IncomeTrack> incomeEntries = new List<IncomeTrack>();
            if (date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year)
            {
                incomeEntries = SelectedMonthIncome(DateTime.Now.Month, DateTime.Now.Year);
            }
            else
            {
                incomeEntries = SelectedMonthIncome(date.Month, date.Year);
            }

            VMEntryList payDayOutput = new VMEntryList();
            VMEntryList tipsOutput = new VMEntryList();
            VMEntryList othersOutput = new VMEntryList();

            // ..Sorting out Categories..
            foreach (var s in incomeEntries)
            {
                if (s.Descr == "PayDay")
                {
                    payDayOutput.EntryList.Add(new VMEntry
                    {
                        Id = s.Id,
                        Descr = s.Descr,
                        Amount = s.Amount,
                        Date = s.Date,
                        DateToString = s.Date.DayOfWeek + " " + s.Date.ToString("dd MMM HH:mm")
                    });
                    payDayOutput.Summary += s.Amount;

                }
                else if (s.Descr == "Tips")
                {
                    tipsOutput.EntryList.Add(new VMEntry
                    {
                        Id = s.Id,
                        Descr = s.Descr,
                        Amount = s.Amount,
                        Date = s.Date,
                        DateToString = s.Date.DayOfWeek + " " + s.Date.ToString("dd MMM HH:mm")
                    });
                    tipsOutput.Summary += s.Amount;
                }
                else
                {
                    othersOutput.EntryList.Add(new VMEntry
                    {
                        Id = s.Id,
                        Descr = s.Descr,
                        Amount = s.Amount,
                        Date = s.Date,
                        DateToString = s.Date.DayOfWeek + " " + s.Date.ToString("dd MMM HH:mm")
                    });
                    othersOutput.Summary += s.Amount;
                }

            }
            // ..Checks if its the current month..
            if (date.Month == DateTime.Now.Month && date.Year == DateTime.Now.Year)
            {
                // ..Links selected Category with BindingContext..
                if (descr == "PayDay")
                {
                    _vmEntryList = payDayOutput;
                    secTitle.Text = "This month you got " + _vmEntryList.Summary + " from PayDay!";


                }
                else if (descr == "Tips")
                {
                    _vmEntryList = tipsOutput;
                    secTitle.Text = "This month you got " + _vmEntryList.Summary + " from Tips!";
                }
                else
                {
                    _vmEntryList = othersOutput;
                    secTitle.Text = "This month you got " + _vmEntryList.Summary + " from Other Resources!";
                }
            }
            else
            {
                // ..Links selected Category with BindingContext..
                if (descr == "PayDay")
                {
                    _vmEntryList = payDayOutput;
                    secTitle.Text = "On " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " you got " + _vmEntryList.Summary + " from PayDay!";


                }
                else if (descr == "Tips")
                {
                    _vmEntryList = tipsOutput;
                    secTitle.Text = "On " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " you got " + _vmEntryList.Summary + " from Tips!";
                }
                else
                {
                    _vmEntryList = othersOutput;
                    secTitle.Text = "On " + DateTimeFormatInfo.CurrentInfo.GetAbbreviatedMonthName(date.Month) + " you got " + _vmEntryList.Summary + " from Other Resources!";
                }
            }
        }

        async void AddIncomePage(object sender, EventArgs e)
        {
            string returnAnswer = "";

            var answer = await DisplayActionSheet("New Item", null, null, "PayDay", "Tips", "Other");
            if (answer == "PayDay")
            {
                returnAnswer = "PayDay";
            }
            else if (answer == "Tips")
            {
                returnAnswer = "Tips";
            }
            else if (answer == "Other")
            {
                returnAnswer = "";
            }
            else
            {
                return;
            }
            await Navigation.PushAsync(new TrackIncomePageAddNew(-1,returnAnswer));
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
            else if (answer == "Edit")
            {
                await Navigation.PushAsync(new TrackIncomePageAddNew(getId.Id,""));
            }
            else
            {
                return;
            }
        }

    }
}