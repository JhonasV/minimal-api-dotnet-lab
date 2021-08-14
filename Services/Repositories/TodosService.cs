using MinApi.Models;
using MinApi.Services.Interfaces;

namespace MinApi.Services.Repositories {
    public class TodosService : ITodosService
    {

        private IHttpClientService<Todos> _httpClient;
        public TodosService(IHttpClientService<Todos> httpClient){
            _httpClient = httpClient;
        }

        public async Task<Todos> FindAsync(int id)
        {
            return await _httpClient.Get($"/Todos", id);
        }

        public async Task<List<Todos>> GetAllAsync()
        { 
            return await _httpClient.GetAll("/Todos");
        }
    }
}