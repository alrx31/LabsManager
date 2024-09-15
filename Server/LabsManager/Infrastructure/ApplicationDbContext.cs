using LabsManager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Npgsql;

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
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Labs)
                .WithOne(l => l.Teacher)
                .HasForeignKey(l => l.TeacherId);

            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.passModels)
                .WithOne(p => p.Teacher)
                .HasForeignKey(p => p.TeacherId);

            modelBuilder.Entity<Student>()
                .HasMany(s => s.passModels)
                .WithOne(p => p.Student)
                .HasForeignKey(p => p.StudentId);

            modelBuilder.Entity<Laba>()
                .HasMany(l => l.passModels)
                .WithOne(p => p.Laba)
                .HasForeignKey(p => p.LabaId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
