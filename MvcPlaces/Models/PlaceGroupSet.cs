using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class PlaceGroupSet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int PlaceId { get; set; }

        [Required]
        public int GroupId { get; set; }

        public Place Place { get; set; }

        public PlaceGroup Group { get; set; }
    }
}