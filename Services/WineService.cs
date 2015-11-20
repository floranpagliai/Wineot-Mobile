using System;
using System.Threading.Tasks;

namespace Wineot
{
	public class WineService
	{
		private static WineService _instance;
		protected static WineotRestClient _client;

		public static WineService getInstance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new WineService();
					_client = WineotRestClient.getInstance;
				}
				return _instance;
			}
		}

		public async Task<WineModel> GetWineAction (string id)
		{
			return await _client.getWine(id);
		}
	}
}

