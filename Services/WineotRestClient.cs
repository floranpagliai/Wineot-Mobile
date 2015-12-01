using System;
using RestSharp.Portable;

using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Wineot
{
	public class WineotRestClient
	{
		private static WineotRestClient _instance;
		private static HttpClient _client;
		private static string _baseUrl;
		private static string _baseUrlNew;


		public static WineotRestClient Instance
		{
			get 
			{
				if (_instance == null)
				{
					_instance = new WineotRestClient();
					_client = new HttpClient();
					//_client.MaxResponseContentBufferSize = 256000;
					_baseUrl = "http://5.196.65.30:8181";
					_baseUrlNew = "http://wineot.net/api";
					//_baseUrlNew = "http://localhost:8888/Wineot/web/api";
				}
				return _instance;
			}
		}

		public async Task<UserModel> postLogin(string username, string password)
		{
			var uri = new Uri (_baseUrl + "/login");
			Dictionary<string, string> postData = new Dictionary<string, string>();

			postData.Add("username", username);
			postData.Add("password", password);

			var formContent = new FormUrlEncodedContent(postData);

			var response = await _client.PostAsync(uri, formContent);
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync ();
				var result = JsonConvert.DeserializeObject <UserModel> (JObject.Parse (content) ["user"].ToString ());
				System.Diagnostics.Debug.WriteLine (content);
				return result;
			} else {
				return new UserModel();
			}
		}

		public async Task<UserModel> postRegister(string username, string email, string password)
		{
			var uri = new Uri (_baseUrl + "/login");
			Dictionary<string, string> postData = new Dictionary<string, string>();

			postData.Add("username", username);
			postData.Add("password", password);

			var formContent = new FormUrlEncodedContent(postData);

			var response = await _client.PostAsync(uri, formContent);
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync ();
				var result = JsonConvert.DeserializeObject <UserModel> (JObject.Parse (content) ["user"].ToString ());
				System.Diagnostics.Debug.WriteLine (content);
				return result;
			} else {
				return new UserModel();
			}
		}

		public async Task<WineModel> getWine(string id)
		{
			var uri = new Uri (_baseUrlNew + "/wine/" + id);
			var request = new HttpRequestMessage ();

			request.RequestUri = uri;
			request.Method = HttpMethod.Get;
			//request.Headers.Add ("token", UserService.getInstance.getUser().token);

			var response = await _client.SendAsync (request);
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync ();
				return JsonConvert.DeserializeObject <WineModel> (JObject.Parse (content).ToString ());
			} else {
				return new WineModel();
			}
		}

		public async Task<VintageModel> getVintage(string id)
		{
			var uri = new Uri (_baseUrlNew + "/wine/vintage/" + id);
			var request = new HttpRequestMessage ();

			request.RequestUri = uri;
			request.Method = HttpMethod.Get;
			//request.Headers.Add ("token", UserService.getInstance.getUser().token);

			var response = await _client.SendAsync (request);
			if (response.IsSuccessStatusCode) {
				var content = await response.Content.ReadAsStringAsync ();
				System.Diagnostics.Debug.WriteLine (content);
				return JsonConvert.DeserializeObject <VintageModel> (JObject.Parse (content).ToString ());
			} else {
				return new VintageModel();
			}
		}
	}
}

