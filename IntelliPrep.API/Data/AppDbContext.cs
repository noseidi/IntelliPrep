using IntelliPrep.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
namespace IntelliPrep.API.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
  public DbSet<Topic> Topics { get; set; }
        public DbSet<Question> Questions { get; set; }
    public DbSet<Test> Tests => Set<Test>();
    public DbSet<Option> Options { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Test>()
            .HasMany(t => t.Questions)
            .WithOne()
            .OnDelete(DeleteBehavior.Cascade);

       
    }
}

