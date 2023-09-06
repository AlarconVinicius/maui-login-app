using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Newtonsoft.Json;
using ProjMauiLogin.App.Models;
using ProjMauiLogin.App.Services;
using ProjMauiLogin.App.UserControl;
using ProjMauiLogin.App.Views;

namespace ProjMauiLogin.App.ViewModels
{
	public partial class LoginPageViewModel : BaseViewModel
	{
		[ObservableProperty]
		private string _userName;

		[ObservableProperty]
		private string _password;

		readonly ILoginRepository loginRepository = new LoginService();
		[ICommand]
		public async void Login()
		{
			if(!string.IsNullOrWhiteSpace(UserName) && !string.IsNullOrWhiteSpace(Password)) 
			{
				UserInfo userInfo = await loginRepository.Login(UserName, Password);
				if (userInfo is null) return;
				if(Preferences.ContainsKey(nameof(App.UserInfo)))
				{
					Preferences.Remove(nameof(App.UserInfo));
				}

				//string userDetails = JsonConvert.SerializeObject(userInfo);
				//Preferences.Set(nameof(App.UserInfo), userDetails);
				App.UserInfo = userInfo;
				AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
				await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
			}
		}
	}
}
