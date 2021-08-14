using MinApi.Services.Interfaces;

namespace MinApi.Controllers {
    public class TodosController {
        public async Task GetAllAsync(HttpContext http)
        {
            var todoservice = http.RequestServices.GetRequiredService<ITodosService>();
            await http.Response.WriteAsJsonAsync(await todoservice.GetAllAsync());
        }

        public async Task GetAsync(HttpContext http)
        {
            http.Request.RouteValues.TryGetValue("id", out var id);
            if(id?.ToString() == null){
                http.Response.StatusCode = StatusCodes.Status400BadRequest;
                return;
            }
            int idInt = int.Parse(id.ToString() ?? "0");

            var todoservice = http.RequestServices.GetRequiredService<ITodosService>();
            await http.Response.WriteAsJsonAsync(await todoservice.FindAsync(idInt));
        }

    }
}