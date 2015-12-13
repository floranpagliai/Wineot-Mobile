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

		public string GetWineColor
		{
			get
			{			
			if (this.color == 0)
				return "Rouge";
			else if (this.color == 1)
				return "Blanc";
			else
				return "Rosé";
			}
		}

		public string GetWineColorIcon
		{
			get
			{			
				if (this.color == 0)
					return "wine_color_red.png";
				else if (this.color == 1)
					return "wine_color_white.png";
				else
					return "wine_color_pink.png";
			}
		}

		public string GetAvgPrice
		{
			get
			{
				if (avgPrice != null)
					return avgPrice.ToString ();
				else
					return "-";
			}
		}

		public string GetAvgRating
		{
			get
			{
				if (avgRating != null)
					return avgRating.ToString ();
				else
					return "-";
			}
		}
			
	}
}

