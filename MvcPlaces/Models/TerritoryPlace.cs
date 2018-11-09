using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class TerritoryPlace
    {
        #region Database Properties

        [Key]
        public int Id { get; set; }

        [Display(Name = "Territory")]
        [Required]
        public int TerritoryId { get; set; }

        [Display(Name = "Place")]
        [Required]
        public int PlaceId { get; set; }

        #endregion Database Properties

        #region Foreign Properties

        public Territory Territory { get; set; }
        public Place Place { get; set; }

        #endregion Foreign Properties
    }
}