using BlitzEcoCarWash.Pages;

namespace BlitzEcoCarWash;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
        Routing.RegisterRoute(nameof(RegisterPage), typeof(RegisterPage));
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(BookingPage), typeof(BookingPage));
        Routing.RegisterRoute(nameof(VehicleSelectionPage), typeof(VehicleSelectionPage));
        Routing.RegisterRoute(nameof(PackageSelectionPage), typeof(PackageSelectionPage));
        Routing.RegisterRoute(nameof(OrderSummaryPage), typeof(OrderSummaryPage));
        Routing.RegisterRoute(nameof(PaymentPage), typeof(PaymentPage));
        Routing.RegisterRoute(nameof(ReceiptPage), typeof(ReceiptPage));
        Routing.RegisterRoute(nameof(TrackingPage), typeof(TrackingPage));
        Routing.RegisterRoute(nameof(RatingPage), typeof(RatingPage));
    }
}