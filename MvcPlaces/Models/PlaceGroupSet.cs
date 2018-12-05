using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class PlaceGroupSet
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Place")]
        public int PlaceId { get; set; }

        [Required]
        [Display(Name = "Group")]
        public int GroupId { get; set; }

        public Place Place { get; set; }

        public PlaceGroup Group { get; set; }
    }
}