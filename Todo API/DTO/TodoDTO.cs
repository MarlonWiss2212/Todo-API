namespace Todo_API.DTO
{
    public class TodoDTO
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Description { get; set; }
    }
}
