using Microsoft.AspNetCore.Mvc;

public class TodoController : Controller
{
    private readonly ITodoRepository _todoRepository;

    public TodoController(ITodoRepository todoRepository)
    {
        _todoRepository = todoRepository;
    }
}
