using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Country
    {
        public Country()
        {
            ArmedForce = new HashSet<ArmedForce>();
            CountryCapital = new HashSet<CountryCapital>();
            CountryMajorCity = new HashSet<CountryMajorCity>();
            CountryNeighbourCountry = new HashSet<CountryNeighbour>();
            CountryNeighbourNeighbour = new HashSet<CountryNeighbour>();
            CountryReconciliation = new HashSet<CountryReconciliation>();
            Navy = new HashSet<Navy>();
            Region = new HashSet<Region>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string FullName { get; set; }
        public int ContinentId { get; set; }
        public int? Population { get; set; }
        public int? Area { get; set; }
        public int? LandBoundaries { get; set; }
        public int? Coastline { get; set; }
        public int? HighestPoint { get; set; }
        public int? LowestPoint { get; set; }
        public string HighestPointName { get; set; }
        public string LowestPointName { get; set; }
        public int? IrrigatedLand { get; set; }
        public double? BirthRate { get; set; }
        public double? DeathRate { get; set; }
        public double? LifeExpectancy { get; set; }
        public string Government { get; set; }
        public double? Gdp { get; set; }
        public double? GdpperCapita { get; set; }
        public double? LabourForce { get; set; }
        public int? Airports { get; set; }
        public int? Railways { get; set; }
        public int? Roads { get; set; }
        public string Isocode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public int Zoom { get; set; }

        public Continent Continent { get; set; }
        public ICollection<ArmedForce> ArmedForce { get; set; }
        public ICollection<CountryCapital> CountryCapital { get; set; }
        public ICollection<CountryMajorCity> CountryMajorCity { get; set; }
        public ICollection<CountryNeighbour> CountryNeighbourCountry { get; set; }
        public ICollection<CountryNeighbour> CountryNeighbourNeighbour { get; set; }
        public ICollection<CountryReconciliation> CountryReconciliation { get; set; }
        public ICollection<Navy> Navy { get; set; }
        public ICollection<Region> Region { get; set; }
    }
}
