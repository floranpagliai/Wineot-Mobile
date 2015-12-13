using System;
using Newtonsoft.Json;

namespace Wineot
{
	public class CountryModel
	{
		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("name")]
		public string name { get; set; }

		[JsonProperty("code")]
		public string code { get { return "fr"; }  }

		public CountryModel ()
		{
		}
	}
}

