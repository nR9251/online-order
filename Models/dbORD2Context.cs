using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace prjonlineorder.Models
{
    public partial class dbORD2Context : DbContext
    {
        public dbORD2Context()
        {
        }

        public dbORD2Context(DbContextOptions<dbORD2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<TableA> TableA { get; set; }
        public virtual DbSet<TableB1> TableB1 { get; set; }
        public virtual DbSet<TableB2> TableB2 { get; set; }
        public virtual DbSet<TableB3> TableB3 { get; set; }
        public virtual DbSet<TableC> TableC { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-LD3NQLFM;Initial Catalog=dbORD2;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TableA>(entity =>
            {
                entity.HasKey(e => e.TId);

                entity.Property(e => e.TId)
                    .HasColumnName("tId")
                    .HasMaxLength(50);

                entity.Property(e => e.TDesk).HasColumnName("tDesk");

                entity.Property(e => e.TTotal).HasColumnName("tTotal");
            });

            modelBuilder.Entity<TableB1>(entity =>
            {
                entity.HasKey(e => e.TNumber);

                entity.Property(e => e.TNumber)
                    .HasColumnName("tNumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.TMeal)
                    .IsRequired()
                    .HasColumnName("tMeal")
                    .HasMaxLength(50);

                entity.Property(e => e.TNum).HasColumnName("tNum");

                entity.Property(e => e.TPrice).HasColumnName("tPrice");
            });

            modelBuilder.Entity<TableB2>(entity =>
            {
                entity.HasKey(e => e.TNumber);

                entity.Property(e => e.TNumber)
                    .HasColumnName("tNumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.TMeal)
                    .IsRequired()
                    .HasColumnName("tMeal")
                    .HasMaxLength(50);

                entity.Property(e => e.TNum).HasColumnName("tNum");

                entity.Property(e => e.TPrice).HasColumnName("tPrice");
            });

            modelBuilder.Entity<TableB3>(entity =>
            {
                entity.HasKey(e => e.TNumber);

                entity.Property(e => e.TNumber)
                    .HasColumnName("tNumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.TMeal)
                    .IsRequired()
                    .HasColumnName("tMeal")
                    .HasMaxLength(50);

                entity.Property(e => e.TNum).HasColumnName("tNum");

                entity.Property(e => e.TPrice).HasColumnName("tPrice");
            });

            modelBuilder.Entity<TableC>(entity =>
            {
                entity.HasKey(e => e.TNumber);

                entity.Property(e => e.TNumber)
                    .HasColumnName("tNumber")
                    .ValueGeneratedNever();

                entity.Property(e => e.TMeal)
                    .IsRequired()
                    .HasColumnName("tMeal")
                    .HasMaxLength(50);

                entity.Property(e => e.TPrice).HasColumnName("tPrice");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
