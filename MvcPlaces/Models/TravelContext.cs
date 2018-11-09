using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcPlaces.Models
{
    public partial class TravelContext : DbContext
    {
        public TravelContext()
        {
        }

        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }
        public virtual DbSet<TerritoryType> TerritoryType { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<TerritoryPlace> TerritoryPlace { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Travel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Continent>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Children)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Continent_Continent");
            });

            modelBuilder.Entity<Territory>(entity =>
            {
                entity.Property(e => e.Isocode)
                    .HasColumnName("ISOCode")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Continent)
                    .WithMany(p => p.Territories)
                    .HasForeignKey(d => d.ContinentId)
                    .HasConstraintName("FK_Territory_Continent");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.Children)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Territory_Territory");

                entity.HasOne(d => d.TerritoryType)
                    .WithMany(p => p.Territories)
                    .HasForeignKey(d => d.TerritoryTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Territory_TerritoryType");
            });

            modelBuilder.Entity<TerritoryType>(entity =>
            {
                entity.Property(e => e.Type).IsRequired();
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<TerritoryPlace>(entity =>
            {
                entity.HasOne(d => d.Territory)
                    .WithMany(p => p.TerritoryPlaces)
                    .HasForeignKey(d => d.TerritoryId)
                    .HasConstraintName("FK_TerritoryPlace_Territory");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.TerritoryPlaces)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("FK_TerritoryPlace_Place");
            });
        }
    }
}