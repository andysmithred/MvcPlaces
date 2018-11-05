using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class AirfieldPlace
    {
        public int Id { get; set; }
        public int AirfieldId { get; set; }
        public int PlaceId { get; set; }

        public Airfield Airfield { get; set; }
        public Place Place { get; set; }
    }
}
