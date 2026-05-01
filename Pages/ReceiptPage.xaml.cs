namespace BlitzEcoCarWash.Pages;

public partial class ReceiptPage : ContentPage
{
    public ReceiptPage() => InitializeComponent();

    private async void OnTrackClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync(nameof(TrackingPage));

    private async void OnHomeClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync($"///{nameof(LandingPage)}/{nameof(HomePage)}");
}
