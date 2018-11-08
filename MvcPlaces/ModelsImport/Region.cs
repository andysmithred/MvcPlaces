using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Region
    {
        public Region()
        {
            Airfield = new HashSet<Airfield>();
            Base = new HashSet<Base>();
            Builder = new HashSet<Builder>();
            City = new HashSet<City>();
            Place = new HashSet<Place>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public double? Area { get; set; }
        public string Isocode { get; set; }
        public bool HasFlag { get; set; }
        public int? Population { get; set; }
        public string Type { get; set; }
        public int? ImportId { get; set; }

        public Country Country { get; set; }
        public ICollection<Airfield> Airfield { get; set; }
        public ICollection<Base> Base { get; set; }
        public ICollection<Builder> Builder { get; set; }
        public ICollection<City> City { get; set; }
        public ICollection<Place> Place { get; set; }
    }
}
