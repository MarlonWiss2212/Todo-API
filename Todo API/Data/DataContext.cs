using Microsoft.EntityFrameworkCore;
using Todo_API.Models;

namespace Todo_API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) 
        {
                
        }

        public DbSet<Todo> Todos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Todo>().HasKey(pc => new { pc.Id});
            base.OnModelCreating(modelBuilder);
        }
    }
}
