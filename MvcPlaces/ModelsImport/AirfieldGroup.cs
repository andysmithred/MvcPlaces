using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class AirfieldGroup
    {
        public AirfieldGroup()
        {
            AirfieldGroupSet = new HashSet<AirfieldGroupSet>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public ICollection<AirfieldGroupSet> AirfieldGroupSet { get; set; }
    }
}
