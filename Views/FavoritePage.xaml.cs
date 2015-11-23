using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace Wineot
{
	public partial class FavoritePage : ContentPage
	{
		ObservableCollection<WineModel> _wines = new ObservableCollection<WineModel>();

		public FavoritePage ()
		{
			this.Icon = "unlike.png";
			Title = "Favoris"; 
			InitializeComponent ();
		}
	
		async void GetWineHistoryAction()
		{
			var wines = UserService.getInstance.getUser ().favoriteWines;
			foreach(var wine in wines)
			{
				WineModel wineElem = await WineService.getInstance.GetWineAction (wine);

				if (wineElem.name != "")
					_wines.Add (wineElem);
			}
		}
	}
}

