using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
  public class ToDoListContext : DbContext
  {
    public virtual DbSet<Category> Categories { get; set; }
    public DbSet<Item> Items { get; set; }
    public DbSet<CategoryItem> CategoryItem { get; set; }

    public ToDoListContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}

//Obviously change out namespace, class, and Context file name to whatever is used as the project name instead of ToDoList.

// Change out Item/Items and Category/Categories to match what is used in the project. REMEMBER TO MAKE NOTE OF SINGULAR VS PLURAL USE. 