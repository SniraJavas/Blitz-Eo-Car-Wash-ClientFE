namespace BlitzEcoCarWash.Pages;

public partial class TrackingPage : ContentPage
{
    public TrackingPage() => InitializeComponent();
    private async void OnBackClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
    private async void OnCompleteClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync(nameof(RatingPage));
    private async void OnHelpClicked(object sender, EventArgs e)
        => await DisplayAlert("Need Help?", "Call us: 0800-BLITZ (25489) or chat via WhatsApp.", "OK");
}
