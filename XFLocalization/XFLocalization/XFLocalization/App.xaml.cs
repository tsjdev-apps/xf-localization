using Xamarin.CommunityToolkit.Helpers;
using Xamarin.Forms;
using XFLocalization.Resources;

namespace XFLocalization
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			LocalizationResourceManager.Current.Init(AppResources.ResourceManager);

			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
