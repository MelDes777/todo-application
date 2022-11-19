using Microsoft.EntityFrameworkCore;
using todo_application.Models;

namespace todo_application.Infrastructure
{
    public class TodoContext: DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options) { }

        public DbSet<Todo> Todoes { get; set; }
    }
}
