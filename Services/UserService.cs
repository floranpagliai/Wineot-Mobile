using System;
using System.Threading.Tasks;

namespace Wineot
{
	public class UserService
	{
		private static UserService _instance;
		protected static WineotRestClient _client;
		protected UserModel user;


		public static UserService getInstance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new UserService();
					_client = WineotRestClient.getInstance;
				}
				return _instance;
			}
		}

		private UserService ()
		{
			user = new UserModel ();
		}

		public UserModel getUser()
		{
			return user;
		}

		public async Task<UserModel> LoginAction (string username, string password)
		{
			user = await _client.postLogin(username, MD5CryptoServiceProvider.GetMd5String(password));
			return user;
		}

		public async Task<UserModel> RegisterAction(string username, string email, string password)
		{
			return await _client.postRegister(username, MD5CryptoServiceProvider.GetMd5String(password), email);
		}
	}
}

