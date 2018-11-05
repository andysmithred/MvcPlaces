using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class ShipType
    {
        public ShipType()
        {
            ShipClass = new HashSet<ShipClass>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Category { get; set; }

        public ICollection<ShipClass> ShipClass { get; set; }
    }
}
