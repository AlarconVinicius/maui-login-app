using ProjMauiLogin.App.ViewModels;
using ProjMauiLogin.App.Views;

namespace ProjMauiLogin.App
{
	public partial class AppShell : Shell
	{
		public AppShell()
		{
			InitializeComponent();
			this.BindingContext = new AppShellViewModel();
			Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		}
	}
}