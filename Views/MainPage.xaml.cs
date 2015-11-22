using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wineot
{
	public partial class MainPage : NavigationPage
	{
		public MainPage ()
		{
			Navigation.PushAsync (new MenuPage ());
			InitializeComponent ();
		}
	}
}

