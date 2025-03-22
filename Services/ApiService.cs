using Newtonsoft.Json;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Elian_App.Services
{
    public class ApiService
    {
        private static List<SimpleModel> _localItems = new List<SimpleModel>();
        private readonly HttpClient _httpClient;

        public ApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<SimpleModel>> GetDataAsync()
        {
            var url = "https://jsonplaceholder.typicode.com/posts";
            var response = await _httpClient.GetAsync(url);
            if (!response.IsSuccessStatusCode)
                return new List<SimpleModel>();

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonConvert.DeserializeObject<List<SimpleModel>>(json) ?? new List<SimpleModel>();
            data.AddRange(_localItems);
            return data;
        }

        public void AddLocalItem(SimpleModel item)
        {
            _localItems.Add(item);
        }
    }

    public class SimpleModel
    {
        public int userId { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string body { get; set; }
    }
}