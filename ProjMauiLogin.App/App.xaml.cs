using ProjMauiLogin.App.Models;

namespace ProjMauiLogin.App
{
	public partial class App : Application
	{
		public static UserInfo UserInfo;
		public App()
		{
			InitializeComponent();

			MainPage = new AppShell();
		}
	}
}