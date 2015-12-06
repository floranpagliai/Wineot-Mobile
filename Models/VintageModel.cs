using System;
using Newtonsoft.Json;

namespace Wineot
{
	public class VintageModel
	{
		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("wine")]
		public WineModel wine { get; set; }

		[JsonProperty("vintage")]
		public int vintage { get; set; }

		[JsonProperty("is_bio")]
		public bool isBio { get; set; }

		[JsonProperty("contains_sulphites")]
		public bool containsSulphites { get; set; }

		[JsonProperty("peak")]
		public int? peak { get; set; }

		[JsonProperty("keeping")]
		public int? keeping { get; set; }

		[JsonProperty("avg_rating")]
		public double? avgRating { get; set; }

		[JsonProperty("avg_price")]
		public double? avgPrice { get; set; }

		public string name { get { return wine.name; } }

		public WineryModel winery { get { return wine.winery; } }

		public int color { get { return wine.color; } }

		public VintageModel ()
		{
			this.wine = new WineModel ();
		}
	}
}

