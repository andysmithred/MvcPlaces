using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MvcPlaces.ModelsImport
{
    public partial class MyDataContext : DbContext
    {
        public MyDataContext()
        {
        }

        public MyDataContext(DbContextOptions<MyDataContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Airfield> Airfield { get; set; }
        public virtual DbSet<AirfieldCity> AirfieldCity { get; set; }
        public virtual DbSet<AirfieldGroup> AirfieldGroup { get; set; }
        public virtual DbSet<AirfieldGroupSet> AirfieldGroupSet { get; set; }
        public virtual DbSet<AirfieldPlace> AirfieldPlace { get; set; }
        public virtual DbSet<ArmedForce> ArmedForce { get; set; }
        public virtual DbSet<Base> Base { get; set; }
        public virtual DbSet<BaseType> BaseType { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<BranchType> BranchType { get; set; }
        public virtual DbSet<Builder> Builder { get; set; }
        public virtual DbSet<Career> Career { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Continent> Continent { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<CountryCapital> CountryCapital { get; set; }
        public virtual DbSet<CountryMajorCity> CountryMajorCity { get; set; }
        public virtual DbSet<CountryNeighbour> CountryNeighbour { get; set; }
        public virtual DbSet<CountryReconciliation> CountryReconciliation { get; set; }
        public virtual DbSet<Drive> Drive { get; set; }
        public virtual DbSet<DriveLeg> DriveLeg { get; set; }
        public virtual DbSet<Leg> Leg { get; set; }
        public virtual DbSet<Navy> Navy { get; set; }
        public virtual DbSet<Place> Place { get; set; }
        public virtual DbSet<PlaceGroup> PlaceGroup { get; set; }
        public virtual DbSet<PlaceGroupSet> PlaceGroupSet { get; set; }
        public virtual DbSet<Port> Port { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<Route> Route { get; set; }
        public virtual DbSet<Runway> Runway { get; set; }
        public virtual DbSet<Ship> Ship { get; set; }
        public virtual DbSet<ShipClass> ShipClass { get; set; }
        public virtual DbSet<ShipType> ShipType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ASMITH\\SOURCE\\REPOS\\MVCPLACES\\MVCPLACES\\DATABASES\\MYDATA.MDF;Integrated Security=True;Connect Timeout=30");
                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ASMITH\\MYDATA.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

                //optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=C:\\USERS\\ASMITH\\MYDATA.MDF;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
                

            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Airfield>(entity =>
            {
                entity.Property(e => e.IataCode).HasMaxLength(3);

                entity.Property(e => e.IcaoCode).HasMaxLength(4);

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.Airfield)
                    .HasForeignKey(d => d.BaseId)
                    .HasConstraintName("FK_Airfield_To_Base");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Airfield)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Airfield_To_Region");
            });

            modelBuilder.Entity<AirfieldCity>(entity =>
            {
                entity.HasOne(d => d.Airfield)
                    .WithMany(p => p.AirfieldCity)
                    .HasForeignKey(d => d.AirfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirfieldCity_To_Airfield");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.AirfieldCity)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirfieldCity_To_City");
            });

            modelBuilder.Entity<AirfieldGroup>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<AirfieldGroupSet>(entity =>
            {
                entity.HasOne(d => d.Airfield)
                    .WithMany(p => p.AirfieldGroupSet)
                    .HasForeignKey(d => d.AirfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirfieldGroupSet_ToAirfield");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.AirfieldGroupSet)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirfieldGroupSet_ToAirfieldGroup");
            });

            modelBuilder.Entity<AirfieldPlace>(entity =>
            {
                entity.HasOne(d => d.Airfield)
                    .WithMany(p => p.AirfieldPlace)
                    .HasForeignKey(d => d.AirfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirfieldPlace_To_Airfield");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.AirfieldPlace)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AirfieldPlace_To_Place");
            });

            modelBuilder.Entity<ArmedForce>(entity =>
            {
                entity.Property(e => e.ArmedForcesCode).HasMaxLength(5);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.City)
                    .WithMany(p => p.ArmedForce)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_ArmedForce_To_City");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.ArmedForce)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArmedForce_To_Country");
            });

            modelBuilder.Entity<Base>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.BaseType)
                    .WithMany(p => p.Base)
                    .HasForeignKey(d => d.BaseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Base_To_BaseType");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Base)
                    .HasForeignKey(d => d.BranchId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Base_To_Branch");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Base)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Base_To_Region");
            });

            modelBuilder.Entity<BaseType>(entity =>
            {
                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.ArmedForce)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.ArmedForceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branch_To_ArmedForce");

                entity.HasOne(d => d.BranchType)
                    .WithMany(p => p.Branch)
                    .HasForeignKey(d => d.BranchTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Branch_To_BranchType");
            });

            modelBuilder.Entity<BranchType>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Builder>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Builder)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Builder_ToRegion");
            });

            modelBuilder.Entity<Career>(entity =>
            {
                entity.Property(e => e.Commissioned).HasColumnType("datetime");

                entity.Property(e => e.Decommissioned).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Penant).HasMaxLength(50);

                entity.HasOne(d => d.Base)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.BaseId)
                    .HasConstraintName("FK_Career_To_Base");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_Career_To_Branch");

                entity.HasOne(d => d.Ship)
                    .WithMany(p => p.Career)
                    .HasForeignKey(d => d.ShipId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Career_To_Ship");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.City)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_City_To_Region");
            });

            modelBuilder.Entity<Continent>(entity =>
            {
                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(3)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Gdp).HasColumnName("GDP");

                entity.Property(e => e.GdpperCapita).HasColumnName("GDPPerCapita");

                entity.Property(e => e.Government).HasMaxLength(50);

                entity.Property(e => e.Isocode)
                    .HasColumnName("ISOCode")
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Zoom).HasDefaultValueSql("((10))");

                entity.HasOne(d => d.Continent)
                    .WithMany(p => p.Country)
                    .HasForeignKey(d => d.ContinentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Country_To_Continent");
            });

            modelBuilder.Entity<CountryCapital>(entity =>
            {
                entity.HasOne(d => d.City)
                    .WithMany(p => p.CountryCapital)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryCapital_ToCity");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryCapital)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryCapital_ToCountry");
            });

            modelBuilder.Entity<CountryMajorCity>(entity =>
            {
                entity.HasOne(d => d.City)
                    .WithMany(p => p.CountryMajorCity)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryMajorCity_ToCity");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryMajorCity)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryMajorCity_ToCountry");
            });

            modelBuilder.Entity<CountryNeighbour>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryNeighbourCountry)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryNeighbour_To_Country1");

                entity.HasOne(d => d.Neighbour)
                    .WithMany(p => p.CountryNeighbourNeighbour)
                    .HasForeignKey(d => d.NeighbourId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryNeighbour_To_Country2");
            });

            modelBuilder.Entity<CountryReconciliation>(entity =>
            {
                entity.HasOne(d => d.Country)
                    .WithMany(p => p.CountryReconciliation)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CountryReconciliation_ToCountry");
            });

            modelBuilder.Entity<Drive>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<DriveLeg>(entity =>
            {
                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.DriveLegDestination)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriveLeg_ToPlace_Destination");

                entity.HasOne(d => d.Drive)
                    .WithMany(p => p.DriveLeg)
                    .HasForeignKey(d => d.DriveId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriveLeg_ToDrive");

                entity.HasOne(d => d.Origin)
                    .WithMany(p => p.DriveLegOrigin)
                    .HasForeignKey(d => d.OriginId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriveLeg_ToPlace_Origin");
            });

            modelBuilder.Entity<Leg>(entity =>
            {
                entity.HasOne(d => d.DestinationAirfield)
                    .WithMany(p => p.LegDestinationAirfield)
                    .HasForeignKey(d => d.DestinationAirfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leg_ToAirfieldDestination");

                entity.HasOne(d => d.OriginAirfield)
                    .WithMany(p => p.LegOriginAirfield)
                    .HasForeignKey(d => d.OriginAirfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leg_ToAirfieldOrigin");

                entity.HasOne(d => d.Route)
                    .WithMany(p => p.Leg)
                    .HasForeignKey(d => d.RouteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Leg_ToRoute");
            });

            modelBuilder.Entity<Navy>(entity =>
            {
                entity.Property(e => e.Ensign).HasMaxLength(10);

                entity.Property(e => e.Jack).HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Navy)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Navy_To_Country");
            });

            modelBuilder.Entity<Place>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Place)
                    .HasForeignKey(d => d.RegionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Place_ToRegion");
            });

            modelBuilder.Entity<PlaceGroup>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<PlaceGroupSet>(entity =>
            {
                entity.HasOne(d => d.Group)
                    .WithMany(p => p.PlaceGroupSet)
                    .HasForeignKey(d => d.GroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceGroupSet_ToPlaceGroup");

                entity.HasOne(d => d.Place)
                    .WithMany(p => p.PlaceGroupSet)
                    .HasForeignKey(d => d.PlaceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PlaceGroupSet_ToPlace");
            });

            modelBuilder.Entity<Port>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Port)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_Port_To_City");

                entity.HasOne(d => d.Navy)
                    .WithMany(p => p.Port)
                    .HasForeignKey(d => d.NavyId)
                    .HasConstraintName("FK_Port_To_Navy");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Isocode)
                    .HasColumnName("ISOCode")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Region_To_Country");
            });

            modelBuilder.Entity<Route>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();
            });

            modelBuilder.Entity<Runway>(entity =>
            {
                entity.Property(e => e.Direction)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surface)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Airfield)
                    .WithMany(p => p.Runway)
                    .HasForeignKey(d => d.AirfieldId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Runway_To_Airfield");
            });

            modelBuilder.Entity<Ship>(entity =>
            {
                entity.Property(e => e.Launched).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Builder)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.BuilderId)
                    .HasConstraintName("FK_Ship_To_Builder");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.Ship)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ship_To_ShipClass");
            });

            modelBuilder.Entity<ShipClass>(entity =>
            {
                entity.Property(e => e.Name).IsRequired();

                entity.HasOne(d => d.Preceded)
                    .WithMany(p => p.InversePreceded)
                    .HasForeignKey(d => d.PrecededId)
                    .HasConstraintName("FK_ShipClass_To_ShipClassPre");

                entity.HasOne(d => d.Succeeded)
                    .WithMany(p => p.InverseSucceeded)
                    .HasForeignKey(d => d.SucceededId)
                    .HasConstraintName("FK_ShipClass_To_ShipClassSuc");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ShipClass)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ShipClass_To_ShipType");
            });

            modelBuilder.Entity<ShipType>(entity =>
            {
                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);
            });
        }
    }
}
