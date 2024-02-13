using Todo_API.Data;
using Todo_API.Interfaces;
using Todo_API.Models;

namespace Todo_API.Repository
{
    public class TodoRepository(DataContext context) : ITodoRepository
    {
        private readonly DataContext _context = context;

        public bool CreateTodo(Todo todo)
        {
            _context.Add(todo);
            return Save();
        }

        public Todo? GetTodo(int id)
        {
            return _context.Todos.Where(todo => todo.Id == id).FirstOrDefault();
        }

        public ICollection<Todo> GetTodos()
        {
            return _context.Todos.OrderBy(todo => todo.Id).ToList();
        }

        public bool UpdateTodo(Todo todo)
        {
            _context.Update(todo);
            return Save();
        }

        public bool DeleteTodo(Todo todo)
        {
            _context.Remove(todo);
            return Save();
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0;
        }
    }
}
