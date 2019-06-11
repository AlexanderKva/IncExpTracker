using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static IncExpTracker.SqlTableExpenses;
using static IncExpTracker.SqlTableFixedCosts;

namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackIncomeExpensesPageFixedCostsAdd : ContentPage
	{
        VMFixedCosts _vmFixedCosts = new VMFixedCosts();
        public int getId = -1;
        
		public TrackIncomeExpensesPageFixedCostsAdd (int id)
		{
			InitializeComponent ();
            TitleLabel.Text = "Fixed Costs!";
            TitleLabel.TextColor = Color.IndianRed;
            List<string> picker = new List<string>();
            getId = id;
            
            BindingContext = _vmFixedCosts;

            for (int i = 1; i < 32; i++)
            {
                if ((i%10) == 1 && i != 11)
                {
                    picker.Add("Every " + i + "rst of month");
                }
                else if ((i%10) == 2 && i != 12)
                {
                    picker.Add("Every " + i + "nd of month");
                }
                else if ((i%10) == 3 && i != 13)
                {
                    picker.Add("Every " + i + "rd of month");
                }
                else
                {
                    picker.Add("Every " + i + "th of month");
                }
            }
            FreqPicker.ItemsSource = picker;
            if (id > 0)
            {
                VMFixedCosts zz = new VMFixedCosts();
                zz = SelectId(id);
                _vmFixedCosts.Descr = zz.Descr;
                _vmFixedCosts.AmountToString = zz.AmountToString;
                _vmFixedCosts.Id = zz.Id;
                FreqPicker.SelectedIndex = zz.UpdEvery -1;
                
            }


            
            
            
           
		}

        async void AddNewCost(object sender, EventArgs e)
        {
            List<ExpensesTrack> validationCheck = SelectExpenses();
            foreach (var s in validationCheck)
            {
                if (_vmFixedCosts.Descr == s.Descr)
                {
                    await DisplayAlert("Invalid Description", "Specific Descr. already exists on expenses table, please insert something else", "Ok");
                    return;
                }
            }

            FixedExpenses zz = new FixedExpenses();
            if (getId == -1)
            {

                try
                {
                    zz.Amount = Convert.ToDouble(_vmFixedCosts.AmountToString);

                }
                catch (Exception)
                {
                    await DisplayAlert("Wrong Input", "Please enter the amount", "ok");
                    return;
                }
                zz.Descr = _vmFixedCosts.Descr;
                zz.IsEnabled = true;
                zz.UpdateEvery = FreqPicker.SelectedIndex + 1;
                try
                {
                    if (DateTime.Now > new DateTime(DateTime.Now.Year, DateTime.Now.Month, FreqPicker.SelectedIndex + 1))
                    {
                        zz.NextUpdateDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, FreqPicker.SelectedIndex + 1).AddMonths(1);
                    }
                    else
                    {
                        zz.NextUpdateDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, FreqPicker.SelectedIndex + 1);
                    }
                }
                catch (Exception)
                {
                    zz.NextUpdateDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                }

                AddFixedCosts(zz);
                await DisplayAlert("Done", "Fixed Cost added", "Great!");
            }
            else
            {
                try
                {
                    zz.Amount = Convert.ToDouble(_vmFixedCosts.AmountToString);

                }
                catch (Exception)
                {
                    await DisplayAlert("Wrong Input", "Please enter the amount", "ok");
                    return;
                }
                zz.Id = _vmFixedCosts.Id;
                zz.Descr = _vmFixedCosts.Descr;
                zz.IsEnabled = true;
                zz.UpdateEvery = FreqPicker.SelectedIndex + 1;
                try
                {
                    zz.NextUpdateDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, FreqPicker.SelectedIndex + 1);
                }
                catch (Exception)
                {
                    zz.NextUpdateDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1).AddMonths(1).AddDays(-1);
                }

                UpdateFixedCosts(zz);
                await DisplayAlert("Done", "Fixed Cost updated", "Great!");
            }

            

            await Navigation.PushAsync(new MainPage());

        }

    }
}