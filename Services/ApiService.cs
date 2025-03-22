using Newtonsoft.Json;

namespace Elian_App.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<SimpleModel>> GetDataAsync()
    {
        var url = "https://sampleapis.com/coffee/api/hot";
        var response = await _httpClient.GetAsync(url);
        if (!response.IsSuccessStatusCode)
            return new List<SimpleModel>();

        var json = await response.Content.ReadAsStringAsync();
        var data = JsonConvert.DeserializeObject<List<SimpleModel>>(json);
        return data ?? new List<SimpleModel>();
    }
}

public class SimpleModel
{
    public int id { get; set; }
    public string title { get; set; }
    public string description { get; set; }
    public string ingredients { get; set; }
    public string image { get; set; }
}