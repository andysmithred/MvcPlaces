using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class BranchType
    {
        public BranchType()
        {
            Branch = new HashSet<Branch>();
        }

        public int Id { get; set; }
        public string Type { get; set; }
        public string Code { get; set; }

        public ICollection<Branch> Branch { get; set; }
    }
}
