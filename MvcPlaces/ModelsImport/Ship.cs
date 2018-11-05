using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Ship
    {
        public Ship()
        {
            Career = new HashSet<Career>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public DateTime? Launched { get; set; }
        public int? BuilderId { get; set; }

        public Builder Builder { get; set; }
        public ShipClass Class { get; set; }
        public ICollection<Career> Career { get; set; }
    }
}
