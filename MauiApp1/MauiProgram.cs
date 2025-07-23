using CommunityToolkit.Maui;
using MauiApp1.Services;
using MauiApp1.Services.Interfaces;
using MauiApp1.ViewModels;
using MauiApp1.Views;
using Microsoft.Extensions.Logging;

namespace MauiApp1
{
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

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IStudentService, StudentService>();

            builder.Services.AddTransient<Page1ViewModel>();
            builder.Services.AddTransient<Page2ViewModel>();
            builder.Services.AddTransient<Page3ViewModel>();
            builder.Services.AddTransient<Page4ViewModel>();

            builder.Services.AddTransient<Page1>();
            builder.Services.AddTransient<Page2>();
            builder.Services.AddTransient<Page3>();
            builder.Services.AddTransient<Page4>();

            return builder.Build();
        }
    }
}
