using Microsoft.Extensions.Logging;
using WAP2._1.views;
using WAP2._1.ViewModel;
namespace WAP2._1;

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
        builder.Services.AddSingleton<HomePage>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<Categoria>();
        builder.Services.AddSingleton<Segmento>();

        builder.Services.AddSingleton<LoginPageViewModel>();
		builder.Services.AddSingleton<AddCategoria>();
        


#endif

        return builder.Build();
	}
}
