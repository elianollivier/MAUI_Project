using Elian_App.Services;
using Elian_App.ViewModels;
using Microsoft.Maui.Controls;

namespace Elian_App.Views;

public partial class Tab2Page : ContentPage
{
    private Tab2ViewModel vm;

    public Tab2Page()
    {
        InitializeComponent();
        vm = new Tab2ViewModel(new ApiService());
        BindingContext = vm;
    }

    void DataList_ItemTapped(object sender, ItemTappedEventArgs e)
    {
        if (e.Item is SimpleModel item)
        {
            vm.ItemTappedCommand.Execute(item);
            ((ListView)sender).SelectedItem = null;
        }
    }
}