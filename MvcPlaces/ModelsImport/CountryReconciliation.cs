using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class CountryReconciliation
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public bool RegionsCompleted { get; set; }
        public int RegionsExpected { get; set; }
        public bool AirfieldsCompleted { get; set; }
        public int AirfieldsExpected { get; set; }
        public bool CapitalsCompleted { get; set; }
        public int CapitalsExpected { get; set; }
        public bool MajorUrbanAreasCompleted { get; set; }
        public int MajorUrbanAreasExpected { get; set; }
        public bool NeighboursCompleted { get; set; }
        public int NeighboursExpected { get; set; }

        public Country Country { get; set; }
    }
}
