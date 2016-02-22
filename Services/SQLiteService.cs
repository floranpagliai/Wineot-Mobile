using System;
using SQLite.Net;
using System.Linq.Expressions;
using SQLite.Net.Interop;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using System.Collections.Generic;

namespace Wineot
{
	public class SQLiteService
	{

		private string _dbPath;


		private static volatile SQLiteService _instance = null;
		private static object _syncRoot = new Object ();

		private SQLiteService () { }

		#region Singleton

		public static SQLiteService Instance {
			get {
				if (_instance == null) {
					lock (_syncRoot) {
						if (_instance == null)
							_instance = new SQLiteService ();
					}
				}
				return _instance;
			}
		}

		#endregion


		public static SQLiteConnection Connection;

		public static void SetupDatabase (string filePath, ISQLitePlatform platForm)
		{
			Connection = new SQLiteConnection (platForm, filePath);
			Connection.CreateTable<UserModel> ();
			Connection.CreateTable<HistoricWine> ();

			SQLiteService.Instance._dbPath = filePath;
		}

		public static bool Insert_UpdateObject<T> (T obj)
		{
			try {
				Connection.InsertOrReplaceWithChildren(obj, true);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public static List<T> FetchObject<T> (Expression<Func<T, bool>> pred) where T: class
		{
			try {
				var res = Connection.GetAllWithChildren<T>(null, true);
				return res;
			} catch (Exception ex) {
				return null;
			}
		}
	}
}

