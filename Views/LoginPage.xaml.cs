using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.IO;
using SQLite.Net;


namespace Wineot
{
	//TODO Add try catch surrounding request to webservices
	//TODO Define custom exceptions
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}
	
		#region View Lifecycle

		protected override void OnAppearing ()
		{
			base.OnAppearing ();
		}

		protected override void OnDisappearing ()
		{
			base.OnDisappearing ();
		}

		#endregion

		async void LoginAction (object sender, EventArgs e)
		{
			if (!string.IsNullOrWhiteSpace (usernameText.Text) && !string.IsNullOrWhiteSpace (passwordText.Text))
			{
				UserService userService = UserService.Instance;
				await userService.LoginAction(usernameText.Text, passwordText.Text);
				if (userService.GetUser() == null)
					await this.DisplayAlert ("Erreur", "Utillisateur ou mot de passe invalide", "OK");
				else {
					var user = userService.GetUser ();
					//Insert or update the user in the database and all of his child object a.k.a HistoricWine objects 
					SQLiteService.Insert_UpdateObject<UserModel> (user);
					await Navigation.PushModalAsync (new MainPage ());
					System.Diagnostics.Debug.WriteLine (userService.GetUser ().historicWines[0].id);
				}
			} else {
				//InputEffectExtensions.InputChangeBorderColor(usernameTextInput, "#e4655f", 0.5f);
				//InputEffectExtensions.InputChangeBorderColor(passwordTextIput, "#e4655f", 0.5f);
			}
		}

		async void RegisterAction (object sender, EventArgs e)
		{
			await Navigation.PushModalAsync (new RegisterPage ());
		}

		async void ForgetPasswordAction (object sender, EventArgs e)
		{
			await Navigation.PushModalAsync (new RegisterPage ());
		}
	}
}

