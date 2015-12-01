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


		public static SQLiteConnection connection;

		public static void SetupDatabase (string filePath, ISQLitePlatform platForm)
		{
			connection = new SQLiteConnection (platForm, filePath);
			connection.CreateTable<UserModel> ();
			connection.CreateTable<HistoricWine> ();

			SQLiteService.Instance._dbPath = filePath;
		}

		public static bool Insert_UpdateObject<T> (T obj)
		{
			try {
				connection.InsertOrReplaceWithChildren(obj, true);
				return true;
			} catch (Exception ex) {
				return false;
			}
		}

		public static List<U> FetchObject<U> (Expression<Func<U, bool>> pred) where U: class
		{
			try {
				var res = connection.GetAllWithChildren<U>(null, true);
				return res;
			} catch (Exception ex) {
				return null;
			}
		}
	}
}

