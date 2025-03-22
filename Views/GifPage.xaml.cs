namespace Elian_App.Views;

public partial class GifPage : ContentPage
{
    public GifPage()
    {
        InitializeComponent();
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}