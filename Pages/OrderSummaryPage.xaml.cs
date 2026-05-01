namespace BlitzEcoCarWash.Pages;

public partial class OrderSummaryPage : ContentPage
{
    public OrderSummaryPage() => InitializeComponent();
    private async void OnBackClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
    private async void OnPayClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync(nameof(PaymentPage));
}
