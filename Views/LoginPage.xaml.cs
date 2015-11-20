using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Wineot
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

		async void OnLogin (object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace (usernameText.Text) && !string.IsNullOrWhiteSpace (passwordText.Text))
			{
				UserService userService = UserService.getInstance;
				await userService.LoginAction(usernameText.Text, passwordText.Text);
				if (userService.getUser ()._token == null)
					this.DisplayAlert ("Erreur", "Utillisateur ou mot de passe invalide", "OK");
				else {
					await Navigation.PushModalAsync (new MenuPage ());
					System.Diagnostics.Debug.WriteLine (userService.getUser ()._historicWines[0]._id);
				}
			} else {
				//InputEffectExtensions.InputChangeBorderColor(usernameTextInput, "#e4655f", 0.5f);
				//InputEffectExtensions.InputChangeBorderColor(passwordTextIput, "#e4655f", 0.5f);
			}
		}
	}
}

