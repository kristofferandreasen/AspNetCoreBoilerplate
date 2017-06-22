using Microsoft.EntityFrameworkCore;
using AspNetCoreBoilerplate.Models;

namespace AspNetCoreBoilerplate.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Item> Items { get; set; }
    }
}