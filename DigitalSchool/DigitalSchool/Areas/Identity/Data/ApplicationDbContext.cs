using Microsoft.EntityFrameworkCore;

namespace DigitalSchool.Areas.Identity.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Simulated> Simulations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Class>()
                .HasMany(t => t.Students)
                .WithOne(a => a.Class)
                .HasForeignKey(a => a.Class.Id);

            modelBuilder.Entity<Simulated>()
                .HasMany(s => s.Questions)
                .WithOne()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Simulated>()
                .HasOne(s => s.Class)
                .WithMany()
                .HasForeignKey(s => s.Class.Id);
        }
    }
}
