using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Continent
    {
        public Continent()
        {
            Country = new HashSet<Country>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? Area { get; set; }
        public double? Population { get; set; }
        public string Code { get; set; }
        public int? ImportId { get; set; }

        public ICollection<Country> Country { get; set; }
    }
}
