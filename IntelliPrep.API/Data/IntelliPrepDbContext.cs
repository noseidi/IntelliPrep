using IntelliPrep.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace IntelliPrep.API.Data
{
    public class IntelliPrepDbContext : DbContext
    {
        public IntelliPrepDbContext(DbContextOptions<IntelliPrepDbContext> options) : base(options) {}

        public DbSet<Topic> Topics { get; set; }
        public DbSet<Test> Tests { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}