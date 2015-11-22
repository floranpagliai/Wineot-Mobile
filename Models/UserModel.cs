using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wineot
{
	public class UserModel
	{
		[JsonProperty("_id")]
		public string id { get; set; }
		[JsonProperty("username")]
		public string username { get; set; }
		[JsonProperty("mail")]
		public string email { get; set; }
		[JsonProperty("token")]
		public string token { get; set; }
		[JsonProperty("historic_wine_ids")]
		public List<HistoricWine> historicWines { get; set; }
		[JsonProperty("favorite_wine_ids")]
		public List<string> favoriteWines { get; set; }

		public UserModel ()
		{
		}
	}

	public class HistoricWine
	{
		[JsonProperty("wine_id")]
		public string id { get; set; }
		[JsonProperty("date")]
		public string date { get; set; }
	}
}

