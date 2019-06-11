using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IncExpTracker
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TrackExpensesByCat : ContentPage
	{
        List<VMMonthlyDetails> _vmMonthlyDet = new List<VMMonthlyDetails>();
        string des = "";
		public TrackExpensesByCat (string descr)
		{
			InitializeComponent ();
            des = descr;
            string titleDate = "";
            if (descr == "")
            {
                titleDate = FillTheGrid();
                if (titleDate != "")
                {
                    titleLbl.Text = "All-Time Expenses " + "\n(from " + titleDate + ")" ;
                }
                else
                {
                    titleLbl.Text = "All-Time Expenses ";
                }
                

            }
            else
            {
                SpecificExpense(descr);
                titleLbl.Text = "All-Time Expenses - " + descr;
            }
            titleLbl.TextColor = Color.IndianRed;

        }

        async void TappedItem(object sender, EventArgs e)
        {
            if (des == "")
            {
                var getDescr = insideGrid.SelectedItem as VMMonthlyDetails;
                des = getDescr.Descr;
                titleLbl.Text = "All-Time Expenses - " + getDescr.Descr;
                SpecificExpense(getDescr.Descr);
            }
            else
            {

            }
        }

        string FillTheGrid()
        {
            try
            {
                List<VMMonthlyDetails> gridList = SqlTableExpenses.ExpensesAllTime();
                insideGrid.ItemsSource = gridList;
                string retString = gridList.FirstOrDefault().Date.ToString("MMMM yyyy", CultureInfo.InvariantCulture);
                return retString;
            }
            catch (Exception)
            {
                return "";
            }
            

        }
        async void SpecificExpense(string descr)
        {
            List<VMMonthlyDetails> gridList = SqlTableExpenses.SpecificExpenseAllTime(descr);
            insideGrid.ItemsSource = gridList;
        }
	}
}