using System.Text.Json.Serialization;
using Todo_API.Models;

namespace Todo_API.DTO
{
    public class TodoDTO
    {
        public TodoDTO(Todo todo) { 
            Id = todo.Id;
            Title = todo.Title;
            Description = todo.Description;
        }

        [JsonConstructor]
        public TodoDTO(int Id, String Title, String Description)
        {
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
        }
      

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
