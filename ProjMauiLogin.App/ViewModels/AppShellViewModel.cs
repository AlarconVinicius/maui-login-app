using Microsoft.Toolkit.Mvvm.Input;

namespace ProjMauiLogin.App.ViewModels
{
	public partial class AppShellViewModel : BaseViewModel
	{
		[ICommand]
		async void SignOut()
		{
			if (Preferences.ContainsKey(nameof(App.UserInfo)))
			{
				Preferences.Remove(nameof(App.UserInfo));
			}
			await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
		}
	}
}
