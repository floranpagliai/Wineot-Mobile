using System;
using System.Threading.Tasks;

namespace Wineot
{
	public class UserService
	{
		private static UserService _instance;
		protected static WineotRestClient _client;
		protected UserModel _user;


		public static UserService Instance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new UserService();
					_client = WineotRestClient.Instance;
				}
				return _instance;
			}
		}

		private UserService ()
		{
			_user = new UserModel ();
		}

		public UserModel GetUser()
		{
			return _user;
		}

		public void SetUser(UserModel user)
		{
			_user = user;
		}

		public async Task<UserModel> LoginAction (string username, string password)
		{
			_user = await _client.postLogin(username, MD5CryptoServiceProvider.GetMd5String(password));
			if (_user != null)
				_user.isCurrentUser = true;
			return _user;
		}

		public async Task<UserModel> RegisterAction(string username, string email, string password)
		{
			_user = await _client.postRegister(username, MD5CryptoServiceProvider.GetMd5String(password), email);
			if (_user != null)
				_user.isCurrentUser = true;
			return _user;
		}
	}
}

