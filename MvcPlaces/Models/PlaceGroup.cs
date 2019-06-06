using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class PlaceGroup
    {
        public PlaceGroup()
        {
            PlaceGroupSets = new HashSet<PlaceGroupSet>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [StringLength(50)]
        public string Icon { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        public ICollection<PlaceGroupSet> PlaceGroupSets { get; set; }
    }
}