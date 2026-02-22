using MenagerLekow.Db;
using MenagerLekow.INTERFACES;
using MenagerLekow.MVVM.VIEW;
using MenagerLekow.MVVM.VIEWMODEL;
using Microsoft.Extensions.Logging;

namespace MenagerLekow
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

#if DEBUG
            builder.Services.AddTransient<glownaViewModel>();
            builder.Services.AddTransient<StronaGlowna>();
            //rejestracja bazy danych w kontenerze DI
            //dodano komentarz
            builder.Services.AddSingleton<IBazaDanych, BazaDanych>();
            builder.Services.AddTransient<DodajElement>();

            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
