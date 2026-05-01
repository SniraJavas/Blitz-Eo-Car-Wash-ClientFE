namespace BlitzEcoCarWash.Pages;

public partial class RatingPage : ContentPage
{
    public RatingPage() => InitializeComponent();

    private async void OnBackClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");

    private async void OnSubmitClicked(object sender, EventArgs e)
    {
        await DisplayAlert("Thank You!", "Thanks for rating Thabo. Your feedback helps us improve! 🌿", "Back to Home");
        await Shell.Current.GoToAsync($"///{nameof(LandingPage)}/{nameof(HomePage)}");
    }

    private async void OnSkipClicked(object sender, EventArgs e)
        => await Shell.Current.GoToAsync($"///{nameof(LandingPage)}/{nameof(HomePage)}");
}
