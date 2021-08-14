namespace MinApi.Routes {
    public class Routes {

        private PostsRoutes _postsRoutes;
        private TodosRoutes _todosRoutes;
        public Routes()
        {
            _postsRoutes = new PostsRoutes();
            _todosRoutes = new TodosRoutes();
        }
        public void Init(WebApplication app)
        {
            _postsRoutes.Init(app);
            _todosRoutes.Init(app);
        }
    }
}