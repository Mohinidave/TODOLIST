using Microsoft.EntityFrameworkCore;

namespace ToDoDemo.Models
{
    public class ToDoContext:DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> option):base(option) { }

        public DbSet<ToDo> ToDos { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Status> Statuses { get; set; } = null!;

        //seed data

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = "work", Name = "Work" },
                new Category { CategoryId = "shop", Name = "Shopping" },
                new Category { CategoryId = "ex", Name = "Exercise" },
                new Category { CategoryId = "call", Name = "Contact" },
                new Category { CategoryId = "home", Name = "Home" }


                );
            modelBuilder.Entity<Status>().HasData(
                new Status { StatusId="open" , Name="Open"},
                new Status { StatusId="closed",Name="Completed"}
                );
        }

    }
}
