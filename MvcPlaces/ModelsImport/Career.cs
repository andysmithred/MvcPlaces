using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Career
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public string Name { get; set; }
        public string Penant { get; set; }
        public DateTime? Commissioned { get; set; }
        public DateTime? Decommissioned { get; set; }
        public bool Active { get; set; }
        public string Fate { get; set; }
        public int? BaseId { get; set; }
        public int? BranchId { get; set; }

        public Base Base { get; set; }
        public Branch Branch { get; set; }
        public Ship Ship { get; set; }
    }
}
