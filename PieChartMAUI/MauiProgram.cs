using Telerik.Maui.Controls.Compatibility;
using Microsoft.Extensions.Logging.Debug;
using Microsoft.Extensions.Logging;

namespace PieChartMAUI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseTelerik()
                
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

                #if DEBUG
                            builder.Logging.AddDebug();
                #endif

            return builder.Build();
        }
    }
}