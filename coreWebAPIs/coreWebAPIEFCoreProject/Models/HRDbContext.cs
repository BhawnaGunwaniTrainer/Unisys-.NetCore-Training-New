using Microsoft.EntityFrameworkCore;

namespace coreWebAPIEFCoreProject.Models
{
    public class HRDbContext: DbContext
    {
        public HRDbContext() { }
        public HRDbContext(DbContextOptions<HRDbContext> options) : base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet <Author> Authors { get; set; }
        public DbSet<AuthorBiography> Biographries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<AuthorBiography>()
                .HasKey(s => s.BioId);

            modelBuilder.Entity<Book>(entity =>
            {
                entity.HasKey(b => b.Id);
                entity.Property(b => b.Title).IsRequired().HasMaxLength(50);
                entity.Property(b => b.Price).IsRequired();
            });
                

            base.OnModelCreating(modelBuilder);
        }

    }
}
