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
            DriveOriginLegs = new HashSet<DriveLeg>();
            DriveDestinationLegs = new HashSet<DriveLeg>();
            RouteOriginLegs = new HashSet<RouteLeg>();
            RouteDestinationLegs = new HashSet<RouteLeg>();
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

        [Required]
        public bool Complete { get; set; }

        public ICollection<TerritoryPlace> TerritoryPlaces { get; set; }

        public ICollection<PlaceGroupSet> PlaceGroupSets { get; set; }

        public ICollection<DriveLeg> DriveOriginLegs { get; set; }

        public ICollection<DriveLeg> DriveDestinationLegs { get; set; }

        public ICollection<RouteLeg> RouteOriginLegs { get; set; }

        public ICollection<RouteLeg> RouteDestinationLegs { get; set; }
    }
}
