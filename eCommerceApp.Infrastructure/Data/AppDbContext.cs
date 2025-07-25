using eCommerceApp.Domain.Entities;
using eCommerceApp.Domain.Entities.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace eCommerceApp.Infrastructure.Data
{
        public class AppDbContext : IdentityDbContext<AppUser>
        {
                public AppDbContext(DbContextOptions options) : base(options)
                {
                        
                }
                
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<RefreshToken> RefreshToken { get; set; }
            
        }
}
