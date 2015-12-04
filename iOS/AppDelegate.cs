using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using System.IO;

namespace Wineot.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();
			string folderPath = System.Environment.GetFolderPath (System.Environment.SpecialFolder.Personal);
			string dbPath = Path.Combine (folderPath, "wineot.sqlite3");

			SQLiteService.SetupDatabase (dbPath, new  SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS ());
			Console.WriteLine (dbPath);
			LoadApplication (new App ());
			return base.FinishedLaunching (app, options);
		}
	}
}

