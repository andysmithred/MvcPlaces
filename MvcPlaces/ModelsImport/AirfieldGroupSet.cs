using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class AirfieldGroupSet
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public int AirfieldId { get; set; }

        public Airfield Airfield { get; set; }
        public AirfieldGroup Group { get; set; }
    }
}
