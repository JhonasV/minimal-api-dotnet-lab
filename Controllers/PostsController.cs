using MinApi.Models;
using MinApi.Services.Interfaces;

namespace MinApi.Controllers {
    public class PostsController {
        public async Task GetAllAsync(HttpContext http)
        {
            var postService = http.RequestServices.GetRequiredService<IPostService>();
            await http.Response.WriteAsJsonAsync(await postService.GetAllAsync());
        }

        public async Task GetAsync(HttpContext http)
        {
            http.Request.RouteValues.TryGetValue("id", out var id);
            if(id?.ToString() == null){
                http.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            int idInt = int.Parse(id.ToString() ?? "0");

            var postService = http.RequestServices.GetRequiredService<IPostService>();
            await http.Response.WriteAsJsonAsync(await postService.FindAsync(idInt));
        }

    }
}