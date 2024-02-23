using BuildAppsTestTask.Services.Profile;
using BuildAppsTestTask.ViewModels;
using BuildAppsTestTask.Views;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace BuildAppsTestTask;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiCommunityToolkit()
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        builder.Services.AddSingleton<IProfileService, ProfileService>();

        builder.Services.AddTransient<Tab1>();
        builder.Services.AddTransient<Tab2>();
        builder.Services.AddTransient<NewPage>();

        builder.Services.AddTransient<Tab1ViewModel>();
        builder.Services.AddTransient<Tab2ViewModel>();
        builder.Services.AddTransient<NewPageViewModel>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
