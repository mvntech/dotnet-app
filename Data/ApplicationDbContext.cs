using dotnet_app.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_app.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        }
        public DbSet<Student>Students { get; set; }
        public DbSet<Faculty> Faculty { get; set; } = default!;
    }
}
