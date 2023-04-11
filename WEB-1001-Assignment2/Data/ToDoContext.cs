using Microsoft.EntityFrameworkCore;
using WEB_1001_Assignment2.Models;

namespace WEB_1001_Assignment2.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options) : base(options) { }

        public DbSet<ToDo> ToDos => Set<ToDo>();

    }
}
