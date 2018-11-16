using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class PlaceGroup
    {
        public PlaceGroup()
        {
            PlaceGroupSet = new HashSet<PlaceGroupSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ImportId { get; set; }

        public ICollection<PlaceGroupSet> PlaceGroupSet { get; set; }
    }
}
