using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Urban.Models;

namespace Urban.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Urban.Models.Product> Product { get; set; }
        
        public DbSet<Urban.Models.Order> Order { get; set; }
        public DbSet<Urban.Models.OrderItem> OrderItem { get; set; }

        public DbSet<Urban.Models.ShoppingCart> ShoppingCart { get; set; }

    }
}