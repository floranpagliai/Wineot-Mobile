using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wineot
{
	public partial class MenuPage : TabbedPage
	{
		public MenuPage ()
		{
			this.Children.Add(new CameraPage());
			this.Children.Add(new HistoryPage());
			this.HeightRequest = 30;
			InitializeComponent ();
		}
	}
}

