using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class TerritoryType
    {
        public TerritoryType()
        {
            Territories = new HashSet<Territory>();
        }

        [Key]
        public int Id { get; set; }
        public string Type { get; set; }

        public ICollection<Territory> Territories { get; set; }
    }
}