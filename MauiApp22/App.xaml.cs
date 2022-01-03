using MauiApp22.PageModels;

namespace MauiApp22;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = FreshMvvm.Maui.FreshPageModelResolver.ResolvePageModel<MainPageModel>();
	}
}
