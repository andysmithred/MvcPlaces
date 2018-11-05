using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class CountryCapital
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }

        public City City { get; set; }
        public Country Country { get; set; }
    }
}
