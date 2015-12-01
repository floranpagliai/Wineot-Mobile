using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Wineot
{
	public partial class FavoritePage : ContentPage
	{
		ObservableCollection<VintageModel> _wines = new ObservableCollection<VintageModel>();

		public FavoritePage ()
		{
			this.Icon = "like.png";
			Title = "Favoris"; 
			InitializeComponent ();

			WineListView.ItemsSource = _wines;
			this.GetUserWineFavorite ();
		}

		/// <summary>
		/// Gets the user wine favorite.
		/// </summary>
		void GetUserWineFavorite()
		{
			var wines = UserService.Instance.getUser ().favoriteWines;
			foreach(var wine in wines)
			{
				this.FetchWineToList (wine);
			}
		}

		/// <summary>
		/// Fetchs the wine to list.
		/// </summary>
		/// <param name="id">Identifier.</param>
		async void FetchWineToList(string id)
		{
			VintageModel wine = await WineService.Instance.GetVintageAction (id);
			if (!string.IsNullOrWhiteSpace (wine.name))
				_wines.Add (wine);
		}
	}
}

