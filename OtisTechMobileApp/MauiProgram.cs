using MudBlazor;
using MudBlazor.Services;
using OtisTechMobileApp.Services;

namespace OtisTechMobileApp
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
                });

            builder.Services.AddScoped<IApiService, ApiService>();
            builder.Services.AddScoped<IUpdateData, UpdateData>();

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif
            builder.Services.AddMudServices(config=>
            {
                config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomLeft;
            });

            return builder.Build();
        }
    }
}