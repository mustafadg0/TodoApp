using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TodoApp.Core.Entities;

namespace TodoApp.Data
{
    public class TodoAppDbContext : DbContext
    {
        public TodoAppDbContext(DbContextOptions<TodoAppDbContext> options) : base(options)
        {
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
