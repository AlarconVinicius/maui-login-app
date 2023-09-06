using ProjMauiLogin.App.Models;

namespace ProjMauiLogin.App.Services
{
	public interface ILoginRepository
	{
		Task<UserInfo> Login(string username, string password);
	}
}
