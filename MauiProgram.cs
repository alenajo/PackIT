﻿namespace RMA_Tim6;

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
                fonts.AddFont("PlayfairDisplay-VariableFont_wght.ttf", "PlayfairDisplay");
				fonts.AddFont("GrandHotel-Regular.ttf", "GrandHotel");
            });

		return builder.Build();
	}
}
