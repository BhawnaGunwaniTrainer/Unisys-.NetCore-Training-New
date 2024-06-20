using Microsoft.EntityFrameworkCore;

namespace coreWebAPIEFCoreProject.Models
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=booksdb;Integrated Security=true;TrustServerCertificate=true");
            /*optionsBuilder.UseSqlServer("Server=DESKTOP-EI4423A;Database=booksdb;User Id=sa;Password=sa@123456;TrustServerCertificate=true");*/
        }
    }
}
