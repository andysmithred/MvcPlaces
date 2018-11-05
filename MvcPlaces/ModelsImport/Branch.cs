using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Branch
    {
        public Branch()
        {
            Base = new HashSet<Base>();
            Career = new HashSet<Career>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int BranchTypeId { get; set; }
        public int? Active { get; set; }
        public int? Reserve { get; set; }
        public int ArmedForceId { get; set; }
        public bool HasRoundel { get; set; }
        public bool HasJack { get; set; }

        public ArmedForce ArmedForce { get; set; }
        public BranchType BranchType { get; set; }
        public ICollection<Base> Base { get; set; }
        public ICollection<Career> Career { get; set; }
    }
}
