using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SVG.Forms.Plugin.Droid;
using System.IO;

namespace Wineot.Droid
{
	[Activity (Label = "Wineot.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);
			string folderPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			string dbPath = Path.Combine (folderPath, "wineot.sqlite3");

			SQLiteService.SetupDatabase (dbPath, new  SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid ());
			Console.WriteLine (dbPath);
			SvgImageRenderer.Init();

			LoadApplication (new App ());
		}
	}
}

