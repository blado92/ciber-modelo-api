using Microsoft.EntityFrameworkCore;

namespace DBManager
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public ApplicationDbContext()
        {
        }

        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=db_CiberModelo;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }*/

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ValidationState>()
                .HasKey(v => new { v.DeceasedId, v.UserId });
        }

        public DbSet<User> User { get; set; }
        public DbSet<Deceased> Deceased { get; set; }
        public DbSet<DeceasedDocuments> DeceasedDocuments { get; set; }
        public DbSet<ValidationState> ValidationState { get; set; }
    }
}
