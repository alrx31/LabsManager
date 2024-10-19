using LabsManager.Entities;
using Microsoft.EntityFrameworkCore;

namespace LabsManager.Infrastructure
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Laba> Labs { get; set; }
        public DbSet<PassModel> PassModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasKey(t => t.id);
            modelBuilder.Entity<Teacher>().HasKey(t => t.id);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.labs)
                .WithOne(l => l.teacher)
                .HasForeignKey(l => l.teacherId);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.passModels)
                .WithOne(p => p.teacher)
                .HasForeignKey(p => p.teacherId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.passModels)
                .WithOne(p => p.student)
                .HasForeignKey(p => p.studentId);

            modelBuilder.Entity<Laba>()
                .HasMany(l => l.passLabs)
                .WithOne(p => p.lab)
                .HasForeignKey(p => p.labId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
