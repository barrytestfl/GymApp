using CommunityToolkit.Maui;
using DevExpress.Maui;
using GymApp.Extensions;
using Microsoft.Extensions.Logging;
using Sharpnado.CollectionView;
using Sharpnado.Tabs;
using ZXing.Net.Maui.Controls;

namespace GymApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseSharpnadoCollectionView(loggerEnable:false)
                .UseSharpnadoTabs(loggerEnable: false)
                .UseDevExpress()
                .UseBarcodeReader()
                .UseMauiCommunityToolkit()
                .AddServices()
                .AddViewModels()
                .AddViews()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("FontAwesomeSolid.otf", "AwesomeSolid");
                    fonts.AddFont("latoblack.TTF", "latoblack");
                    fonts.AddFont("latobold.TTF", "latobold");
                    fonts.AddFont("latoitalic.TTF", "latoitalic");
                    fonts.AddFont("latoregular.TTF", "latoregular");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}