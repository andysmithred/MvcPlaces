using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Drive
    {
        public Drive()
        {
            DriveLegs = new HashSet<DriveLeg>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public ICollection<DriveLeg> DriveLegs { get; set; }
    }
}