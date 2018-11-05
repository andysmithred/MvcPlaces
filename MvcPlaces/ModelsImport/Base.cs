using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Base
    {
        public Base()
        {
            Airfield = new HashSet<Airfield>();
            Career = new HashSet<Career>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchId { get; set; }
        public int BaseTypeId { get; set; }
        public int RegionId { get; set; }
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }

        public BaseType BaseType { get; set; }
        public Branch Branch { get; set; }
        public Region Region { get; set; }
        public ICollection<Airfield> Airfield { get; set; }
        public ICollection<Career> Career { get; set; }
    }
}
