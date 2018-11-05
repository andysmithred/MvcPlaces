using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class City
    {
        public City()
        {
            AirfieldCity = new HashSet<AirfieldCity>();
            ArmedForce = new HashSet<ArmedForce>();
            CountryCapital = new HashSet<CountryCapital>();
            CountryMajorCity = new HashSet<CountryMajorCity>();
            Port = new HashSet<Port>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Population { get; set; }
        public int? Founded { get; set; }
        public int RegionId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public Region Region { get; set; }
        public ICollection<AirfieldCity> AirfieldCity { get; set; }
        public ICollection<ArmedForce> ArmedForce { get; set; }
        public ICollection<CountryCapital> CountryCapital { get; set; }
        public ICollection<CountryMajorCity> CountryMajorCity { get; set; }
        public ICollection<Port> Port { get; set; }
    }
}
