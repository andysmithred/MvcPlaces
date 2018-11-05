using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Runway
    {
        public int Id { get; set; }
        public string Direction { get; set; }
        public int Length { get; set; }
        public string Surface { get; set; }
        public int AirfieldId { get; set; }

        public Airfield Airfield { get; set; }
    }
}
