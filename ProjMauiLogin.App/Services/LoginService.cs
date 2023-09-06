using ProjMauiLogin.App.Models;
using System.Net.Http.Json;

namespace ProjMauiLogin.App.Services
{
	public class LoginService : ILoginRepository
	{
		public async Task<UserInfo> Login(string username, string password)
		{
			try
			{
				if (Connectivity.Current.NetworkAccess == NetworkAccess.Internet)
				{
					var userInfo = new UserInfo();
					//var client = new HttpClient();
					//string url = "http://localhost/api/";
					//client.BaseAddress = new Uri(url);
					//HttpResponseMessage response = await client.GetAsync("");
					//if (response.IsSuccessStatusCode)
					//{
					//	userInfo = await response.Content.ReadFromJsonAsync<UserInfo>();
					//	return await Task.FromResult(userInfo);
					//}
					//else
					//{
					//	return null;
					//}
					if (username == "admin" && password == "123")
					{
						userInfo.UserId = 1;
						userInfo.UserName = username;
						userInfo.Password = password;
						return await Task.FromResult(userInfo);
					}
					else
					{
						return null;
					}
				}
				else
				{
					return null;
				}
			}catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
