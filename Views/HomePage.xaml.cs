namespace Elian_App.Views;

public partial class HomePage : ContentPage
{
    int count = 0;

    public HomePage()
    {
        InitializeComponent();
    }



    private async void OnShowGifClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(GifPage));
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();


        RunAnimation();
    }

    private async void RunAnimation()
    {

        await AnimatedImage.FadeTo(1, 750);


        await AnimatedImage.ScaleTo(1, 500);


    }
}