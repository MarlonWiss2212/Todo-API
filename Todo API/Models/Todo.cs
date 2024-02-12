using Todo_API.DTO;

namespace Todo_API.Models
{
    public class Todo
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
        public required DateTime CreatedAt { get; set; }

        public static Todo CreateTodoFromTodoDTO(TodoDTO todoDTO)
        {
            return new Todo { Id = todoDTO.Id, Title = todoDTO.Title, Description = todoDTO.Description, CreatedAt = DateTime.Now };
        }
    }
}
