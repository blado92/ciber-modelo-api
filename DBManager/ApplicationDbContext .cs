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

        #if DEBUG
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=db_CiberModelo;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }
        #endif

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ValidationState>()
                .HasKey(v => new { v.DeceasedId, v.UserId });

            modelBuilder.Entity<DeceasedDocuments>()
                .HasKey(v => new { v.Id, v.DeceasedId });

            modelBuilder.Entity<UserDeceasedRole>()
                .HasKey(v => new { v.UserId, v.DeceasedId, v.RoleId });

            modelBuilder.Entity<AccessMatrix>()
                .HasKey(v => new { v.RoleId, v.QueryTypeId, v.AccessLevelId });

            modelBuilder.Entity<FieldAccessLevel>()
                .HasKey(v => new { v.QueryTypeId, v.AccessLevelId, v.FieldId });
        }

        public DbSet<User> User { get; set; }
        public DbSet<Deceased> Deceased { get; set; }
        public DbSet<DeceasedDocuments> DeceasedDocuments { get; set; }
        public DbSet<ValidationState> ValidationState { get; set; }
        public DbSet<UserDeceasedRole> UserDeceasedRole { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<AccessMatrix> AccessMatrix { get; set; }
        public DbSet<AccessLevel> AccessLevel { get; set; }
        public DbSet<QueryType> QueryType { get; set; }
        public DbSet<FieldAccessLevel> FieldAccessLevel { get; set; }
        public DbSet<Fields> Fields { get; set; }
    }
}
