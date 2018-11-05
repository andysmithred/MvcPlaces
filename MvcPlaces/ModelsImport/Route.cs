using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Route
    {
        public Route()
        {
            Leg = new HashSet<Leg>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<Leg> Leg { get; set; }
    }
}
