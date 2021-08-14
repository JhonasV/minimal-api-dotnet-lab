using MinApi.Models;
using MinApi.Services.Interfaces;

namespace MinApi.Services.Repositories {
    public class PostService : IPostService
    {

        private IHttpClientService<Posts> _httpClient;
        public PostService(IHttpClientService<Posts> httpClient){
            _httpClient = httpClient;
        }

        public async Task<Posts> FindAsync(int id)
        {
            return await _httpClient.Get($"/posts", id);
        }

        public async Task<List<Posts>> GetAllAsync()
        { 
            return await _httpClient.GetAll("/posts");
        }
    }
}