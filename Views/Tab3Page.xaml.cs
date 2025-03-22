using Elian_App.Services;

namespace Elian_App.Views;

public partial class Tab3Page : ContentPage
{
    private ApiService _apiService = new ApiService();

    public Tab3Page()
    {
        InitializeComponent();
    }

    private async void BtnLoadData_Clicked(object sender, EventArgs e)
    {
        var items = await _apiService.GetDataAsync();
        ApiList.ItemsSource = items;
    }
}