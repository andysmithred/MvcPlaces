using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcPlaces.Models
{
    public partial class TravelContext : DbContext
    {
        public TravelContext() { }

        public TravelContext(DbContextOptions<TravelContext> options)
            : base(options) { }

        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Territory> Territory { get; set; }
        public virtual DbSet<TerritoryType> TerritoryType { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<TerritoryPlace> TerritoryPlace { get; set; }
        public virtual DbSet<Flag> Flag { get; set; }
        public virtual DbSet<PlaceGroup> PlaceGroup { get; set; }
        public virtual DbSet<PlaceGroupSet> PlaceGroupSet { get; set; }
        public virtual DbSet<Drive> Drive { get; set; }
        public virtual DbSet<DriveLeg> DriveLeg { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<RouteLeg> RouteLeg { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Travel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                //optionsBuilder.UseSqlServer("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\asmith\\source\\repos\\MvcPlaces\\MvcPlaces\\Databases\\Travel.mdf;Integrated Security=True;Connect Timeout=30");

                optionsBuilder.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\asmith\source\repos\MvcPlaces\MvcPlaces\Databases\Travel.mdf;Integrated Security=True;Connect Timeout=30");
                //optionsBuilder.UseSqlServer("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename=C:\\dev\\MvcPlaces\\MvcPlaces\\Databases\\Travel.mdf; Integrated Security = True;Connect Timeout=30");
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

                entity.Property(e => e.Complete)
                    .IsRequired();

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

                entity.Property(e => e.Complete).IsRequired();
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

            modelBuilder.Entity<Flag>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Active)
                    .IsRequired();

                entity.Property(e => e.Complete)
                    .IsRequired();
            });

            modelBuilder.Entity<PlaceGroup>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired();

                entity.Property(e => e.Icon)
                    .HasMaxLength(50);

                entity.Property(e => e.Image)
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PlaceGroupSet>(entity =>
            {
                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceGroupSets)
                    .HasForeignKey(d => d.PlaceId)
                    .HasConstraintName("FK_PlaceGroupSet_To_Place");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PlaceGroupSets)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_PlaceGroupSet_To_PlaceGroup");
            });

            modelBuilder.Entity<Drive>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DriveLeg>(entity =>
            {
                entity.Property(e => e.Number)
                    .IsRequired();

                entity.Property(e => e.DriveId)
                    .IsRequired();

                entity.Property(e => e.OriginId)
                    .IsRequired();

                entity.Property(e => e.DestinationId)
                    .IsRequired();

                entity.HasOne(d => d.Drive)
                    .WithMany(p => p.DriveLegs)
                    .HasForeignKey(d => d.DriveId)
                    .HasConstraintName("FK_DriveLeg_To_Drive");

                entity.HasOne(d => d.Origin)
                    .WithMany(p => p.DriveOriginLegs)
                    .HasForeignKey(d => d.OriginId)
                    .HasConstraintName("FK_DriveLeg_To_Place_Origin");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.DriveDestinationLegs)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("FK_DriveLeg_To_Place_Destination");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<RouteLeg>(entity =>
            {
                entity.Property(e => e.Number)
                    .IsRequired();

                entity.Property(e => e.RouteId)
                    .IsRequired();

                entity.Property(e => e.OriginId)
                    .IsRequired();

                entity.Property(e => e.DestinationId)
                    .IsRequired();

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.RouteLegs)
                    .HasForeignKey(d => d.RouteId)
                    .HasConstraintName("FK_RouteLeg_ToRoute");

                entity.HasOne(d => d.Origin)
                    .WithMany(p => p.RouteOriginLegs)
                    .HasForeignKey(d => d.OriginId)
                    .HasConstraintName("FK_RouteLeg_ToOrigin");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.RouteDestinationLegs)
                    .HasForeignKey(d => d.DestinationId)
                    .HasConstraintName("FK_RouteLeg_ToDestination");
            });
        }
    }
}
