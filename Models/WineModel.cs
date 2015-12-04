using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Wineot
{
	public class WineModel
	{
		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("winery")]
		public WineryModel winery { get; set; }

		[JsonProperty("name")]
		public string name { get; set; }

		[JsonProperty("color")]
		public int color { get; set; }

		[JsonProperty("description")]
		public string description { get; set; }

		[JsonProperty("vintages")]
		public List<VintageModel> vintages { get; set; }

		public WineModel ()
		{
		}
	}
}

