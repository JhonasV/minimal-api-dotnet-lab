using MinApi.Models;
using MinApi.Services.Interfaces;

namespace MinApi.Services.Repositories {
    public class HttpClientService<T> : IHttpClientService<T> where T: class
    {
        private HttpClient _httpClient;

        public HttpClientService(ApplicationConfig appConfig){
            _httpClient = new HttpClient();            
            _httpClient.BaseAddress = new Uri(appConfig.BaseApiUrl);
        }

        public async Task<T> Get(string path, object param)
        {
            var response = await _httpClient.GetAsync($"{path}/{param}");
            Type type = typeof(T);
            object result = Activator.CreateInstance(type) ?? new object();
            if(response.IsSuccessStatusCode){
                result = await response.Content.ReadFromJsonAsync<T>();             
            }

            return (T)result;
        }

        public async Task<List<T>> GetAll(string path)
        {
            var response = await _httpClient.GetAsync(path);
            Type type = typeof(List<T>);
            object result = Activator.CreateInstance(type);
            if(response.IsSuccessStatusCode){
                result = await response.Content.ReadFromJsonAsync<List<T>>();             
            }

            return (List<T>)result;
        }
    }
}