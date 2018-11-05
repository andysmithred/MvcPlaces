using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class AirfieldCity
    {
        public int Id { get; set; }
        public int AirfieldId { get; set; }
        public int CityId { get; set; }

        public Airfield Airfield { get; set; }
        public City City { get; set; }
    }
}
