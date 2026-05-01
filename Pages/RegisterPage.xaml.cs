namespace BlitzEcoCarWash.Pages;

/// <summary>
/// RegisterPage.xaml.cs
/// =====================
/// PLACEMENT: BlitzEcoCarWash/Pages/RegisterPage.xaml.cs
/// </summary>
public partial class RegisterPage : ContentPage
{
    public RegisterPage()
    {
        InitializeComponent();
    }

    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    /// <summary>Sign Up → navigates to HomePage after successful registration</summary>
    private async void OnSignUpClicked(object sender, EventArgs e)
    {
        // In a real app: validate fields and call API.
        await Shell.Current.GoToAsync($"///{nameof(LandingPage)}/{nameof(HomePage)}");
    }

    private async void OnLoginTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
