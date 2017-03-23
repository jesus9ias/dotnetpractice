using Microsoft.EntityFrameworkCore;
using dotnetpractice.Models;

namespace dotnetpractice
{
    public class WebsiteDbContext : DbContext
    {
        public WebsiteDbContext(DbContextOptions<WebsiteDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
