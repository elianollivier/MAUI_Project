using System.Linq;
using Elian_App.Services;
using Microsoft.Maui.Controls;

namespace Elian_App.ViewModels;

[QueryProperty(nameof(Id), "id")]
public class ItemDetailViewModel : BaseViewModel
{
    private readonly ApiService _apiService;

    private int _id;
    public int Id
    {
        get => _id;
        set
        {
            _id = value;
            OnPropertyChanged();
            LoadDetail();
        }
    }

    private string _title;
    public string Title
    {
        get => _title;
        set { _title = value; OnPropertyChanged(); }
    }

    private string _body;
    public string Body
    {
        get => _body;
        set { _body = value; OnPropertyChanged(); }
    }

    public ItemDetailViewModel(ApiService apiService)
    {
        _apiService = apiService;
    }

    private async void LoadDetail()
    {
        var data = await _apiService.GetDataAsync();
        var found = data.FirstOrDefault(x => x.id == Id);
        if (found != null)
        {
            Title = found.title;
            Body  = found.body;
        }
    }
}