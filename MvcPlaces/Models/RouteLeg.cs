using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public class RouteLeg
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int RouteId { get; set; }
        public Route Route { get; set; }

        [Required]
        public int OriginId { get; set; }
        public Place Origin { get; set; }

        [Required]
        public int DestinationId { get; set; }
        public Place Destination { get; set; }

        public string Description { get; set; }
    }
}
