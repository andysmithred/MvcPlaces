using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Place
    {
        public Place()
        {
            TerritoryPlaces = new HashSet<TerritoryPlace>();
            PlaceGroupSets = new HashSet<PlaceGroupSet>();
            OriginLegs = new HashSet<DriveLeg>();
            DestinationLegs = new HashSet<DriveLeg>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string LocalName { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public int? Zoom { get; set; }

        public ICollection<TerritoryPlace> TerritoryPlaces { get; set; }

        public ICollection<PlaceGroupSet> PlaceGroupSets { get; set; }

        public ICollection<DriveLeg> OriginLegs { get; set; }

        public ICollection<DriveLeg> DestinationLegs { get; set; }
    }
}