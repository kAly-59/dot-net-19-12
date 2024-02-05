using TodoList.Data;

namespace TodoList.Repositories
{
    public class TodoRepository : ITodoRepository
    {
        private readonly TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public void Add(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TodoItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public TodoItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TodoItem todoItem)
        {
            throw new NotImplementedException();
        }
    }

}
