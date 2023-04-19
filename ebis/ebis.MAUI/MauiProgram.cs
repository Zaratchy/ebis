﻿using ebis.MAUI.Model;
using ebis.MAUI;
using Microsoft.Extensions.Logging;
using ebis.MAUI.ViewModel;

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
		builder.Services.AddSingleton<StatViewModel>();

        return builder.Build();
	}
}
