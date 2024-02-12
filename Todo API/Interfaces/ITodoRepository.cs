using Todo_API.Models;

namespace Todo_API.Interfaces
{
    public interface ITodoRepository
    {
        bool CreateTodo(Todo todo);
        ICollection<Todo> GetTodos();
        Todo? GetTodo(int id);
        bool Save();
    }
}
