using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using SQLite.Net.Attributes;
using SQLiteNetExtensions.Attributes;
using System.Linq;
namespace Wineot
{
	public class UserModel
	{
		[JsonProperty("_id")]
		[PrimaryKey]
		public string id { get; set; }

		[JsonProperty("username")]
		public string username { get; set; }

		[JsonProperty("mail")]
		public string email { get; set; }

		[JsonProperty("token")]
		public string token { get; set; }

		[JsonProperty("historic_wine_ids")]
		[OneToMany(CascadeOperations = CascadeOperation.All)] 
		public List<HistoricWine> historicWines { get; set; }

		[JsonProperty("favorite_wine_ids")]
		[TextBlob("favorite_wine_ids_blobbed")]
		public List<string> favoriteWines { get; set; }

		public string favorite_wine_ids_blobbed { get; set; }

		public bool isCurrentUser { get; set; }

		public UserModel ()
		{
		}
	}

	public class HistoricWine
	{
		[JsonProperty("wine_id")]
		[PrimaryKey]
		public string id { get; set; }

		[ForeignKey(typeof(UserModel))] 
		public string UserModelId {get; set; }

		[JsonProperty("date")]
		public string date { get; set; }
	}
}

