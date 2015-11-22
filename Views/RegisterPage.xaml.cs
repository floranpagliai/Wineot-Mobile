using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wineot
{
	public partial class RegisterPage : ContentPage
	{
		public RegisterPage ()
		{
			this.BackgroundImage = "background.jpg";
			InitializeComponent ();
		}

		async void RegisterAction (object sender, EventArgs e)
		{
			await Navigation.PushModalAsync (new LoginPage ());
		}

		async void LoginAction (object sender, EventArgs e)
		{
			await Navigation.PopModalAsync ();
		}

		async void ForgetPasswordAction (object sender, EventArgs e)
		{
			await Navigation.PushModalAsync (new LoginPage ());
		}
	}
}

