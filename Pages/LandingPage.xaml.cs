namespace BlitzEcoCarWash.Pages;

/// <summary>
/// LandingPage.xaml.cs
/// ====================
/// PLACEMENT: BlitzEcoCarWash/Pages/LandingPage.xaml.cs
///
/// Code-behind for the Landing (splash/onboarding) page.
/// Handles the two main navigation actions:
///   - Get Started → RegisterPage
///   - Login       → LoginPage
/// </summary>
public partial class LandingPage : ContentPage
{
    public LandingPage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Called when "Get Started" button is tapped.
    /// Navigates to RegisterPage so new users can create an account.
    /// </summary>
    private async void OnGetStartedClicked(object sender, EventArgs e)
    {
        // Navigate to RegisterPage (registered in AppShell.xaml.cs)
        await Shell.Current.GoToAsync(nameof(RegisterPage));
    }

    /// <summary>
    /// Called when "Already have an account? Login" button is tapped.
    /// Navigates to LoginPage for existing users.
    /// </summary>
    private async void OnLoginClicked(object sender, EventArgs e)
    {
        // Navigate to LoginPage (registered in AppShell.xaml.cs)
        await Shell.Current.GoToAsync(nameof(LoginPage));
    }
}
