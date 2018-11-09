﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcPlaces.Models
{
    public partial class Place
    {
        public Place()
        {
            TerritoryPlaces = new HashSet<TerritoryPlace>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name = "Local Name")]
        public string LocalName { get; set; }

        public double? Latitude { get; set; }

        public double? Longitude { get; set; }

        public int? Zoom { get; set; }

        public ICollection<TerritoryPlace> TerritoryPlaces { get; set; }
    }
}
