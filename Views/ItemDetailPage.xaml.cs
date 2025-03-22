using Elian_App.ViewModels;
using Elian_App.Services;
using Microsoft.Maui.Controls;

namespace Elian_App.Views;

public partial class ItemDetailPage : ContentPage
{
    public ItemDetailPage()
    {
        InitializeComponent();
        BindingContext = new ItemDetailViewModel(new ApiService());
    }
}