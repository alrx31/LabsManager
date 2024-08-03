using domain.entities;
using Microsoft.EntityFrameworkCore;
namespace infrastructure.persistence
{
    public class LabsManagerDbContext : DbContext
    {
        public LabsManagerDbContext()
            : base()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=LabsManager;Username=postgres;Password=M3g6Ar23");
            }
        }

        public DbSet<Student> students { get; set; }
        public DbSet<Teacher> teachers { get; set; }
        public DbSet<Lab> labs { get; set; }
        public DbSet<Subject> subjects { get; set; }
        public DbSet<FollowStudentSubject> follows { get; set; }
    }


    
}
