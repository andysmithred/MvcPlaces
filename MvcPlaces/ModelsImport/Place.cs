using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Place
    {
        public Place()
        {
            AirfieldPlace = new HashSet<AirfieldPlace>();
            DriveLegDestination = new HashSet<DriveLeg>();
            DriveLegOrigin = new HashSet<DriveLeg>();
            PlaceGroupSet = new HashSet<PlaceGroupSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public Region Region { get; set; }
        public ICollection<AirfieldPlace> AirfieldPlace { get; set; }
        public ICollection<DriveLeg> DriveLegDestination { get; set; }
        public ICollection<DriveLeg> DriveLegOrigin { get; set; }
        public ICollection<PlaceGroupSet> PlaceGroupSet { get; set; }
    }
}
