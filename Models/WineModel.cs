using System;
using Newtonsoft.Json;

namespace Wineot
{
	public class WineModel
	{
		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("name")]
		public string name { get; set; }

		[JsonProperty("color")]
		public int color { get; set; }

		[JsonProperty("winery")]
		public WineryModel winery { get; set; }

		public WineModel ()
		{
		}
	}
}

