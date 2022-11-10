namespace MyStarterKit;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<MainViewModel>();

        builder.Services.AddSingleton<MainPage>();

        builder.Services.AddSingleton<LocalizationViewModel>();

        builder.Services.AddSingleton<LocalizationPage>();

        builder.Services.AddSingleton<SampleViewModel>();

        builder.Services.AddSingleton<SamplePage>();

		builder.Services.AddTransient<SampleDataService>();
		builder.Services.AddTransient<ListDetailSampleDetailViewModel>();
		builder.Services.AddTransient<ListDetailSampleDetailPage>();

        builder.Services.AddSingleton<ListDetailSampleViewModel>();

        builder.Services.AddSingleton<ListDetailSamplePage>();

        builder.Services.AddSingleton<DrawingSampleViewModel>();

        builder.Services.AddSingleton<DrawingSamplePage>();

        builder.Services.AddSingleton<WebViewSampleViewModel>();

        builder.Services.AddSingleton<WebViewSamplePage>();

		return builder.Build();
	}
}
