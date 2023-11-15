using Aspdotnet3.Models;
using Microsoft.EntityFrameworkCore;
namespace Aspdotnet3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }

        public DbSet<Category> Category { get; set; }
    }
}
