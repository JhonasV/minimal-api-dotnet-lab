using MinApi.Models;

namespace MinApi.Services.Interfaces {
    public interface IService<T> {
        Task<List<T>> GetAllAsync();
        Task<T> FindAsync(int id);
        
    }
}