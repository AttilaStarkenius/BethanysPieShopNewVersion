using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopNewVersion.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }
        public DbSet<Pie> Pies { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
