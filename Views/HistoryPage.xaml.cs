using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Wineot
{
	public partial class HistoryPage : ContentPage
	{
		ObservableCollection<WineModel> _wines = new ObservableCollection<WineModel>();

		public HistoryPage ()
		{
			this.Icon = "history.png";
			InitializeComponent ();

			WineListView.ItemsSource = _wines;
			this.GetWineHistoryAction ();
		}

		async void GetWineHistoryAction()
		{
			var wines = UserService.getInstance.getUser ().historicWines;
			foreach(var wine in wines)
			{
				WineModel wineElem = await WineService.getInstance.GetWineAction (wine.id);

				System.Diagnostics.Debug.WriteLine (wine.date);
				//System.Diagnostics.Debug.WriteLine (wineElem.name);

				if (wineElem.name != "")
					_wines.Add (wineElem);
			}
		}
	}
}

