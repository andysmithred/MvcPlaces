using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Continent
    {
        public Continent()
        {
            Children = new HashSet<Continent>();
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(50)]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(3, MinimumLength = 3)]
        [Required]
        public string Code { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Display(Name = "Parent")]
        public int? ParentId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Continent Parent { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<Continent> Children { get; set; }
    }
}