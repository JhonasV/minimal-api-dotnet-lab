using MinApi.Controllers;
using MinApi.Models;
using MinApi.Services.Interfaces;
using MinApi.Services.Repositories;

namespace MinApi.Configuration {
    public static class IocConfiguration {


        public static void Init(IServiceCollection services, IConfiguration configuration){
                var appConfig = configuration.GetSection(nameof(ApplicationConfig)).Get<ApplicationConfig>();

                if (appConfig == null)
                {
                    throw new Exception($"The configuration for {nameof(appConfig)} was not supply");
                }
                services.AddSingleton(appConfig);
                services.AddTransient(typeof(IHttpClientService<>), typeof(HttpClientService<>));
                services.AddTransient<IPostService, PostService>();
                services.AddTransient<ITodosService, TodosService>();
        }
    }
}