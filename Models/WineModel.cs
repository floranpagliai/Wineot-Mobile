using System;
using Newtonsoft.Json;

namespace Wineot
{
	public class WineModel
	{
		[JsonProperty("_id")]
		public string _id { get; set; }

		public WineModel ()
		{
		}
	}
}

