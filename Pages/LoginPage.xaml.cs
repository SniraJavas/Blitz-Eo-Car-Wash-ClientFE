namespace BlitzEcoCarWash.Pages;

/// <summary>
/// LoginPage.xaml.cs
/// ==================
/// PLACEMENT: BlitzEcoCarWash/Pages/LoginPage.xaml.cs
/// </summary>
public partial class LoginPage : ContentPage
{
    public LoginPage()
    {
        InitializeComponent();
    }

    /// <summary>Back arrow → returns to previous page (LandingPage)</summary>
    private async void OnBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    /// <summary>Login button → navigates to HomePage (main app)</summary>
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // In a real app: validate credentials first.
        // Navigate to HomePage using absolute route (///) to clear the back stack.
        await Shell.Current.GoToAsync($"///{nameof(LandingPage)}/{nameof(HomePage)}");
    }

    private async void OnForgotPasswordTapped(object sender, TappedEventArgs e)
    {
        await DisplayAlert("Forgot Password", "Password reset functionality coming soon.", "OK");
    }

    /// <summary>"Sign up" link → navigate to RegisterPage</summary>
    private async void OnSignUpTapped(object sender, TappedEventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }
}
