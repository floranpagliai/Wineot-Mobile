using System;

using Xamarin.Forms;

namespace Wineot
{
	public partial class App : Application
	{
		public App ()
		{
			// The root page of your application
			InitializeComponent();
			var users = SQLiteService.FetchObject<UserModel> (u => u.isCurrentUser == true);
			if (users.Count > 0) {
				UserService.Instance.SetUser (users [0]);
				MainPage = new Wineot.MainPage ();
			}
			else
				MainPage = new Wineot.LoginPage ();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

