using Microsoft.EntityFrameworkCore;

namespace coreWebAPIEFCoreProject.Models
{
    public class ECommerceDBContext: DbContext
    {
        public ECommerceDBContext(DbContextOptions<ECommerceDBContext> options) : base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
