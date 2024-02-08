using Todo_API.Data;
using Todo_API.Models;

namespace Todo_API
{
    public class Seed(DataContext dataContext)
    {
        private readonly DataContext dataContext = dataContext;

        public void SeedDataContext()
        {
            if(!dataContext.Todos.Any())
            {
                var todos = new List<Todo>()
                {
                    new()
                    {
                        Title = "todo1",
                        Description = "Description1",
                        CreatedAt = DateTime.Now,
                    },
                    new()
                    {
                        Title = "todo2",
                        Description = "Description2",
                        CreatedAt = DateTime.Now,
                    }
                };
                dataContext.Todos.AddRange(todos);
                dataContext.SaveChanges();
            }
        }
    }
}
