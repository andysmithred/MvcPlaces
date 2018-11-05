using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Builder
    {
        public Builder()
        {
            Ship = new HashSet<Ship>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int? RegionId { get; set; }

        public Region Region { get; set; }
        public ICollection<Ship> Ship { get; set; }
    }
}
