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

		[JsonProperty("avg_rating")]
		public double? avgRating { get; set; }

		[JsonProperty("avg_price")]
		public double? avgPrice { get; set; }

		public WineModel ()
		{
		}

		public string GetWineColor()
		{
			if (this.color == 0)
				return "Rouge";
			else if (this.color == 1)
				return "Blanc";
			else
				return "Rosé";
		}
	}
}

