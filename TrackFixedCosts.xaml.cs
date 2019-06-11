using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static IncExpTracker.SqlTableFixedCosts;

namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackFixedExpenses : ContentPage
	{
        VMFixedCostsList _vmFixedCosts = new VMFixedCostsList();
		public TrackFixedExpenses ()
		{
			InitializeComponent ();
            FillTheGrid();
            BindingContext = _vmFixedCosts;


		}

        async void FillTheGrid()
        {
            List<FixedExpenses> fixedExpenses = SelectFixedExpenses();
            List<VMFixedCosts> asd = new List<VMFixedCosts>();
            string enabled = "Yes";
            foreach (var s in fixedExpenses)
            {
                if (s.IsEnabled)
                {
                    enabled = "Yes";
                }
                else
                {
                    enabled = "No";
                }
                asd.Add(new VMFixedCosts
                {
                    Id = s.Id,
                    Descr = s.Descr,
                    Amount = s.Amount,
                    AmountToString = s.Amount.ToString(),
                    IsEnabled = enabled,
                    LastUpd = s.LastUpdateDate,
                    NextUpd = s.NextUpdateDate,
                    LastUpdToString = s.LastUpdateDate.ToString("ddd dd MMM"),
                    NextUpdToString = s.NextUpdateDate.ToString("ddd dd MMM"),
                    UpdEvery = s.UpdateEvery
                });

                
            }

            _vmFixedCosts.EntryList = asd;

        }

        async void FixedCostsTap(object sender, EventArgs e)
        {
            var getId = insideGrid.SelectedItem as VMFixedCosts;
            var answer = "";
            if (getId.IsEnabled == "Yes")
            {
                answer = await DisplayActionSheet("What to do?!", null, null, "Edit", "Disable", "Delete");
            }
            else
            {
                answer = await DisplayActionSheet("What to do?!", null, null, "Edit", "Enable", "Delete");
            }

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
                await Navigation.PushAsync(new TrackIncomeExpensesPageFixedCostsAdd(getId.Id));
            }
            else if (answer == "Enable" || answer == "Disable")
            {
                FixedExpenses toUpd = new FixedExpenses();
                toUpd.Id = getId.Id;
                toUpd.Amount = getId.Amount;
                toUpd.Descr = getId.Descr;
                if (answer == "Enable")
                {
                    toUpd.IsEnabled = true;
                }
                else
                {
                    toUpd.IsEnabled = false;
                }
                toUpd.LastUpdateDate = getId.LastUpd;
                toUpd.NextUpdateDate = getId.NextUpd;
                toUpd.UpdateEvery = getId.UpdEvery;
                UpdateFixedCosts(toUpd);
                FillTheGrid();

            }

        }

        async void AddNewFixedCost(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrackIncomeExpensesPageFixedCostsAdd(-1));
        }
    }
}