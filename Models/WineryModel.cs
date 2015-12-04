using System;
using Newtonsoft.Json;

namespace Wineot
{
	public class WineryModel
	{
		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("name")]
		public string name { get; set; }

		[JsonProperty("country")]
		public string country { get; set; }

		[JsonProperty("region")]
		public string region { get; set; }

		public WineryModel ()
		{
		}
	}
}

