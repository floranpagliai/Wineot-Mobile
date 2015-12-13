using System;
using System.Threading.Tasks;

namespace Wineot
{
	public class WineService
	{
		private static WineService _instance;
		protected static WineotRestClient _client;

		public static WineService Instance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new WineService();
					_client = WineotRestClient.Instance;
				}
				return _instance;
			}
		}

		public async Task<WineModel> GetWineAction (string id)
		{
			return await _client.getWine(id);
		}

		public async Task<WineModel> GetWineRecognitionAction (string picture)
		{
			return await _client.postRecognition(UserService.Instance.GetUser().id, picture);
		}

		public async Task<VintageModel> GetVintageAction (string id)
		{
			return await _client.getVintage(id);
		}
	}
}

