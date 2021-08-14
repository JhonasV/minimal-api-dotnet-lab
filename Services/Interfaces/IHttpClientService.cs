namespace MinApi.Services.Interfaces {
    public interface IHttpClientService<T> {
        Task<T> Get(string path, object param);
        Task<List<T>> GetAll(string path);
    }
}