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
			Title = "Historique"; 
			InitializeComponent ();

			WineListView.ItemsSource = _wines;
			this.GetUserWineHistory ();
		}

		/// <summary>
		/// Gets the user's wine history.
		/// </summary>
		void GetUserWineHistory()
		{
			var wines = UserService.Instance.getUser ().historicWines;
			foreach(var wine in wines)
			{
				this.FetchWineToList (wine.id);
			}
		}

		/// <summary>
		/// Fetchs the wine to list.
		/// </summary>
		/// <param name="id">Identifier.</param>
		async void FetchWineToList(string id)
		{
			WineModel wine = await WineService.Instance.GetWineAction (id);
			if (!string.IsNullOrWhiteSpace (wine.name))
				_wines.Add (wine);
		}
	}
}



