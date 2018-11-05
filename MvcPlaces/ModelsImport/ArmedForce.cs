using System;
using System.Collections.Generic;

namespace MvcPlaces.ModelsImport
{
    public partial class ArmedForce
    {
        public ArmedForce()
        {
            Branch = new HashSet<Branch>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public int? Active { get; set; }
        public int? Reserve { get; set; }
        public long? Budget { get; set; }
        public int? AvailableManpower { get; set; }
        public int? FitManpower { get; set; }
        public int? AnnualManpower { get; set; }
        public int? CityId { get; set; }
        public bool Conscription { get; set; }
        public bool? IsActive { get; set; }
        public string ArmedForcesCode { get; set; }

        public City City { get; set; }
        public Country Country { get; set; }
        public ICollection<Branch> Branch { get; set; }
    }
}
