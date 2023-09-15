using MauiApp4.ViewModels;
using MauiApp4.Views;
using Microsoft.Extensions.Logging;

namespace MauiApp4
{
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

        // SERVICES

        //Views Registration
        builder.Services.AddSingleton<StudentListPage>();

        //View Modles
        builder.Services.AddSingleton<StudentListPageViewModel>();

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}