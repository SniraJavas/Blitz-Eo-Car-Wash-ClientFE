namespace BlitzEcoCarWash.Pages;

/// <summary>
/// HomePage.xaml.cs
/// =================
/// PLACEMENT: BlitzEcoCarWash/Pages/HomePage.xaml.cs
/// </summary>
public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
    }

    private async void OnBookNowClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BookingPage));
    }

    private async void OnMyBookingsTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BookingPage));
    }

    private async void OnTrackWashTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(TrackingPage));
    }

    private async void OnLearnMoreTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Eco Offer", "Use code ECO10 to get 10% off your next eco-friendly wash!", "Awesome!");
    }
}
