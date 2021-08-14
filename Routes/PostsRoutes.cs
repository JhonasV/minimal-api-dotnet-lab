using MinApi.Controllers;

namespace MinApi.Routes{
    public class PostsRoutes {
        private MinApi.Controllers.Controllers _controllers;

        public PostsRoutes()
        {
            _controllers = new MinApi.Controllers.Controllers();
        }

        public void Init(WebApplication app)
        {
            app.MapGet("/", _controllers.PostsController.GetAllAsync);

            app.MapGet("/posts", _controllers.PostsController.GetAllAsync);

            app.MapGet("/post/{id}", _controllers.PostsController.GetAsync);
        }
    }
}