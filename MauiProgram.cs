using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Stashify.Services;
using Stashify.ViewModels;
using Microsoft.Maui.Controls;


namespace Stashify
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

                    fonts.AddFont("FA6Brands.otf", "FA6Brands");
                    fonts.AddFont("FA6Regular.otf", "FA6Regular");
                    fonts.AddFont("FA6Solid.otf", "FA6Solid");
                });

//#if DEBUG
            //builder.Logging.AddDebug();
//#endif

            // Register services and view models
            builder.Services.AddSingleton<IAlertService, AlertService>();
            builder.Services.AddTransient<HomePageVM>();
            builder.Services.AddTransient<StashPageVM>();
            builder.Services.AddTransient<WishListPageVM>();

            return builder.Build();
        }
    }
}
