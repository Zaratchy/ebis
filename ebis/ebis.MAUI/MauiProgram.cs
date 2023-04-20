using ebis.MAUI.Services;
using ebis.MAUI.ViewModel;
using Microsoft.Extensions.Logging;

namespace ebis.MAUI;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

#if DEBUG
		builder.Logging.AddDebug();


#endif
		builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<BddService>();
		builder.Services.AddSingleton<StatViewModel>();

        return builder.Build();
	}
}
