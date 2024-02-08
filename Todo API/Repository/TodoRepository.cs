using Todo_API.Data;
using Todo_API.Interfaces;
using Todo_API.Models;

namespace Todo_API.Repository
{
    public class TodoRepository : ITodoRepository
    {
        private readonly DataContext _context;

        public TodoRepository(DataContext context) 
        {
            _context = context;
        }

        public Todo? GetTodo(int id)
        {
            Todo? todo = _context.Todos.Where(todo => todo.Id == id).FirstOrDefault();
            return todo;
        }

        public ICollection<Todo> GetTodos()
        {
            return _context.Todos.OrderBy(todo => todo.Id).ToList();
        }
    }
}
