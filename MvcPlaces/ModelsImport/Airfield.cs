using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Airfield
    {
        public Airfield()
        {
            AirfieldCity = new HashSet<AirfieldCity>();
            AirfieldGroupSet = new HashSet<AirfieldGroupSet>();
            AirfieldPlace = new HashSet<AirfieldPlace>();
            LegDestinationAirfield = new HashSet<Leg>();
            LegOriginAirfield = new HashSet<Leg>();
            Runway = new HashSet<Runway>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int RegionId { get; set; }
        public int? Elevation { get; set; }
        public string IataCode { get; set; }
        public string Type { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? BaseId { get; set; }
        public string IcaoCode { get; set; }
        public int Prominence { get; set; }

        public Base Base { get; set; }
        public Region Region { get; set; }
        public ICollection<AirfieldCity> AirfieldCity { get; set; }
        public ICollection<AirfieldGroupSet> AirfieldGroupSet { get; set; }
        public ICollection<AirfieldPlace> AirfieldPlace { get; set; }
        public ICollection<Leg> LegDestinationAirfield { get; set; }
        public ICollection<Leg> LegOriginAirfield { get; set; }
        public ICollection<Runway> Runway { get; set; }
    }
}
