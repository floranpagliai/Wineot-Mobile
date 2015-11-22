using System;
using Newtonsoft.Json;

namespace Wineot
{
	public class RegionModel
	{
		[JsonProperty("id")]
		public string id { get; set; }

		[JsonProperty("name")]
		public string name { get; set; }

		public RegionModel ()
		{
		}
	}
}

