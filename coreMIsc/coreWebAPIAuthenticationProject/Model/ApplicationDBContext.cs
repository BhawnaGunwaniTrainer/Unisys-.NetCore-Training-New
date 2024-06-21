using Microsoft.EntityFrameworkCore;

namespace coreWebAPIAuthenticationProject.Model
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }

        public DbSet<MyUser> MyUsers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MyUser>().HasKey(x => x.Id);
            modelBuilder.Entity<MyUser>().HasData(
               new MyUser { Id = 1, FirstName = "System", LastName = "", isActive = true}
            );

            modelBuilder.Entity<User>().HasData(
              new User { Id = 1, FirstName = "System", LastName = "", Username = "System", Password = "System" }
           );

        }
    }
}
