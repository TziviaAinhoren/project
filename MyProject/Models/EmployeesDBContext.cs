using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MyProject.Models
{
    public partial class EmployeesDBContext : DbContext
    {
        public EmployeesDBContext()
        {
        }

        public EmployeesDBContext(DbContextOptions<EmployeesDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeesTbl> EmployeesTbl { get; set; }
        public virtual DbSet<StreetsTbl> StreetsTbl { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-57AQD4B.;Database=EmployeesDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeesTbl>(entity =>
            {
                entity.Property(e => e.Id).HasMaxLength(9);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<StreetsTbl>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CityName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
