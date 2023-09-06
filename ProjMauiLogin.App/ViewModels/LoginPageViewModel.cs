using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;

namespace ProjMauiLogin.App.ViewModels
{
	public partial class LoginPageViewModel : BaseViewModel
	{
		[ObservableProperty]
		private string _userName;

		[ObservableProperty]
		private string _password;

		[ICommand]
		public async void Login()
		{

		}
	}
}
