using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;

namespace BlitzEcoCarWash;

/// <summary>
/// MauiProgram.cs
/// ==============
/// PLACEMENT: Root of project → BlitzEcoCarWash/MauiProgram.cs
///
/// This is the app's .NET MAUI startup entry point.
/// Register all Pages and Services here using dependency injection.
/// </summary>
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();

        builder.UseMauiApp<App>()
            .UseMauiCommunityToolkit()   // ← add this line
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // -----------------------------------------------
        // REGISTER ALL PAGES FOR DEPENDENCY INJECTION
        // -----------------------------------------------
        // This lets MAUI create pages with constructor injection later.
        // Add any new pages here as AddTransient<YourPage>().
        // -----------------------------------------------
        builder.Services.AddTransient<Pages.LandingPage>();
        builder.Services.AddTransient<Pages.LoginPage>();
        builder.Services.AddTransient<Pages.RegisterPage>();
        builder.Services.AddTransient<Pages.HomePage>();
        builder.Services.AddTransient<Pages.BookingPage>();
        builder.Services.AddTransient<Pages.VehicleSelectionPage>();
        builder.Services.AddTransient<Pages.PackageSelectionPage>();
        builder.Services.AddTransient<Pages.OrderSummaryPage>();
        builder.Services.AddTransient<Pages.PaymentPage>();
        builder.Services.AddTransient<Pages.ReceiptPage>();
        builder.Services.AddTransient<Pages.TrackingPage>();
        builder.Services.AddTransient<Pages.RatingPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
