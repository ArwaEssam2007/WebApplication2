using Microsoft.EntityFrameworkCore;

namespace WebApplication2
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Student> students { get; set; }
        public DbSet<Subject> subjects { get; set; }
        
    }
}
