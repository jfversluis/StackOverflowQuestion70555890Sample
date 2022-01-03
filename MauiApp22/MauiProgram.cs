namespace MauiApp22;
using FreshMvvm.Maui.Extensions;
using MauiApp22.PageModels;
using MauiApp22.Pages;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddTransient<IApiService, ApiService>();
		builder.Services.AddTransient<MainPageModel>();
		builder.Services.AddTransient<MainPage>();

		builder.Services.UseFreshMvvm();

		return builder.Build();
	}
}
