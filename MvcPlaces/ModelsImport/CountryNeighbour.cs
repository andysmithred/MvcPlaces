using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class CountryNeighbour
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public int NeighbourId { get; set; }
        public int? Boundary { get; set; }

        public Country Country { get; set; }
        public Country Neighbour { get; set; }
    }
}
