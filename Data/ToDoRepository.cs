namespace WebApplication1.Data
{
    public class ToDoRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ToDoRepository(ApplicationDbContext dbContext) => _dbContext = dbContext;

        public ToDoItem? FindMyToDo(int id)
        {
            var myToDo = _dbContext.ToDoItems.Find(id);
            return myToDo;
        }

        public IEnumerable<ToDoItem> GetMyToDos()
        {
            var myToDos = new List<ToDoItem>();
            return myToDos;
        }

        public void AddToDoItem(ToDoItem toDoItem)
        {
            _dbContext.Add(toDoItem);
            _dbContext.SaveChanges();
        }

        public void UpdateToDoItem(ToDoItem toDoItem)

        {
            _dbContext.Update(toDoItem);
            _dbContext.SaveChanges();
        }

        public void DeleteToDoItem(ToDoItem toDoItem)

        {
            _dbContext.Remove(toDoItem);
            _dbContext.SaveChanges();
        }
    }

}
