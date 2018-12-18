using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class Drive
    {
        public Drive()
        {
            DriveLeg = new HashSet<DriveLeg>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? ImportId { get; set; }

        public ICollection<DriveLeg> DriveLeg { get; set; }
    }
}
