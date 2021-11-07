using Microsoft.EntityFrameworkCore;

namespace BlazorRenderErrorTest.Models {
  public class AppDbContext : DbContext {
    public DbSet<Person> People { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
      optionsBuilder.UseSqlite(@$"Data Source=test.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
      base.OnModelCreating(modelBuilder);
      modelBuilder.Entity<Person>().HasData(new Person { Id = 1, Name = "Kceilorty", Tel = 077448545664 });
      modelBuilder.Entity<Person>().HasData(new Person { Id = 2, Name = "Zurokiea", Tel = 077448545664 });
      modelBuilder.Entity<Person>().HasData(new Person { Id = 3, Name = "Stymliea", Tel = 077448545664 });
    }
  }
}
