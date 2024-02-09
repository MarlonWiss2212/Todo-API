using Todo_API.Models;

namespace Todo_API.DTO
{
    public class TodoDTO(Todo todo)
    {
        public int Id { get; set; } = todo.Id;
        public string Title { get; set; } = todo.Title;
        public string Description { get; set; } = todo.Description;
    }
}
