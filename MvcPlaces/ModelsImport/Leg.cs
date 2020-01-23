using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Leg
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int RouteId { get; set; }
        public int OriginAirfieldId { get; set; }
        public int DestinationAirfieldId { get; set; }
        public string Description { get; set; }
        public int? ImportId { get; set; }

        public Airfield DestinationAirfield { get; set; }
        public Airfield OriginAirfield { get; set; }
        public Route Route { get; set; }
    }
}
