using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Navy
    {
        public Navy()
        {
            Port = new HashSet<Port>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int? Manpower { get; set; }
        public int? Ships { get; set; }
        public int? Aircraft { get; set; }
        public string Ensign { get; set; }
        public string Jack { get; set; }
        public int? HeadquarterId { get; set; }
        public string Type { get; set; }

        public Country Country { get; set; }
        public ICollection<Port> Port { get; set; }
    }
}
