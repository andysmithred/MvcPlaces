using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Route
    {
        public Route()
        {
            RouteLegs = new HashSet<RouteLeg>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; } 

        public ICollection<RouteLeg> RouteLegs { get; set; }
    }
}
