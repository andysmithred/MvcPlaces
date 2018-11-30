using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcPlaces.Models
{
    public partial class Flag
    {
        public Flag()
        {
            //Children = new HashSet<Territory>();

            Territories = new HashSet<Territory>();
        }

        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public string Name { get; set; }

        [StringLength(6)]
        [Required]
        public string Code { get; set; }

        public string Description { get; set; }

        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }

        [Display(Name = "End Date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }

        [Required]
        public bool Active { get; set; }

        public ICollection<Territory> Territories { get; set; }



        //public Continent Continent { get; set; }
        //public Territory Parent { get; set; }
        //public TerritoryType TerritoryType { get; set; }


        //public ICollection<TerritoryPlace> TerritoryPlaces { get; set; }
    }
}
