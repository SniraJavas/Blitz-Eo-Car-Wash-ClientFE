namespace BlitzEcoCarWash.Pages;

public partial class PackageSelectionPage : ContentPage
{
    public PackageSelectionPage() => InitializeComponent();
    private async void OnBackClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
    private async void OnContinueClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync(nameof(OrderSummaryPage));
}
