using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wineot
{
	public class UserModel
	{
		[JsonProperty("_id")]
		public string _id { get; set; }
		[JsonProperty("username")]
		public string _username { get; set; }
		[JsonProperty("mail")]
		public string _email { get; set; }
		[JsonProperty("token")]
		public string _token { get; set; }
		[JsonProperty("historic_wine_ids")]
		public List<HistoricWine> _historicWines { get; set; }
		[JsonProperty("favorite_wine_ids")]
		public List<string> _favoriteWines { get; set; }

		public UserModel ()
		{
		}
	}

	public class HistoricWine
	{
		[JsonProperty("wine_id")]
		public string _id { get; set; }
		[JsonProperty("date")]
		public string _date { get; set; }
	}
}

