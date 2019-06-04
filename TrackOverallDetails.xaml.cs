using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static IncExpTracker.SqlTableOveralDetails;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackOverallDetails : ContentPage
	{
        VMOverallDetailsList _vmOveralDetList = new VMOverallDetailsList();
		public TrackOverallDetails ()
		{
			InitializeComponent ();
            BindingContext = _vmOveralDetList;
            FillTheGrid();
		}

        public void FillTheGrid()
        {
            List<OverallDetails> detailsList = SelectOverallDetails();
            foreach (var s in detailsList)
            {
                _vmOveralDetList.EntryList.Add(new VMOveralDetails
                {
                    Id = s.id,
                    ExpThisMonth = s.ExpThisMonth,
                    IncThisMonth = s.IncThisMonth,
                    Month = s.Month,
                    MonthToInt = s.MonthToInt,
                    Summary = s.Summary,
                    Year = s.Year,
            });
                _vmOveralDetList.OverallExp += s.ExpThisMonth;
                _vmOveralDetList.OverallInc += s.IncThisMonth;
            }
            _vmOveralDetList.OverallSum = _vmOveralDetList.OverallInc - _vmOveralDetList.OverallExp;
        }

        async void SelectedMonthReview(object sender, EventArgs e)
        {
            var getMonth = insideGrid.SelectedItem as VMOveralDetails;
            int a = getMonth.MonthToInt;
            int b = getMonth.Year;

            await Navigation.PushAsync(new TrackMonthlyRev(a,b));
        }
    }
}