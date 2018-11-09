using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Territory
    {
        public Territory()
        {
            Children = new HashSet<Territory>();
            TerritoryPlaces = new HashSet<TerritoryPlace>();
        }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Display(Name = "Native Name")]
        public string NativeName { get; set; }

        [Display(Name = "Continent")]
        public int? ContinentId { get; set; }

        [Display(Name = "Parent")]
        public int? ParentId { get; set; }

        public int? Population { get; set; }
        public decimal? Area { get; set; }

        [Display(Name = "ISO")]
        public string Isocode { get; set; }

        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public int? Zoom { get; set; }

        [Display(Name = "Type")]
        public int TerritoryTypeId { get; set; }

        public Continent Continent { get; set; }
        public Territory Parent { get; set; }
        public TerritoryType TerritoryType { get; set; }
        public ICollection<Territory> Children { get; set; }

        public ICollection<TerritoryPlace> TerritoryPlaces { get; set; }
    }
}
