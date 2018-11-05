using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Port
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? NavyId { get; set; }
        public int? CityId { get; set; }
        public string Type { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public City City { get; set; }
        public Navy Navy { get; set; }
    }
}
