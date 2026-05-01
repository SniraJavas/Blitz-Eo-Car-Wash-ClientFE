namespace BlitzEcoCarWash.Pages;

public partial class PaymentPage : ContentPage
{
    public PaymentPage() => InitializeComponent();
    private async void OnBackClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync("..");
    private async void OnPayClicked(object sender, EventArgs e) => await Shell.Current.GoToAsync(nameof(ReceiptPage));
}
