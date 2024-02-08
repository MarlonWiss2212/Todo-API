using Todo_API.Models;

namespace Todo_API.Interfaces
{
    public interface ITodoRepository
    {
        ICollection<Todo> GetTodos();
        Todo? GetTodo(int id);

    }
}
