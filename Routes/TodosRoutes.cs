using MinApi.Controllers;

namespace MinApi.Routes{
    public class TodosRoutes {
        private MinApi.Controllers.Controllers _controllers;

        public TodosRoutes()
        {
            _controllers = new MinApi.Controllers.Controllers();
        }

        public void Init(WebApplication app)
        {
            app.MapGet("/todos", _controllers.TodosController.GetAllAsync);

            app.MapGet("/todo/{id}", _controllers.TodosController.GetAsync);
        }
    }
}