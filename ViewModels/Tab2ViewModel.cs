using System.Collections.ObjectModel;
using System.Windows.Input;
using Elian_App.Services;
using Elian_App.Views;

using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace Elian_App.ViewModels;

public class Tab2ViewModel : BaseViewModel
{
    public ObservableCollection<SimpleModel> Items { get; } = new();
    public ICommand LoadCommand { get; }
    public ICommand ItemTappedCommand { get; }

    private ApiService _apiService;

    public Tab2ViewModel(ApiService apiService)
    {
        _apiService = apiService;
        LoadCommand = new Command(async () => await LoadData());
        ItemTappedCommand = new Command<SimpleModel>(async (item) => await OnItemSelected(item));
        LoadCommand.Execute(null);
    }

    private async Task LoadData()
    {
        Items.Clear();
        var data = await _apiService.GetDataAsync();
        foreach (var it in data)
            Items.Add(it);
    }

    private async Task OnItemSelected(SimpleModel item)
    {
        if (item == null)
            return;
        await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?id={item.id}");
    }
}