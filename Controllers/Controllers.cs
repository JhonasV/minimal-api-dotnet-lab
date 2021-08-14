namespace MinApi.Controllers {
    public class Controllers {       
        public PostsController PostsController;
        public TodosController TodosController;

        public Controllers()
        {
            PostsController = new PostsController();
            TodosController = new TodosController();
        }
    }

}