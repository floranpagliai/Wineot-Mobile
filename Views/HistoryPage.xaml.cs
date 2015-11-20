using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wineot
{
	public partial class HistoryPage : ContentPage
	{
		public HistoryPage ()
		{
			InitializeComponent ();
		}

		async void OnClick (object sender, EventArgs e)
		{
			var wines = UserService.getInstance.getUser ()._historicWines;
			foreach(var wine in wines)
			{
				WineService.getInstance.GetWineAction (wine._id);
			}
		}
	}
}

