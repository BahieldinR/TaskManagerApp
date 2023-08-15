using TaskManager.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskManager
{
    public class MainContext : DbContext
    {
        public MainContext(DbContextOptions options) : base(options) { }

        public DbSet<TodoList> tasks { get; set; }
        public DbSet<Item> items { get; set; }
    }
}
