using TodoList.Data;

public interface ITodoRepository
{
    IEnumerable<TodoItem> GetAll();
    TodoItem GetById(int id);
    void Add(TodoItem todoItem);
    void Update(TodoItem todoItem);
    void Delete(int id);
}
