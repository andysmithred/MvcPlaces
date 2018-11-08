using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Continent
    {
        public Continent()
        {
            Children = new HashSet<Continent>();
            Territories = new HashSet<Territory>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        [StringLength(3, MinimumLength = 3)]
        [Required]
        public string Code { get; set; }

        [Display(Name = "Parent")]
        public int? ParentId { get; set; }


        public int? Test { get; set; }

        public Continent Parent { get; set; }

        public ICollection<Continent> Children { get; set; }

        public ICollection<Territory> Territories { get; set; }
    }
}
